using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;

namespace BusinessLogicLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public enum enMode { AddNew = 1, Update = 2 };
        private enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }

        public clsLicenseClass LicenseClasssInfo;

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;

            Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID, int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            enApplicationStatus applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID, int licenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = applicationID;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicantPersonInfo = clsPerson.Find(applicantPersonID);
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.Status = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.LicenseClassID = licenseClassID;
            this.LicenseClasssInfo = clsLicenseClass.Find(licenseClassID);

            Mode = enMode.Update;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,
                this.ApplicationID, this.LicenseClassID);
        }

        public bool Save()
        {
            // Set base to the current mode in this application because of inheritance
            base.Mode = (clsApplication.enMode)Mode;
            if (!base.Save())
                return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLocalDrivingLicenseApplication())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    {
                        return _UpdateLocalDrivingLicenseApplication();
                    }
                default:
                    return false ;
            }
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public static clsLocalDrivingLicenseApplication FindByApplicationID(int applicationID)
        {
            int licenseClassID = -1, localDrivingLicenseApplicationID = -1;
            bool isFound = false;

            isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(applicationID,ref localDrivingLicenseApplicationID, ref licenseClassID);

            if (isFound)
            {
                clsApplication application = clsApplication.FindBaseApplication(applicationID);

                return new clsLocalDrivingLicenseApplication(localDrivingLicenseApplicationID, applicationID, application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID,
                    application.Status, application.LastStatusDate, application.PaidFees, application.CreatedByUserID, licenseClassID);
            }
            else return null;
        }

        public static clsLocalDrivingLicenseApplication FindByLocalDrivingLicenseApplicationID(int localDrivingLicenseApplicationID)
        {
            int licenseClassID = -1, applicationID = -1;
            bool isFound = false;

            isFound = clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(localDrivingLicenseApplicationID, ref applicationID, ref licenseClassID);

            if (isFound)
            {
                clsApplication application = clsApplication.FindBaseApplication(applicationID);

                return new clsLocalDrivingLicenseApplication(localDrivingLicenseApplicationID, applicationID, application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeID,
                    application.Status, application.LastStatusDate, application.PaidFees, application.CreatedByUserID, licenseClassID);
            }
            else return null;
        }

        public bool Delete()
        {
            bool isBaseApplicationDeleted = false;
            bool isLocalDrivingLicenseDeleted = false;

            isLocalDrivingLicenseDeleted = clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID);

            if (!isLocalDrivingLicenseDeleted)
                return false;


            isBaseApplicationDeleted = base.Delete();

            return isBaseApplicationDeleted;
        }

        public bool DoesPassTestType(clsTestType.enTestType testType)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)testType);
        }

        public bool DoesPassPreviousTest(clsTestType.enTestType currentTestType)
        {
            switch (currentTestType)
            {
                case clsTestType.enTestType.VisionTest:
                    return true; //in this case no required prvious test to pass.

                case clsTestType.enTestType.WrittenTest:
                    return this.DoesPassTestType(clsTestType.enTestType.VisionTest);
                case clsTestType.enTestType.StreetTest:
                    return this.DoesPassTestType(clsTestType.enTestType.WrittenTest);
                default:
                    return false ;
            }

        }

        public static bool DoesPassTestType(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesPassTestType(localDrivingLicenseApplicationID, (int)testTypeID);
        }

        public bool DoesAttendTestType(clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)testTypeID);
        }

        public byte TotalTrialsPerTest(clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)testTypeID);
        }

        public static byte TotalTrialsPerTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(localDrivingLicenseApplicationID, (int)testTypeID);
        }

        public bool AttendedTest(clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)testTypeID) > 0;
        }

        public static bool AttendedTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.TotalTrialsPerTest(localDrivingLicenseApplicationID, (int)testTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(localDrivingLicenseApplicationID, (int)testTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType testTypeID)
        {
            return clsLocalDrivingLicenseApplicationData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)testTypeID);
        }

        public clsTest GetLastTestPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, this.LicenseClassID, TestTypeID);
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return clsTest.PassedAllTests(LocalDrivingLicenseApplicationID);
        }



    }
}
