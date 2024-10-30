using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public class clsPersonData
    {


        public static bool GetPersonbyID(int ID, ref string  FirstName, ref string LastName,
                       ref string   Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
            ,  ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select * from Persones where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string )reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address= (string)reader["Address"];
                    DateOfBirth =(DateTime)reader["DateOfBirth"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                        ImagePath = "";



                }

            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }
            return IsFound;
        }
        public static int AddNewPersone(string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, string ImagePath)
        {

            int PersoneID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Persones (FirstName, LastName, Email, Phone, Address,DateOfBirth,ImagePath)
                             VALUES (@FirstName, @LastName, @Email, @Phone, @Address,@DateOfBirth,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersoneID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }

            return PersoneID;



        }


        public static bool UpdatePersone(int ID, string FirstName, string LastName,
           string Email, string Phone, string Address, DateTime DateOfBirth,  string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update  Persones  
                            set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email, 
                                Phone = @Phone, 
                                Address = @Address, 
                                DateOfBirth = @DateOfBirth,
                                
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
       

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeletePerson(int PersoneID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Persones 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersoneID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
    }

}
