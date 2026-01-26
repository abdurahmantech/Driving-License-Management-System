using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public static class clsApplicationTypeData
    {
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID,
          ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToDecimal(reader["ApplicationFees"]);

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


        public static DataTable GetAllApplicationTypes()
        {

            DataTable dt = new DataTable();

            using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes";

            using SqlCommand command = new(query, connection);

            try
            {
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


        public static int AddNewApplicationType(string Title, decimal Fees)
        {
            int ApplicationTypeID = -1;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@Title,@Fees)
                            
                            SELECT SCOPE_IDENTITY();";

            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

         
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return ApplicationTypeID;

        }


        public static bool UpdateApplicationType(int ApplicationTypeID, string Title, decimal  Fees)
        {

            int rowsAffected = 0;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @Title,
                                ApplicationFees = @Fees
                                where ApplicationTypeID = @ApplicationTypeID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Fees", Fees);

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


    }
}
