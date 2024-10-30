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
    public partial class Permi : Form
    {
        public enum enPermission
        {
            enAll = -1, pListClient = 1, pAddNewClient = 2, pManageClient = 4,
            pFindClient = 8, pManageUser = 16, pTransAction = 32
        }
      
        
        public Permi()
        {
            InitializeComponent();
        }

        private void Permi_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;

            e.Graphics.DrawRectangle(pen, 30, 70, 300, 300);
            //e.Graphics.DrawRectangle(pen, 380, 120, 280, 200);
        }

        private void Permi_Load(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            

        }
    }
}
