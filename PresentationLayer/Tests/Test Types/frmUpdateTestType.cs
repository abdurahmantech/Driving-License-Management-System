using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer.Tests
{
    public partial class frmUpdateTestType : Form
    {
        int _testTypeID = -1;
        clsTestType _testType;

        public frmUpdateTestType(int testTypeID)
        {
            InitializeComponent();

            _testTypeID = testTypeID;
        }

        void _LoadApplicationTypeInfo()
        {
            lblApplicationID.Text = _testTypeID.ToString();

            _testType = clsTestType.Find((clsTestType.enTestType)_testTypeID);

            if (_testType != null)
            {
                tbTitle.Text = _testType.Title;
                tbFees.Text = _testType.Fees.ToString("0.##");
                tbDescription.Text = _testType.Description;
            }
            else
                MessageBox.Show(
                       $"Application type with ID [{_testTypeID}] not found. Please make sure the ID is correct.",
                       "Not Found",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );
        }

        bool _IsValidInput()
        {
            bool isValid = true;

            List<TextBox> list = new List<TextBox> { tbDescription, tbFees, tbTitle };

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

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypeInfo();
            btnSave.Enabled = false;
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar));
        }

        private void tbFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)); // allow controls or digits only
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_IsValidInput())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _testType.Title = tbTitle.Text.Trim();
            _testType.Fees = Convert.ToDecimal(tbFees.Text.Trim());
            _testType.Description = tbDescription.Text.Trim();

            if (_testType.Save())
            {
                MessageBox.Show("Data Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void tbDescription_Validating(object sender, CancelEventArgs e)
        {
            btnSave.Enabled = (tbTitle?.Text.Trim() != _testType.Title || Convert.ToDecimal(tbFees.Text) != _testType.Fees || tbDescription?.Text.Trim() != _testType.Description);
        }
    }
}
