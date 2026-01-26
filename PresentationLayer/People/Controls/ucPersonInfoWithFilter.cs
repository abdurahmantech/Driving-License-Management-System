using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer.People.Controls
{
    public partial class ucPersonInfoWithFilter : UserControl
    {

        [DefaultValue(true)]
        public bool FilterEnabled
        {
            get
            {
                return gbFilter.Enabled;
            }
            set
            {
                gbFilter.Enabled = value;
            }
        }

        /*        // Define a custom event handler delegate with parameters
public event Action<int> OnPersonSelected;
// Create a protected method to raise the event with a parameter
protected virtual void PersonSelected(int PersonID)
{
Action<int> handler = OnPersonSelected;
if (handler != null)
{
handler(PersonID); // Raise the event with the parameter
}
}*/

        public ucPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {

            cbFilterBy.SelectedIndex = 0;
            tbFilterValue.Text = PersonID.ToString();

            FindNow();

        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ucPersonDetails1.LoadPersonInfo(int.Parse(tbFilterValue.Text));

                    break;

                case "National No.":
                    ucPersonDetails1.LoadPersonInfo(tbFilterValue.Text);
                    break;

                default:
                    break;
            }

            /*            if (OnPersonSelected != null && FilterEnabled)
                            // Raise the event with a parameter
                            OnPersonSelected(ctrlPersonCard1.PersonID);*/
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";
            tbFilterValue.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNow();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm1 = new frmAddUpdatePerson();
            frm1.DataBack += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();

        }

        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            tbFilterValue.Text = PersonID.ToString();
            ucPersonDetails1.LoadPersonInfo(PersonID);
        }

        public void FilterValueFocus()
        {
            tbFilterValue.Focus();
        }

        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnSearch.PerformClick();
                return;
            }

            if (cbFilterBy.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public int PersonID
        {
            get { return ucPersonDetails1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return ucPersonDetails1.SelectedPersonInfo; }
        }


        private void tbFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text.Trim()))
            {
                errorProvider1.SetError(tbFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(tbFilterValue, null);
            }
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

        private void ucPersonInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
        }
    }
}
