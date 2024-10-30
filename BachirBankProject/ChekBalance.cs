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
    public partial class ChekBalance : UserControl
    {
        public ChekBalance()
        {
            InitializeComponent();
        }

        private void ChekBalance_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;

            e.Graphics.DrawRectangle(pen, 30, 70, 300, 150);
            e.Graphics.DrawRectangle(pen, 380, 120, 280, 200);
        }

        private void ChekBalance_Load(object sender, EventArgs e)
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
    }
}
