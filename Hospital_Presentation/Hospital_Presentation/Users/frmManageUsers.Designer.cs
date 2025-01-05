namespace Hospital_Presentation.Users
{
    partial class frmManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPeopleCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearchForPersonByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvListPeople = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ContextMenuStripUsersMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUsernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.ContextMenuStripUsersMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeopleCount
            // 
            this.lblPeopleCount.AutoSize = true;
            this.lblPeopleCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblPeopleCount.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPeopleCount.Location = new System.Drawing.Point(13, 12);
            this.lblPeopleCount.Name = "lblPeopleCount";
            this.lblPeopleCount.Size = new System.Drawing.Size(37, 45);
            this.lblPeopleCount.TabIndex = 42;
            this.lblPeopleCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(188, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 44;
            this.label4.Text = "Sort By :";
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
            this.tbSearchForPersonByName.Location = new System.Drawing.Point(741, 12);
            this.tbSearchForPersonByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchForPersonByName.Name = "tbSearchForPersonByName";
            this.tbSearchForPersonByName.PasswordChar = '\0';
            this.tbSearchForPersonByName.PlaceholderText = "Search by Username";
            this.tbSearchForPersonByName.SelectedText = "";
            this.tbSearchForPersonByName.Size = new System.Drawing.Size(408, 47);
            this.tbSearchForPersonByName.TabIndex = 46;
            this.tbSearchForPersonByName.TextOffset = new System.Drawing.Point(2, 0);
            this.tbSearchForPersonByName.TextChanged += new System.EventHandler(this.tbSearchForPersonByName_TextChanged);
            // 
            // dgvListPeople
            // 
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvListPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListPeople.ColumnHeadersHeight = 45;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPeople.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListPeople.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvListPeople.Location = new System.Drawing.Point(15, 86);
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListPeople.RowHeadersVisible = false;
            this.dgvListPeople.RowHeadersWidth = 62;
            this.dgvListPeople.RowTemplate.DividerHeight = 1;
            this.dgvListPeople.RowTemplate.Height = 45;
            this.dgvListPeople.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPeople.Size = new System.Drawing.Size(1134, 578);
            this.dgvListPeople.TabIndex = 40;
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
            this.dgvListPeople.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvListPeople.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
            "User ID",
            "Person ID",
            "Username"});
            this.cbSortBy.Location = new System.Drawing.Point(278, 12);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(373, 47);
            this.cbSortBy.TabIndex = 45;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1179, 690);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 49);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            // 
            // ContextMenuStripUsersMenu
            // 
            this.ContextMenuStripUsersMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ContextMenuStripUsersMenu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ContextMenuStripUsersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewUserToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteUsernToolStripMenuItem,
            this.toolStripSeparator5});
            this.ContextMenuStripUsersMenu.Name = "ContextMenuStripPeopleMenu";
            this.ContextMenuStripUsersMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ContextMenuStripUsersMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStripUsersMenu.RenderStyle.ColorTable = null;
            this.ContextMenuStripUsersMenu.RenderStyle.RoundedEdges = true;
            this.ContextMenuStripUsersMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.ContextMenuStripUsersMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ContextMenuStripUsersMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStripUsersMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.ContextMenuStripUsersMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStripUsersMenu.Size = new System.Drawing.Size(245, 174);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.editUserToolStripMenuItem.Text = "   Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(239, 6);
            // 
            // ShowUserToolStripMenuItem
            // 
            this.ShowUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ShowUserToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.info_black;
            this.ShowUserToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowUserToolStripMenuItem.Name = "ShowUserToolStripMenuItem";
            this.ShowUserToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.ShowUserToolStripMenuItem.Text = "   Show User Info";
            this.ShowUserToolStripMenuItem.Click += new System.EventHandler(this.ShowUserToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addNewUserToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.AddBlue2;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.addNewUserToolStripMenuItem.Text = "   Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteUsernToolStripMenuItem
            // 
            this.deleteUsernToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteUsernToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancelRed;
            this.deleteUsernToolStripMenuItem.Name = "deleteUsernToolStripMenuItem";
            this.deleteUsernToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.deleteUsernToolStripMenuItem.Text = "   Delete User";
            this.deleteUsernToolStripMenuItem.Click += new System.EventHandler(this.deleteUsernToolStripMenuItem_Click);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 687);
            this.ContextMenuStrip = this.ContextMenuStripUsersMenu;
            this.Controls.Add(this.lblPeopleCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSearchForPersonByName);
            this.Controls.Add(this.dgvListPeople);
            this.Controls.Add(this.cbSortBy);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.ContextMenuStripUsersMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeopleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchForPersonByName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListPeople;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip ContextMenuStripUsersMenu;
        private System.Windows.Forms.ToolStripMenuItem ShowUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteUsernToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}