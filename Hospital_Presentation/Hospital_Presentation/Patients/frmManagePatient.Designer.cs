namespace Hospital_Presentation.Patients
{
    partial class frmManagePatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPatientCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbSearchForPersonByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsPatientsMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPatientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatients)).BeginInit();
            this.cmsPatientsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPatientCount
            // 
            this.lblPatientCount.AutoSize = true;
            this.lblPatientCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblPatientCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPatientCount.Location = new System.Drawing.Point(15, 17);
            this.lblPatientCount.Name = "lblPatientCount";
            this.lblPatientCount.Size = new System.Drawing.Size(37, 45);
            this.lblPatientCount.TabIndex = 41;
            this.lblPatientCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Patiens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(196, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 43;
            this.label4.Text = "Sort By :";
            // 
            // cbSortBy
            // 
            this.cbSortBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSortBy.BorderRadius = 7;
            this.cbSortBy.BorderThickness = 0;
            this.cbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSortBy.ItemHeight = 41;
            this.cbSortBy.Items.AddRange(new object[] {
            "None",
            "Patient ID",
            "Person ID",
            "Full Name",
            "Assurance Number"});
            this.cbSortBy.Location = new System.Drawing.Point(286, 17);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(373, 47);
            this.cbSortBy.TabIndex = 44;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // tbSearchForPersonByName
            // 
            this.tbSearchForPersonByName.BorderRadius = 7;
            this.tbSearchForPersonByName.BorderThickness = 0;
            this.tbSearchForPersonByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchForPersonByName.DefaultText = "";
            this.tbSearchForPersonByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchForPersonByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchForPersonByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchForPersonByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchForPersonByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchForPersonByName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearchForPersonByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchForPersonByName.Location = new System.Drawing.Point(1076, 17);
            this.tbSearchForPersonByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchForPersonByName.Name = "tbSearchForPersonByName";
            this.tbSearchForPersonByName.PasswordChar = '\0';
            this.tbSearchForPersonByName.PlaceholderText = "Search by Name";
            this.tbSearchForPersonByName.SelectedText = "";
            this.tbSearchForPersonByName.Size = new System.Drawing.Size(408, 47);
            this.tbSearchForPersonByName.TabIndex = 45;
            this.tbSearchForPersonByName.TextOffset = new System.Drawing.Point(2, 0);
            this.tbSearchForPersonByName.TextChanged += new System.EventHandler(this.tbSearchForPersonByName_TextChanged);
            // 
            // dgvListPatients
            // 
            this.dgvListPatients.AllowUserToAddRows = false;
            this.dgvListPatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvListPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListPatients.ColumnHeadersHeight = 45;
            this.dgvListPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPatients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPatients.Location = new System.Drawing.Point(23, 91);
            this.dgvListPatients.Name = "dgvListPatients";
            this.dgvListPatients.ReadOnly = true;
            this.dgvListPatients.RowHeadersVisible = false;
            this.dgvListPatients.RowHeadersWidth = 62;
            this.dgvListPatients.RowTemplate.DividerHeight = 1;
            this.dgvListPatients.RowTemplate.Height = 45;
            this.dgvListPatients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPatients.Size = new System.Drawing.Size(1462, 622);
            this.dgvListPatients.TabIndex = 40;
            this.dgvListPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvListPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvListPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPatients.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvListPatients.ThemeStyle.ReadOnly = true;
            this.dgvListPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dgvListPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvListPatients.ThemeStyle.RowsStyle.Height = 45;
            this.dgvListPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgvListPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // cmsPatientsMenu
            // 
            this.cmsPatientsMenu.BackColor = System.Drawing.Color.White;
            this.cmsPatientsMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmsPatientsMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsPatientsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPatientInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.toolStripSeparator2,
            this.deletePersonToolStripMenuItem,
            this.toolStripSeparator3});
            this.cmsPatientsMenu.Name = "ContextMenuStripPeopleMenu";
            this.cmsPatientsMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsPatientsMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsPatientsMenu.RenderStyle.ColorTable = null;
            this.cmsPatientsMenu.RenderStyle.RoundedEdges = true;
            this.cmsPatientsMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsPatientsMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsPatientsMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsPatientsMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsPatientsMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsPatientsMenu.Size = new System.Drawing.Size(241, 158);
            // 
            // showPatientInfoToolStripMenuItem
            // 
            this.showPatientInfoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.showPatientInfoToolStripMenuItem.Name = "showPatientInfoToolStripMenuItem";
            this.showPatientInfoToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.showPatientInfoToolStripMenuItem.Text = "  Show Patient";
            this.showPatientInfoToolStripMenuItem.Click += new System.EventHandler(this.showPatientInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.addNewPersonToolStripMenuItem.Text = "  Add New Patient";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.editPersonToolStripMenuItem.Text = "  Edit Patient";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.deletePersonToolStripMenuItem.Text = "  Delete Patient";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(237, 6);
            // 
            // frmManagePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 769);
            this.ContextMenuStrip = this.cmsPatientsMenu;
            this.Controls.Add(this.lblPatientCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSortBy);
            this.Controls.Add(this.tbSearchForPersonByName);
            this.Controls.Add(this.dgvListPatients);
            this.Name = "frmManagePatient";
            this.Text = "Manage Patients";
            this.Load += new System.EventHandler(this.frmMaagePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatients)).EndInit();
            this.cmsPatientsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchForPersonByName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListPatients;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsPatientsMenu;
        private System.Windows.Forms.ToolStripMenuItem showPatientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}