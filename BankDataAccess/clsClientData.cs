using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Security.Policy;

namespace BankDataAccess
{
    public class clsClientData
    {
        
        public static bool GetClientByID(int ClientID,ref string AcountNumber,
                  ref string PinCode,float AcountBalance,ref int PersonID , ref string FirstName, ref string LastName,
                       ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
            , ref string ImagePath)
        {
            bool IsFound2=false;    
            bool IsFound = false;
            SqlConnection Connection =new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "Select * from Clients where ClientID=@ClientID";
            SqlCommand command = new SqlCommand(query,Connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    AcountNumber = (string)reader["AcountNumber"];
                    PinCode = (string)reader["PinCode"];
                    AcountBalance = (float)reader["AcountBalance"];
                    PersonID = (int)reader["PersonID"];
                    IsFound2 = clsPersonData.GetPersonbyID(PersonID, ref FirstName,
                        ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }
            return (IsFound && IsFound2);
        }


        public static bool GetClientByAcountNumber( ref int ClientID, string AcountNumber,
                  ref string PinCode, ref float AcountBalance, ref int PersonID, ref string FirstName, ref string LastName,
                       ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth
            , ref string ImagePath)
        {
            bool IsFound2=false;    
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select* from Clients where AcountNumber=@AcountNumber";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@AcountNumber", AcountNumber);

            try
            {
                Connection.Open();
               
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ClientID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    AcountBalance =  Convert.ToSingle(  reader["AcountBalance"]);
                    PersonID = (int)reader["PersonID"];




                }
          
            }
            catch (Exception ex)
            {

            }
            finally { Connection.Close(); }
            IsFound2 = clsPersonData.GetPersonbyID(PersonID, ref FirstName,
            ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath);
            return (IsFound==true &&IsFound2 ==true);
        }

        public static int AddNewClient(string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, string ImagePath,
            string AcountNumber,string PinCode,float AcountBalance)
        {
            int ClientID = -1;

            int PersonID = clsPersonData.AddNewPersone(FirstName, LastName, Email, Phone,
                Address, DateOfBirth, ImagePath);

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"INSERT INTO Clients (AcountNumber,PinCode,AcountBalance,PersonID)
                             VALUES (@AcountNumber, @PinCode, @AcountBalance, @PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AcountNumber", AcountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AcountBalance", AcountBalance);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                   ClientID = insertedID;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return ClientID;
        }


        public static bool UpdateClient(int ClientID,int PersonId, string FirstName, string LastName, string Email,
            string Phone, string Address, DateTime DateOfBirth, string ImagePath,
            string AcountNumber, string PinCode, float AcountBalance)
        {
            int rowsAffected = 0;
            bool IsUpdated=false;   
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update  Clients  
                            set AcountNumber = @AcountNumber, 
                                PinCode = @PinCode, 
                                AcountBalance = @AcountBalance
                                
                                where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@AcountNumber", AcountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AcountBalance", AcountBalance);

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
            return (rowsAffected > 0 && IsUpdated==true);
        }


        public static bool DeleteClient(int ClientID,int PersonID)
        {
            int rowsAffected = 0;
            bool IsDeleted=false;   

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete Clients 
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
            IsDeleted = clsPersonData.DeletePerson(PersonID);
            return (rowsAffected > 0 && IsDeleted==true);


        }

        static int NumberOfClients = 0;
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
        
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select  FirstName,LastName,Email,ImagePath,Clients.AcountNumber,Clients.PinCode,Clients.AcountBalance " +
                             "from Persones join Clients on Clients.PersonID=Persones.PersonID";
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

        public static DataTable GetDataByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select  FirstName,LastName,Email,ImagePath,Clients.AcountNumber,Clients.PinCode,Clients.AcountBalance " +
                             "from Persones join Clients on Clients.PersonID=Persones.PersonID Where FirstName like @FirstName";
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

        public static DataTable GetDataByAcount(string Acount)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select  FirstName,LastName,Email,ImagePath,Clients.AcountNumber,Clients.PinCode,Clients.AcountBalance " +
                             "from Persones join Clients on Clients.PersonID=Persones.PersonID Where AcountNumber like @AcountNumber";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@AcountNumber", Acount);
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

        public static int GetNumberOfClient() {

            int Total = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select Count(*) from Clients";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int TotalClients))
                {
                    Total = TotalClients;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally { connection.Close(); }




            return Total;


        }

        public static bool IsClientExist(string AcountNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select found=1 from Clients where AcountNumber=@AcountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AcountNumber", AcountNumber);
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

    }
}
