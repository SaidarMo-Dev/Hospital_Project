namespace Hospital_Presentation.MedicalRecords
{
	partial class frmMedicalRecord
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbAdditionalNotes = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCreatedByUsername = new System.Windows.Forms.Label();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tbVisitdescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbDiagnosiss = new Guna.UI2.WinForms.Guna2TextBox();
			this.lblMedicalRecordId = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblPatientName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(44, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Visit Description";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(44, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Diagnosis";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(44, 381);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Notes";
			// 
			// tbAdditionalNotes
			// 
			this.tbAdditionalNotes.BorderRadius = 5;
			this.tbAdditionalNotes.BorderThickness = 0;
			this.tbAdditionalNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAdditionalNotes.DefaultText = "";
			this.tbAdditionalNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAdditionalNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbAdditionalNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdditionalNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdditionalNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdditionalNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbAdditionalNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdditionalNotes.Location = new System.Drawing.Point(48, 420);
			this.tbAdditionalNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbAdditionalNotes.Multiline = true;
			this.tbAdditionalNotes.Name = "tbAdditionalNotes";
			this.tbAdditionalNotes.PasswordChar = '\0';
			this.tbAdditionalNotes.PlaceholderText = "";
			this.tbAdditionalNotes.SelectedText = "";
			this.tbAdditionalNotes.Size = new System.Drawing.Size(497, 96);
			this.tbAdditionalNotes.TabIndex = 4;
			this.tbAdditionalNotes.TextChanged += new System.EventHandler(this.tbAdditionalNotes_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Gray;
			this.label4.Location = new System.Drawing.Point(52, 570);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Created By ";
			// 
			// lblCreatedByUsername
			// 
			this.lblCreatedByUsername.AutoSize = true;
			this.lblCreatedByUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreatedByUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblCreatedByUsername.Location = new System.Drawing.Point(173, 571);
			this.lblCreatedByUsername.Name = "lblCreatedByUsername";
			this.lblCreatedByUsername.Size = new System.Drawing.Size(91, 25);
			this.lblCreatedByUsername.TabIndex = 7;
			this.lblCreatedByUsername.Text = "Username";
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
			this.btnSave.Location = new System.Drawing.Point(378, 587);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(167, 45);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// tbVisitdescription
			// 
			this.tbVisitdescription.BorderRadius = 5;
			this.tbVisitdescription.BorderThickness = 0;
			this.tbVisitdescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbVisitdescription.DefaultText = "";
			this.tbVisitdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbVisitdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbVisitdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbVisitdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbVisitdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbVisitdescription.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbVisitdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbVisitdescription.Location = new System.Drawing.Point(49, 163);
			this.tbVisitdescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbVisitdescription.Multiline = true;
			this.tbVisitdescription.Name = "tbVisitdescription";
			this.tbVisitdescription.PasswordChar = '\0';
			this.tbVisitdescription.PlaceholderText = "";
			this.tbVisitdescription.SelectedText = "";
			this.tbVisitdescription.Size = new System.Drawing.Size(497, 96);
			this.tbVisitdescription.TabIndex = 10;
			// 
			// tbDiagnosiss
			// 
			this.tbDiagnosiss.BorderRadius = 5;
			this.tbDiagnosiss.BorderThickness = 0;
			this.tbDiagnosiss.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDiagnosiss.DefaultText = "";
			this.tbDiagnosiss.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDiagnosiss.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbDiagnosiss.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDiagnosiss.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDiagnosiss.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDiagnosiss.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbDiagnosiss.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbDiagnosiss.Location = new System.Drawing.Point(49, 317);
			this.tbDiagnosiss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDiagnosiss.Name = "tbDiagnosiss";
			this.tbDiagnosiss.PasswordChar = '\0';
			this.tbDiagnosiss.PlaceholderText = "";
			this.tbDiagnosiss.SelectedText = "";
			this.tbDiagnosiss.Size = new System.Drawing.Size(497, 48);
			this.tbDiagnosiss.TabIndex = 11;
			this.tbDiagnosiss.Validating += new System.ComponentModel.CancelEventHandler(this.tbDiagnosiss_Validating);
			// 
			// lblMedicalRecordId
			// 
			this.lblMedicalRecordId.AutoSize = true;
			this.lblMedicalRecordId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMedicalRecordId.ForeColor = System.Drawing.Color.Black;
			this.lblMedicalRecordId.Location = new System.Drawing.Point(207, 83);
			this.lblMedicalRecordId.Name = "lblMedicalRecordId";
			this.lblMedicalRecordId.Size = new System.Drawing.Size(54, 25);
			this.lblMedicalRecordId.TabIndex = 37;
			this.lblMedicalRecordId.Text = "[????]";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(44, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(157, 25);
			this.label8.TabIndex = 36;
			this.label8.Text = "Medical record ID ";
			// 
			// lblPatientName
			// 
			this.lblPatientName.AutoSize = true;
			this.lblPatientName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lblPatientName.ForeColor = System.Drawing.Color.Gray;
			this.lblPatientName.Location = new System.Drawing.Point(17, 31);
			this.lblPatientName.Name = "lblPatientName";
			this.lblPatientName.Size = new System.Drawing.Size(129, 28);
			this.lblPatientName.TabIndex = 8;
			this.lblPatientName.Text = "Patient Name";
			// 
			// frmMedicalRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(565, 667);
			this.Controls.Add(this.lblMedicalRecordId);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbDiagnosiss);
			this.Controls.Add(this.tbVisitdescription);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblPatientName);
			this.Controls.Add(this.lblCreatedByUsername);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbAdditionalNotes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmMedicalRecord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.frmMedicalRecord_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox tbDiagnosis;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		//private Guna.UI2.WinForms.Guna2TextBox tbDiagnosis;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbAdditionalNotes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCreatedByUsername;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2TextBox tbDiagnosiss;
		private Guna.UI2.WinForms.Guna2TextBox tbVisitdescription;
		private System.Windows.Forms.Label lblMedicalRecordId;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblPatientName;
	}
}