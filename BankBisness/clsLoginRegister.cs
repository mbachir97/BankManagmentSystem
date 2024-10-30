using BankDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccess;
using System.Data;

namespace BankBisness
{
    public  class clsLoginRegister
    {

        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public int LoginID { get; set; }
   

        public DateTime  LoginDate { get; set; }

        public int UserID { get; set; } 

        public float Amount { get; set; }

        public clsLoginRegister()
        {
            this.LoginID = -1;
            this.UserID = -1;
         
            this.Amount = -1;
            this.LoginDate = DateTime.Now;
            _Mode = enMode.AddNew;

        }


        bool _AddNewLog()
        {
            this.LoginID = clsLoginRegisterData.AddNewDLog(this.LoginDate, this.UserID);    
            return (this.LoginID != -1);
        }

        public static bool DeleteLog(int UserID)
        {
            return clsLoginRegisterData.DeleteLogin(UserID);
        }


        bool _UpdateLogin()
        {
            return true;
        }

        public static DataTable GetAllLogins()
        {
            return clsLoginRegisterData.GetAllLogin();
        }
        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLog())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateLogin();
                default: return false;

            }


        }


    }
}
