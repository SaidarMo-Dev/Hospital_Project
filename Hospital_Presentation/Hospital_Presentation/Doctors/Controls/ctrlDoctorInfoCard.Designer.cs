namespace Hospital_Presentation.Doctors.Controls
{
    partial class ctrlDoctorInfoCard
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnActiveAppointements = new Guna.UI2.WinForms.Guna2Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnCompletedAppointments = new Guna.UI2.WinForms.Guna2Button();
			this.dgvDoctorAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
			this.ctrlShowDoctorInfo1 = new Hospital_Presentation.Doctors.Controls.ctrlShowDoctorInfo();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAppointments)).BeginInit();
			this.SuspendLayout();
			// 
			// btnActiveAppointements
			// 
			this.btnActiveAppointements.BorderRadius = 14;
			this.btnActiveAppointements.CheckedState.FillColor = System.Drawing.Color.SlateBlue;
			this.btnActiveAppointements.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnActiveAppointements.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnActiveAppointements.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnActiveAppointements.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnActiveAppointements.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnActiveAppointements.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnActiveAppointements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActiveAppointements.ForeColor = System.Drawing.Color.Gray;
			this.btnActiveAppointements.HoverState.FillColor = System.Drawing.Color.SlateBlue;
			this.btnActiveAppointements.HoverState.ForeColor = System.Drawing.Color.White;
			this.btnActiveAppointements.Location = new System.Drawing.Point(519, 47);
			this.btnActiveAppointements.Name = "btnActiveAppointements";
			this.btnActiveAppointements.Size = new System.Drawing.Size(266, 55);
			this.btnActiveAppointements.TabIndex = 3;
			this.btnActiveAppointements.Text = "Active Appointments";
			this.btnActiveAppointements.Click += new System.EventHandler(this.btnActiveAppointements_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Gray;
			this.lblTitle.Location = new System.Drawing.Point(500, 125);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(132, 25);
			this.lblTitle.TabIndex = 5;
			this.lblTitle.Text = "Appointments";
			// 
			// btnCompletedAppointments
			// 
			this.btnCompletedAppointments.BorderRadius = 14;
			this.btnCompletedAppointments.CheckedState.FillColor = System.Drawing.Color.SlateBlue;
			this.btnCompletedAppointments.CheckedState.ForeColor = System.Drawing.Color.White;
			this.btnCompletedAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCompletedAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCompletedAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCompletedAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCompletedAppointments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCompletedAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompletedAppointments.ForeColor = System.Drawing.Color.Gray;
			this.btnCompletedAppointments.HoverState.FillColor = System.Drawing.Color.SlateBlue;
			this.btnCompletedAppointments.HoverState.ForeColor = System.Drawing.Color.White;
			this.btnCompletedAppointments.Location = new System.Drawing.Point(1038, 47);
			this.btnCompletedAppointments.Name = "btnCompletedAppointments";
			this.btnCompletedAppointments.Size = new System.Drawing.Size(266, 55);
			this.btnCompletedAppointments.TabIndex = 7;
			this.btnCompletedAppointments.Text = "Completed Appointments";
			this.btnCompletedAppointments.Click += new System.EventHandler(this.btnCompletedAppointments_Click);
			// 
			// dgvDoctorAppointments
			// 
			this.dgvDoctorAppointments.AllowUserToAddRows = false;
			this.dgvDoctorAppointments.AllowUserToDeleteRows = false;
			this.dgvDoctorAppointments.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvDoctorAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDoctorAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDoctorAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDoctorAppointments.ColumnHeadersHeight = 45;
			this.dgvDoctorAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDoctorAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDoctorAppointments.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvDoctorAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoctorAppointments.Location = new System.Drawing.Point(500, 163);
			this.dgvDoctorAppointments.Name = "dgvDoctorAppointments";
			this.dgvDoctorAppointments.ReadOnly = true;
			this.dgvDoctorAppointments.RowHeadersVisible = false;
			this.dgvDoctorAppointments.RowHeadersWidth = 62;
			this.dgvDoctorAppointments.RowTemplate.DividerHeight = 1;
			this.dgvDoctorAppointments.RowTemplate.Height = 45;
			this.dgvDoctorAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDoctorAppointments.Size = new System.Drawing.Size(820, 411);
			this.dgvDoctorAppointments.TabIndex = 41;
			this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvDoctorAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoctorAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvDoctorAppointments.ThemeStyle.ReadOnly = true;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.Height = 45;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvDoctorAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// ctrlShowDoctorInfo1
			// 
			this.ctrlShowDoctorInfo1.Location = new System.Drawing.Point(3, 3);
			this.ctrlShowDoctorInfo1.Name = "ctrlShowDoctorInfo1";
			this.ctrlShowDoctorInfo1.Size = new System.Drawing.Size(475, 581);
			this.ctrlShowDoctorInfo1.TabIndex = 0;
			// 
			// ctrlDoctorInfoCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.dgvDoctorAppointments);
			this.Controls.Add(this.btnCompletedAppointments);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnActiveAppointements);
			this.Controls.Add(this.ctrlShowDoctorInfo1);
			this.Name = "ctrlDoctorInfoCard";
			this.Size = new System.Drawing.Size(1328, 592);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAppointments)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ctrlShowDoctorInfo ctrlShowDoctorInfo1;
        private Guna.UI2.WinForms.Guna2Button btnActiveAppointements;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCompletedAppointments;
		private Guna.UI2.WinForms.Guna2DataGridView dgvDoctorAppointments;
	}
}
