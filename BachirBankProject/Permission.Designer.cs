namespace BachirBankProject
{
    partial class Permission
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
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(84, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 43);
            this.label8.TabIndex = 4;
            this.label8.Text = "Create A New Customer";
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Name = "Permission";
            this.Size = new System.Drawing.Size(518, 613);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Permission_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
    }
}
