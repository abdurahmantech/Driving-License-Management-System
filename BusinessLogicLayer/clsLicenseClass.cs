using System;
using DataAccessLayer;
using System.Data;
using Microsoft.Win32.SafeHandles;

namespace BusinessLogicLayer
{
    public class clsLicenseClass
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;

        }

        public clsLicenseClass(int licenseClassID, string className, string classDescription,
            byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            this.LicenseClassID = licenseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefaultValidityLength = defaultValidityLength;
            this.ClassFees = classFees;

            Mode = enMode.Update;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassData.GetAllLicenseClasses();

        }


        public static clsLicenseClass Find(string className)
        {
            int licenseClassID = -1; string classDescription = "";
            byte minimumAllowedAge = 0, defaultValidityLength = 0; decimal classFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByClassName(className, ref licenseClassID, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
                return new clsLicenseClass(licenseClassID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            else
                return null;
        }

        public static clsLicenseClass Find(int licenseClassID)
        {
            string className = "", classDescription = "";
            byte minimumAllowedAge = 0, defaultValidityLength = 0; decimal classFees = 0;

            if (clsLicenseClassData.GetLicenseClassInfoByID(licenseClassID, ref className, ref classDescription, ref minimumAllowedAge, ref defaultValidityLength, ref classFees))
                return new clsLicenseClass(licenseClassID, className, classDescription, minimumAllowedAge, defaultValidityLength, classFees);
            else
                return null;
        }

        private void _Update()
        {

        }

        private void _AddNew()
        {

        }

        public void Delete()
        {

        }
    }

}
