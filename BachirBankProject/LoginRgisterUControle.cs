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
    public partial class LoginRgisterUControle : UserControl
    {
        public LoginRgisterUControle()
        {
            InitializeComponent();
        }

        private void LoginRgisterUControle_Load(object sender, EventArgs e)
        {
            DataTable dataTable=clsLoginRegister.GetAllLogins();
            dgvList.DataSource = dataTable; 
        }
    }
}
