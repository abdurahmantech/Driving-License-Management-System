using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessLayer
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
  ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);
                {

                    string query = "SELECT * FROM Users WHERE UserID = @UserID";

                    using SqlCommand command = new(query, connection);
                    command.Parameters.AddWithValue("@UserID", UserID);


                    connection.Open();
                    using SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // The record was found
                        isFound = true;

                        PersonID = (int)reader["PersonID"];
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];


                    }


                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }


            return isFound;
        }



        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
          ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

                isFound = false;
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string UserName, string Password,
            ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool isFound = false;

            try
            {

                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@Username", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


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
        
        public static int AddNewUser(int PersonID, string UserName,
             string Password, bool IsActive)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
                             VALUES (@PersonID, @UserName,@Password,@IsActive);
                             SELECT SCOPE_IDENTITY();";

            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return UserID;
        }


        public static bool UpdateUser(int UserID, int PersonID, string UserName,
             string Password, bool IsActive)
        {

            int rowsAffected = 0;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  Users  
                            set PersonID = @PersonID,
                                UserName = @UserName,
                                Password = @Password,
                                IsActive = @IsActive
                                where UserID = @UserID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@UserID", UserID);



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


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"SELECT  Users.UserID, Users.PersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,
                             Users.UserName, Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.PersonID";

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

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Delete Users 
                                where UserID = @UserID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);


                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }

            return (rowsAffected > 0);

        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);


                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static bool IsUserExist(string UserName)
        {
            bool isFound = false;
            try
            {
                using SqlConnection connection = new (clsDataAccessSetting.ConnectionString);

                string query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

                using SqlCommand command = new (query, connection);

                command.Parameters.AddWithValue("@UserName", UserName);


                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }


            return isFound;
        }

        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);


                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static bool DoesPersonHaveUser(int PersonID)
        {
            bool isFound = false;


            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@PersonID", PersonID);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }

            return isFound;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            try
            {
                using SqlConnection connection = new(clsDataAccessSetting.ConnectionString);

                string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

                using SqlCommand command = new(query, connection);

                command.Parameters.AddWithValue("@UserID", UserID);


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
