using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

using BankBisness;



namespace BachirBankProject
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);   
        }

        int move,movx,movy;

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84) {
             Point pos = new Point(m.LParam.ToInt32());   
                pos=this.PointToClient(pos);
                if(pos.Y<cCaption)
                {
                    m.Result=(IntPtr)2;
                    return;
                }

                if (pos.X>=this.ClientSize.Width-cGrip && pos.Y>=this.ClientSize.Height-cGrip)
                {
                    m.Result = (IntPtr)17;
                        return      ;
                }
            }
            base.WndProc(ref m);    
        }
        void _LoadData()
        {
            //DataTable dataTable = clsClient.GetAllClients(); 
            
            //testgridview.DataSource= dataTable; 
            
        }
        void CustomizePanel()
        {
            panel_Client.Visible = false;
            panel_Trans.Visible = false;
            panel_User.Visible = false;
        }

        void HidePanel()
        {
            if (panel_Client.Visible == true)
            {
                panel_Client.Visible = false;   
            }
            if (panel_Trans.Visible == true)
            {
                panel_Trans.Visible = false;    
            }
            if (panel_User.Visible == true)
            {
                panel_User.Visible = false; 
            }
        }

        void ShowPanel(Panel panel)
        {
            HidePanel();
            if (panel.Visible == false)
            {
                panel.Visible = true;   
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CustomizePanel();
            _LoadData();
            dashbord dash =new dashbord();
            timer1.Start();
            AddUserControle(dash);
        }

        void AddUserControle(UserControl usercontrole)
        {
            usercontrole.Dock = DockStyle.Fill; 
            panel_Container.Controls.Clear();  
            panel_Container.Controls.Add(usercontrole);
            usercontrole.BringToFront();
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_Client);
        }

        private void btnTransAction_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_Trans);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ShowPanel(panel_User);
        }

        private void btnRegstration_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.
                CheckPermission(clsUser.enPermission.pAddNewClient))
            {
                RgisterClient uc = new RgisterClient();
                AddUserControle(uc);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCustomList_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnCustomList_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            ChekBalance chekBalance = new ChekBalance();
            AddUserControle(chekBalance);
        }

        private void btnCustomList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            AddUserControle(customerList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAcount searchAcount = new SearchAcount();
            AddUserControle(searchAcount);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {

            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pManageClient))
            {
                ManageClient manageClient = new ManageClient();
                AddUserControle(manageClient);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pManageUser))
            {
                NewUser newUser = new NewUser();
                AddUserControle(newUser);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
           
        }

        private void btListUser_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pManageUser))
            {
                ListUsers listUsers = new ListUsers();
                AddUserControle(listUsers);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pManageUser))
            {
                manageUsers user = new manageUsers();
                AddUserControle(user);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pTransAction))
            {
                DepositUControle depositUControle = new DepositUControle();
                AddUserControle(depositUControle);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
           
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pTransAction))
            {
                WithDrawUControl WithDraw = new WithDrawUControl();
                AddUserControle(WithDraw);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
           
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.CheckPermission(clsUser.enPermission.pTransAction))
            {
                TransferUControle transferUControle = new TransferUControle();
                AddUserControle(transferUControle);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
           
        }

        private void transDetails_Click(object sender, EventArgs e)
        {
            if (GlobalUser.CurrentUser.
               CheckPermission(clsUser.enPermission.ptransDetails))
            {
                transDetailsUControle transDetails = new transDetailsUControle();
                AddUserControle(transDetails);
            }
            else
            {
                Permi permi = new Permi();
                gunaTransition1.ShowSync(permi);
            }
          
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
         
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            move = 1;
            movx = e.X; movy = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          dashbord dashbord = new dashbord();
            AddUserControle(dashbord);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginRgisterUControle loginRgisterUControle = new LoginRgisterUControle();
            AddUserControle(loginRgisterUControle);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
        }

        private void panel_Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
