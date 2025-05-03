namespace Hospital_Presentation.People
{
    partial class frmManagePeople
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
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.ContextMenuStripPeopleMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.dgvListPeople = new Guna.UI2.WinForms.Guna2DataGridView();
			this.lblPeopleCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tbSearchForPersonByName = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
			this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuStripPeopleMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(1196, 703);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(184, 49);
			this.btnClose.TabIndex = 34;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// callPhoneToolStripMenuItem
			// 
			this.callPhoneToolStripMenuItem.AutoSize = false;
			this.callPhoneToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.callPhoneToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.call_phone_blue;
			this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
			this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.callPhoneToolStripMenuItem.Text = "  Call Phone";
			this.callPhoneToolStripMenuItem.Click += new System.EventHandler(this.callPhoneToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(253, 6);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(253, 6);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(253, 6);
			// 
			// ContextMenuStripPeopleMenu
			// 
			this.ContextMenuStripPeopleMenu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ContextMenuStripPeopleMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.ContextMenuStripPeopleMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.ContextMenuStripPeopleMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.toolStripSeparator2,
            this.deletePersonToolStripMenuItem,
            this.toolStripSeparator3,
            this.sendEmailToolStripMenuItem,
            this.toolStripSeparator4,
            this.callPhoneToolStripMenuItem,
            this.toolStripSeparator5});
			this.ContextMenuStripPeopleMenu.Name = "ContextMenuStripPeopleMenu";
			this.ContextMenuStripPeopleMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.ContextMenuStripPeopleMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.ContextMenuStripPeopleMenu.RenderStyle.ColorTable = null;
			this.ContextMenuStripPeopleMenu.RenderStyle.RoundedEdges = true;
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.Gainsboro;
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.ContextMenuStripPeopleMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.ContextMenuStripPeopleMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.ContextMenuStripPeopleMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ContextMenuStripPeopleMenu.Size = new System.Drawing.Size(257, 286);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
			// 
			// dgvListPeople
			// 
			this.dgvListPeople.AllowUserToAddRows = false;
			this.dgvListPeople.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvListPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListPeople.ColumnHeadersHeight = 45;
			this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListPeople.ContextMenuStrip = this.ContextMenuStripPeopleMenu;
			this.dgvListPeople.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListPeople.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListPeople.Location = new System.Drawing.Point(32, 99);
			this.dgvListPeople.Name = "dgvListPeople";
			this.dgvListPeople.ReadOnly = true;
			this.dgvListPeople.RowHeadersVisible = false;
			this.dgvListPeople.RowHeadersWidth = 62;
			this.dgvListPeople.RowTemplate.DividerHeight = 1;
			this.dgvListPeople.RowTemplate.Height = 45;
			this.dgvListPeople.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListPeople.Size = new System.Drawing.Size(1350, 578);
			this.dgvListPeople.TabIndex = 12;
			this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvListPeople.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvListPeople.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvListPeople.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListPeople.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListPeople.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListPeople.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListPeople.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListPeople.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListPeople.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvListPeople.ThemeStyle.ReadOnly = true;
			this.dgvListPeople.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListPeople.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListPeople.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListPeople.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvListPeople.ThemeStyle.RowsStyle.Height = 45;
			this.dgvListPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvListPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// lblPeopleCount
			// 
			this.lblPeopleCount.AutoSize = true;
			this.lblPeopleCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lblPeopleCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblPeopleCount.Location = new System.Drawing.Point(24, 25);
			this.lblPeopleCount.Name = "lblPeopleCount";
			this.lblPeopleCount.Size = new System.Drawing.Size(37, 45);
			this.lblPeopleCount.TabIndex = 35;
			this.lblPeopleCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(76, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 30);
			this.label3.TabIndex = 36;
			this.label3.Text = "Persons";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(193, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 37;
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
			this.cbSortBy.ItemHeight = 49;
			this.cbSortBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "First Name",
            "Last Name"});
			this.cbSortBy.Location = new System.Drawing.Point(295, 25);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 55);
			this.cbSortBy.TabIndex = 38;
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
			this.tbSearchForPersonByName.Location = new System.Drawing.Point(745, 25);
			this.tbSearchForPersonByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSearchForPersonByName.Name = "tbSearchForPersonByName";
			this.tbSearchForPersonByName.PasswordChar = '\0';
			this.tbSearchForPersonByName.PlaceholderText = "Search by Name";
			this.tbSearchForPersonByName.SelectedText = "";
			this.tbSearchForPersonByName.Size = new System.Drawing.Size(408, 55);
			this.tbSearchForPersonByName.TabIndex = 39;
			this.tbSearchForPersonByName.TextOffset = new System.Drawing.Point(2, 0);
			this.tbSearchForPersonByName.TextChanged += new System.EventHandler(this.tbSearchForPersonByName_TextChanged);
			// 
			// btnAddNewPerson
			// 
			this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
			this.btnAddNewPerson.BorderColor = System.Drawing.Color.LightGray;
			this.btnAddNewPerson.BorderRadius = 15;
			this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddNewPerson.FillColor = System.Drawing.Color.CornflowerBlue;
			this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
			this.btnAddNewPerson.Location = new System.Drawing.Point(1196, 25);
			this.btnAddNewPerson.Name = "btnAddNewPerson";
			this.btnAddNewPerson.Size = new System.Drawing.Size(172, 55);
			this.btnAddNewPerson.TabIndex = 40;
			this.btnAddNewPerson.Text = "Create Person";
			this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
			// 
			// showPersonInfoToolStripMenuItem
			// 
			this.showPersonInfoToolStripMenuItem.AutoSize = false;
			this.showPersonInfoToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.showPersonInfoToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.info_black;
			this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
			this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.showPersonInfoToolStripMenuItem.Text = "  Show Person Info";
			this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
			// 
			// addNewPersonToolStripMenuItem
			// 
			this.addNewPersonToolStripMenuItem.AutoSize = false;
			this.addNewPersonToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.addNewPersonToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.AddBlue21;
			this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
			this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.addNewPersonToolStripMenuItem.Text = "  Add New Person";
			this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
			// 
			// editPersonToolStripMenuItem
			// 
			this.editPersonToolStripMenuItem.AutoSize = false;
			this.editPersonToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.editPersonToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.edit_blue;
			this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
			this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.editPersonToolStripMenuItem.Text = "  Edit Person";
			this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
			// 
			// deletePersonToolStripMenuItem
			// 
			this.deletePersonToolStripMenuItem.AutoSize = false;
			this.deletePersonToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.deletePersonToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancelRed;
			this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
			this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.deletePersonToolStripMenuItem.Text = "  Delete Person";
			this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
			// 
			// sendEmailToolStripMenuItem
			// 
			this.sendEmailToolStripMenuItem.AutoSize = false;
			this.sendEmailToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
			this.sendEmailToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.send_email_white;
			this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
			this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(256, 42);
			this.sendEmailToolStripMenuItem.Text = "  Send Email";
			this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
			// 
			// frmManagePeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1393, 764);
			this.Controls.Add(this.btnAddNewPerson);
			this.Controls.Add(this.lblPeopleCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.tbSearchForPersonByName);
			this.Controls.Add(this.dgvListPeople);
			this.Controls.Add(this.btnClose);
			this.Name = "frmManagePeople";
			this.Text = "frmManagePeople";
			this.Load += new System.EventHandler(this.frmManagePeople_Load);
			this.ContextMenuStripPeopleMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStripPeopleMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListPeople;
        private System.Windows.Forms.Label lblPeopleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchForPersonByName;
		private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}