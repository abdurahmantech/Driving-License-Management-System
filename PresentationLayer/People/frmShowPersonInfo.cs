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
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personID)
        {
            InitializeComponent();

            ucPersonDetails1.LoadPersonInfo(personID);
        }

        public frmShowPersonInfo(string nationalNo)
        {
            InitializeComponent();

            ucPersonDetails1.LoadPersonInfo(nationalNo);
        }


        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Tag = ucPersonDetails1.Tag; // pass 1 if data has changed
        }
    }
}
