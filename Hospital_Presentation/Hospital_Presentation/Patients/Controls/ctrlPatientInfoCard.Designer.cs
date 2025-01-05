namespace Hospital_Presentation.Patients.Controls
{
    partial class ctrlPatientInfoCard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPatientRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnMedicalRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrescriptions = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPatientInfo1 = new Hospital_Presentation.Patients.Controls.ctrlPatientInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.Controls.Add(this.dgvPatientRecords);
            this.guna2Panel1.Controls.Add(this.btnMedicalRecords);
            this.guna2Panel1.Controls.Add(this.btnPrescriptions);
            this.guna2Panel1.Location = new System.Drawing.Point(492, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(911, 604);
            this.guna2Panel1.TabIndex = 5;
            // 
            // dgvPatientRecords
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvPatientRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientRecords.ColumnHeadersHeight = 4;
            this.dgvPatientRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatientRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvPatientRecords.Location = new System.Drawing.Point(14, 149);
            this.dgvPatientRecords.Name = "dgvPatientRecords";
            this.dgvPatientRecords.RowHeadersVisible = false;
            this.dgvPatientRecords.RowHeadersWidth = 62;
            this.dgvPatientRecords.RowTemplate.Height = 28;
            this.dgvPatientRecords.Size = new System.Drawing.Size(858, 443);
            this.dgvPatientRecords.TabIndex = 3;
            this.dgvPatientRecords.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgvPatientRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvPatientRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPatientRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPatientRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPatientRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPatientRecords.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPatientRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPatientRecords.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPatientRecords.ThemeStyle.ReadOnly = false;
            this.dgvPatientRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvPatientRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPatientRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatientRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPatientRecords.ThemeStyle.RowsStyle.Height = 28;
            this.dgvPatientRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvPatientRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnMedicalRecords
            // 
            this.btnMedicalRecords.BorderRadius = 14;
            this.btnMedicalRecords.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicalRecords.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicalRecords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicalRecords.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalRecords.ForeColor = System.Drawing.Color.Gray;
            this.btnMedicalRecords.Location = new System.Drawing.Point(528, 30);
            this.btnMedicalRecords.Name = "btnMedicalRecords";
            this.btnMedicalRecords.Size = new System.Drawing.Size(335, 55);
            this.btnMedicalRecords.TabIndex = 2;
            this.btnMedicalRecords.Text = "Medical Records";
            this.btnMedicalRecords.Click += new System.EventHandler(this.btnMedicalRecords_Click);
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.BorderRadius = 14;
            this.btnPrescriptions.CheckedState.FillColor = System.Drawing.Color.SlateBlue;
            this.btnPrescriptions.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPrescriptions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescriptions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrescriptions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrescriptions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrescriptions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescriptions.ForeColor = System.Drawing.Color.Gray;
            this.btnPrescriptions.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.btnPrescriptions.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrescriptions.Location = new System.Drawing.Point(83, 30);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(342, 55);
            this.btnPrescriptions.TabIndex = 1;
            this.btnPrescriptions.Text = "Prescriptions";
            this.btnPrescriptions.Click += new System.EventHandler(this.btnPrescriptions_Click);
            // 
            // ctrlPatientInfo1
            // 
            this.ctrlPatientInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPatientInfo1.Location = new System.Drawing.Point(11, 15);
            this.ctrlPatientInfo1.Name = "ctrlPatientInfo1";
            this.ctrlPatientInfo1.Size = new System.Drawing.Size(467, 604);
            this.ctrlPatientInfo1.TabIndex = 3;
            this.ctrlPatientInfo1.Load += new System.EventHandler(this.ctrlPatientInfo1_Load);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(36, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Patient Prescriptions";
            // 
            // ctrlPatientInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ctrlPatientInfo1);
            this.Name = "ctrlPatientInfoCard";
            this.Size = new System.Drawing.Size(1414, 632);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPatientRecords;
        private Guna.UI2.WinForms.Guna2Button btnMedicalRecords;
        private Guna.UI2.WinForms.Guna2Button btnPrescriptions;
        private ctrlPatientInfo ctrlPatientInfo1;
        private System.Windows.Forms.Label lblTitle;
    }
}
