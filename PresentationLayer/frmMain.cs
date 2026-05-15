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
using PresentationLayer.Users;
using DVLD.Classes;
using PresentationLayer.ApplicationTypes;
using PresentationLayer.Tests;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {

        Form _frmLogin;
        public frmMain(Form frmLogin)
        {
            InitializeComponent();

            _frmLogin = frmLogin;

        }

        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPeopleList = new frmPeopleList();
            frmPeopleList.ShowDialog();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {

        }

        private void tsmiPeople_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsers();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void loggedUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.LoggedInUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUserPassword frm = new frmChangeUserPassword(clsGlobal.LoggedInUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.LoggedInUser = null;

            _frmLogin.Show();
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLogin.Close();
        }

        private void tsmiManageTestTypes_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void tsmiManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDLApplication frm = new();
            frm.ShowDialog();
        }

        private void tsmiLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationList frm = new();
            frm.ShowDialog();
        }
    }
}
