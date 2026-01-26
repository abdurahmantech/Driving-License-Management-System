using BusinessLogicLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.Users.Controls
{
    public partial class ucUserInfo : UserControl
    {
        public ucUserInfo()
        {
            InitializeComponent();
        }

        private clsUser _user;
        private int _userID = -1;

        public int UserID
        {
            get { return _userID; }
        }

        public ucUserInfo(int userID)
        {
            InitializeComponent();

            this._userID = userID;
        }

        public void LoadUserInfo(int userID)
        {
            _user = clsUser.FindByUserID(userID);
            if (_user == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            ucPersonDetails1.LoadPersonInfo(_user.PersonID);
            lblUserID.Text = _user.UserID.ToString();
            lblUsername.Text = _user.UserName.ToString();

            if (_user.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";

        }

        private void _ResetPersonInfo()
        {

            ucPersonDetails1.ResetPersonInfo();
            lblUserID.Text = "[???]";
            lblUsername.Text = "[???]";
            lblIsActive.Text = "[???]";
        }
    }
}
