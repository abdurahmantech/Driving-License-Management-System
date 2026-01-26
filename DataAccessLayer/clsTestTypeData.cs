using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsTestTypeData
    {
        static public bool GetTestTypeInfoByID(int TestTypeID,
            ref string TestTypeTitle, ref string TestDescription, ref decimal TestFees)
        {
            bool isFound = false;
            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT TestTypes.*
                        FROM   TestTypes WHERE TestTypeID = @ID;";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@ID", TestTypeID);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;

                        TestFees = (decimal)reader["TestTypeFees"];
                        TestTypeTitle = (string)reader["TestTypeTitle"];
                        TestDescription = (string)reader["TestTypeDescription"];

                    }

                }


            }
            catch
            {
                throw;
            }
            return isFound;
        }

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, decimal Fees)
        {

            int rowsAffected = 0;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeDescription=@TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                command.Parameters.AddWithValue("@TestTypeTitle", Title);
                command.Parameters.AddWithValue("@TestTypeDescription", Description);
                command.Parameters.AddWithValue("@TestTypeFees", Fees);


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

        public static DataTable GetAllTestTypes()
        {

            DataTable dt = new DataTable();
            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM TestTypes order by TestTypeID";

                using SqlCommand command = new(query, conn);

                conn.Open();

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

        public static int AddNewTestType(string Title, string Description, decimal Fees)
        {
            int TestTypeID = -1;
            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = @"Insert Into TestTypes (TestTypeTitle,TestTypeTitle,TestTypeFees)
                            Values (@TestTypeTitle,@TestTypeDescription,@ApplicationFees)
                            where TestTypeID = @TestTypeID;
                            SELECT SCOPE_IDENTITY();";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@TestTypeTitle", Title);
                cmd.Parameters.AddWithValue("@TestTypeDescription", Description);
                cmd.Parameters.AddWithValue("@ApplicationFees", Fees);


                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestTypeID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            return TestTypeID;

        }

    }
}
