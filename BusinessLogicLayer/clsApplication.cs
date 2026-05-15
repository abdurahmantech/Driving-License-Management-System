using System;
using System.Collections.Generic;
using DataAccessLayer;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;

namespace BusinessLogicLayer
{
    public class clsApplication
    {
        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public enum enApplicationType
        {
            NewLocalDrivingLicense = 1,
            RenewDrivingLicense = 2,
            ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalDrivingLicense = 6,
            RetakeTest = 7
        }

        public enum enApplicationStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }

        public enMode Mode = enMode.AddNew;

        public int ApplicationID { set; get; }

        public int ApplicantPersonID { set; get; }

        public clsPerson? ApplicantPersonInfo { set; get; }

        public string ApplicantFullName
        {
            get
            {
                if (ApplicantPersonInfo != null)
                    return ApplicantPersonInfo.FullName;
                else
                    return string.Empty;
            }
        }

        public int ApplicationTypeID { get; set; }

        public clsApplicationType? ApplicationTypeInfo { get; set; }
        public DateTime ApplicationDate { set; get; }

        public decimal PaidFees { get; set; }

        public enApplicationStatus Status { set; get; }

        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
                
            }
        }

        public DateTime LastStatusDate { set; get; }

        public int CreatedByUserID { get; set; }

        public clsUser? CreatedByUserInfo { set; get; }

        public clsApplication()
        {
            Mode = enMode.AddNew;

            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicantPersonInfo = null;

            ApplicationTypeID = -1;
            ApplicationTypeInfo = null;

            ApplicationDate = DateTime.Now;
            LastStatusDate = DateTime.Now;

            PaidFees = 0;

            Status = enApplicationStatus.New;

            CreatedByUserID = -1;
            CreatedByUserInfo = null;

        }

        private clsApplication(int applicationID, int applicantPersonID, int applicationTypeID, DateTime applicationDate,
            decimal paidFees, enApplicationStatus status, DateTime lastStatusDate, int createdByUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicantPersonInfo = clsPerson.Find(applicantPersonID);

            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(applicationTypeID);

            this.ApplicationDate = applicationDate;
            this.PaidFees = paidFees;

            this.Status = status;
            this.LastStatusDate = lastStatusDate;

            this.CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(createdByUserID);

            this.Mode = enMode.Update;
        }


        public bool Cancel()
        {
            return clsApplicationData.UpdateStatus(ApplicationID, (short)enApplicationStatus.Cancelled);
        }

        public bool SetCompleted()
        {
            return clsApplicationData.UpdateStatus(ApplicationID, (short)enApplicationStatus.Completed);
        }

        private bool _AddNewApplication()
        {
            ApplicationID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)Status, LastStatusDate, PaidFees, CreatedByUserID);

            return (ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(this.ApplicationID,ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, (byte)Status, LastStatusDate, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        return _AddNewApplication();
                    }
                case enMode.Update:
                    {
                        return _UpdateApplication();
                    }
                default:
                    return false;
            }
        }

        public static bool IsApplicationExist(int applicationID)
        {
            return clsApplicationData.IsApplicationExist(applicationID);
        }

        public static clsApplication FindBaseApplication(int applicationID)
        {
            int applicantPersonID = -1, applicationTypeID = -1, createdByUserID = -1;
            DateTime applicationDate = DateTime.Now, lastStatusDate = DateTime.Now;

            decimal paidFees = 0;

            byte status = (byte)enApplicationStatus.New;

          bool isFound =  clsApplicationData.GetApplicationInfoByID(applicationID, ref applicantPersonID, ref applicationDate, ref applicationTypeID, ref status,
                ref lastStatusDate, ref paidFees, ref createdByUserID);

            if (isFound)
                return new clsApplication(applicationID, applicantPersonID, applicationTypeID, applicationDate, paidFees, (enApplicationStatus)status, lastStatusDate, createdByUserID);
            else
                return null;

            
        }

        public bool Delete()
        {
            return clsApplicationData.DeleteApplication(this.ApplicationID);
        }

        public static bool DoesPersonHaveActiveApplication(int personID, clsApplication.enApplicationType applicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(personID, (int)applicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClassID(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(this.ApplicantPersonID, (int)ApplicationTypeID);
        }
    }

}
