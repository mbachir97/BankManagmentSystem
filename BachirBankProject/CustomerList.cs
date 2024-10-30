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
    public partial class CustomerList : UserControl
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            DataTable dataTable = clsClient.GetAllClients();

            dgvList.DataSource = dataTable;

        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
