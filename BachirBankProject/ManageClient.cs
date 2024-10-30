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
    public partial class ManageClient : UserControl
    {
        public ManageClient()
        {
            InitializeComponent();
        }

        private void ManageClient_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;

            e.Graphics.DrawRectangle(pen, 30, 70, 300, 150);
         
        }


        void _FillData()
        {
            if (clsClient.IsClientExist(txtSearch.Text))
            {
                clsClient Client = clsClient.Find(txtSearch.Text);
                txtFirstName.Text = Client.FirstName;
                txtLastName.Text = Client.LastName;
                txtEmail.Text = Client.Email;
                txtPhone.Text = Client.Phone;
                txtAddress.Text = Client.Address;
                DateTimePicker1.Value = Client.DateOfBirth;
                txtAcountNumber.Text = Client.AcountNumber;
                txtAcountBalance.Text = Client.AcountBalance.ToString();
                if (Client.ImagePath != "")
                {
                    pictureBox1.Load(Client.ImagePath);
                }
            }
            else
            {
                MessageBox.Show("this Acount is Not Exist....", "Warning"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         

            

        }
        private void ManageClient_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            _FillData();
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

        private void btncreat_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(txtSearch.Text);
            client.FirstName = txtFirstName.Text; client.LastName=txtLastName.Text; 
            client.Email = txtEmail.Text;   
            client.Phone = txtPhone.Text;
            client.Address= txtAddress.Text;
            client.AcountNumber = txtAcountNumber.Text;
            client.AcountBalance=Convert.ToSingle(txtAcountBalance.Text);
            client.DateOfBirth = DateTimePicker1.Value;
            if (pictureBox1.ImageLocation != null)
                client.ImagePath = pictureBox1.ImageLocation;
            else
                client.ImagePath = "";


            if (client.Save())
            {
                MessageBox.Show("Client Updated Successfuly", "Information"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("fail to Update this Client");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            clsClient client = clsClient.Find(txtSearch.Text);

            if(MessageBox.Show("Are you sure you want to delete this Client",
                "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)
                == DialogResult.OK)
            {

                MessageBox.Show(client.ClientID.ToString());
                clsDeposit.DeleteDeposit(client.ClientID);
                clsWithdraw.DeleteWithdraw(client.ClientID);
                clsTransfer.DeleteTransfer(client.ClientID);
                //clsClient.DeleteClient(client.ClientID, client.PersonID)

                if (clsClient.DeleteClient(client.ClientID, client.PersonID))
                {
                    MessageBox.Show("Delete Successfuly");
                   
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
        }
    }
}
