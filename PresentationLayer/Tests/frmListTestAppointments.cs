using BusinessLogicLayer;
using PresentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BusinessLogicLayer.clsTestType;

namespace PresentationLayer.Tests
{
    public partial class frmListTestAppointments : Form
    {
        clsTestType.enTestType _testType;
        int _localDrivingLicenseApplicationID = -1;
        DataTable _dtTestAppointments;

        public frmListTestAppointments(int localDrivingLicenseApplicationID, clsTestType.enTestType testType)
        {
            InitializeComponent();

            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _testType = testType;
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();

            ucLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_localDrivingLicenseApplicationID);
            _dtTestAppointments = clsTestAppointment.GetApplicationTestAppointmentsPerTestType(_localDrivingLicenseApplicationID, _testType);

            dgvTestAppointments.DataSource = _dtTestAppointments;
            lblRecordsCount.Text = dgvTestAppointments.Rows.Count.ToString();


            if (dgvTestAppointments.Rows.Count > 0)
            {
                dgvTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvTestAppointments.Columns[0].Width = 150;

                dgvTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvTestAppointments.Columns[1].Width = 200;

                dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvTestAppointments.Columns[2].Width = 150;

                dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvTestAppointments.Columns[3].Width = 100;
            }

        }

        private void _LoadTestTypeImageAndTitle()
        {
            switch (_testType)
            {

                case clsTestType.enTestType.VisionTest:
                    {
                        lblAppointmentTypeHeader.Text = "Vision Test Appointments";
                        this.Text = lblAppointmentTypeHeader.Text;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        lblAppointmentTypeHeader.Text = "Written Test Appointments";
                        this.Text = lblAppointmentTypeHeader.Text;
                        break;
                    }
                case clsTestType.enTestType.StreetTest:
                    {
                        lblAppointmentTypeHeader.Text = "Street Test Appointments";
                        this.Text = lblAppointmentTypeHeader.Text;
                        break;
                    }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);


            if (localDrivingLicenseApplication.IsThereAnActiveScheduledTest(_testType))
            {
                MessageBox.Show("Person Already have an active appointment for this test, You cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTest LastTest = localDrivingLicenseApplication.GetLastTestPerTestType(_testType);

            if (LastTest == null)
            {
                frmScheduleTest frm1 = new frmScheduleTest(_localDrivingLicenseApplicationID, _testType);
                frm1.ShowDialog();
                frmListTestAppointments_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest
                (LastTest.TestAppointmentInfo.LocalDrivingLicenseApplicationID, _testType);
            frm2.ShowDialog();
            frmListTestAppointments_Load(null, null);
            //---
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;


            frmScheduleTest frm = new frmScheduleTest(_localDrivingLicenseApplicationID, _testType, testAppointmentID);
            frm.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;

            // Open take test form
            frmTakeTest frm = new(testAppointmentID, _testType);
            frm.ShowDialog();

            frmListTestAppointments_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
