namespace Hospital_Presentation
{
	partial class frmLogin
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
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.CheckBoxRememberMe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BorderRadius = 5;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.LightSeaGreen;
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(625, 383);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(253, 45);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// CheckBoxRememberMe
			// 
			this.CheckBoxRememberMe.BackColor = System.Drawing.SystemColors.ControlLight;
			this.CheckBoxRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.CheckBoxRememberMe.CheckedState.BorderRadius = 2;
			this.CheckBoxRememberMe.CheckedState.BorderThickness = 0;
			this.CheckBoxRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.CheckBoxRememberMe.Location = new System.Drawing.Point(543, 334);
			this.CheckBoxRememberMe.Name = "CheckBoxRememberMe";
			this.CheckBoxRememberMe.Size = new System.Drawing.Size(22, 22);
			this.CheckBoxRememberMe.TabIndex = 5;
			this.CheckBoxRememberMe.Text = "guna2CustomCheckBox1";
			this.CheckBoxRememberMe.UncheckedState.BorderColor = System.Drawing.Color.White;
			this.CheckBoxRememberMe.UncheckedState.BorderRadius = 2;
			this.CheckBoxRememberMe.UncheckedState.BorderThickness = 0;
			this.CheckBoxRememberMe.UncheckedState.FillColor = System.Drawing.SystemColors.ControlLight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label1.Location = new System.Drawing.Point(584, 334);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Remember me";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(26, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(289, 46);
			this.label2.TabIndex = 0;
			this.label2.Text = "Welcome Back";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.guna2Panel1.BorderColor = System.Drawing.Color.DimGray;
			this.guna2Panel1.Controls.Add(this.label3);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(389, 526);
			this.guna2Panel1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(70, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "Enter Your Login";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancel.FillColor = System.Drawing.Color.Transparent;
			this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnCancel.ForeColor = System.Drawing.Color.Black;
			this.btnCancel.ImageSize = new System.Drawing.Size(32, 32);
			this.btnCancel.Location = new System.Drawing.Point(988, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(45, 45);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "X";
			this.btnCancel.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.BorderRadius = 5;
			this.tbPassword.BorderThickness = 0;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FillColor = System.Drawing.SystemColors.Control;
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.IconLeft = global::Hospital_Presentation.Properties.Resources.icons8_password_50;
			this.tbPassword.IconLeftSize = new System.Drawing.Size(24, 24);
			this.tbPassword.IconRight = global::Hospital_Presentation.Properties.Resources.IconHidePassword;
			this.tbPassword.IconRightSize = new System.Drawing.Size(24, 24);
			this.tbPassword.Location = new System.Drawing.Point(543, 268);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.tbPassword.PlaceholderText = "Password";
			this.tbPassword.SelectedText = "";
			this.tbPassword.Size = new System.Drawing.Size(413, 48);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.TextOffset = new System.Drawing.Point(7, 0);
			this.tbPassword.IconRightClick += new System.EventHandler(this.tbPassword_IconRightClick);
			this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPasssword_Validating);
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::Hospital_Presentation.Properties.Resources.employeesBlue2;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(645, 65);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(187, 119);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 1;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			// 
			// tbUsername
			// 
			this.tbUsername.BorderRadius = 5;
			this.tbUsername.BorderThickness = 0;
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.DefaultText = "";
			this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.FillColor = System.Drawing.SystemColors.Control;
			this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbUsername.ForeColor = System.Drawing.Color.Black;
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.IconLeft = global::Hospital_Presentation.Properties.Resources.icons8_username_30;
			this.tbUsername.IconLeftSize = new System.Drawing.Size(24, 24);
			this.tbUsername.Location = new System.Drawing.Point(543, 201);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.tbUsername.PlaceholderText = "Username";
			this.tbUsername.SelectedText = "";
			this.tbUsername.Size = new System.Drawing.Size(413, 48);
			this.tbUsername.TabIndex = 0;
			this.tbUsername.TextOffset = new System.Drawing.Point(7, 0);
			this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(1038, 526);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CheckBoxRememberMe);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.tbUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private Guna.UI2.WinForms.Guna2CustomCheckBox CheckBoxRememberMe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private Guna.UI2.WinForms.Guna2Button btnCancel;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label label3;
	}
}