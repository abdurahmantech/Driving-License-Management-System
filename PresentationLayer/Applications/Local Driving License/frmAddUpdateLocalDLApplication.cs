using BusinessLogicLayer;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmAddUpdateLocalDLApplication : Form
    {
        clsPerson _person = null;

        public enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmAddUpdateLocalDLApplication()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateLocalDLApplication(int localDLApplicationID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _LocalDrivingLicenseApplicationID = localDLApplicationID;
        }


        void _ResetDefaultValues()
        {
            _LoadLicenseClassesInComboBox();

            if (_Mode == enMode.AddNew)
            {

                lblHeader.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                ucPersonInfoWithFilter1.FilterFocus();
                tbApplicationInfo.Enabled = false;

                cbLicenseClasses.SelectedIndex = 2;
                lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocalDrivingLicense).Fees.ToString();
                lblApplicationDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = clsGlobal.LoggedInUser.UserName;
                btnSave.Enabled = false;
            }
            else
            {
                lblHeader.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";

                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        void _LoadLicenseClassesInComboBox()
        {
            cbLicenseClasses.DataSource = clsLicenseClass.GetAllLicenseClasses();

            cbLicenseClasses.DisplayMember = "ClassName";
            cbLicenseClasses.ValueMember = "LicenseClassID";
        }

        private void _LoadData()
        {
            ucPersonInfoWithFilter1.FilterEnabled = false;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            ucPersonInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToShortDateString();
            cbLicenseClasses.SelectedIndex = _LocalDrivingLicenseApplication.LicenseClassID; // Intialize Before with the ID Value
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString("0.##");
            lblCreatedBy.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        }

        private void frmAddNewLocalDLApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void frmAddNewLocalDLApplication_Shown(object sender, EventArgs e)
        {
            ucPersonInfoWithFilter1.FilterFocus();
        }

        private void ucPersonInfoWithFilter1_OnPersonSelected(int personID)
        {
            _person = clsPerson.Find(personID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update || (_Mode == enMode.AddNew && ucPersonInfoWithFilter1.PersonID != -1)) // Update Mode Or In case Addnew there is selected person 
            {
                btnSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tabControl1.SelectedIndex = 1;
                return;
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonInfoWithFilter1.FilterFocus();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            int licenseClassID = clsLicenseClass.Find(cbLicenseClasses.Text).LicenseClassID;

            int ActiveApplicationID = clsLocalDrivingLicenseApplication.GetActiveApplicationIDForLicenseClass(ucPersonInfoWithFilter1.PersonID,
                clsLocalDrivingLicenseApplication.enApplicationType.NewLocalDrivingLicense, licenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active _application for the selected class with id=" + ActiveApplicationID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cbLicenseClasses.Focus();


                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = ucPersonInfoWithFilter1.PersonID;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.NewLocalDrivingLicense;
            _LocalDrivingLicenseApplication.Status = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lblApplicationFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.LoggedInUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = licenseClassID;

            if (_LocalDrivingLicenseApplication.Save())
            {
                lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();

                //Change the current mode to update mode
                _Mode = enMode.Update;

                lblHeader.Text = "Update Local Driving License Application";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ucPersonInfoWithFilter1.PersonID != -1 && _Mode == enMode.AddNew)
            {
                if (MessageBox.Show("Are you sure you want to proceed with this action? This cannot be undone", "Confirm Action",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
            }
            this.Close();
        }

        private void ucPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }
    }
}
