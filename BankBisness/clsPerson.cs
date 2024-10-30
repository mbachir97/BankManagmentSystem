using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBisness
{
    public  class clsPerson
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Email { get; set; }   

        public string Phone { get; set; }   
        public string Address {get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath {get; set; }

         public clsPerson() {
        
        this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.ImagePath = "";
        
        } 

        public clsPerson(int ID, string FirstName, string LastName,
           string Email, string Phone, string Address, DateTime DateOfBirth,  string ImagePath)
        {
            

        
                this.PersonID = ID;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;
                this.Phone = Phone;
                this.Address = Address;
                this.DateOfBirth = DateOfBirth;
            
                this.ImagePath = ImagePath;
            }


    }
}
