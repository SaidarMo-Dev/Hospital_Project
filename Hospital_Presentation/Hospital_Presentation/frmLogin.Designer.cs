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
			this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
			this.label4 = new System.Windows.Forms.Label();
			this.LoginProgressIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
			this.btnLogin.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(820, 439);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(354, 45);
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
			this.CheckBoxRememberMe.Location = new System.Drawing.Point(775, 367);
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
			this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label1.Location = new System.Drawing.Point(816, 367);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Remember me";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
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
			this.btnCancel.Location = new System.Drawing.Point(1220, 0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(45, 45);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "X";
			this.btnCancel.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DimGray;
			this.label4.Location = new System.Drawing.Point(813, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(311, 38);
			this.label4.TabIndex = 10;
			this.label4.Text = "Enter your Login info";
			// 
			// LoginProgressIndicator
			// 
			this.LoginProgressIndicator.AnimationSpeed = 80;
			this.LoginProgressIndicator.CircleSize = 0.6F;
			this.LoginProgressIndicator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.LoginProgressIndicator.Location = new System.Drawing.Point(935, 421);
			this.LoginProgressIndicator.Name = "LoginProgressIndicator";
			this.LoginProgressIndicator.Size = new System.Drawing.Size(90, 90);
			this.LoginProgressIndicator.TabIndex = 12;
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
			this.tbPassword.Font = new System.Drawing.Font("Roboto", 9F);
			this.tbPassword.ForeColor = System.Drawing.Color.Black;
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPassword.IconLeft = global::Hospital_Presentation.Properties.Resources.icons8_password_50;
			this.tbPassword.IconLeftSize = new System.Drawing.Size(24, 24);
			this.tbPassword.IconRight = global::Hospital_Presentation.Properties.Resources.IconHidePassword;
			this.tbPassword.IconRightSize = new System.Drawing.Size(24, 24);
			this.tbPassword.Location = new System.Drawing.Point(775, 299);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
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
			this.guna2PictureBox1.Location = new System.Drawing.Point(877, 87);
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
			this.tbUsername.Font = new System.Drawing.Font("Roboto", 9F);
			this.tbUsername.ForeColor = System.Drawing.Color.Black;
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUsername.IconLeft = global::Hospital_Presentation.Properties.Resources.icons8_username_30;
			this.tbUsername.IconLeftSize = new System.Drawing.Size(24, 24);
			this.tbUsername.Location = new System.Drawing.Point(775, 223);
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
			// guna2PictureBox2
			// 
			this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox2.BorderRadius = 50;
			this.guna2PictureBox2.CustomizableEdges.BottomLeft = false;
			this.guna2PictureBox2.CustomizableEdges.TopLeft = false;
			this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2PictureBox2.Image = global::Hospital_Presentation.Properties.Resources.MedicalImage1;
			this.guna2PictureBox2.ImageRotate = 0F;
			this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.Size = new System.Drawing.Size(674, 602);
			this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox2.TabIndex = 13;
			this.guna2PictureBox2.TabStop = false;
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(1277, 602);
			this.Controls.Add(this.guna2PictureBox2);
			this.Controls.Add(this.LoginProgressIndicator);
			this.Controls.Add(this.label4);
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
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
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
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ProgressIndicator LoginProgressIndicator;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
	}
}