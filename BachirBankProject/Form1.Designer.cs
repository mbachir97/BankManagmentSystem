namespace BachirBankProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Slidepanel = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_User = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btListUser = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel_Trans = new System.Windows.Forms.Panel();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransAction = new System.Windows.Forms.Button();
            this.panel_Client = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnRegstration = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.transDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnCustomList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Container = new System.Windows.Forms.Panel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.Slidepanel.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_User.SuspendLayout();
            this.panel_Trans.SuspendLayout();
            this.panel_Client.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Slidepanel
            // 
            this.Slidepanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Slidepanel.Controls.Add(this.panel_logo);
            this.Slidepanel.Controls.Add(this.panel_User);
            this.Slidepanel.Controls.Add(this.btnExit);
            this.Slidepanel.Controls.Add(this.btnUser);
            this.Slidepanel.Controls.Add(this.panel_Trans);
            this.Slidepanel.Controls.Add(this.btnTransAction);
            this.Slidepanel.Controls.Add(this.panel_Client);
            this.Slidepanel.Controls.Add(this.btnClient);
            this.gunaTransition1.SetDecoration(this.Slidepanel, Guna.UI.Animation.DecorationType.None);
            this.Slidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidepanel.Location = new System.Drawing.Point(0, 0);
            this.Slidepanel.Name = "Slidepanel";
            this.Slidepanel.Size = new System.Drawing.Size(200, 815);
            this.Slidepanel.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.gunaTransition1.SetDecoration(this.panel_logo, Guna.UI.Animation.DecorationType.None);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 73);
            this.panel_logo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.gunaTransition1.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_User
            // 
            this.panel_User.BackColor = System.Drawing.Color.Azure;
            this.panel_User.Controls.Add(this.button1);
            this.panel_User.Controls.Add(this.btListUser);
            this.panel_User.Controls.Add(this.button4);
            this.panel_User.Controls.Add(this.button5);
            this.gunaTransition1.SetDecoration(this.panel_User, Guna.UI.Animation.DecorationType.None);
            this.panel_User.Location = new System.Drawing.Point(-3, 461);
            this.panel_User.Name = "panel_User";
            this.panel_User.Size = new System.Drawing.Size(210, 189);
            this.panel_User.TabIndex = 7;
            // 
            // button1
            // 
            this.gunaTransition1.SetDecoration(this.button1, Guna.UI.Animation.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.Location = new System.Drawing.Point(1, 139);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(199, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "LogRegistre";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btListUser
            // 
            this.btListUser.BackColor = System.Drawing.Color.Azure;
            this.gunaTransition1.SetDecoration(this.btListUser, Guna.UI.Animation.DecorationType.None);
            this.btListUser.FlatAppearance.BorderSize = 0;
            this.btListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListUser.ForeColor = System.Drawing.Color.Black;
            this.btListUser.Location = new System.Drawing.Point(1, 92);
            this.btListUser.Name = "btListUser";
            this.btListUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btListUser.Size = new System.Drawing.Size(199, 40);
            this.btListUser.TabIndex = 4;
            this.btListUser.Text = "List Users";
            this.btListUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btListUser.UseVisualStyleBackColor = false;
            this.btListUser.Click += new System.EventHandler(this.btListUser_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Azure;
            this.gunaTransition1.SetDecoration(this.button4, Guna.UI.Animation.DecorationType.None);
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(-3, 46);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(199, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Manage User";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.gunaTransition1.SetDecoration(this.button5, Guna.UI.Animation.DecorationType.None);
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(8, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(195, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "New User";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExit
            // 
            this.gunaTransition1.SetDecoration(this.btnExit, Guna.UI.Animation.DecorationType.None);
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 666);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(199, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit\r\n\r\n";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUser
            // 
            this.gunaTransition1.SetDecoration(this.btnUser, Guna.UI.Animation.DecorationType.None);
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 420);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(199, 45);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel_Trans
            // 
            this.panel_Trans.BackColor = System.Drawing.Color.Azure;
            this.panel_Trans.Controls.Add(this.btnTransfer);
            this.panel_Trans.Controls.Add(this.btnWithdraw);
            this.panel_Trans.Controls.Add(this.btnDeposit);
            this.gunaTransition1.SetDecoration(this.panel_Trans, Guna.UI.Animation.DecorationType.None);
            this.panel_Trans.ForeColor = System.Drawing.Color.Black;
            this.panel_Trans.Location = new System.Drawing.Point(-6, 290);
            this.panel_Trans.Name = "panel_Trans";
            this.panel_Trans.Size = new System.Drawing.Size(206, 136);
            this.panel_Trans.TabIndex = 5;
            // 
            // btnTransfer
            // 
            this.gunaTransition1.SetDecoration(this.btnTransfer, Guna.UI.Animation.DecorationType.None);
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Location = new System.Drawing.Point(-3, 90);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(199, 43);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.gunaTransition1.SetDecoration(this.btnWithdraw, Guna.UI.Animation.DecorationType.None);
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.Location = new System.Drawing.Point(-3, 46);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(199, 38);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.gunaTransition1.SetDecoration(this.btnDeposit, Guna.UI.Animation.DecorationType.None);
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Black;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(-3, 0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(199, 40);
            this.btnDeposit.TabIndex = 4;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransAction
            // 
            this.gunaTransition1.SetDecoration(this.btnTransAction, Guna.UI.Animation.DecorationType.None);
            this.btnTransAction.FlatAppearance.BorderSize = 0;
            this.btnTransAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransAction.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransAction.ForeColor = System.Drawing.Color.White;
            this.btnTransAction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransAction.Image")));
            this.btnTransAction.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTransAction.Location = new System.Drawing.Point(-22, 238);
            this.btnTransAction.Name = "btnTransAction";
            this.btnTransAction.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTransAction.Size = new System.Drawing.Size(222, 56);
            this.btnTransAction.TabIndex = 4;
            this.btnTransAction.Text = "TransActions";
            this.btnTransAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransAction.UseVisualStyleBackColor = true;
            this.btnTransAction.Click += new System.EventHandler(this.btnTransAction_Click);
            // 
            // panel_Client
            // 
            this.panel_Client.BackColor = System.Drawing.Color.Azure;
            this.panel_Client.Controls.Add(this.btnManage);
            this.panel_Client.Controls.Add(this.btnRegstration);
            this.gunaTransition1.SetDecoration(this.panel_Client, Guna.UI.Animation.DecorationType.None);
            this.panel_Client.Location = new System.Drawing.Point(3, 130);
            this.panel_Client.Name = "panel_Client";
            this.panel_Client.Size = new System.Drawing.Size(196, 121);
            this.panel_Client.TabIndex = 3;
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.Azure;
            this.gunaTransition1.SetDecoration(this.btnManage, Guna.UI.Animation.DecorationType.None);
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.Location = new System.Drawing.Point(3, 56);
            this.btnManage.Name = "btnManage";
            this.btnManage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManage.Size = new System.Drawing.Size(193, 35);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "Manage Client";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnRegstration
            // 
            this.btnRegstration.BackColor = System.Drawing.Color.Azure;
            this.gunaTransition1.SetDecoration(this.btnRegstration, Guna.UI.Animation.DecorationType.None);
            this.btnRegstration.FlatAppearance.BorderSize = 0;
            this.btnRegstration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegstration.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegstration.ForeColor = System.Drawing.Color.Black;
            this.btnRegstration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegstration.Location = new System.Drawing.Point(8, 0);
            this.btnRegstration.Name = "btnRegstration";
            this.btnRegstration.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRegstration.Size = new System.Drawing.Size(185, 40);
            this.btnRegstration.TabIndex = 4;
            this.btnRegstration.Text = "Registration";
            this.btnRegstration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegstration.UseVisualStyleBackColor = false;
            this.btnRegstration.Click += new System.EventHandler(this.btnRegstration_Click);
            // 
            // btnClient
            // 
            this.gunaTransition1.SetDecoration(this.btnClient, Guna.UI.Animation.DecorationType.None);
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(3, 79);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(196, 45);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.transDetails);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCheckBalance);
            this.panel1.Controls.Add(this.btnCustomList);
            this.gunaTransition1.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 73);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnMax
            // 
            this.gunaTransition1.SetDecoration(this.btnMax, Guna.UI.Animation.DecorationType.None);
            this.btnMax.Location = new System.Drawing.Point(0, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(48, 48);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // transDetails
            // 
            this.transDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaTransition1.SetDecoration(this.transDetails, Guna.UI.Animation.DecorationType.None);
            this.transDetails.FlatAppearance.BorderSize = 0;
            this.transDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transDetails.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transDetails.ForeColor = System.Drawing.Color.White;
            this.transDetails.Image = ((System.Drawing.Image)(resources.GetObject("transDetails.Image")));
            this.transDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transDetails.Location = new System.Drawing.Point(1045, 7);
            this.transDetails.Name = "transDetails";
            this.transDetails.Size = new System.Drawing.Size(289, 60);
            this.transDetails.TabIndex = 7;
            this.transDetails.Text = "TransActionDetails";
            this.transDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transDetails.UseVisualStyleBackColor = true;
            this.transDetails.Click += new System.EventHandler(this.transDetails_Click);
            this.transDetails.MouseEnter += new System.EventHandler(this.btnCustomList_MouseEnter);
            this.transDetails.MouseHover += new System.EventHandler(this.btnCustomList_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaTransition1.SetDecoration(this.btnSearch, Guna.UI.Animation.DecorationType.None);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(776, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(229, 60);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Acount";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnCustomList_MouseEnter);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnCustomList_MouseHover);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaTransition1.SetDecoration(this.btnCheckBalance, Guna.UI.Animation.DecorationType.None);
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.Color.White;
            this.btnCheckBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckBalance.Image")));
            this.btnCheckBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance.Location = new System.Drawing.Point(520, 4);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(230, 60);
            this.btnCheckBalance.TabIndex = 7;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            this.btnCheckBalance.MouseEnter += new System.EventHandler(this.btnCustomList_MouseEnter);
            this.btnCheckBalance.MouseHover += new System.EventHandler(this.btnCustomList_MouseHover);
            // 
            // btnCustomList
            // 
            this.btnCustomList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gunaTransition1.SetDecoration(this.btnCustomList, Guna.UI.Animation.DecorationType.None);
            this.btnCustomList.FlatAppearance.BorderSize = 0;
            this.btnCustomList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomList.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomList.ForeColor = System.Drawing.Color.White;
            this.btnCustomList.Location = new System.Drawing.Point(295, 0);
            this.btnCustomList.Name = "btnCustomList";
            this.btnCustomList.Size = new System.Drawing.Size(204, 60);
            this.btnCustomList.TabIndex = 7;
            this.btnCustomList.Text = "Custemer List";
            this.btnCustomList.UseVisualStyleBackColor = true;
            this.btnCustomList.Click += new System.EventHandler(this.btnCustomList_Click);
            this.btnCustomList.MouseEnter += new System.EventHandler(this.btnCustomList_MouseEnter);
            this.btnCustomList.MouseHover += new System.EventHandler(this.btnCustomList_MouseHover);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaTransition1.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(200, 792);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 23);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_Container
            // 
            this.gunaTransition1.SetDecoration(this.panel_Container, Guna.UI.Animation.DecorationType.None);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(200, 73);
            this.panel_Container.MinimumSize = new System.Drawing.Size(1300, 668);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(1600, 719);
            this.panel_Container.TabIndex = 5;
            this.panel_Container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Container_Paint);
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 815);
            this.Controls.Add(this.panel_Container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Slidepanel);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 815);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Slidepanel.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_User.ResumeLayout(false);
            this.panel_Trans.ResumeLayout(false);
            this.panel_Client.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel Slidepanel;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panel_Client;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnRegstration;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel_Trans;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransAction;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel_User;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.Button btnCustomList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btListUser;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
        private System.Windows.Forms.Button transDetails;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button button1;
    }
}

