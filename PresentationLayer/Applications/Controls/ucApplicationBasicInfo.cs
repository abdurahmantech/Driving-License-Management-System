using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class ucApplicationBasicInfo : UserControl
    {
        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private clsApplication _application = null;

        public int ApplicationID
        {
            get { return _application.ApplicationID; }
        }


        public void LoadApplicationInfo(int applicationID)
        {
            _application = clsApplication.FindBaseApplication(applicationID);
            if (_application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + applicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            lblApplicationID.Text = _application.ApplicationID.ToString();
            lblType.Text = _application.ApplicationTypeInfo.Title;
            lblStatus.Text = _application.StatusText;
            lblPaidFees.Text = _application.PaidFees.ToString("0.####");
            lblApplicant.Text = _application.ApplicantFullName;
            lblDate.Text = _application.ApplicationDate.ToString("dd/MM/yyyy");
            lblLastStatusDate.Text = _application.LastStatusDate.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = _application.CreatedByUserInfo.UserName;


        }

        public void ResetApplicationInfo()
        {
            lblApplicationID.Text = "[???]";
            lblStatus.Text = "[???]";
            lblType.Text = "[???]";
            lblPaidFees.Text = "[$$$]";
            lblApplicant.Text = "[???]";
            lblDate.Text = "[???]";
            lblLastStatusDate.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_application != null)
            {
                frmShowPersonInfo frm = new frmShowPersonInfo(_application.ApplicantPersonID);
                frm.ShowDialog();

                LoadApplicationInfo(_application.ApplicationID);
            }
        }
    }
}
