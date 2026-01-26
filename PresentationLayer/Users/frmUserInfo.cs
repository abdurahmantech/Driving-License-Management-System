using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PresentationLayer.Users.Controls;

namespace PresentationLayer.Users
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo(int userID)
        {
            InitializeComponent();

            _userID = userID;
        }

        int _userID = -1;



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ucUserInfo1.LoadUserInfo(_userID);
        }
    }
}
