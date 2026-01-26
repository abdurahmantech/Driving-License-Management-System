using BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmChangeUserPassword : Form
    {
        public frmChangeUserPassword()
        {

            InitializeComponent();

        }

        int _userID = -1;

        public frmChangeUserPassword(int userID)
        {

            InitializeComponent();
            _userID = userID;
        }

        private void _ResetDefualtValues()
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Text = "";
            tbCurrentPassword.Focus();
        }


        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {


        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowHideCurrentpassword_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHideNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            clsUser user = clsUser.FindByUserID(_userID);

            if(user == null)
            {
                MessageBox.Show("Could not Find User with id = " + _userID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            ucUserInfo1.LoadUserInfo(_userID);
        }
    }
}
