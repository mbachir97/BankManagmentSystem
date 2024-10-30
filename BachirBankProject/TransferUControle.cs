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
    public partial class TransferUControle : UserControl
    {
        public TransferUControle()
        {
            InitializeComponent();
        }

        private void TransferUControle_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, 30, 70, 330, 120);
            e.Graphics.DrawRectangle(pen, 30, 210, 330, 140);

            e.Graphics.DrawRectangle(pen, 420, 45, 300, 160);
            e.Graphics.DrawRectangle(pen, 420, 220, 300, 160);
            //e.Graphics.DrawRectangle(pen, 30, 260, 340, 120);
        }

        private void TransferUControle_Load(object sender, EventArgs e)
        {

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

        private void btnSerchTo_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExist(txtSearch.Text))
            {
                clsClient Client = clsClient.Find(txtAcountTo.Text);
                txtFirstNameTo.Text = Client.FirstName;
                txtLastNameTo.Text = Client.LastName;
                txtBalanceTo.Text = Client.AcountBalance.ToString();
            }
     
                   else
            {
                MessageBox.Show("this Acount is Not Exist....", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        clsTransfer _FillTransferObject()

        {

            clsClient Sender1 = clsClient.Find(txtSearch.Text);

            clsClient Resiever1 = clsClient.Find(txtAcountTo.Text);



            clsTransfer transfer1 = new clsTransfer();
            transfer1.DateOfTransfer = DateTime.Now;
            transfer1.Amount = Convert.ToSingle(txtAmount.Text);
            transfer1.SenderClientID = Sender1.ClientID;
            transfer1.RecieveClientID = Resiever1.ClientID;
            transfer1.NewRecieveBalance = (float)(Resiever1.AcountBalance + transfer1.Amount);
            transfer1.NewSenderBalance = (float)(Sender1.AcountBalance - transfer1.Amount);
            transfer1.UserID = GlobalUser.CurrentUser.UserID;

            return  transfer1;  
        }
        private void btnAplyTransfer_Click(object sender, EventArgs e)
        {
            clsClient Sender1 = new clsClient();
            clsClient Resiever1 = new clsClient();
            if (clsClient.IsClientExist(txtSearch.Text))
            {
                Sender1 = clsClient.Find(txtSearch.Text);
            }
            else
            {
                MessageBox.Show("this Acount is Not Exist....", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (clsClient.IsClientExist(txtAcountTo.Text))
            {
                Resiever1 = clsClient.Find(txtAcountTo.Text);
            }
            else
            {
                MessageBox.Show("this Acount is Not Exist....", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clsTransfer transfer1 = _FillTransferObject();
             
            if(MessageBox.Show("Are you Sure You Want To Aply this Transfer","Information"
               ,MessageBoxButtons.OKCancel,MessageBoxIcon.Information )==DialogResult.OK)
            {
                if(Sender1.AcountBalance< transfer1.Amount)
                {
                    MessageBox.Show(" Sorry! We Can not Apply this Transfer " +
                        "the Balance Of The Sender is Less Than the Amount " +
                        "Try Again Whith Onoter Amount", "Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);

                    return;
                }
                if(Sender1.Transfer(transfer1.Amount, Resiever1))
                {

                    MessageBox.Show("Transfer is Maked Successfuly","Information",MessageBoxButtons.OK
                        , MessageBoxIcon.Information);

                    MessageBox.Show(  " "+transfer1.Save()
                        );   
                }
                else
                {
                    MessageBox.Show("Transfer Faild, ", "Error", MessageBoxButtons.OK
                      , MessageBoxIcon.Error);
                }
            }
         


        }
    }
}
