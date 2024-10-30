using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public  class clsLoginRegisterData
    {


        public static int AddNewDLog(DateTime DateOflOG, int UserID)
        {
            int LogID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO LoginRegister (LoginDate,UserID)
                             VALUES (@DateOflOG, @UserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
         
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@DateOflOG", DateOflOG);
           


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LogID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return LogID;

        }



        public static bool DeleteLogin(int UserID)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete LoginRegister 
                                where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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


        public static DataTable GetAllLogin()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"select Users.UserID, FirstName ,Users.UserName,Users.PassWord,Users.Permission,LoginRegister.LoginDate from Users
              join LoginRegister on Users.UserID=LoginRegister.UserID join Persones on Users.PersonID=Persones.PersonID";
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


    }
}
