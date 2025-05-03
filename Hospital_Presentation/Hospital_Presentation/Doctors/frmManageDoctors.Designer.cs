namespace Hospital_Presentation.Doctors
{
    partial class frmManageDoctors
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblEmployeesCountCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSearchByName = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvListDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ContextMenuStripPeopleMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListDoctors)).BeginInit();
			this.ContextMenuStripPeopleMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblEmployeesCountCount
			// 
			this.lblEmployeesCountCount.AutoSize = true;
			this.lblEmployeesCountCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lblEmployeesCountCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblEmployeesCountCount.Location = new System.Drawing.Point(8, 12);
			this.lblEmployeesCountCount.Name = "lblEmployeesCountCount";
			this.lblEmployeesCountCount.Size = new System.Drawing.Size(37, 45);
			this.lblEmployeesCountCount.TabIndex = 49;
			this.lblEmployeesCountCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(60, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 30);
			this.label3.TabIndex = 50;
			this.label3.Text = "Doctors";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(189, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 51;
			this.label4.Text = "Sort By :";
			// 
			// tbSearchByName
			// 
			this.tbSearchByName.BorderRadius = 7;
			this.tbSearchByName.BorderThickness = 0;
			this.tbSearchByName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearchByName.DefaultText = "";
			this.tbSearchByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearchByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearchByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbSearchByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByName.Location = new System.Drawing.Point(746, 12);
			this.tbSearchByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSearchByName.Name = "tbSearchByName";
			this.tbSearchByName.PasswordChar = '\0';
			this.tbSearchByName.PlaceholderText = "Doctor Name";
			this.tbSearchByName.SelectedText = "";
			this.tbSearchByName.Size = new System.Drawing.Size(463, 55);
			this.tbSearchByName.TabIndex = 53;
			this.tbSearchByName.TextOffset = new System.Drawing.Point(2, 0);
			this.tbSearchByName.TextChanged += new System.EventHandler(this.tbSearchForEmployee_TextChanged);
			// 
			// dgvListDoctors
			// 
			this.dgvListDoctors.AllowUserToAddRows = false;
			this.dgvListDoctors.AllowUserToDeleteRows = false;
			this.dgvListDoctors.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvListDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListDoctors.ColumnHeadersHeight = 45;
			this.dgvListDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListDoctors.ContextMenuStrip = this.ContextMenuStripPeopleMenu;
			this.dgvListDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListDoctors.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListDoctors.Location = new System.Drawing.Point(15, 87);
			this.dgvListDoctors.Name = "dgvListDoctors";
			this.dgvListDoctors.ReadOnly = true;
			this.dgvListDoctors.RowHeadersVisible = false;
			this.dgvListDoctors.RowHeadersWidth = 62;
			this.dgvListDoctors.RowTemplate.DividerHeight = 1;
			this.dgvListDoctors.RowTemplate.Height = 45;
			this.dgvListDoctors.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListDoctors.Size = new System.Drawing.Size(1394, 578);
			this.dgvListDoctors.TabIndex = 47;
			this.dgvListDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvListDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvListDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvListDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvListDoctors.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvListDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListDoctors.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvListDoctors.ThemeStyle.ReadOnly = true;
			this.dgvListDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvListDoctors.ThemeStyle.RowsStyle.Height = 45;
			this.dgvListDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvListDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// ContextMenuStripPeopleMenu
			// 
			this.ContextMenuStripPeopleMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ContextMenuStripPeopleMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.ContextMenuStripPeopleMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.ContextMenuStripPeopleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.toolStripSeparator2,
            this.deletePersonToolStripMenuItem,
            this.toolStripSeparator5});
			this.ContextMenuStripPeopleMenu.Name = "ContextMenuStripPeopleMenu";
			this.ContextMenuStripPeopleMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.ContextMenuStripPeopleMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.ContextMenuStripPeopleMenu.RenderStyle.ColorTable = null;
			this.ContextMenuStripPeopleMenu.RenderStyle.RoundedEdges = true;
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.ContextMenuStripPeopleMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.ContextMenuStripPeopleMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ContextMenuStripPeopleMenu.Size = new System.Drawing.Size(259, 223);
			// 
			// showPersonInfoToolStripMenuItem
			// 
			this.showPersonInfoToolStripMenuItem.AutoSize = false;
			this.showPersonInfoToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.showPersonInfoToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.info_black;
			this.showPersonInfoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
			this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(258, 42);
			this.showPersonInfoToolStripMenuItem.Text = "   Show Info";
			this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(255, 6);
			// 
			// addNewEmployeeToolStripMenuItem
			// 
			this.addNewEmployeeToolStripMenuItem.AutoSize = false;
			this.addNewEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.addNewEmployeeToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.AddBlue2;
			this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
			this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(258, 42);
			this.addNewEmployeeToolStripMenuItem.Text = "   Add New Doctor";
			this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
			// 
			// editEmployeeToolStripMenuItem
			// 
			this.editEmployeeToolStripMenuItem.AutoSize = false;
			this.editEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.editEmployeeToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.edit_blue;
			this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
			this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(258, 42);
			this.editEmployeeToolStripMenuItem.Text = "   Edit Doctor";
			this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(255, 6);
			// 
			// deletePersonToolStripMenuItem
			// 
			this.deletePersonToolStripMenuItem.AutoSize = false;
			this.deletePersonToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.deletePersonToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancelRed;
			this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
			this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(258, 42);
			this.deletePersonToolStripMenuItem.Text = "   Delete Doctor";
			this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(255, 6);
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
			this.cbSortBy.ItemHeight = 49;
			this.cbSortBy.Items.AddRange(new object[] {
            "None",
            "Doctor ID",
            "Full Name",
            "License Number",
            "Salary"});
			this.cbSortBy.Location = new System.Drawing.Point(294, 12);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 55);
			this.cbSortBy.TabIndex = 52;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
			// 
			// btnAddNewPerson
			// 
			this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
			this.btnAddNewPerson.BorderColor = System.Drawing.Color.LightGray;
			this.btnAddNewPerson.BorderRadius = 7;
			this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddNewPerson.FillColor = System.Drawing.Color.CornflowerBlue;
			this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
			this.btnAddNewPerson.Location = new System.Drawing.Point(1236, 12);
			this.btnAddNewPerson.Name = "btnAddNewPerson";
			this.btnAddNewPerson.Size = new System.Drawing.Size(172, 55);
			this.btnAddNewPerson.TabIndex = 54;
			this.btnAddNewPerson.Text = "Create Doctor";
			this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
			// 
			// frmManageDoctors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1420, 673);
			this.Controls.Add(this.btnAddNewPerson);
			this.Controls.Add(this.lblEmployeesCountCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSearchByName);
			this.Controls.Add(this.dgvListDoctors);
			this.Controls.Add(this.cbSortBy);
			this.Name = "frmManageDoctors";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmManageDoctors";
			this.Load += new System.EventHandler(this.frmManageDoctors_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListDoctors)).EndInit();
			this.ContextMenuStripPeopleMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeesCountCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchByName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListDoctors;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStripPeopleMenu;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
		private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
	}
}