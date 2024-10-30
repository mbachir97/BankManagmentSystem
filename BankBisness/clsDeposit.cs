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
    public  class clsDeposit
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public int DepositID { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }

        public DateTime  DateOfDeposit { get; set; }

       

        public float Amount { get; set; }

        public clsDeposit() 
        {
            this.ClientID = -1;
            this.UserID = -1;
            this.DepositID=-1 ;
            this.Amount = -1;
            this.DateOfDeposit = DateTime.Now;  
            _Mode = enMode.AddNew;

        }


        bool _AddNewDeposit()
        {
            this.DepositID = clsDepositData._AddNewDeposi(this.DateOfDeposit, 
                this.Amount, this.ClientID, this.UserID);
            return (this.DepositID != -1);
        }

        public static bool DeleteDeposit(int ClientID)
        {
           return clsDepositData.DeleteDeposit(ClientID);   
        }


        bool _UpdateDeposit()
        {
            return true;
        }
            

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDeposit())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateDeposit();
                default: return false;

            }


        }

        public static DataTable GetSommInforForDeposit()
        {
           return   clsDepositData.GetSomeInfoForDepositAcount();   
        }



        public static DataTable GetDepositsData() {
        
        return clsDepositData.GetDepositsData();


        }

    }
}
