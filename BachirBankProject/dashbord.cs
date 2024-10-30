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
    public partial class dashbord : UserControl
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashbord_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dddd-MMM-yyyy  - hh:mm:ss tt ");
            lblClient.Text = "Clients"+"\n\n " +
                "  "+clsClient.GetNumberOfClient().ToString();

            labUser.Text="Users"+ "\n\n " +
                "  " + clsUser.GetNumberOfUsers().ToString();

            DataTable dt = clsDeposit.GetDepositsData();

           


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int pos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;   
          


           // date.AddSeconds(1);
             labelDate.Text = date.ToString("dddd-MMM-yyyy  - hh:mm:ss tt");
            

            //labelDate.Text= string.Format("{0}.{1}.{2}", hour.ToString().ToString().PadLeft(2, '0'),
            //      Min.ToString().ToString().PadLeft(2, '0'), Second.ToString().ToString().PadLeft(2, '0'));

            if (pos == 0)
            {

                labelMouve.Location = new Point(3, 300);
                labelMouve.ForeColor = Color.DeepSkyBlue;
                pos++;
            }

            else if (pos == 1)
            {
                labelMouve.Location = new Point(100, 300);
                labelMouve.ForeColor = Color.Orange;
                pos++;
            }
            else if (pos == 2)
            {
                labelMouve.Location = new Point(250, 300);
                labelMouve.ForeColor = Color.Green;
                pos = 0;
            }



        }

        private void labelMouve_Click(object sender, EventArgs e)
        {

        }
    }
}
