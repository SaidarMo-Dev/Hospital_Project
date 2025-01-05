namespace Hospital_Presentation.Appointments
{
    partial class frmAddUpdateAppointment
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PageDoctorInfo = new System.Windows.Forms.TabPage();
            this.btnFindDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchByDoctorID = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlShowDoctorInfo1 = new Hospital_Presentation.Doctors.Controls.ctrlShowDoctorInfo();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PagePatientInfo = new System.Windows.Forms.TabPage();
            this.btnFindPatient = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchByPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlPatientInfo1 = new Hospital_Presentation.Patients.Controls.ctrlPatientInfo();
            this.TabControlAppointmentInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.PageDoctorInfo.SuspendLayout();
            this.PagePatientInfo.SuspendLayout();
            this.TabControlAppointmentInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PageDoctorInfo
            // 
            this.PageDoctorInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PageDoctorInfo.Controls.Add(this.btnFindDoctor);
            this.PageDoctorInfo.Controls.Add(this.txtSearchByDoctorID);
            this.PageDoctorInfo.Controls.Add(this.ctrlShowDoctorInfo1);
            this.PageDoctorInfo.Controls.Add(this.guna2Button1);
            this.PageDoctorInfo.Location = new System.Drawing.Point(184, 4);
            this.PageDoctorInfo.Name = "PageDoctorInfo";
            this.PageDoctorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PageDoctorInfo.Size = new System.Drawing.Size(1100, 690);
            this.PageDoctorInfo.TabIndex = 1;
            this.PageDoctorInfo.Text = "Doctor Info";
            // 
            // btnFindDoctor
            // 
            this.btnFindDoctor.BorderRadius = 10;
            this.btnFindDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindDoctor.FillColor = System.Drawing.Color.White;
            this.btnFindDoctor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindDoctor.ForeColor = System.Drawing.Color.DimGray;
            this.btnFindDoctor.Location = new System.Drawing.Point(973, 28);
            this.btnFindDoctor.Name = "btnFindDoctor";
            this.btnFindDoctor.Size = new System.Drawing.Size(101, 59);
            this.btnFindDoctor.TabIndex = 44;
            this.btnFindDoctor.Text = "Find";
            this.btnFindDoctor.Click += new System.EventHandler(this.btnFindDoctor_Click);
            // 
            // txtSearchByDoctorID
            // 
            this.txtSearchByDoctorID.BorderRadius = 15;
            this.txtSearchByDoctorID.BorderThickness = 0;
            this.txtSearchByDoctorID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByDoctorID.DefaultText = "";
            this.txtSearchByDoctorID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByDoctorID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByDoctorID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByDoctorID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByDoctorID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByDoctorID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByDoctorID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchByDoctorID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByDoctorID.Location = new System.Drawing.Point(513, 28);
            this.txtSearchByDoctorID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchByDoctorID.Name = "txtSearchByDoctorID";
            this.txtSearchByDoctorID.PasswordChar = '\0';
            this.txtSearchByDoctorID.PlaceholderText = "Doctor ID";
            this.txtSearchByDoctorID.SelectedText = "";
            this.txtSearchByDoctorID.Size = new System.Drawing.Size(453, 59);
            this.txtSearchByDoctorID.TabIndex = 43;
            this.txtSearchByDoctorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByDoctorID_KeyPress);
            // 
            // ctrlShowDoctorInfo1
            // 
            this.ctrlShowDoctorInfo1.Location = new System.Drawing.Point(25, 15);
            this.ctrlShowDoctorInfo1.Name = "ctrlShowDoctorInfo1";
            this.ctrlShowDoctorInfo1.Size = new System.Drawing.Size(475, 581);
            this.ctrlShowDoctorInfo1.TabIndex = 42;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(36, 611);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(206, 54);
            this.guna2Button1.TabIndex = 41;
            this.guna2Button1.Text = "Back";
            // 
            // PagePatientInfo
            // 
            this.PagePatientInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PagePatientInfo.Controls.Add(this.btnFindPatient);
            this.PagePatientInfo.Controls.Add(this.txtSearchByPatientID);
            this.PagePatientInfo.Controls.Add(this.ctrlPatientInfo1);
            this.PagePatientInfo.Location = new System.Drawing.Point(184, 4);
            this.PagePatientInfo.Name = "PagePatientInfo";
            this.PagePatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PagePatientInfo.Size = new System.Drawing.Size(1100, 690);
            this.PagePatientInfo.TabIndex = 0;
            this.PagePatientInfo.Text = "Patient Info";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.BorderRadius = 10;
            this.btnFindPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindPatient.FillColor = System.Drawing.Color.White;
            this.btnFindPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPatient.ForeColor = System.Drawing.Color.DimGray;
            this.btnFindPatient.Location = new System.Drawing.Point(971, 35);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(111, 59);
            this.btnFindPatient.TabIndex = 4;
            this.btnFindPatient.Text = "Find";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // txtSearchByPatientID
            // 
            this.txtSearchByPatientID.BorderRadius = 15;
            this.txtSearchByPatientID.BorderThickness = 0;
            this.txtSearchByPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByPatientID.DefaultText = "";
            this.txtSearchByPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByPatientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByPatientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByPatientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByPatientID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPatientID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchByPatientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByPatientID.Location = new System.Drawing.Point(495, 35);
            this.txtSearchByPatientID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchByPatientID.Name = "txtSearchByPatientID";
            this.txtSearchByPatientID.PasswordChar = '\0';
            this.txtSearchByPatientID.PlaceholderText = "PatientID";
            this.txtSearchByPatientID.SelectedText = "";
            this.txtSearchByPatientID.Size = new System.Drawing.Size(469, 59);
            this.txtSearchByPatientID.TabIndex = 3;
            this.txtSearchByPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByPatientID_KeyPress);
            // 
            // ctrlPatientInfo1
            // 
            this.ctrlPatientInfo1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPatientInfo1.Location = new System.Drawing.Point(28, 26);
            this.ctrlPatientInfo1.Name = "ctrlPatientInfo1";
            this.ctrlPatientInfo1.Size = new System.Drawing.Size(445, 604);
            this.ctrlPatientInfo1.TabIndex = 0;
            // 
            // TabControlAppointmentInfo
            // 
            this.TabControlAppointmentInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControlAppointmentInfo.Controls.Add(this.PagePatientInfo);
            this.TabControlAppointmentInfo.Controls.Add(this.PageDoctorInfo);
            this.TabControlAppointmentInfo.Controls.Add(this.tabPage1);
            this.TabControlAppointmentInfo.ItemSize = new System.Drawing.Size(180, 48);
            this.TabControlAppointmentInfo.Location = new System.Drawing.Point(12, 12);
            this.TabControlAppointmentInfo.Name = "TabControlAppointmentInfo";
            this.TabControlAppointmentInfo.SelectedIndex = 0;
            this.TabControlAppointmentInfo.Size = new System.Drawing.Size(1288, 698);
            this.TabControlAppointmentInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlAppointmentInfo.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.TabControlAppointmentInfo.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlAppointmentInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlAppointmentInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.Gray;
            this.TabControlAppointmentInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlAppointmentInfo.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.TabControlAppointmentInfo.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlAppointmentInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlAppointmentInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.TabControlAppointmentInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlAppointmentInfo.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.TabControlAppointmentInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlAppointmentInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.DimGray;
            this.TabControlAppointmentInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.LightSeaGreen;
            this.TabControlAppointmentInfo.TabButtonSize = new System.Drawing.Size(180, 48);
            this.TabControlAppointmentInfo.TabIndex = 2;
            this.TabControlAppointmentInfo.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblAppointmentID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePickerAppointmentDate);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1100, 690);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Appointment Info";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 5;
            this.txtNotes.BorderThickness = 0;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNotes.Location = new System.Drawing.Point(90, 272);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "Notes...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(582, 98);
            this.txtNotes.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(85, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(85, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Appointment Date";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerAppointmentDate.BorderRadius = 5;
            this.dateTimePickerAppointmentDate.Checked = true;
            this.dateTimePickerAppointmentDate.FillColor = System.Drawing.Color.LightBlue;
            this.dateTimePickerAppointmentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(90, 162);
            this.dateTimePickerAppointmentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAppointmentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(326, 45);
            this.dateTimePickerAppointmentDate.TabIndex = 42;
            this.dateTimePickerAppointmentDate.Value = new System.DateTime(2024, 12, 31, 15, 25, 46, 157);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(880, 628);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 47);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(85, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Appointment ID:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAppointmentID.Location = new System.Drawing.Point(271, 48);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(54, 25);
            this.lblAppointmentID.TabIndex = 48;
            this.lblAppointmentID.Text = "[????]";
            // 
            // frmAddUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 722);
            this.Controls.Add(this.TabControlAppointmentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateAppointment";
            this.Load += new System.EventHandler(this.frmAddUpdateAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.PageDoctorInfo.ResumeLayout(false);
            this.PagePatientInfo.ResumeLayout(false);
            this.TabControlAppointmentInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl TabControlAppointmentInfo;
        private System.Windows.Forms.TabPage PagePatientInfo;
        private Guna.UI2.WinForms.Guna2Button btnFindPatient;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByPatientID;
        private Patients.Controls.ctrlPatientInfo ctrlPatientInfo1;
        private System.Windows.Forms.TabPage PageDoctorInfo;
        private Guna.UI2.WinForms.Guna2Button btnFindDoctor;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByDoctorID;
        private Doctors.Controls.ctrlShowDoctorInfo ctrlShowDoctorInfo1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerAppointmentDate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label3;
    }
}