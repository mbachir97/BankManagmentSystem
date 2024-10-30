using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public  static  class clsDepositData
    {

        public static  int _AddNewDeposi(DateTime DateOfDeposit,float Amount,int ClientID,int UserID)
        {
            int DepositID = -1;

          

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Deposits (DateOfDeposit,Amount,ClientID,UserID)
                             VALUES (@DateOfDeposit, @Amount, @ClientID, @UserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@DateOfDeposit", DateOfDeposit);
            command.Parameters.AddWithValue("@Amount", Amount);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DepositID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return DepositID;

        }



        public static bool DeleteDeposit(int ClientID)
        {
            int rowsAffected = 0;
           

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Deposits 
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
         
            return (rowsAffected > 0 );
        }


        public static DataTable GetSomeInfoForDepositAcount()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select AcountNumber ,count(Deposits.ClientID) as NumberOfDeposits" +
                " from Clients\r\njoin Deposits on Clients.ClientID=Deposits.ClientID " +
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



        public static DataTable GetDepositsData()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"select FirstName,LastName, Deposits.DateOfDeposit,Deposits.Amount,Users.UserName
                   from Clients join Deposits on Deposits.ClientID=Clients.ClientID join Persones on 
                   Persones.PersonID=Clients.PersonID join Users on Users.UserID=Deposits.UserID";
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
