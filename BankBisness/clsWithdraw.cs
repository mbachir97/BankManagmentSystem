using BankDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBisness
{
    public  class clsWithdraw
    {
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public int WithDrawID { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }

        public DateTime DateOfWithDraw { get; set; }



        public float Amount { get; set; }

        public clsWithdraw()
        {
            this.ClientID = -1;
            this.UserID = -1;
            this.WithDrawID = -1;
            this.Amount = -1;
            this.DateOfWithDraw = DateTime.Now;
            _Mode = enMode.AddNew;

        }


        bool _AddNewWithDraw()
        {
            this.WithDrawID = clsWithdrawData._AddNewWithDraw(this.DateOfWithDraw,
                this.Amount, this.ClientID, this.UserID);
            return (this.WithDrawID != -1);
        }

        public static bool DeleteWithdraw(int ClientID)
        {
            return clsWithdrawData.DeleteWithdraw(ClientID);
        }


        bool _UpdateWithdraw()
        {
            return true;
        }

        public static DataTable GetSommInforForWithdraw()
        {
            return clsWithdrawData.GetSomeInfoForWithdrawAcount();
        }

        public static DataTable GetAllWithDraws()
        {
            return  clsWithdrawData.GetWithDrawsData();
        }
        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewWithDraw())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateWithdraw();
                default: return false;

            }


        }
    }
}
