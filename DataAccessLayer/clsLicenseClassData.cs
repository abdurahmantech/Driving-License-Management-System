using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer
{
    public static class clsLicenseClassData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"SELECT LicenseClasses.*
                                        FROM   LicenseClasses;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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

        public static bool GetLicenseClassInfoByID(int licenseClassID, ref string className, ref string classDescription, ref byte minimumAllowedAge,
           ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;

        
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM LicenseClasses WHERE licenseClassID = @licenseClassID";

                using SqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            try
            {
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    className = (string)reader["className"];
                    classDescription = (string)reader["classDescription"];
                    minimumAllowedAge = (byte)reader["minimumAllowedAge"];
                    defaultValidityLength = (byte)reader["defaultValidityLength"];
                    classFees = Convert.ToDecimal(reader["classFees"]);

                }
            }
            catch
            {
                throw;
            }
            return isFound;
        }

        public static bool GetLicenseClassInfoByClassName(string className, ref int licenseClassID, ref string classDescription, ref byte minimumAllowedAge,
   ref byte defaultValidityLength, ref decimal classFees)
        {
            bool isFound = false;


            using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE className = @className";

            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@className", className);
            try
            {
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    licenseClassID = (int)reader["licenseClassID"];
                    classDescription = (string)reader["classDescription"];
                    minimumAllowedAge = (byte)reader["minimumAllowedAge"];
                    defaultValidityLength = (byte)reader["defaultValidityLength"];
                    classFees = Convert.ToDecimal(reader["classFees"]);

                }
            }
            catch
            {
                throw;
            }
            return isFound;
        }

        public static int AddNewLicenseClass(string className, string classDescription,
         byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {
            int licenseClassID = -1;

            using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into LicenseClasses 
           (
            ClassName,ClassDescription,MinimumAllowedAge, 
            DefaultValidityLength,ClassFees)
                            Values ( 
            @ClassName,@ClassDescription,@MinimumAllowedAge, 
            @DefaultValidityLength,@ClassFees)
                            where LicenseClassID = @LicenseClassID;
                            SELECT SCOPE_IDENTITY();";



            using SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@ClassName", className);
            cmd.Parameters.AddWithValue("@ClassDescription", classDescription);
            cmd.Parameters.AddWithValue("@MinimumAllowedAge", minimumAllowedAge);
            cmd.Parameters.AddWithValue("@DefaultValidityLength", defaultValidityLength);
            cmd.Parameters.AddWithValue("@ClassFees", classFees);



            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    licenseClassID = insertedID;
                }
            }

            catch
            {
                throw;
            }
            return licenseClassID;

        }

        public static bool UpdateLicenseClass(int licenseClassID, string className, string classDescription,
         byte minimumAllowedAge, byte defaultValidityLength, decimal classFees)
        {

            int rowsAffected = 0;
            using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

            string query = @"Update  LicenseClasses  
                            set className = @className,
                                classDescription = @classDescription,
                                minimumAllowedAge = @minimumAllowedAge,
                                defaultValidityLength = @defaultValidityLength,
                                classFees = @classFees
                                where licenseClassID = @licenseClassID";

            using SqlCommand cmd = new(query, connection);

            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            cmd.Parameters.AddWithValue("@ClassName", className);
            cmd.Parameters.AddWithValue("@ClassDescription", classDescription);
            cmd.Parameters.AddWithValue("@MinimumAllowedAge", minimumAllowedAge);
            cmd.Parameters.AddWithValue("@DefaultValidityLength", defaultValidityLength);
            cmd.Parameters.AddWithValue("@ClassFees", classFees);

            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;
            }

            return (rowsAffected > 0);
        }


        public static bool DeleteLicenseClass(int licenseClassID)
        {
        
                using SqlConnection conn = new(DataAccessLayer.clsDataAccessSetting.ConnectionString);

                string query = @"DELETE FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            try
            {
                conn.Open();

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }

        }
    }
}
