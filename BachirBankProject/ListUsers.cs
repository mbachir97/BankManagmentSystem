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
    public partial class ListUsers : UserControl
    {
        public ListUsers()
        {
            InitializeComponent();
        }

        private void ListUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = clsUser.GetAllUsers();  
            dgvUsersList.DataSource = dt;       
            
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (cbSearch.Text.ToLower() == "firstname")
            {
                dgvUsersList.DataSource = clsUser.GetDataByFirstName(txtSearch.Text + "%");
            }

            if (cbSearch.Text.ToLower() == "username")
            {
                dgvUsersList.DataSource = clsUser.GetDataByUserName(txtSearch.Text + "%");
            }
        }
    }
}
