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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctrlShowDoctorInfo1 = new Hospital_Presentation.Doctors.Controls.ctrlShowDoctorInfo();
            this.btnActiveAppointements = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDoctorAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnCompletedAppointments = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlShowDoctorInfo1
            // 
            this.ctrlShowDoctorInfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlShowDoctorInfo1.Name = "ctrlShowDoctorInfo1";
            this.ctrlShowDoctorInfo1.Size = new System.Drawing.Size(475, 581);
            this.ctrlShowDoctorInfo1.TabIndex = 0;
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
            this.lblTitle.Location = new System.Drawing.Point(514, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(132, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Appointments";
            // 
            // dgvDoctorAppointments
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvDoctorAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctorAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoctorAppointments.ColumnHeadersHeight = 4;
            this.dgvDoctorAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctorAppointments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoctorAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvDoctorAppointments.Location = new System.Drawing.Point(519, 173);
            this.dgvDoctorAppointments.Name = "dgvDoctorAppointments";
            this.dgvDoctorAppointments.RowHeadersVisible = false;
            this.dgvDoctorAppointments.RowHeadersWidth = 62;
            this.dgvDoctorAppointments.RowTemplate.Height = 28;
            this.dgvDoctorAppointments.Size = new System.Drawing.Size(644, 388);
            this.dgvDoctorAppointments.TabIndex = 6;
            this.dgvDoctorAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDoctorAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDoctorAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDoctorAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDoctorAppointments.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDoctorAppointments.ThemeStyle.ReadOnly = false;
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvDoctorAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.btnCompletedAppointments.Location = new System.Drawing.Point(883, 47);
            this.btnCompletedAppointments.Name = "btnCompletedAppointments";
            this.btnCompletedAppointments.Size = new System.Drawing.Size(266, 55);
            this.btnCompletedAppointments.TabIndex = 7;
            this.btnCompletedAppointments.Text = "Completed Appointments";
            this.btnCompletedAppointments.Click += new System.EventHandler(this.btnCompletedAppointments_Click);
            // 
            // ctrlDoctorInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCompletedAppointments);
            this.Controls.Add(this.dgvDoctorAppointments);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnActiveAppointements);
            this.Controls.Add(this.ctrlShowDoctorInfo1);
            this.Name = "ctrlDoctorInfoCard";
            this.Size = new System.Drawing.Size(1188, 592);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctorAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlShowDoctorInfo ctrlShowDoctorInfo1;
        private Guna.UI2.WinForms.Guna2Button btnActiveAppointements;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDoctorAppointments;
        private Guna.UI2.WinForms.Guna2Button btnCompletedAppointments;
    }
}
