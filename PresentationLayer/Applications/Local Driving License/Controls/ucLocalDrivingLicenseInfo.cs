using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class ucLocalDrivingLicenseInfo : UserControl
    {
        public ucLocalDrivingLicenseInfo()
        {
            InitializeComponent();
        }

        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        public int LocalDrivingLicenseApplicationID
        {
            get { return _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID; }
        }

        public void LoadApplicationInfoByLocalDrivingAppID(int localDrivingLicenseApplicationID)
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);
            if (_localDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + localDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        public void LoadApplicationInfoByBaseApplicationID(int applicationID)
        {
            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(applicationID);

            if (_localDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();


                MessageBox.Show("No Application with ApplicationID = " + applicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
                _FillLocalDrivingLicenseApplicationInfo();

        }
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            ucApplicationBasicInfo1.ResetApplicationInfo();
            lblLocalDrivingLicenseApplicationID.Text = "[???]";
            lblAppliedforLicense.Text = "[???]";
            lblPassedTests.Text = "[???]";

        }
        // عالج مشكلة المكتوبة على الورقة

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            lblLocalDrivingLicenseApplicationID.Text = _localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedforLicense.Text = clsLicenseClass.Find(_localDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTests.Text =  _localDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
            ucApplicationBasicInfo1.LoadApplicationInfo(_localDrivingLicenseApplication.ApplicationID);

        }

        private void ucApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void llShowLicenceInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Setup later
        }
    }
}
