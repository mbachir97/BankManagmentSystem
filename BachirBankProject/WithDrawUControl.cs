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
    public partial class WithDrawUControl : UserControl
    {
        public WithDrawUControl()
        {
            InitializeComponent();
        }

        private void WithDrawUControl_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, 30, 70, 300, 150);
            e.Graphics.DrawRectangle(pen, 400, 120, 300, 200);


            e.Graphics.DrawRectangle(pen, 30, 260, 340, 120);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExist(txtSearch.Text))
            {
                clsClient Client = clsClient.Find(txtSearch.Text);
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

        }

        private void btnAplyWithDraw_Click(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find(txtSearch.Text);
           clsWithdraw clsWithdraw = new clsWithdraw();
            clsWithdraw.UserID = GlobalUser.CurrentUser.UserID;
            clsWithdraw.ClientID = Client.ClientID;
            clsWithdraw.Amount = Convert.ToSingle(txtAmount.Text);
            clsWithdraw.DateOfWithDraw = DateTime.Now;
            if(Client.AcountBalance< Convert.ToSingle(txtAmount.Text))
            {
                MessageBox.Show(" Sorry ! " +
                    "we can not Aply This Withdraw " +
                    "your Balance is Less Than this Aount ","Warning",MessageBoxButtons.OK
                    ,MessageBoxIcon.Exclamation);
                return;
            }
            if (Client.WithDraw(Convert.ToSingle(txtAmount.Text)))
            {
                clsWithdraw.Save();
                MessageBox.Show("WithDraw is  Maked Successfuly ");
            }
            else
            {
                MessageBox.Show("WithDraw is Faild ");
            }
        }
    }
}
