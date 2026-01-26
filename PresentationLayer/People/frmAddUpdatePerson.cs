using BusinessLogicLayer;
using DVLD.Classes;
using PresentationLayer.Properties;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer
{

    public partial class frmAddUpdatePerson : Form
    {

        public delegate void DataBackEventHandler(object sender, int personID);

        public event DataBackEventHandler DataBack;

        int _personID = -1;
        clsPerson _person;
        enMode mode;

        enum enGender { Male = 0, Female = 1 };
        enum enMode { Add = 0, Update = 1 };

        public frmAddUpdatePerson()
        {
            InitializeComponent();

            mode = enMode.Add;
        }

        public frmAddUpdatePerson(int personID)
        {
            InitializeComponent();

            mode = enMode.Update;
            _personID = personID;
        }

        private void frmAddEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FillCountriesComboBox()
        {
/*            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
*/
            cbCountry.DataSource = clsCountry.GetAllCountries();

            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

        }

        private void _ResetDefualtValues()
        {
            FillCountriesComboBox();

            if (mode == enMode.Update)
            {
                lblHeader.Text = "Update Person";
                this.Text = "Update Person";   
            }
            else
            {
                lblHeader.Text = "Add New Person";
                this.Text = "Add New Person";
                _person = new clsPerson();
            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Men;
            else
                pbPersonImage.Image = Resources.Women;

            llbRemoveImage.Visible = (pbPersonImage.ImageLocation != "");

            dtpDob.MaxDate = DateTime.Now.AddYears(-18);
            dtpDob.Value = dtpDob.MaxDate;
            dtpDob.MinDate = DateTime.Now.AddYears(-100);
            

            cbCountry.SelectedIndex = cbCountry.FindString("Ethiopia");

            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbLastName.Text = "";
            tbNationalNo.Text = "";
            rbMale.Checked = true;
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }

        void _LoadPersonData()
        {
            _person = clsPerson.Find(_personID);

            if (_person == null)
            {
                MessageBox.Show("No Person with ID = " + _personID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblPersonID.Text = _personID.ToString();
            tbFirstName.Text = _person.FirstName;
            tbSecondName.Text = _person.SecondName;
            tbThirdName.Text = _person.ThirdName;
            tbLastName.Text = _person.LastName;
            tbNationalNo.Text = _person.NationalNo;
            dtpDob.Value = _person.DateOfBirth;

            if (_person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            tbAddress.Text = _person.Address;
            tbPhone.Text = _person.Phone;
            tbEmail.Text = _person.Email;
            cbCountry.SelectedIndex = (int)cbCountry.SelectedValue;

            if (_person.ImagePath != "")
            {
                pbPersonImage.ImageLocation = _person.ImagePath;

            }
            llbRemoveImage.Visible = (_person.ImagePath != "");

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (mode == enMode.Update)
            {
                _LoadPersonData();
            }
        }

        bool _HandlePersonImage()
        {

            if (_person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_person.ImagePath);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error Deleting Old Image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llbRemoveImage.Visible = true;
            }
        }

        private void llbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Men;
            else
                pbPersonImage.Image = Resources.Women;

            llbRemoveImage.Visible = false;

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Women;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Men;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }


        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (tbEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(tbEmail, null);
            }
            ;

        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (tbNationalNo.Text.Trim() != _person.NationalNo && clsPerson.isPersonExist(tbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "National Number is used for another _person!");

            }
            else
            {
                errorProvider1.SetError(tbNationalNo, null);
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

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = clsCountry.Find(Convert.ToInt32( cbCountry.SelectedValue)).ID;

            _person.FirstName = tbFirstName.Text.Trim();
            _person.SecondName = tbSecondName.Text.Trim();
            _person.ThirdName = tbThirdName.Text.Trim();
            _person.LastName = tbLastName.Text.Trim();
            _person.NationalNo = tbNationalNo.Text.Trim();
            _person.Email = tbEmail.Text.Trim();
            _person.Phone = tbPhone.Text.Trim();
            _person.Address = tbAddress.Text.Trim();
            _person.DateOfBirth = dtpDob.Value;

            if (rbMale.Checked)
                _person.Gender = (short)enGender.Male;
            else
                _person.Gender = (short)enGender.Female;

            _person.NationalityCountryID = NationalityCountryID;

            if (pbPersonImage.ImageLocation != null)
                _person.ImagePath = pbPersonImage.ImageLocation;
            else
                _person.ImagePath = "";

            if (_person.Save())
            {
                lblPersonID.Text = _person.PersonID.ToString();
                //change form mode to update.
                mode = enMode.Update;
                lblHeader.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _person.PersonID);

                this.Tag = 1; // Indicate Update occurred
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

}
