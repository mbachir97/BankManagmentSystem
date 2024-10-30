using BankBisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachirBankProject
{
    public partial class SearchAcount : UserControl
    {
        public SearchAcount()
        {
            InitializeComponent();
        }

        void _LoadData()
        {
            DataTable dataTable = clsClient.GetAllClients();

            dgvList.DataSource = dataTable;

        }

        private void SearchAcount_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.SelectedIndex==0)
            {
                DataTable dt = clsClient.GetClientByFirstName(gunaLineTextBox1.Text + "%");
                dgvList.DataSource = dt;
            }
            else if (cbSearch.SelectedIndex == 1)
            {
                DataTable dt = clsClient.GetClientByAcount(gunaLineTextBox1.Text + "%");
                dgvList.DataSource = dt;
            }
          
        }
    }
}
