using BankDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBisness
{
    public  class clsUser : clsPerson
    {
        public enum enPermission
        {
            enAll = -1, pListClient = 1, pAddNewClient = 2, pManageClient = 4,
            pFindClient = 8, pManageUser = 16, pTransAction = 32,ptransDetails=64
        }
        enum enMode { AddNew = 0, Update = 1 };
        enMode _Mode = enMode.AddNew;

        public int UserID { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public int  Permission { get; set; }




        public clsUser() : base()
        {
            this.UserID = -1;
            this.UserName = "";
            this.PassWord = "";
            this.Permission = -1;
            _Mode = enMode.AddNew;

        }

        private clsUser(int UserID, string FirstName, string LastName,
           string Email, string Phone, string Address,
           DateTime DateOfBirth, string ImagePath,
           int PersonID, string UserName, string PassWord,int Permission) : base(PersonID, FirstName, LastName,
           Email, Phone, Address,
            DateOfBirth, ImagePath)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.PassWord = PassWord;
            this.Permission = Permission;
            
            _Mode = enMode.Update;


        }



        public static clsUser Find(string UserName,string PassWord)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            string PinCode = "";
            int Permission = -1;
            int UserID = -1, PersonID = -1;
            if (clsUserData.GetUserByUserNameandPassWord(ref UserID, UserName, PassWord,
                      ref Permission, ref PersonID, ref FirstName, ref LastName,
                      ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath))
            {

                return new clsUser(UserID, FirstName, LastName,
            Email, Phone, Address,
            DateOfBirth, ImagePath,
            PersonID, UserName, PassWord, Permission);
            }
            else { return null; }

        }

        public static clsUser Find(string UserName)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            string PassWord = "";
            DateTime DateOfBirth = DateTime.Now;
            string PinCode = "";
            int Permission = -1;
            int UserID = -1, PersonID = -1;
            if (clsUserData.GetUserByUserName(ref UserID, UserName,ref PassWord,
                      ref Permission, ref PersonID, ref FirstName, ref LastName,
                      ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath))
            {

                return new clsUser(UserID, FirstName, LastName,
            Email, Phone, Address,
            DateOfBirth, ImagePath,
            PersonID, UserName, PassWord, Permission);
            }
            else { return null; }

        }
        bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.FirstName, this.LastName, this.Email, this.Phone,
                this.Address, this.DateOfBirth, this.ImagePath, this.UserName, this.PassWord, this.Permission);
            return (this.UserID != -1);
        }


        bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.FirstName,
                this.LastName, this.Email, this.Phone,
                this.Address, this.DateOfBirth, this.ImagePath,
                this.UserName, this.PassWord, this.Permission);
        }





        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else return false;
                case enMode.Update:
                    return _UpdateUser();
                default: return false;

            }


        }

        public static int GetNumberOfUsers()
        {
            return clsUserData.GetNumberOfUsers();  
        }

        public static bool DeleteUser(int UserID, int PersonID)
        {
            return clsUserData.DeleteUser(UserID, PersonID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUserss();
        }


        public  static DataTable GetDataByFirstName(string FirstName)
        {
            return clsUserData.GetDataByFirstName(FirstName);   
        }



        public static DataTable GetDataByUserName(string UserName)
        {
            return clsUserData.GetDataByUserName(UserName);
        }
        public static bool IsUsertExist(string UserName,string PassWord)
        {
            return clsUserData.IsUsertExist(UserName, PassWord);
        }


        public static bool IsUsertExist(string UserName)
        {
            return clsUserData.IsUsertExist(UserName);
        }
        public bool CheckPermission(enPermission permission)
        {

            if((int)this.Permission==(int)enPermission.enAll)
                return true;
    
            if(((int)permission & (int)this.Permission)==(int)permission)
                return true;

            return false;   

             
        } 

    }
}
