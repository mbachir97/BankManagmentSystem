namespace BachirBankProject
{
    partial class ListUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvUsersList = new Guna.UI.WinForms.GunaDataGridView();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.DeepSkyBlue;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(465, 144);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(509, 39);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(47, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 43);
            this.label8.TabIndex = 14;
            this.label8.Text = "Users List :";
            // 
            // dgvUsersList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.EnableHeadersVisualStyles = false;
            this.dgvUsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.Location = new System.Drawing.Point(37, 199);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.RowHeadersWidth = 62;
            this.dgvUsersList.RowTemplate.Height = 28;
            this.dgvUsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersList.Size = new System.Drawing.Size(963, 278);
            this.dgvUsersList.TabIndex = 13;
            this.dgvUsersList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUsersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvUsersList.ThemeStyle.ReadOnly = false;
            this.dgvUsersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUsersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.Height = 28;
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "FirstName",
            "UserName"});
            this.cbSearch.Location = new System.Drawing.Point(777, 16);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(223, 50);
            this.cbSearch.TabIndex = 18;
            this.cbSearch.Text = "Select Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(613, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 43);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search By :";
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvUsersList);
            this.Name = "ListUsers";
            this.Size = new System.Drawing.Size(1043, 598);
            this.Load += new System.EventHandler(this.ListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDataGridView dgvUsersList;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label1;
    }
}
