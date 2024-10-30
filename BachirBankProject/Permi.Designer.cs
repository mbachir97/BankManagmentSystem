namespace BachirBankProject
{
    partial class Permi
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(102, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 43);
            this.label8.TabIndex = 5;
            this.label8.Text = "Accees denight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(149, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact Your Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 129);
            this.label2.TabIndex = 5;
            this.label2.Text = "may be you dont have A  Permission ...\r\n\r\n\r\n";
            // 
            // Permi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "Permi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permi";
            this.Load += new System.EventHandler(this.Permi_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Permi_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}