using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public static  class clsWithdrawData
    {

        public static int _AddNewWithDraw(DateTime DateOfWithDraw, float Amount, int ClientID, int UserID)
        {
            int WithDrawID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Withdraws (DateOfWithDraw,Amount,ClientID,UserID)
                             VALUES (@DateOfWithDraw, @Amount, @ClientID, @UserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@DateOfWithDraw", DateOfWithDraw);
            command.Parameters.AddWithValue("@Amount", Amount);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    WithDrawID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return WithDrawID;

        }



        public static bool DeleteWithdraw(int ClientID)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Withdraws 
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

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


        public static DataTable GetSomeInfoForWithdrawAcount()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select AcountNumber ,count(Withdraws.ClientID) as NumberOfWithdraws" +
                " from Clients join Withdraws on Clients.ClientID=Withdraws.ClientID " +
                "group by AcountNumber";
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


        public static DataTable GetWithDrawsData()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"select FirstName,LastName, Withdraws.DateOfWithDraw,Withdraws.Amount,Users.UserName
                   from Clients join Withdraws on Withdraws.ClientID=Clients.ClientID join Persones on 
                   Persones.PersonID=Clients.PersonID join Users on Users.UserID=Withdraws.UserID";
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
