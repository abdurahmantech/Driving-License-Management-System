using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsTestAppointmentData
    {
        public static bool GetTestAppointmentWithTestAppointmentID(int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID,
            ref DateTime appointmentDate, ref float paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string q = "select * From TestAppointments where testAppointmentID = @ID;";

                    using (SqlCommand cmd = new SqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", testAppointmentID);
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                testAppointmentID = (int)reader["testAppointmentID"];
                                localDrivingLicenseApplicationID = (int)reader["localDrivingLicenseApplicationID"];
                                testTypeID = (int)reader["testTypeID"];
                                appointmentDate = (DateTime)reader["appointmentDate"];
                                paidFees = Convert.ToSingle(reader["paidFees"]);
                                createdByUserID = (int)reader["createdByUserID"];
                                isLocked = (bool)reader["isLocked"];

                                retakeTestApplicationID = reader["retakeTestApplicationID"] == DBNull.Value ? -1 : Convert.ToInt32(reader["retakeTestApplicationID"]);

                            }
                        }
                    }
                }
            }
            catch
            {
                isFound = false;
            }
            return isFound;
        }

        public static int AddNewAppointment(int testTypeID, int localDrivingLicenseApplicationID,
             DateTime appointmentDate, float paidFees, int createdByUserID, int retakeTestApplicationID)
        {
            int testAppointmentID = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {

                    string query = $@"INSERT INTO [TestAppointments]
                                                 ([testTypeID]
                                                 ,[localDrivingLicenseApplicationID]
                                                 ,[appointmentDate]
                                                 ,[paidFees]
                                                 ,[createdByUserID]
                                                 ,[isLocked]
                                                 ,[retakeTestApplicationID])
                                           VALUES (
                                                   @testTypeID,
                                                   @LDLAppID,
                                                   @Date,
                                                   @paidFees,
                                                   @createdByUserID,
                                                   0,
                                                   @retakeTestApplicationID);
                                                   SELECT SCOPE_IDENTITY();   ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
                        cmd.Parameters.AddWithValue("@LDLAppID", localDrivingLicenseApplicationID);
                        cmd.Parameters.AddWithValue("@Date", appointmentDate);
                        cmd.Parameters.AddWithValue("@paidFees", paidFees);
                        cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
                        cmd.Parameters.AddWithValue("@retakeTestApplicationID", retakeTestApplicationID == -1 ? (object)DBNull.Value : retakeTestApplicationID);

                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                            testAppointmentID = insertedID;
                        

                    }
                }
            }
            catch
            {
                throw;
            }

            return testAppointmentID;

        }

        public static bool UpdateTestAppointment(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID,
             DateTime appointmentDate, float paidFees,
             int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {

            int rowsAffected = 0;
            try
            {
                SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  TestAppointments  
                            set testTypeID = @testTypeID,
                                localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID,
                                appointmentDate = @appointmentDate,
                                paidFees = @paidFees,
                                createdByUserID = @createdByUserID,
                                isLocked=@isLocked,
                                retakeTestApplicationID=@retakeTestApplicationID
                                where testAppointmentID = @testAppointmentID";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
                command.Parameters.AddWithValue("@testTypeID", testTypeID);
                command.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                command.Parameters.AddWithValue("@paidFees", paidFees);
                command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
                command.Parameters.AddWithValue("@isLocked", isLocked);
                command.Parameters.AddWithValue("@retakeTestApplicationID", retakeTestApplicationID == -1 ? DBNull.Value : retakeTestApplicationID);



                conn.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return (rowsAffected > 0);
        }

        static public DataTable GetApplicationTestAppointmentsPerTestType(int localDrivingLicenseApplicationID, int testTypeID)
        {
            DataTable dt = new();

            try
            {
                using (SqlConnection conn = new(clsDataAccessSetting.ConnectionString))
                {

                    string query = @"SELECT testAppointmentID, appointmentDate,paidFees, isLocked
                        FROM TestAppointments
                        WHERE  
                        (testTypeID = @testTypeID) 
                        AND (localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID)
                        order by testAppointmentID desc;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                        cmd.Parameters.AddWithValue("@testTypeID", testTypeID);

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                   dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }


            return dt;
        }

        public static int GetTestID(int testAppointmentID)
        {
            int testID = -1;

            try
            {
               using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"select TestID from Tests where testAppointmentID = @testAppointmentID;";

                using SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);


                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    testID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return testID;

        }

        public static bool GetLastTestAppointment           (  int localDrivingLicenseApplicationID, int testTypeID,
             ref int testAppointmentID, ref DateTime appointmentDate,
             ref float paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT       top 1 *
                FROM            TestAppointments
                WHERE        (testTypeID = @testTypeID) 
                AND (localDrivingLicenseApplicationID = @localDrivingLicenseApplicationID) 
                order by testAppointmentID Desc";


                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                cmd.Parameters.AddWithValue("@testTypeID", testTypeID);


                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    testAppointmentID = (int)reader["testAppointmentID"];
                    appointmentDate = (DateTime)reader["appointmentDate"];
                    paidFees = Convert.ToSingle(reader["paidFees"]);
                    createdByUserID = (int)reader["createdByUserID"];
                    isLocked = (bool)reader["isLocked"];

                    retakeTestApplicationID = reader["retakeTestApplicationID"] == DBNull.Value ? -1 : (int)reader["retakeTestApplicationID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllTestAppointments()
        {

            DataTable dt = new DataTable();

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"select * from TestAppointments_View
                                  order by appointmentDate Desc";


                using SqlCommand cmd = new SqlCommand(query, conn);


                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

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

    }

}
