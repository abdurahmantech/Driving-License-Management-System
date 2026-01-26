  using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public static class clsApplicationData
    {
        public static bool GetApplicationInfoByID(int applicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID,
                ref short applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(DataAccessLayer.clsDataAccessSetting.ConnectionString);

                string query = @"SELECT  applicationID, ApplicantPersonID, ApplicationDate, applicationTypeID, ApplicationStatus,
                                LastStatusDate, PaidFees, CreatedByUserID FROM Applications WHERE applicationID = @applicationID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@applicationID", applicationID);
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    applicantPersonID = (int)reader["ApplicantPersonID"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationTypeID = (int)reader["applicationTypeID"];
                    applicationStatus = (short)reader["ApplicationStatus"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    isFound = true;
                }
            }
            catch
            {
                isFound = false;
            }

            return isFound;

        }

        public static DataTable GetAllApplications()
        {
            DataTable dt = new();

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);
                string query = @"select * from Applications order by applicationID";

                using SqlCommand cmd = new(query, conn);
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch
            {
                throw;
            }

            return dt;
        }

        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            short applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {

            int insertedId = -1;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);
                string query = @"INSERT INTO [dbo].[Applications]
                                (
                                    [ApplicantPersonID],
                                    [ApplicationDate],
                                    [applicationTypeID],
                                    [ApplicationStatus],
                                    [LastStatusDate],
                                    [PaidFees],
                                    [CreatedByUserID]
                                )
                                VALUES
                                (
                                    @ApplicantPersonID,
                                    @ApplicationDate,
                                    @applicationTypeID,
                                    @ApplicationStatus,
                                    @LastStatusDate,
                                    @PaidFees,
                                    @CreatedByUserID
                                );
                                
                                SELECT SCOPE_IDENTITY();";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                cmd.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                conn.Open();

                object result = cmd.ExecuteScalar();
                insertedId = Convert.ToInt32(result);
            }
            catch
            {
                throw;
            }


            return insertedId;
        }

        public static bool UpdateApplication(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            short applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  Applications  
                            set ApplicantPersonID = @ApplicantPersonID,
                                ApplicationDate = @ApplicationDate,
                                applicationTypeID = @applicationTypeID,
                                ApplicationStatus = @ApplicationStatus, 
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,
                                CreatedByUserID=@CreatedByUserID
                            where applicationID=@applicationID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@applicationID", applicationID);
                cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                cmd.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);
                cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                conn.Open();

                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteApplication(int applicationID)
        {
            int rowsAffected = 0;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);


                conn.Open();

                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                throw;
            }

            return (rowsAffected > 0);

        }

        public static bool IsApplicationExist(int applicationID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);
                string query = @"SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                // هنا ممكن تضيف Logging لاحقًا
                // Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static int GetActiveApplicationID(int applicantPersonID, int applicationTypeID)
        {
            int activeApplicationID = -1;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Select ActiveApplicationID = Applications.ApplicationID from Applications 
                                 WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationStatus = 1 and ApplicationTypeID =@ApplicationTypeID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    activeApplicationID = Convert.ToInt32(result);
            }
            catch
            {
                activeApplicationID = -1;
            }
            return activeApplicationID;
        }

        public static bool DoesPersonHaveActiveApplication(int applicantPersonID, int applicationTypeID)
        {
            //incase the ActiveApplication ID !=-1 return true.
            return (GetActiveApplicationID(applicantPersonID, applicationTypeID) != -1);
        }

        public static int GetActiveApplicationIDForLicenseClassID(int applicantPersonID, int applicationTypeID,int licenseClassID)
        {
            int activeApplicationID = -1;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT ActiveApplicationID = a.ApplicationID
                                    FROM Applications a
                                    INNER JOIN LocalDrivingLicenseApplications l
                                        ON a.ApplicationID = l.ApplicationID
                                    WHERE a.ApplicantPersonID = @ApplicantPersonID
                                      AND a.ApplicationStatus = 1
                                      AND a.ApplicationTypeID = @ApplicationTypeID
                                      AND l.LicenseClassID = @LicenseClassID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                cmd.Parameters.AddWithValue("LicenseClassID", licenseClassID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                    activeApplicationID = Convert.ToInt32(result);
            }
            catch
            {
                activeApplicationID = -1;
            }


            return activeApplicationID;
        }

        public static bool UpdateStatus(int applicationID,short newStatus)
        {
            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID=@ApplicationID;";

                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@NewStatus", newStatus);

                conn.Open();

                return (cmd.ExecuteNonQuery() > 0);

            }
            catch
            {
                return false;
            }
        }

    }







}
