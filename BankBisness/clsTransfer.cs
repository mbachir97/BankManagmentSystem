using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccess;

namespace BankBisness
{
    public  class clsTransfer
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public int TransferID { get; set; }
        public int SenderClientID { get; set; }

        public int RecieveClientID { get; set; }
        public int UserID { get; set; }

        public float NewSenderBalance { get; set; }
        public float Amount { get; set; }

        public float NewRecieveBalance { get; set; }
        public DateTime DateOfTransfer { get; set; }

        public clsTransfer() { 
        this.Amount = -1;
            this.DateOfTransfer = DateTime.Now; 
            this.NewSenderBalance = -1;
            this.NewRecieveBalance= -1; 
            this.RecieveClientID= -1;   
            this.UserID = -1;   
            this.SenderClientID = -1;
            this.TransferID= -1;
            _Mode = enMode.AddNew;


        }


        bool _AddNewTransfer()
        {
            this.TransferID=clsTransferData._AddNewTransfer(this.DateOfTransfer,this.Amount,
                this.SenderClientID,this.RecieveClientID,this.NewSenderBalance,
                this.NewRecieveBalance,this.UserID);

            return (this.TransferID!=-1);    
        }


        public static bool DeleteTransfer(int ClientID)
        {
            return clsTransferData.DeleteTransfer(ClientID);    
        }

        public static DataTable GetAllTransfers()
        {
            return clsTransferData.GetAllTransfers();   
        }
        bool _UpdateTransfer()
        {
            return true;
        }


        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTransfer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateTransfer();

                default: return false;

            }


        }

    }
}
