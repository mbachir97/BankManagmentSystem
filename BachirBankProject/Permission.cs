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
    public partial class Permission : UserControl
    {
        public Permission()
        {
            InitializeComponent();
        }

        private void Permission_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.DeepSkyBlue;
            Pen pen = new Pen(color);
            pen.Width = 2;


            e.Graphics.DrawRectangle(pen, 30, 70, 300, 150);
        }
    }
}
