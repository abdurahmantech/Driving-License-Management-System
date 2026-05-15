using BusinessLogicLayer;
using PresentationLayer.Applications.Local_Driving_License;
using PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmLocalDrivingLicenseApplicationList : Form
    {
        private DataTable _dtAlllocalDrivinglLicenseApplications;
        public frmLocalDrivingLicenseApplicationList()
        {
            InitializeComponent();
        }

        void _LoadLocalDrivingLicenseApplications()
        {
            _dtAlllocalDrivinglLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dgvLocalDrivingLicenseApplications.DataSource = _dtAlllocalDrivinglLicenseApplications;

            _AdjustColumnSize();

            //Set the Records Number
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }


        void _AdjustColumnSize()
        {
            if (dgvLocalDrivingLicenseApplications.RowCount > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "License Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No.";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 150;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;

                dgvLocalDrivingLicenseApplications.Columns["Full Name"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            else
                dgvLocalDrivingLicenseApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void frmLocalDrivingLicenseApplicationList_Load(object sender, EventArgs e)
        {
            _LoadLocalDrivingLicenseApplications();
            _SetDefaultValues();
        }

        void _SetDefaultValues()
        {
            cbFilter.SelectedIndex = 0;
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedItem.ToString() == "Local DL AppID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        void FilterDv(ref DataView dv)
        {
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 

            switch (cbFilter.Text)
            {
                case "L.D.L. AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "Class Name":
                    FilterColumn = "ClassName";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (tbSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }
            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                //We're dealing with integer not string
                _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", FilterColumn, tbSearch.Text.Trim());
            }
            else
                _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", FilterColumn, tbSearch.Text.Trim());

            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";


            if (cbFilter.Text == "Status")
            {
                tbSearch.Visible = false;
                cbStatus.Visible = true;

                cbStatus.SelectedIndex = 0;

                return;
            }
            else if (cbStatus.Visible == true && cbFilter.SelectedIndex != 5)
            {
                cbStatus.Visible = false;
                tbSearch.Visible = true;

                _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            }

            tbSearch.Enabled = cbFilter.Text != "None";
            tbSearch.Focus();

        }

        private void frmLocalDLApplications_Shown(object sender, EventArgs e)
        {
            cbFilter.Focus();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
            {
                _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = "";
                return;
            }


            _dtAlllocalDrivinglLicenseApplications.DefaultView.RowFilter = string.Format("{0} = '{1}'", "Status", cbStatus.Text);
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            using (frmAddUpdateLocalDLApplication frm = new frmAddUpdateLocalDLApplication())
            {
                frm.ShowDialog();
            }
            _LoadLocalDrivingLicenseApplications();

        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {

            if (int.TryParse(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value.ToString(), out int selectedAppID))
            {

                if (MessageBox.Show($"Are You Sure To Delete This Local Driving License App.ID [{selectedAppID}] ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(selectedAppID);

                    if (localDrivingLicenseApplication != null && localDrivingLicenseApplication.Delete())
                    {
                        MessageBox.Show("Delete Successfully");
                        _LoadLocalDrivingLicenseApplications();
                    }
                    else
                    {

                        MessageBox.Show("Delete UnSuccessfully", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value.ToString(), out int selectedAppID))
            {
                if (MessageBox.Show($"Are You Sure To Cancel This Local Driving License App.ID [{selectedAppID}] ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(selectedAppID);
                    if (localDrivingLicenseApplication != null && localDrivingLicenseApplication.Cancel())
                    {
                        MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadLocalDrivingLicenseApplications();
                    }
                    else
                    {
                        MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _LoadLocalDrivingLicenseApplications();

        }



        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }





        void HandleContextStripMenu()
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                    clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID
                                                    (LocalDrivingLicenseApplicationID);

            int TotalPassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;

            //bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();


            //Enabled only if person passed all tests and Does not have license. 
            //tsmiIssueDrivingLicenseFirstTime.Enabled = (TotalPassedTests == 3) && !LicenseExists;

            //tsmiShowLicense.Enabled = LicenseExists;
            //tsmiSechduleTests.Enabled = !LicenseExists;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            tsmiCancelApplication.Enabled = (LocalDrivingLicenseApplication.Status == clsApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            tsmDelete.Enabled =
                (LocalDrivingLicenseApplication.Status == clsApplication.enApplicationStatus.New);

            //Enable Disable Schedule menue and it's sub menue
            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest); ;
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);

            tsmiSechduleTests.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.Status == clsApplication.enApplicationStatus.New);

            if (tsmiSechduleTests.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                tsmiSechduleVisionTest.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                tsmiSechduleWrittenTest.Enabled = PassedVisionTest && !PassedWrittenTest;

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                tsmiSechduleStreetTest.Enabled = PassedVisionTest && PassedWrittenTest && !PassedStreetTest;

            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            HandleContextStripMenu();

        }

        private void dgvLocalDrivingLicenseApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmiSechduleVisionTest_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;



            frmListTestAppointments frm = new(localDrivingLicenseApplicationID, clsTestType.enTestType.VisionTest);
            frm.Show();

        }

        private void tsmiSechduleWrittenTest_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;



            frmListTestAppointments frm = new(localDrivingLicenseApplicationID, clsTestType.enTestType.WrittenTest);
            frm.Show();

        }

        private void tsmiSechduleStreetTest_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;



            frmListTestAppointments frm = new(localDrivingLicenseApplicationID, clsTestType.enTestType.StreetTest);
            frm.Show();

        }
    }
}
