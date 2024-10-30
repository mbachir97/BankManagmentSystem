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
    public partial class manageUsers : UserControl
    {
        public manageUsers()
        {
            InitializeComponent();
        }
        //public enum enPermission
        //{
        //    enAll = -1, pListClient = 1, pAddNewClient = 2, pManageClient = 4,
        //    pFindClient = 8, pManageUser = 16, pTransAction = 32
        //}
        private void manageUsers_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;

            e.Graphics.DrawRectangle(pen, 30, 150, 200, 280);
            e.Graphics.DrawRectangle(pen, 25, 50, 300, 90);

            //e.Graphics.DrawRectangle(pen, 30, 80, 200, 300);
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {

        }
        void _FillData()
        {
            if (clsUser.IsUsertExist(txtSearch.Text))
            {
                clsUser User = clsUser.Find(txtSearch.Text);
                txtFirstName.Text = User.FirstName;
                txtLastName.Text = User.LastName;
                txtEmail.Text = User.Email;
                txtPhone.Text = User.Phone;
                txtAddress.Text = User.Address;
                DateTimePicker1.Value = User.DateOfBirth;
                txtUserName.Text = User.UserName;
                txtPassWord.Text = User.PassWord;
                if (User.ImagePath != "")
                {
                    pictureBox1.Load(User.ImagePath);
                }
            }
            else
            {
                MessageBox.Show("this User Name IS not Found...." +
                    "Try Again With Onother UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       



        }
        void _FillCheckboxOfPermission()
        {
            clsUser user = clsUser.Find(txtSearch.Text);

            if (user.Permission == -1)
                checkAll.Checked = true;


            if (user.CheckPermission(clsUser.enPermission.pListClient))
                checkList.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.pAddNewClient))
                chekAdd.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.pFindClient))
                chekFind.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.pManageClient))
                chekManageClient.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.pManageUser))
                chekManageUser.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.pTransAction))
                chekTransAction.Checked = true;
            if (user.CheckPermission(clsUser.enPermission.ptransDetails))
                chekDetails.Checked = true;

        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            _FillData();
            _FillCheckboxOfPermission();

        }
       
        private void btncreat_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.Find(txtSearch.Text);
            User.FirstName = txtFirstName.Text; User.LastName = txtLastName.Text;
            User.Email = txtEmail.Text;
            User.Phone = txtPhone.Text;
            User.Address = txtAddress.Text;
            User.UserName = txtUserName.Text;
            User.PassWord = txtPassWord.Text;
            User.DateOfBirth = DateTimePicker1.Value;
            if (pictureBox1.ImageLocation != null)
                User.ImagePath = pictureBox1.ImageLocation;
            else
                User.ImagePath = "";


            if (User.Save())
            {
                MessageBox.Show("User Updated Successfuly", "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("fail to Update this Client");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsUser User =clsUser.Find(txtSearch.Text);

            if (MessageBox.Show("Are you sure you want to delete this Client",
                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                == DialogResult.OK)
            {
                if (clsUser.DeleteUser(User.UserID, User.PersonID))
                {
                    MessageBox.Show("Delete Successfuly");
                }

            }

        }
    }
}
