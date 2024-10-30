using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public  class clsUserData
    {
        public static bool GetUserByID(int UserID, ref string UserName,
               ref string PassWord, ref int Permission, ref int PersonID, ref string FirstName, ref string LastName,
                    ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
         , ref string ImagePath)
        {
            bool IsFound2 = false;
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Users where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserName = (string)reader["UserName"];
                    PassWord = (string)reader["PassWord"];
                    Permission=(int)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    
                  
                }

            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }

            IsFound2 = clsPersonData.GetPersonbyID(PersonID, ref FirstName,
                        ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
            return (IsFound==true && IsFound2==true);
        }


        public static bool GetUserByUserNameandPassWord(ref int UserID,  string UserName,
               string PassWord, ref int Permission, ref int PersonID, ref string FirstName, ref string LastName,
                   ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
        , ref string ImagePath)
        {
            bool IsFound2 = false;
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Users where UserName=@UserName and PassWord=@PassWord";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
               
                    Permission = (int)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];

                }

            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }

            IsFound2 = clsPersonData.GetPersonbyID(PersonID, ref FirstName,
                        ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
            return (IsFound == true && IsFound2 == true);
        }

        public static bool GetUserByUserName(ref int UserID, string UserName,
           ref string PassWord, ref int Permission, ref int PersonID, ref string FirstName, ref string LastName,
                ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
     , ref string ImagePath)
        {
            bool IsFound2 = false;
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Users where UserName=@UserName ";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@UserName", UserName);
          

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    Permission = (int)reader["Permission"];
                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    PassWord=(string)reader["PassWord"];

                }

            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }

            IsFound2 = clsPersonData.GetPersonbyID(PersonID, ref FirstName,
                        ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
            return (IsFound == true && IsFound2 == true);
        }

        public static int AddNewUser(string FirstName, string LastName, string Email,
          string Phone, string Address, DateTime DateOfBirth, string ImagePath,
          string UserName, string PassWord, int Permission)
        {
            int UserID = -1;

            int PersonID = clsPersonData.AddNewPersone(FirstName, LastName, Email, Phone,
                Address, DateOfBirth, ImagePath);

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Users (UserName,PassWord,Permission,PersonID)
                             VALUES (@UserName, @PassWord, @Permission, @PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
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
            finally { connection.Close(); }




            return UserID;
        }


         public static bool UpdateUser(int UserID, int PersonId, string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, string ImagePath,
            string UserName, string PassWord, int Permission)
        {
            int rowsAffected = 0;
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update  Users  
                            set UserName = @UserName, 
                                PassWord = @PassWord, 
                                Permission = @Permission
                                
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@Permission", Permission);

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
            IsUpdated = clsPersonData.UpdatePersone(PersonId, FirstName, LastName, Email, Phone, Address,
        DateOfBirth, ImagePath);
            return (rowsAffected > 0 && IsUpdated == true);
        }


        public static bool DeleteUser(int ID, int PersonID)
        {
            int rowsAffected = 0;
            bool IsDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Users 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

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
            IsDeleted = clsPersonData.DeletePerson(PersonID);
            return (rowsAffected > 0 && IsDeleted == true);


        }


        public static DataTable GetAllUserss()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select FirstName,LastName,Users.UserName,Users.PassWord,Users.Permission" +
                             " from Persones join Users on Users.PersonID=Persones.PersonID";
            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }

            catch { }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static DataTable GetDataByFirstName(string FirstName) {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select FirstName,LastName,Users.UserName,Users.PassWord,Users.Permission" +
                             " from Persones join Users on Users.PersonID=Persones.PersonID  where FirstName " +
                             "like @FirstName";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }

            catch { }
            finally
            {
                connection.Close();
            }

            return dt;


        }




        public static DataTable GetDataByUserName(string UserName)
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select FirstName,LastName,Users.UserName,Users.PassWord,Users.Permission" +
                             " from Persones join Users on Users.PersonID=Persones.PersonID  where UserName " +
                             "like @UserName";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }

            catch { }
            finally
            {
                connection.Close();
            }

            return dt;


        }
        public static bool IsUsertExist(string UserName,string PassWord)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select found=1 from     Users where UserName=@UserName and PassWord=@PassWord";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@PassWord", PassWord);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }


        public static bool IsUsertExist(string UserName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select found=1 from     Users where UserName=@UserName ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
         
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isFound = reader.HasRows;

                reader.Close();
            }
            catch
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }


        public static int GetNumberOfUsers()
        {

            int Total = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select Count(*) from Users";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int TotalUsers))
                {
                    Total = TotalUsers;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return Total;


        }


    }
}
