namespace Hospital_Presentation.Prescriptions
{
	partial class frmAddPrescriptions
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
			this.tbMedicalName = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblPatientName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbSpecialInstractions = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.tbDosage = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbFrequency = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DateTimePickerStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.DateTimePickerEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.lblCreatedByUsername = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProviderValidations = new System.Windows.Forms.ErrorProvider(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.lblPrescriptionId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderValidations)).BeginInit();
			this.SuspendLayout();
			// 
			// tbMedicalName
			// 
			this.tbMedicalName.BorderRadius = 5;
			this.tbMedicalName.BorderThickness = 0;
			this.tbMedicalName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbMedicalName.DefaultText = "";
			this.tbMedicalName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbMedicalName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbMedicalName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMedicalName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbMedicalName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMedicalName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbMedicalName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbMedicalName.Location = new System.Drawing.Point(43, 167);
			this.tbMedicalName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbMedicalName.Multiline = true;
			this.tbMedicalName.Name = "tbMedicalName";
			this.tbMedicalName.PasswordChar = '\0';
			this.tbMedicalName.PlaceholderText = "";
			this.tbMedicalName.SelectedText = "";
			this.tbMedicalName.Size = new System.Drawing.Size(541, 44);
			this.tbMedicalName.TabIndex = 21;
			this.tbMedicalName.Validating += new System.ComponentModel.CancelEventHandler(this.tbMedicalName_Validating);
			// 
			// lblPatientName
			// 
			this.lblPatientName.AutoSize = true;
			this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblPatientName.ForeColor = System.Drawing.Color.Gray;
			this.lblPatientName.Location = new System.Drawing.Point(12, 24);
			this.lblPatientName.Name = "lblPatientName";
			this.lblPatientName.Size = new System.Drawing.Size(129, 28);
			this.lblPatientName.TabIndex = 20;
			this.lblPatientName.Text = "Patient Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(44, 490);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 25);
			this.label3.TabIndex = 17;
			this.label3.Text = "Special Instractions";
			// 
			// tbSpecialInstractions
			// 
			this.tbSpecialInstractions.BorderRadius = 5;
			this.tbSpecialInstractions.BorderThickness = 0;
			this.tbSpecialInstractions.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSpecialInstractions.DefaultText = "";
			this.tbSpecialInstractions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSpecialInstractions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSpecialInstractions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSpecialInstractions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSpecialInstractions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSpecialInstractions.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbSpecialInstractions.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSpecialInstractions.Location = new System.Drawing.Point(43, 523);
			this.tbSpecialInstractions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSpecialInstractions.Multiline = true;
			this.tbSpecialInstractions.Name = "tbSpecialInstractions";
			this.tbSpecialInstractions.PasswordChar = '\0';
			this.tbSpecialInstractions.PlaceholderText = "";
			this.tbSpecialInstractions.SelectedText = "";
			this.tbSpecialInstractions.Size = new System.Drawing.Size(541, 122);
			this.tbSpecialInstractions.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(38, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Medical Name";
			// 
			// btnSave
			// 
			this.btnSave.BorderRadius = 5;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(417, 710);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(167, 45);
			this.btnSave.TabIndex = 23;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbDosage
			// 
			this.tbDosage.BorderRadius = 5;
			this.tbDosage.BorderThickness = 0;
			this.tbDosage.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDosage.DefaultText = "";
			this.tbDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDosage.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDosage.Location = new System.Drawing.Point(43, 250);
			this.tbDosage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDosage.Multiline = true;
			this.tbDosage.Name = "tbDosage";
			this.tbDosage.PasswordChar = '\0';
			this.tbDosage.PlaceholderText = "";
			this.tbDosage.SelectedText = "";
			this.tbDosage.Size = new System.Drawing.Size(541, 44);
			this.tbDosage.TabIndex = 25;
			this.tbDosage.Validating += new System.ComponentModel.CancelEventHandler(this.tbDosage_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Gray;
			this.label5.Location = new System.Drawing.Point(38, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 25);
			this.label5.TabIndex = 24;
			this.label5.Text = "Dosage";
			// 
			// tbFrequency
			// 
			this.tbFrequency.BorderRadius = 5;
			this.tbFrequency.BorderThickness = 0;
			this.tbFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFrequency.DefaultText = "";
			this.tbFrequency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFrequency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFrequency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFrequency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFrequency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFrequency.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbFrequency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFrequency.Location = new System.Drawing.Point(43, 333);
			this.tbFrequency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbFrequency.Multiline = true;
			this.tbFrequency.Name = "tbFrequency";
			this.tbFrequency.PasswordChar = '\0';
			this.tbFrequency.PlaceholderText = "";
			this.tbFrequency.SelectedText = "";
			this.tbFrequency.Size = new System.Drawing.Size(541, 44);
			this.tbFrequency.TabIndex = 27;
			this.tbFrequency.Validating += new System.ComponentModel.CancelEventHandler(this.tbFrequency_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Gray;
			this.label6.Location = new System.Drawing.Point(38, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 25);
			this.label6.TabIndex = 26;
			this.label6.Text = "Frequency";
			// 
			// DateTimePickerStartDate
			// 
			this.DateTimePickerStartDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DateTimePickerStartDate.BorderRadius = 5;
			this.DateTimePickerStartDate.Checked = true;
			this.DateTimePickerStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DateTimePickerStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.DateTimePickerStartDate.Location = new System.Drawing.Point(43, 431);
			this.DateTimePickerStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.DateTimePickerStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.DateTimePickerStartDate.Name = "DateTimePickerStartDate";
			this.DateTimePickerStartDate.Size = new System.Drawing.Size(263, 42);
			this.DateTimePickerStartDate.TabIndex = 28;
			this.DateTimePickerStartDate.Value = new System.DateTime(2025, 1, 26, 19, 59, 44, 697);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(41, 392);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 25);
			this.label4.TabIndex = 29;
			this.label4.Text = "Start Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Gray;
			this.label7.Location = new System.Drawing.Point(300, 391);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 25);
			this.label7.TabIndex = 31;
			this.label7.Text = "End Date";
			// 
			// DateTimePickerEndDate
			// 
			this.DateTimePickerEndDate.BorderRadius = 5;
			this.DateTimePickerEndDate.Checked = true;
			this.DateTimePickerEndDate.CustomFormat = "";
			this.DateTimePickerEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.DateTimePickerEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.DateTimePickerEndDate.Location = new System.Drawing.Point(322, 429);
			this.DateTimePickerEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.DateTimePickerEndDate.MinDate = new System.DateTime(2025, 1, 26, 0, 0, 0, 0);
			this.DateTimePickerEndDate.Name = "DateTimePickerEndDate";
			this.DateTimePickerEndDate.Size = new System.Drawing.Size(263, 42);
			this.DateTimePickerEndDate.TabIndex = 30;
			this.DateTimePickerEndDate.Value = new System.DateTime(2025, 1, 26, 19, 59, 44, 697);
			// 
			// lblCreatedByUsername
			// 
			this.lblCreatedByUsername.AutoSize = true;
			this.lblCreatedByUsername.Font = new System.Drawing.Font("Segoe UI", 9.25F);
			this.lblCreatedByUsername.ForeColor = System.Drawing.Color.Black;
			this.lblCreatedByUsername.Location = new System.Drawing.Point(161, 676);
			this.lblCreatedByUsername.Name = "lblCreatedByUsername";
			this.lblCreatedByUsername.Size = new System.Drawing.Size(97, 25);
			this.lblCreatedByUsername.TabIndex = 33;
			this.lblCreatedByUsername.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(40, 675);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 25);
			this.label2.TabIndex = 32;
			this.label2.Text = "Created By ";
			// 
			// errorProviderValidations
			// 
			this.errorProviderValidations.ContainerControl = this;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(38, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 25);
			this.label8.TabIndex = 34;
			this.label8.Text = "Prescription ID ";
			// 
			// lblPrescriptionId
			// 
			this.lblPrescriptionId.AutoSize = true;
			this.lblPrescriptionId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrescriptionId.ForeColor = System.Drawing.Color.Black;
			this.lblPrescriptionId.Location = new System.Drawing.Point(181, 88);
			this.lblPrescriptionId.Name = "lblPrescriptionId";
			this.lblPrescriptionId.Size = new System.Drawing.Size(54, 25);
			this.lblPrescriptionId.TabIndex = 35;
			this.lblPrescriptionId.Text = "[????]";
			// 
			// frmAddPrescriptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 776);
			this.Controls.Add(this.lblPrescriptionId);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblCreatedByUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.DateTimePickerEndDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DateTimePickerStartDate);
			this.Controls.Add(this.tbFrequency);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbDosage);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbMedicalName);
			this.Controls.Add(this.lblPatientName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSpecialInstractions);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmAddPrescriptions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmAddPrescriptions";
			this.Load += new System.EventHandler(this.frmAddPrescriptions_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderValidations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2TextBox tbMedicalName;
		private System.Windows.Forms.Label lblPatientName;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbSpecialInstractions;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2TextBox tbDosage;
		private System.Windows.Forms.Label label5;
		private Guna.UI2.WinForms.Guna2TextBox tbFrequency;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerStartDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerEndDate;
		private System.Windows.Forms.Label lblCreatedByUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ErrorProvider errorProviderValidations;
		private System.Windows.Forms.Label lblPrescriptionId;
		private System.Windows.Forms.Label label8;
	}
}