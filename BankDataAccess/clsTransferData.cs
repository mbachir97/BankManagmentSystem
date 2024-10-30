using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccess
{
    public static  class clsTransferData
    {

        public static int _AddNewTransfer(DateTime DateOfTransfer, 
            float Amount, int SendreClientID, int RecieveClientID,
            float NewSenderBalance,float NewRecieveBalance,int UserID)
        {
            int TransferID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Transfers (TransferDate,SenderClientID,
            RecieveClientID,Amount,NewSenderBalance,UserID,NewRecieveBalance)
                             VALUES (@TransferDate,@SendreClientID,@RecieveClientID
                                   , @Amount, @NewSenderBalance, @UserID,@NewRecieveBalance);
                             SELECT SCOPE_IDENTITY();";

            //string query = @"INSERT INTO Deposits (DateOfDeposit,Amount,ClientID,UserID)
            //                 VALUES (@DateOfDeposit, @Amount, @ClientID, @UserID);
            //                 SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SendreClientID", SendreClientID);
            command.Parameters.AddWithValue("@RecieveClientID", RecieveClientID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@TransferDate", DateOfTransfer);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@NewSenderBalance", NewSenderBalance);
            command.Parameters.AddWithValue("@NewRecieveBalance", NewRecieveBalance);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransferID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return TransferID;

        }


        public static bool DeleteTransfer(int ClientID)
        {
            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"delete Transfers where SenderClientID=@SendreClientID
                                or RecieveClientID=@RecieveClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@SendreClientID", ClientID);
            command.Parameters.AddWithValue("@RecieveClientID", ClientID);

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

        public static DataTable GetAllTransfers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select SenderAcount ,RecieveAcount ," +
                       "NewSenderBalance,NewRecieveBalance,Amount,UserName,UserFirstName from TransferDetail";
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
