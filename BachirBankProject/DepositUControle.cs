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
    public partial class DepositUControle : UserControl
    {
        public DepositUControle()
        {
            InitializeComponent();
        }

        private void DepositUControle_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, 30, 70, 300, 150);
            e.Graphics.DrawRectangle(pen, 400, 120, 300, 200);

         
            e.Graphics.DrawRectangle(pen, 30, 260, 340, 120);
        }

        private void DepositUControle_Load(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find(txtSearch.Text);
            if (Client!=null)
            {
               
                txtFirstName.Text = Client.FirstName;
                txtLastName.Text = Client.LastName;
                txtBalance.Text = Client.AcountBalance.ToString();
            }
           

            else
            {
                MessageBox.Show("this Acount is Not Exist....", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAplyDeposit_Click(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find(txtSearch.Text);
            clsDeposit depo1=new clsDeposit();
            depo1.UserID=GlobalUser.CurrentUser.UserID; 
            depo1.ClientID=Client.ClientID;
            depo1.Amount = Convert.ToSingle(txtAmount.Text);
            depo1.DateOfDeposit=DateTime.Now;
            if (Client.Deposit(Convert.ToSingle(txtAmount.Text)))
            {
                depo1.Save();
                MessageBox.Show("Deposit is  Maked Successfuly ");
            }
            else
            {
                MessageBox.Show("Deposit is Faild ");
            }


        }
    }
}
