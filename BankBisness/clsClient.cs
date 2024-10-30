using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BankDataAccess;

namespace BankBisness
{
    public class clsClient : clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 };
         enMode _Mode = enMode.AddNew;

        public int ClientID { get; set; }   

        public string AcountNumber {get; set; }

        public string PinCode {get; set; }

        public float AcountBalance {get; set; }




        public clsClient() : base() { 
        this.ClientID = -1;
            this.AcountNumber = "";
            this.PinCode = "";
            this.AcountBalance = -1;
            _Mode = enMode.AddNew;
        
        }

        private clsClient(int ClientID, string FirstName, string LastName,
           string Email, string Phone, string Address, 
           DateTime DateOfBirth,  string ImagePath,
           int PersonID,string AcountNumber,string PinCode,float AcountBalance): base( PersonID,  FirstName, LastName,
           Email, Phone, Address,
            DateOfBirth,  ImagePath)
        {
            this.ClientID = ClientID;
            this.AcountNumber = AcountNumber;   
            this.PinCode = PinCode; 
            this.AcountBalance = AcountBalance;
            _Mode = enMode.Update;


        }

       public  static clsClient Find(string AcountNumber)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            string PinCode = "";
            float AcountBalance = -1;
            int ClientID = -1, PersonID = -1;
            if (clsClientData.GetClientByAcountNumber(ref ClientID, AcountNumber, ref PinCode,
                      ref AcountBalance, ref PersonID, ref FirstName, ref LastName,
                      ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath))
            {

                return new clsClient(ClientID, FirstName, LastName,
            Email, Phone, Address,
            DateOfBirth, ImagePath,
            PersonID, AcountNumber, PinCode, AcountBalance);
            }
            else { return null; }

        }



        bool _AddNewClient()
        {
            this.ClientID=clsClientData.AddNewClient(this.FirstName,this.LastName,this.Email,this.Phone,
                this.Address,this.DateOfBirth, this.ImagePath,this.AcountNumber,this.PinCode,this.AcountBalance);
                return (this.ClientID != -1);
        }

        bool _UpdateClient()
        {  
            return clsClientData.UpdateClient(this.ClientID, this.PersonID, this.FirstName,
                this.LastName, this.Email, this.Phone,
                this.Address, this.DateOfBirth, this.ImagePath, 
                this.AcountNumber, this.PinCode, this.AcountBalance);
        }

        public bool Deposit(float Amount)
        {

            this.AcountBalance += Amount;

           
            

           
           return  Save();
            
        }

        public bool WithDraw(float Amount)
        {
            if(this.AcountBalance<Amount)
                return false;
            else
            {
                this.AcountBalance -= Amount;
                return Save();
            }

        }

        public bool Transfer(float Amount,clsClient ClientDestination) {
            if (Amount > this.AcountBalance)
            {
                return false;
            }
            this.WithDraw(Amount);

             return ClientDestination.Deposit(Amount);
        }
       public  bool Save()
        {

            switch (_Mode)
            {
                   case enMode.AddNew:

                    if (_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false; 
                    case enMode.Update:
                    return _UpdateClient(); 
                    default: return false;  

            }
          

        }

        public static bool DeleteClient(int ClientID,int PersonID)
        {
            return clsClientData.DeleteClient(ClientID, PersonID);
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }

        public static DataTable GetClientByFirstName(string FirstName)
        {
          return   clsClientData.GetDataByFirstName(FirstName);
        }

        public static int GetNumberOfClient() {

            return clsClientData.GetNumberOfClient();        
        }
        public static DataTable GetClientByAcount(string Acount)
        {
            return clsClientData.GetDataByAcount(Acount);
        }
        public static bool IsClientExist(string AcountNumber)
        {
            return clsClientData.IsClientExist(AcountNumber);
        }
    }
}
