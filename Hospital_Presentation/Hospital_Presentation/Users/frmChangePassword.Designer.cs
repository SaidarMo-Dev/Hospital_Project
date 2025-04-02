namespace Hospital_Presentation.Users
{
	partial class frmChangePassword
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ctrlUserInfoCardV21 = new Hospital_Presentation.Users.Controls.ctrlUserInfoCardV2();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(25, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Card";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.tbConfirmPassword);
			this.groupBox1.Controls.Add(this.tbNewPassword);
			this.groupBox1.Controls.Add(this.tbOldPassword);
			this.groupBox1.ForeColor = System.Drawing.Color.Gray;
			this.groupBox1.Location = new System.Drawing.Point(31, 455);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(983, 254);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Change Passsword";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbConfirmPassword.BorderRadius = 5;
			this.tbConfirmPassword.BorderThickness = 0;
			this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbConfirmPassword.DefaultText = "";
			this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.FillColor = System.Drawing.SystemColors.ControlLight;
			this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbConfirmPassword.Location = new System.Drawing.Point(178, 169);
			this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.PasswordChar = '*';
			this.tbConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbConfirmPassword.PlaceholderText = "Confirm Password";
			this.tbConfirmPassword.SelectedText = "";
			this.tbConfirmPassword.Size = new System.Drawing.Size(379, 48);
			this.tbConfirmPassword.TabIndex = 8;
			this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
			this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
			// 
			// tbNewPassword
			// 
			this.tbNewPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbNewPassword.BorderRadius = 5;
			this.tbNewPassword.BorderThickness = 0;
			this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNewPassword.DefaultText = "";
			this.tbNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNewPassword.FillColor = System.Drawing.SystemColors.ControlLight;
			this.tbNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
			this.tbNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNewPassword.Location = new System.Drawing.Point(178, 97);
			this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbNewPassword.Name = "tbNewPassword";
			this.tbNewPassword.PasswordChar = '*';
			this.tbNewPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbNewPassword.PlaceholderText = "New Password";
			this.tbNewPassword.SelectedText = "";
			this.tbNewPassword.Size = new System.Drawing.Size(379, 48);
			this.tbNewPassword.TabIndex = 7;
			this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
			// 
			// tbOldPassword
			// 
			this.tbOldPassword.BackColor = System.Drawing.Color.Transparent;
			this.tbOldPassword.BorderRadius = 5;
			this.tbOldPassword.BorderThickness = 0;
			this.tbOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbOldPassword.DefaultText = "";
			this.tbOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbOldPassword.FillColor = System.Drawing.SystemColors.ControlLight;
			this.tbOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbOldPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbOldPassword.ForeColor = System.Drawing.Color.Black;
			this.tbOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbOldPassword.Location = new System.Drawing.Point(178, 27);
			this.tbOldPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbOldPassword.Name = "tbOldPassword";
			this.tbOldPassword.PasswordChar = '\0';
			this.tbOldPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbOldPassword.PlaceholderText = "Old Pasword";
			this.tbOldPassword.SelectedText = "";
			this.tbOldPassword.Size = new System.Drawing.Size(379, 48);
			this.tbOldPassword.TabIndex = 6;
			this.tbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPassword_Validating);
			// 
			// guna2Button1
			// 
			this.guna2Button1.BorderRadius = 5;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.LightSeaGreen;
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(834, 725);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(180, 45);
			this.guna2Button1.TabIndex = 7;
			this.guna2Button1.Text = "Save";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ctrlUserInfoCardV21
			// 
			this.ctrlUserInfoCardV21.BackColor = System.Drawing.Color.Transparent;
			this.ctrlUserInfoCardV21.Location = new System.Drawing.Point(12, 53);
			this.ctrlUserInfoCardV21.Name = "ctrlUserInfoCardV21";
			this.ctrlUserInfoCardV21.Size = new System.Drawing.Size(1002, 396);
			this.ctrlUserInfoCardV21.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BorderRadius = 5;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.FillColor = System.Drawing.Color.LightSeaGreen;
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(31, 725);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(180, 45);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1037, 782);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.guna2Button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ctrlUserInfoCardV21);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmChangePassword";
			this.Text = "frmChangePassword";
			this.Load += new System.EventHandler(this.frmChangePassword_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbNewPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbOldPassword;
		private Controls.ctrlUserInfoCardV2 ctrlUserInfoCardV21;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}