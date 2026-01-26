using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace BusinessLogicLayer
{
    public class clsPerson
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }

        }
        public string NationalNo { set; get; }
        public DateTime DateOfBirth { set; get; }
        public short Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }

        public clsCountry CountryInfo;
            
        private string _ImagePath;

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()

        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";
            this.CountryInfo = null;
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName,
           string LastName, string NationalNo, DateTime DateOfBirth, short Gender,
            string Address, string Phone, string Email,
           int NationalityCountryID, string ImagePath)

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            Mode = enMode.Update;
        }


        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.PersonID = clsPersonData.AddNewPerson(
                this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNo,
                this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email,
                this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPersonData.UpdatePerson(
                this.PersonID, this.FirstName, this.SecondName, this.ThirdName,
                this.LastName, this.NationalNo, this.DateOfBirth, this.Gender,
                this.Address, this.Phone, this.Email,
                  this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int personID)
        {

            string nationalNo = "", firstName = "", secondName = "", thirdName = "", lastName = "", email = "", phone = "", address = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            int nationalityCountryID = -1;
            short gender = 0;

            bool IsFound = clsPersonData.GetPersonInfoByID
 (               personID, ref firstName, ref secondName,
                                    ref thirdName, ref lastName, ref nationalNo, ref dateOfBirth,
                                    ref gender, ref address, ref phone, ref email,
                                    ref nationalityCountryID, ref imagePath
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsPerson(personID, firstName, secondName, thirdName, lastName,
                          nationalNo, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath);
            else
                return null;
        }

        public static clsPerson Find(string nationalNo)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", email = "", phone = "", address = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            int personID = -1, nationalityCountryID = -1;
            short gender = 0;

            bool isFound = clsPersonData.GetPersonInfoByNationalNo
                                (
                                    ref personID, ref firstName, ref secondName,
                                    ref thirdName, ref lastName, nationalNo , ref dateOfBirth,
                                    ref gender, ref address, ref phone, ref email,
                                    ref nationalityCountryID, ref imagePath
                                );

            if (isFound)

                return new clsPerson(personID, firstName, secondName, thirdName, lastName,
                          nationalNo, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool DeletePerson(int personID)
        {
            return clsPersonData.DeletePerson(personID);
        }

        public static bool isPersonExist(int personID)
        {
            return clsPersonData.IsPersonExist(personID);
        }

        public static bool isPersonExist(string nationalNo)
        {
            return clsPersonData.IsPersonExist(nationalNo);
        }

    }
}
