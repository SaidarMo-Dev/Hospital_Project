namespace Hospital_Presentation.Employees
{
    partial class frmManageEmployees
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
			this.tbSearchForEmployee = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvListEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ContextMenuStripPeopleMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).BeginInit();
			this.ContextMenuStripPeopleMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblEmployeesCountCount
			// 
			this.lblEmployeesCountCount.AutoSize = true;
			this.lblEmployeesCountCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lblEmployeesCountCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblEmployeesCountCount.Location = new System.Drawing.Point(11, 12);
			this.lblEmployeesCountCount.Name = "lblEmployeesCountCount";
			this.lblEmployeesCountCount.Size = new System.Drawing.Size(37, 45);
			this.lblEmployeesCountCount.TabIndex = 42;
			this.lblEmployeesCountCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(63, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 30);
			this.label3.TabIndex = 43;
			this.label3.Text = "Emloyees";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(192, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 44;
			this.label4.Text = "Sort By :";
			// 
			// tbSearchForEmployee
			// 
			this.tbSearchForEmployee.BorderRadius = 7;
			this.tbSearchForEmployee.BorderThickness = 0;
			this.tbSearchForEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearchForEmployee.DefaultText = "";
			this.tbSearchForEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearchForEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearchForEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchForEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchForEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchForEmployee.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbSearchForEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchForEmployee.Location = new System.Drawing.Point(986, 12);
			this.tbSearchForEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSearchForEmployee.Name = "tbSearchForEmployee";
			this.tbSearchForEmployee.PasswordChar = '\0';
			this.tbSearchForEmployee.PlaceholderText = "Employee Name";
			this.tbSearchForEmployee.SelectedText = "";
			this.tbSearchForEmployee.Size = new System.Drawing.Size(426, 47);
			this.tbSearchForEmployee.TabIndex = 46;
			this.tbSearchForEmployee.TextOffset = new System.Drawing.Point(2, 0);
			this.tbSearchForEmployee.TextChanged += new System.EventHandler(this.tbSearchForEmployee_TextChanged);
			// 
			// dgvListEmployees
			// 
			this.dgvListEmployees.AllowUserToAddRows = false;
			this.dgvListEmployees.AllowUserToDeleteRows = false;
			this.dgvListEmployees.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvListEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListEmployees.ColumnHeadersHeight = 45;
			this.dgvListEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListEmployees.ContextMenuStrip = this.ContextMenuStripPeopleMenu;
			this.dgvListEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListEmployees.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListEmployees.Location = new System.Drawing.Point(18, 87);
			this.dgvListEmployees.Name = "dgvListEmployees";
			this.dgvListEmployees.ReadOnly = true;
			this.dgvListEmployees.RowHeadersVisible = false;
			this.dgvListEmployees.RowHeadersWidth = 62;
			this.dgvListEmployees.RowTemplate.DividerHeight = 1;
			this.dgvListEmployees.RowTemplate.Height = 45;
			this.dgvListEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListEmployees.Size = new System.Drawing.Size(1394, 578);
			this.dgvListEmployees.TabIndex = 40;
			this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvListEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvListEmployees.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvListEmployees.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListEmployees.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListEmployees.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListEmployees.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListEmployees.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListEmployees.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvListEmployees.ThemeStyle.ReadOnly = true;
			this.dgvListEmployees.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListEmployees.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListEmployees.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListEmployees.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvListEmployees.ThemeStyle.RowsStyle.Height = 45;
			this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvListEmployees.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// ContextMenuStripPeopleMenu
			// 
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
			this.ContextMenuStripPeopleMenu.Size = new System.Drawing.Size(285, 174);
			this.ContextMenuStripPeopleMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripPeopleMenu_Opening);
			// 
			// showPersonInfoToolStripMenuItem
			// 
			this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
			this.showPersonInfoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
			this.showPersonInfoToolStripMenuItem.Text = "  Show Employee Info";
			this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
			// 
			// addNewEmployeeToolStripMenuItem
			// 
			this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
			this.addNewEmployeeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
			this.addNewEmployeeToolStripMenuItem.Text = "  Add Employee";
			this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
			// 
			// editEmployeeToolStripMenuItem
			// 
			this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
			this.editEmployeeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
			this.editEmployeeToolStripMenuItem.Text = "  Edit Employee";
			this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
			// 
			// deletePersonToolStripMenuItem
			// 
			this.deletePersonToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancelRed;
			this.deletePersonToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
			this.deletePersonToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(284, 38);
			this.deletePersonToolStripMenuItem.Text = "  Delete Employee";
			this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(281, 6);
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
            "Employee Id",
            "Full Name",
            "Salary",
            "HireDate"});
			this.cbSortBy.Location = new System.Drawing.Point(282, 12);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 47);
			this.cbSortBy.TabIndex = 45;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(1228, 685);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(184, 49);
			this.btnClose.TabIndex = 41;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmManageEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(1424, 746);
			this.Controls.Add(this.lblEmployeesCountCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSearchForEmployee);
			this.Controls.Add(this.dgvListEmployees);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.btnClose);
			this.Name = "frmManageEmployees";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Manage Employees";
			this.Load += new System.EventHandler(this.frmManageEmployees_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListEmployees)).EndInit();
			this.ContextMenuStripPeopleMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeesCountCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchForEmployee;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListEmployees;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStripPeopleMenu;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}