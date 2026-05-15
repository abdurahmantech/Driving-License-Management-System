using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static Azure.Core.HttpHeader;

namespace DataAccessLayer
{
    public static class clsTestData
    {

        public static bool GetTestInfoByID(int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM Tests WHERE TestID = @TestID";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@TestID", testID);


                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    testAppointmentID = (int)reader["TestAppointmentID"];
                    testResult = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)

                        notes = "";
                    else
                        notes = (string)reader["Notes"];

                    createdByUserID = (int)reader["CreatedByUserID"];

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


        public static bool GetLastTestByPersonAndTestTypeAndLicenseClassID(int testTypeID, int personID, int licenseClassID, ref int testID, ref int testAppointmentID,
            ref bool testResult, ref string notes, ref int createdByUserID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT  top 1 Tests.TestID, 
                Tests.TestAppointmentID, Tests.TestResult, 
			    Tests.Notes, Tests.CreatedByUserID, Applications.ApplicantPersonID
                FROM            LocalDrivingLicenseApplications INNER JOIN
                                         Tests INNER JOIN
                                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID ON
                        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                WHERE        (Applications.ApplicantPersonID = @PersonID) 
                        AND (LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID)
                        AND ( TestAppointments.TestTypeID=@TestTypeID)
                ORDER BY Tests.TestAppointmentID DESC";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@PersonID", personID);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);


                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    testID = (int)reader["TestID"];
                    testAppointmentID = (int)reader["TestAppointmentID"];
                    testResult = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)

                        notes = "";
                    else
                        notes = (string)reader["Notes"];

                    createdByUserID = (int)reader["CreatedByUserID"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static DataTable GetAllTests()
        {

            DataTable dt = new DataTable();

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM Tests order by TestID";

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



        public static int AddNewTest(int TestAppointmentID, bool TestResult,
             string Notes, int CreatedByUserID)
        {
            int TestID = -1;


            try
            {
                using SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

                string query = @"Insert Into Tests (TestAppointmentID,TestResult,
                                                Notes,   CreatedByUserID)
                            Values (@TestAppointmentID,@TestResult,
                                                @Notes,   @CreatedByUserID);
                            
                                UPDATE TestAppointments 
                                SET IsLocked=1 where TestAppointmentID = @TestAppointmentID;

                                SELECT SCOPE_IDENTITY();";

                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestResult", TestResult);

                if (Notes != "" && Notes != null)
                    cmd.Parameters.AddWithValue("@Notes", Notes);
                else
                    cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);



                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }


            return TestID;

        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult,
             string Notes, int CreatedByUserID)
        {

            int rowsAffected = 0;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  Tests  
                            set TestAppointmentID = @TestAppointmentID,
                                TestResult=@TestResult,
                                Notes = @Notes,
                                CreatedByUserID=@CreatedByUserID
                                where TestID = @TestID";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@TestID", TestID);
                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                cmd.Parameters.AddWithValue("@TestResult", TestResult);
                cmd.Parameters.AddWithValue("@Notes", Notes);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            return (rowsAffected > 0);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            byte PassedTestCount = 0;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT PassedTestCount = count(TestTypeID)
                         FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						 where LocalDrivingLicenseApplicationID =@LocalDrivingLicenseApplicationID and TestResult=1";

                using SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    PassedTestCount = ptCount;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return PassedTestCount;
        }

    }



}
