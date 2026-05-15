using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationData
    {

        public static bool GetLocalDrivingLicenseApplicationInfoByID(
            int localDrivingLicenseApplicationID, ref int applicationID,
            ref int licenseClassID)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);


                string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);


                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    applicationID = (int)reader["applicationID"];
                    licenseClassID = (int)reader["licenseClassID"];
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(
         int applicationID, ref int localDrivingLicenseApplicationID,
         ref int licenseClassID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE applicationID = @applicationID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@applicationID", applicationID);


                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    localDrivingLicenseApplicationID = (int)reader["localDrivingLicenseApplicationID"];
                    licenseClassID = (int)reader["licenseClassID"];

                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            DataTable dt = new DataTable();
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT *
                              FROM LocalDrivingLicenseApplications_View
                              order by ApplicationDate Desc";




                using SqlCommand command = new(query, connection);


                connection.Open();

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }


            return dt;
        }

        public static int AddNewLocalDrivingLicenseApplication(
            int applicationID, int licenseClassID )
        {

            //this function will return the new person id if succeeded and -1 if not.
            int LocalDrivingLicenseApplicationID = -1;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"INSERT INTO LocalDrivingLicenseApplications ( 
                            applicationID,licenseClassID)
                             VALUES (@applicationID,@licenseClassID);
                             SELECT SCOPE_IDENTITY();";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("applicationID", applicationID);
                command.Parameters.AddWithValue("licenseClassID", licenseClassID);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalDrivingLicenseApplicationID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLocalDrivingLicenseApplication(
            int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {

            int rowsAffected = 0;
            try
            { 
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  LocalDrivingLicenseApplications  
                            set applicationID = @applicationID,
                                licenseClassID = @licenseClassID
                            where localDrivingLicenseApplicationID=@localDrivingLicenseApplicationID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("applicationID", applicationID);
                command.Parameters.AddWithValue("licenseClassID", licenseClassID);


                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID)
        {

            int rowsAffected = 0;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Delete LocalDrivingLicenseApplications 
                                where localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);


                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return (rowsAffected > 0);
        }

        public static bool DoesPassTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            bool Result = false;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = TestAppointments.localDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID) 
                            AND(TestAppointments.testTypeID = @testTypeID) AND (Tests.TestResult = 1)
                            ORDER BY TestAppointments.TestAppointmentID desc";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return Result;

        }

        public static bool DoesAttendTestType(int localDrivingLicenseApplicationID, int testTypeID)

        {

            bool IsFound = false;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = TestAppointments.localDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID) 
                            AND(TestAppointments.testTypeID = @testTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }   

            return IsFound;

        }

        public static byte TotalTrialsPerTest(int localDrivingLicenseApplicationID, int testTypeID)
        {
            byte TotalTrialsPerTest = 0;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"
                                    SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = TestAppointments.localDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID) 
                            AND(TestAppointments.testTypeID = @testTypeID) ";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);


                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return TotalTrialsPerTest;
        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, int testTypeID)

        {

            bool Result = false;
            try
            {
                using SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

                string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = TestAppointments.localDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID)  
                            AND(TestAppointments.testTypeID = @testTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

                using SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);


                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return Result;
        }

    }
}
