using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Applications.Local_Driving_License
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        public frmLocalDrivingLicenseApplicationInfo(int localDrivinglicenseApplicationID)
        {
            InitializeComponent();

            _localDrivinglicenseApplicationID = localDrivinglicenseApplicationID;
        }

        private int _localDrivinglicenseApplicationID = -1;

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ucLocalDrivingLicenseInfo1.LoadApplicationInfoByLocalDrivingAppID(_localDrivinglicenseApplicationID);
        }
    }
}
