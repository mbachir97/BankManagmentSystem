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
    public partial class transDetailsUControle : UserControl
    {
        public transDetailsUControle()
        {
            InitializeComponent();
        }

        private void transDetailsUControle_Load(object sender, EventArgs e)
        {
            DataTable transDetails = clsTransfer.GetAllTransfers();
            dgvTransfer.DataSource = transDetails;  

            DataTable dataTable = clsDeposit.GetSommInforForDeposit();    
            dgvdeposit.DataSource = dataTable;


            DataTable dataTable1 = clsWithdraw.GetSommInforForWithdraw();
            dgvWithdr.DataSource = dataTable1;


        }

        private void dgvWithdr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.ToLower() == "transfer")
            {
                DataTable transDetails = clsTransfer.GetAllTransfers();
                dgvTransfer.DataSource = transDetails;
            }

            if (cbSearch.Text.ToLower() == "deposit")
            {

                DataTable dt = clsDeposit.GetDepositsData();
                dgvTransfer.DataSource= dt; 


            }

            if (cbSearch.Text.ToLower() == "withdraw")
            {
                DataTable dt = clsWithdraw.GetAllWithDraws();
                dgvTransfer.DataSource = dt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


          
        }
    }
}
