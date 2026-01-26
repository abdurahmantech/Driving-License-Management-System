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



namespace PresentationLayer
{
    public partial class frmAddUpdateUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        clsUser _User;

        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int userID)
        {
            InitializeComponent();

            _UserID = userID;
            _Mode = enMode.Update;

        }


        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == enMode.AddNew)
            {
                lblHeader.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                tbLoginInfo.Enabled = false;

                ucPersonInfoWithFilter1.FilterValueFocus();
            }
            else
            {
                lblHeader.Text = "Update User";
                this.Text = "Update User";

                tbLoginInfo.Enabled = true;
                btnSave.Enabled = true;


            }

            tbUsername.Text = "";
            tbPassword.Text = "";
            tbConfirmPassword.Text = "";
            chkIsActive.Checked = true;


        }

        private void _LoadData()
        {

            _User = clsUser.FindByUserID(_UserID);
            ucPersonInfoWithFilter1.FilterEnabled = false;

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            //the following code will not be executed if the person was not found
            lblUserID.Text = _User.UserID.ToString();
            tbUsername.Text = _User.UserName;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ucPersonInfoWithFilter1.LoadPersonInfo(_User.PersonID);

            tbPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            btnShowHidePassword.Enabled = false;
        }


        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void tbPersonInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbLoginInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tbLoginInfo"];
                return;
            }

            if (ucPersonInfoWithFilter1.PersonID != -1)
            {
                if (clsUser.isUserExistForPersonID(ucPersonInfoWithFilter1.PersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucPersonInfoWithFilter1.FilterValueFocus();
                }

                else
                {
                    btnSave.Enabled = true;
                    tbLoginInfo.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages["tbLoginInfo"];
                }

            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucPersonInfoWithFilter1.FilterValueFocus();
            }

        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Username cannot be blank");
                return;
            }

            if (_Mode == enMode.AddNew)
            {

                if (clsUser.isUserExist(tbUsername.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUsername, "username is used by another user");
                    return;
                }
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != tbUsername.Text.Trim())
                {
                    if (clsUser.isUserExist(tbUsername.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbUsername, "username is used by another user");
                        return;
                    }
                }
            }

            errorProvider1.SetError(tbUsername, null);

        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text.Trim().Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password must be more than 4 characters");
                return;
            }
            errorProvider1.SetError(tbPassword, null);

            ;
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(tbConfirmPassword, null);
            }
            ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valid!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.PersonID = ucPersonInfoWithFilter1.PersonID;
            _User.UserName = tbUsername.Text.Trim();
            _User.Password = tbPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;


            if (_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblHeader.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Tag = 1; // Assign that data has successfully changed to caller form
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close the form?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPassword.UseSystemPasswordChar = false;

                btnShowHidePassword.Image = Properties.Resources.hidden;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPassword.UseSystemPasswordChar = true;

                btnShowHidePassword.Image = Properties.Resources.visible;
            }

        }
    }
}
