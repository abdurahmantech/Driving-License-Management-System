using BusinessLogicLayer;
using PresentationLayer;
using PresentationLayer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ucPersonDetails : UserControl
    {
        public ucPersonDetails()
        {
            InitializeComponent();
        }

        clsPerson _person;
        int _personID = -1;

        public int PersonID
        {
            get { return _personID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _person; }
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_personID);

            frm.ShowDialog();
            
            if(frm.Tag != null)
            {
                //refresh
                LoadPersonInfo(_personID);
                this.Tag = 1; //indicate data has changed
            }
        }

        private void gbPersonInformation_Enter(object sender, EventArgs e)
        {

        }


        public void ResetPersonInfo()
        {
            _personID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
            pbGender.Image = Resources.Men;
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDOB.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pbPersonImage.Image = Resources.Men;

        }

        public void LoadPersonInfo(int PersonID)
        {
            _person = clsPerson.Find(PersonID);
            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _person = clsPerson.Find(NationalNo);
            if (_person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {
            if (_person.Gender == 0)
                pbPersonImage.Image = Resources.Men;
            else
                pbPersonImage.Image = Resources.Women;

            string ImagePath = _person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void _FillPersonInfo()
        {
            llEditPersonInfo.Enabled = true;
            _personID = _person.PersonID;
            lblPersonID.Text=_person.PersonID.ToString();
            lblNationalNo.Text = _person.NationalNo;
            lblName.Text = _person.FullName;
            lblGender.Text = _person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _person.Email;
            lblPhone.Text = _person.Phone;
            lblDOB.Text = _person.DateOfBirth.ToString("dd/MM/yyyy");
            lblCountry.Text= clsCountry.Find( _person.NationalityCountryID).CountryName ;
            lblAddress.Text= _person.Address;
            _LoadPersonImage();
        }
    }
}
