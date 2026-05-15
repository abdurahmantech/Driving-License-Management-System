using BusinessLogicLayer;
using PresentationLayer.Tests.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Tests
{
    public partial class frmScheduleTest : Form
    {

        private clsTestType.enTestType _testType = clsTestType.enTestType.VisionTest;
        private int _localDrivingLicenseApplicationID = -1;
        private int _testAppointmentID = -1;


        public frmScheduleTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testType, int testAppointmentID = -1)
        {
            InitializeComponent();

            this._localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this._testType = testType;
            this._testAppointmentID = testAppointmentID;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ucScheduleTest1.TestType = _testType;
            ucScheduleTest1.LoadInfo(_localDrivingLicenseApplicationID, _testAppointmentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucScheduleTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
