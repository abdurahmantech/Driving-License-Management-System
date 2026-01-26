using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    static public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName)
        {
            bool isFound = false;

            using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    CountryName = (string)reader["CountryName"];

                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return isFound;
        }

        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["CountryID"];

                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            return isFound;
        }

        public static DataTable GetAllCountries()
        {

            DataTable dt = null;
            using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM Countries Order by CountryName";

            using SqlCommand command = new(query, conn);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt = new DataTable();
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
