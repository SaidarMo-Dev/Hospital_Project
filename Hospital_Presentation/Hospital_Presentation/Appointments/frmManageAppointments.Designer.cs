namespace Hospital_Presentation.Appointments
{
    partial class frmManageAppointments
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblPatientCount = new System.Windows.Forms.Label();
			this.lblappointment555 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dgvListAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
			this.cmsAppointmentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.showAppointmentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.takeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).BeginInit();
			this.cmsAppointmentMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPatientCount
			// 
			this.lblPatientCount.AutoSize = true;
			this.lblPatientCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lblPatientCount.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.lblPatientCount.Location = new System.Drawing.Point(13, 22);
			this.lblPatientCount.Name = "lblPatientCount";
			this.lblPatientCount.Size = new System.Drawing.Size(37, 45);
			this.lblPatientCount.TabIndex = 47;
			this.lblPatientCount.Text = "0";
			// 
			// lblappointment555
			// 
			this.lblappointment555.AutoSize = true;
			this.lblappointment555.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.lblappointment555.ForeColor = System.Drawing.Color.Black;
			this.lblappointment555.Location = new System.Drawing.Point(65, 31);
			this.lblappointment555.Name = "lblappointment555";
			this.lblappointment555.Size = new System.Drawing.Size(140, 30);
			this.lblappointment555.TabIndex = 48;
			this.lblappointment555.Text = "Appointment";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(273, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 49;
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
            "Appointment ID",
            "Patient ID",
            "Doctor ID",
            "Appointment Date"});
			this.cbSortBy.Location = new System.Drawing.Point(388, 22);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 47);
			this.cbSortBy.TabIndex = 50;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
			// 
			// dgvListAppointments
			// 
			this.dgvListAppointments.AllowUserToAddRows = false;
			this.dgvListAppointments.AllowUserToDeleteRows = false;
			this.dgvListAppointments.AllowUserToResizeColumns = false;
			this.dgvListAppointments.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvListAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListAppointments.ColumnHeadersHeight = 45;
			this.dgvListAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListAppointments.ContextMenuStrip = this.cmsAppointmentMenu;
			this.dgvListAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListAppointments.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListAppointments.Location = new System.Drawing.Point(21, 96);
			this.dgvListAppointments.Name = "dgvListAppointments";
			this.dgvListAppointments.ReadOnly = true;
			this.dgvListAppointments.RowHeadersVisible = false;
			this.dgvListAppointments.RowHeadersWidth = 62;
			this.dgvListAppointments.RowTemplate.DividerHeight = 1;
			this.dgvListAppointments.RowTemplate.Height = 45;
			this.dgvListAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListAppointments.Size = new System.Drawing.Size(1462, 622);
			this.dgvListAppointments.TabIndex = 46;
			this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvListAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvListAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvListAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvListAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvListAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvListAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvListAppointments.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvListAppointments.ThemeStyle.ReadOnly = true;
			this.dgvListAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvListAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvListAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvListAppointments.ThemeStyle.RowsStyle.Height = 45;
			this.dgvListAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvListAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// cmsAppointmentMenu
			// 
			this.cmsAppointmentMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.cmsAppointmentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppointmentInfoToolStripMenuItem,
            this.toolStripSeparator5,
            this.takeAppointmentToolStripMenuItem,
            this.toolStripSeparator6,
            this.addNewAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem,
            this.toolStripSeparator7,
            this.cancelAppointmentToolStripMenuItem,
            this.toolStripSeparator8,
            this.deleteAppointmentToolStripMenuItem});
			this.cmsAppointmentMenu.Name = "cmsAppointmentMenu";
			this.cmsAppointmentMenu.Size = new System.Drawing.Size(292, 280);
			this.cmsAppointmentMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(288, 6);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(288, 6);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(288, 6);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(288, 6);
			// 
			// btnFind
			// 
			this.btnFind.BorderRadius = 5;
			this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnFind.FillColor = System.Drawing.Color.LightSkyBlue;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFind.Location = new System.Drawing.Point(1270, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(213, 45);
			this.btnFind.TabIndex = 55;
			this.btnFind.Text = "Create Appointment";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// showAppointmentInfoToolStripMenuItem
			// 
			this.showAppointmentInfoToolStripMenuItem.AutoSize = false;
			this.showAppointmentInfoToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.info_black;
			this.showAppointmentInfoToolStripMenuItem.Name = "showAppointmentInfoToolStripMenuItem";
			this.showAppointmentInfoToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.showAppointmentInfoToolStripMenuItem.Text = "Show Appointment info";
			this.showAppointmentInfoToolStripMenuItem.Click += new System.EventHandler(this.showAppointmentInfoToolStripMenuItem_Click);
			// 
			// takeAppointmentToolStripMenuItem
			// 
			this.takeAppointmentToolStripMenuItem.AutoSize = false;
			this.takeAppointmentToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.takeAppointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MedicalRecordToolStripMenuItem,
            this.prescriptionToolStripMenuItem});
			this.takeAppointmentToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.take_appointment_blue;
			this.takeAppointmentToolStripMenuItem.Name = "takeAppointmentToolStripMenuItem";
			this.takeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.takeAppointmentToolStripMenuItem.Text = "Take Appointment";
			this.takeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.takeAppointmentToolStripMenuItem1_Click);
			// 
			// MedicalRecordToolStripMenuItem
			// 
			this.MedicalRecordToolStripMenuItem.AutoSize = false;
			this.MedicalRecordToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.MedicalRecordToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.medical_record_bluee;
			this.MedicalRecordToolStripMenuItem.Name = "MedicalRecordToolStripMenuItem";
			this.MedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
			this.MedicalRecordToolStripMenuItem.Text = "Medical Record";
			this.MedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.MedicalRecordToolStripMenuItem_Click);
			// 
			// prescriptionToolStripMenuItem
			// 
			this.prescriptionToolStripMenuItem.AutoSize = false;
			this.prescriptionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.prescriptionToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.prescriptions_white1;
			this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
			this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(270, 42);
			this.prescriptionToolStripMenuItem.Text = "Prescription";
			this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click_1);
			// 
			// addNewAppointmentToolStripMenuItem
			// 
			this.addNewAppointmentToolStripMenuItem.AutoSize = false;
			this.addNewAppointmentToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.AddBlue2;
			this.addNewAppointmentToolStripMenuItem.Name = "addNewAppointmentToolStripMenuItem";
			this.addNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.addNewAppointmentToolStripMenuItem.Text = "Add New Appointment";
			this.addNewAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addNewAppointmentToolStripMenuItem_Click_1);
			// 
			// editAppointmentToolStripMenuItem
			// 
			this.editAppointmentToolStripMenuItem.AutoSize = false;
			this.editAppointmentToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.edit_blue;
			this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
			this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.editAppointmentToolStripMenuItem.Text = "Edit Appointment";
			this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem_Click_1);
			// 
			// cancelAppointmentToolStripMenuItem
			// 
			this.cancelAppointmentToolStripMenuItem.AutoSize = false;
			this.cancelAppointmentToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancel_blue;
			this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
			this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
			this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem1_Click);
			// 
			// deleteAppointmentToolStripMenuItem
			// 
			this.deleteAppointmentToolStripMenuItem.AutoSize = false;
			this.deleteAppointmentToolStripMenuItem.Image = global::Hospital_Presentation.Properties.Resources.cancelRed;
			this.deleteAppointmentToolStripMenuItem.Name = "deleteAppointmentToolStripMenuItem";
			this.deleteAppointmentToolStripMenuItem.Size = new System.Drawing.Size(291, 42);
			this.deleteAppointmentToolStripMenuItem.Text = "Delete Appointment";
			this.deleteAppointmentToolStripMenuItem.Click += new System.EventHandler(this.deleteAppointmentToolStripMenuItem1_Click);
			// 
			// frmManageAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1495, 733);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lblPatientCount);
			this.Controls.Add(this.lblappointment555);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.dgvListAppointments);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmManageAppointments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.frmManageAppointments_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).EndInit();
			this.cmsAppointmentMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label lblappointment555;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListAppointments;
		private System.Windows.Forms.ContextMenuStrip cmsAppointmentMenu;
		private System.Windows.Forms.ToolStripMenuItem showAppointmentInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem takeAppointmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem addNewAppointmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem deleteAppointmentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MedicalRecordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2Button btnFind;
	}
}