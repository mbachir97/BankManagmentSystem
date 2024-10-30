using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBisness;

namespace BachirBankProject
{
    public partial class RgisterClient : UserControl
    {
        public RgisterClient()
        {
            InitializeComponent();
        }

        private void RgisterClient_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           clsClient client = new clsClient();
            client.FirstName=txt_Firstname.Text;
            client.LastName=txt_lastName.Text;  
            client.Email=txt_Email.Text;
            client.Phone=txt_Phone.Text;
            client.Address=txt_Address.Text;
            client.DateOfBirth = DateTimePicker1.Value;
            client.PinCode = txt_PinCode.Text;
            client.AcountNumber = txt_AcountNumber.Text;
            client.AcountBalance = Convert.ToSingle(txt_Balance.Text);
            if (pictureBox1.ImageLocation != null)
                client.ImagePath = pictureBox1.ImageLocation;
            else
                client.ImagePath = "";

            if (client.Save())
            {
                MessageBox.Show("A new Customer Added Succefuly ", "Information ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
