namespace BachirBankProject
{
    partial class dashbord
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashbord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labUser = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMouve = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblClient);
            this.panel1.Location = new System.Drawing.Point(72, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 209);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(41, 48);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(81, 116);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client\r\n\r\n\r\n\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.labUser);
            this.panel2.Location = new System.Drawing.Point(782, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 209);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.Location = new System.Drawing.Point(51, 38);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(81, 29);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "Users";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDate.Location = new System.Drawing.Point(26, 50);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 37);
            this.labelDate.TabIndex = 0;
            this.labelDate.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMouve
            // 
            this.labelMouve.AutoSize = true;
            this.labelMouve.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMouve.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelMouve.Location = new System.Drawing.Point(3, 457);
            this.labelMouve.Name = "labelMouve";
            this.labelMouve.Size = new System.Drawing.Size(690, 54);
            this.labelMouve.TabIndex = 5;
            this.labelMouve.Text = "Thanks Mohammed Abu-Hadhoude";
            this.labelMouve.Click += new System.EventHandler(this.labelMouve_Click);
            // 
            // dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMouve);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dashbord";
            this.Size = new System.Drawing.Size(1070, 612);
            this.Load += new System.EventHandler(this.dashbord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMouve;
    }
}
