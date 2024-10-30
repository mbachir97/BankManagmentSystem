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
    public partial class NewUser : UserControl
    {
        public enum enPermission
        {
            enAll = -1, pListClient = 1, pAddNewClient = 2, pManageClient = 4,
            pFindClient = 8, pManageUser = 16, pTransAction = 32, ptransDetails = 64
        }
        int _CalculatePermission()
        {
            int Permission = 0;
            if (checkAll.Checked)
                return -1;
            if (checkList.Checked)
                Permission += Convert.ToInt32(enPermission.pListClient);

            if (chekAdd.Checked)
                Permission += Convert.ToInt32(enPermission.pAddNewClient);
            if (chekManageClient.Checked)
                Permission += Convert.ToInt32(enPermission.pManageClient);
            if (chekFind.Checked)
                Permission += Convert.ToInt32(enPermission.pFindClient);
            if (chekManageUser.Checked)
                Permission += Convert.ToInt32(enPermission.pManageUser);
            if (chekTransAction.Checked)
                Permission += Convert.ToInt32(enPermission.pTransAction);
            if (chekDetails.Checked)
                Permission += Convert.ToInt32(enPermission.ptransDetails);

            return Permission;

        }
          
        public NewUser(int Permission =-1)
        {
            InitializeComponent();
            
        }

        private void btncreat_Click(object sender, EventArgs e)
        {
            clsUser clsUser = new clsUser();
            clsUser.FirstName=txt_Firstname.Text;   
            clsUser.LastName=txt_lastName.Text;
            clsUser.Email = txt_Email.Text;
            clsUser.Phone = txt_Phone.Text;
            clsUser.Address = txt_Address.Text;
            clsUser.DateOfBirth = DateTimePicker1.Value;
            clsUser.UserName=txt_UserName.Text; 
            clsUser.PassWord = txt_PassWord.Text;
            clsUser.Permission = _CalculatePermission();
            
            if (pictureBox1.ImageLocation != null)
                clsUser.ImagePath = pictureBox1.ImageLocation;
            else
                clsUser.ImagePath = "";

            if (clsUser.Save())
            {
                MessageBox.Show("A new User Added Succefuly ", "Information ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void NewUser_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;

            e.Graphics.DrawRectangle(pen, 530, 80, 200, 300);
            //e.Graphics.DrawRectangle(pen, 380, 120, 280, 200);
        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void btPermission_Click(object sender, EventArgs e)
        {
           Permission permission = new Permission();
            permission.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
