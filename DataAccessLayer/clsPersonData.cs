using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace DataAccessLayer
{
    public class clsPersonData
    {

        static public bool GetPersonInfoByID(int personID, ref string firstName, ref string secondName,
      ref string thirdName, ref string lastName, ref string nationalNo, ref DateTime dateOfBirth,
       ref short gender, ref string address, ref string phone, ref string email,
       ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;

            try
            {
                using SqlConnection conn = new(clsDataAccessSetting.ConnectionString);
                string query = @"
                                Select * From People Where PersonID = @PersonID;";

                using SqlCommand cmd = new(query, conn);
                
                    cmd.Parameters.AddWithValue("@PersonID", personID);
                    conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        thirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        thirdName = "";
                    }

                    lastName = (string)reader["LastName"];
                    nationalNo = (string)reader["NationalNo"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (short)(byte)reader["Gender"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        email = (string)reader["Email"];
                    }
                    else
                    {
                        email = "";
                    }

                    nationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        imagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        imagePath = "";
                    }
                }

            }
            catch
            {
                throw;
            }
            return isFound;
        }


        public static bool GetPersonInfoByNationalNo(ref int personID, ref string firstName, ref string secondName,
      ref string thirdName, ref string lastName, string nationalNo, ref DateTime dateOfBirth,
       ref short gender, ref string address, ref string phone, ref string email,
       ref int nationalityCountryID, ref string imagePath)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = "SELECT * FROM People WHERE NationalNo = @NationalNo;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // The parameter name matches the SQL query exactly.
                        command.Parameters.AddWithValue("@NationalNo", nationalNo);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                firstName = (string)reader["FirstName"];
                                secondName = (string)reader["SecondName"];

                                //ThirdName: allows null in database so we should handle null
                                if (reader["ThirdName"] != DBNull.Value)
                                {
                                    thirdName = (string)reader["ThirdName"];
                                }
                                else
                                {
                                    thirdName = "";
                                }

                                lastName = (string)reader["LastName"];
                                personID = (int)reader["PersonID"];
                                dateOfBirth = (DateTime)reader["DateOfBirth"];
                                gender = (byte)reader["Gender"];
                                address = (string)reader["Address"];
                                phone = (string)reader["Phone"];


                                //Email: allows null in database so we should handle null
                                if (reader["Email"] != DBNull.Value)
                                {
                                    email = (string)reader["Email"];
                                }
                                else
                                {
                                    email = "";
                                }

                                nationalityCountryID = (int)reader["NationalityCountryID"];

                                //ImagePath: allows null in database so we should handle null
                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    imagePath = (string)reader["ImagePath"];
                                }
                                else
                                {
                                    imagePath = "";
                                }

                            }

                        }
                    }
                }
            }
            catch
            {
                throw;
            }

            return isFound;
        }


        public static int AddNewPerson(string firstName, string secondName,
      string thirdName, string lastName, string nationalNo,  DateTime dateOfBirth,
        short gender, string address, string phone, string email,
       int nationalityCountryID, string imagePath)
        {
            int newPersonID = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,
                            Gender,Address,Phone,Email,NationalityCountryID,ImagePath)
                            VALUES 
                            (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
                            @DateOfBirth, @Gender, @Address, @Phone, @Email,
                            @NationalityCountryID, @ImagePath);
                            SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@SecondName", secondName);

                        if (thirdName != "" && thirdName != null)
                            cmd.Parameters.AddWithValue("@ThirdName", thirdName);
                        else
                            cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        if (email != "" && email != null)
                            cmd.Parameters.AddWithValue("@Email", email);
                        else
                            cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

                        cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

                        if (imagePath != "" && imagePath != null)
                             cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                        else
                            cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            newPersonID = insertedId;
                        }
                    }
                }
            }
            catch
            {

                throw;
            }

            return newPersonID;
        }


        static public bool DeletePerson(int personID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = "delete People where PersonID = @PersonID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personID);
                        conn.Open();

                        return cmd.ExecuteNonQuery() > 0;


                    }
                }
            }
            catch(Exception ex)
            {
                return false;
            }


        }


        static public DataTable GetAllPeople()
        {
            DataTable dt = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"SELECT People.PersonID, People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' +
                                            CASE 
                                                WHEN ISNULL(People.ThirdName, '') = '' 
                                                    THEN people.LastName 
                                                ELSE People.ThirdName + ' ' + people.LastName 
                                            END AS [Full Name], FORMAT(People.DateOfBirth, 'dd/MM/yyyy') as [Date Of Birth], People.Gender as GenderNum, 
                                     CASE People.Gender 
                                     WHEN 0 THEN 'Male'
                                     WHEN 1 THEN 'Female'
                                     END AS Gender,
                                     People.Address, People.Phone, People.Email, People.NationalityCountryID,
                                     Countries.CountryName as Country, People.ImagePath
                                     FROM   People INNER JOIN
                                     Countries ON People.NationalityCountryID = Countries.CountryID;";


                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt = new DataTable();
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

        static public bool UpdatePerson(int personID, string firstName, string secondName,
      string thirdName, string lastName, string nationalNo, DateTime dateOfBirth,
        short gender, string address, string phone, string email,
       int nationalityCountryID, string imagePath)
        {
            bool isUpdated = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"
                        UPDATE People
                        SET 
                            [NationalNo] = @NationalNo,
                            [FirstName] = @FirstName,
                            [SecondName] = @SecondName,
                            [ThirdName] = @ThirdName,
                            [LastName] = @LastName,
                            [DateOfBirth] = @DateOfBirth,
                            [Gender] = @Gender,
                            [Address] = @Address,
                            [Phone] = @Phone,
                            [Email] = @Email,
                            [NationalityCountryID] = @NationalityCountryID,
                            [ImagePath] = @ImagePath
                        WHERE 
                            PersonID = @PersonID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personID);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@SecondName", secondName);

                        if (thirdName != "" && thirdName != null)
                            cmd.Parameters.AddWithValue("@ThirdName", thirdName);
                        else
                            cmd.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Phone", phone);

                        if (email != "" && email != null)
                            cmd.Parameters.AddWithValue("@Email", email);
                        else
                            cmd.Parameters.AddWithValue("@Email", System.DBNull.Value);

                        cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

                        if (imagePath != "" && imagePath != null)
                            cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                        else
                            cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                        conn.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                }
            }
            catch
            {
                throw;
            }

            return isUpdated;
        }

        static public bool IsPersonExist(int personID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"
                             Select Found = 1 From People Where PersonID = @PersonID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", personID);
                        conn.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            isFound = true; // found
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return isFound;
        }

        static public bool IsPersonExist(string nationalNo)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString))
                {
                    string query = @"
                             Select Found = 1 From People Where NationalNo = @NationalNo;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NationalNo", nationalNo);
                        conn.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            isFound = true; // found
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return isFound;
        }

    }

}

    
