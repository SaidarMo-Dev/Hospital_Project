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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPatientCount = new System.Windows.Forms.Label();
            this.lblappointment555 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvListAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsPatientsMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAppointments)).BeginInit();
            this.cmsPatientsMenu.SuspendLayout();
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
            // 
            // dgvListAppointments
            // 
            this.dgvListAppointments.AllowUserToAddRows = false;
            this.dgvListAppointments.AllowUserToDeleteRows = false;
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
            // cmsPatientsMenu
            // 
            this.cmsPatientsMenu.BackColor = System.Drawing.Color.White;
            this.cmsPatientsMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmsPatientsMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsPatientsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppointmentToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteAppointmentToolStripMenuItem,
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
            this.cmsPatientsMenu.Size = new System.Drawing.Size(298, 158);
            // 
            // showAppointmentToolStripMenuItem
            // 
            this.showAppointmentToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.showAppointmentToolStripMenuItem.Name = "showAppointmentToolStripMenuItem";
            this.showAppointmentToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.showAppointmentToolStripMenuItem.Text = "  Show Appointment";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(294, 6);
            // 
            // addNewAppointmentToolStripMenuItem
            // 
            this.addNewAppointmentToolStripMenuItem.Name = "addNewAppointmentToolStripMenuItem";
            this.addNewAppointmentToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.addNewAppointmentToolStripMenuItem.Text = "  Add New Appointment";
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.editAppointmentToolStripMenuItem.Text = "  Edit Appointment";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(294, 6);
            // 
            // deleteAppointmentToolStripMenuItem
            // 
            this.deleteAppointmentToolStripMenuItem.Name = "deleteAppointmentToolStripMenuItem";
            this.deleteAppointmentToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.deleteAppointmentToolStripMenuItem.Text = "  Delete Appointment";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(294, 6);
            // 
            // frmManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 733);
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
            this.cmsPatientsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label lblappointment555;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvListAppointments;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsPatientsMenu;
        private System.Windows.Forms.ToolStripMenuItem showAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}