using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBisness;

namespace BachirBankProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsLoginRegister LoginRegister = new clsLoginRegister(); 
            if (clsUser.IsUsertExist(txtUserName.Text, txtPassWord.Text))
            {
                GlobalUser.CurrentUser = clsUser.Find(txtUserName.Text, txtPassWord.Text);
                LoginRegister.UserID = GlobalUser.CurrentUser.UserID;     
                LoginRegister.LoginDate=DateTime.Now;
                LoginRegister.Save();   
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong PassWord or UserName");
            }
        }
    }
}
