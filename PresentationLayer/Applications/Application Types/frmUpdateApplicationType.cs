using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frmUpdateApplicationType : Form
    {
        int _applicationID = -1;
        clsApplicationType _applicationType;

        public frmUpdateApplicationType(int applicationID)
        {
            InitializeComponent();

            _applicationID = applicationID;
        }

        void _LoadApplicationTypeInfo()
        {
            lblApplicationID.Text = _applicationID.ToString();

            _applicationType = clsApplicationType.Find(_applicationID);

            if (_applicationType != null)
            {
                tbTitle.Text = _applicationType.Title;
                tbFees.Text = _applicationType.Fees.ToString("0.##");
            }
            else
                MessageBox.Show(
                       $"Application type with ID [{_applicationID}] not found. Please make sure the ID is correct.",
                       "Not Found",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            _LoadApplicationTypeInfo();
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)); // allow controls or digits only
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidInput())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _applicationType.Title = tbTitle.Text.Trim();
            _applicationType.Fees = Convert.ToDecimal(tbFees.Text.Trim());

            if (_applicationType.Save())
            {
                MessageBox.Show("Data Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (string.IsNullOrEmpty(tb.Text))
                errorProvider1.SetError(tb, "Must Enter A Value");
            else
                errorProvider1.SetError(tb, "");
        }

        bool _IsValidInput()
        {
            bool isValid = true;

            List<TextBox> list = new List<TextBox> { tbFees, tbTitle };

            foreach (TextBox t in list)
            {
                if (string.IsNullOrEmpty(t.Text))
                {
                    errorProvider1.SetError(t, "Must Enter A Value");
                    isValid = false;
                }
                else errorProvider1.SetError(tbTitle, null);
            }

            return isValid;



        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar); // allow letters only
            btnSave.Enabled = (tbTitle.Text != _applicationType.Title || Convert.ToDecimal(tbFees.Text) != _applicationType.Fees);

        }

        private void frmUpdateApplicationType_Validating(object sender, CancelEventArgs e)
        {
            btnSave.Enabled = (tbTitle.Text != _applicationType.Title || Convert.ToDecimal(tbFees.Text) != _applicationType.Fees);
        }

    }
}
