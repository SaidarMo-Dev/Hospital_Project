namespace Hospital_Presentation.Users
{
    partial class frmAddUpdateUser
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.epValidations = new System.Windows.Forms.ErrorProvider(this.components);
            this.PageAdditionalUserInfo = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbIsActive = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.TabControlUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.ctrlPersonInfoCardWithFilter1 = new Hospital_Presentation.People.Controls.ctrlPersonInfoCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.epValidations)).BeginInit();
            this.PageAdditionalUserInfo.SuspendLayout();
            this.PagePersonInfo.SuspendLayout();
            this.TabControlUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1112, 714);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // epValidations
            // 
            this.epValidations.ContainerControl = this;
            // 
            // PageAdditionalUserInfo
            // 
            this.PageAdditionalUserInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PageAdditionalUserInfo.Controls.Add(this.label2);
            this.PageAdditionalUserInfo.Controls.Add(this.chkbIsActive);
            this.PageAdditionalUserInfo.Controls.Add(this.btnBack);
            this.PageAdditionalUserInfo.Controls.Add(this.btnSave);
            this.PageAdditionalUserInfo.Controls.Add(this.label8);
            this.PageAdditionalUserInfo.Controls.Add(this.txtConfirmPassword);
            this.PageAdditionalUserInfo.Controls.Add(this.label6);
            this.PageAdditionalUserInfo.Controls.Add(this.txtPassword);
            this.PageAdditionalUserInfo.Controls.Add(this.label4);
            this.PageAdditionalUserInfo.Controls.Add(this.label3);
            this.PageAdditionalUserInfo.Controls.Add(this.txtUsername);
            this.PageAdditionalUserInfo.Controls.Add(this.lblUserID);
            this.PageAdditionalUserInfo.Controls.Add(this.label1);
            this.PageAdditionalUserInfo.Location = new System.Drawing.Point(184, 4);
            this.PageAdditionalUserInfo.Name = "PageAdditionalUserInfo";
            this.PageAdditionalUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PageAdditionalUserInfo.Size = new System.Drawing.Size(1100, 690);
            this.PageAdditionalUserInfo.TabIndex = 1;
            this.PageAdditionalUserInfo.Text = "User Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(98, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Is Active";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkbIsActive
            // 
            this.chkbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chkbIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbIsActive.CheckedState.BorderRadius = 2;
            this.chkbIsActive.CheckedState.BorderThickness = 0;
            this.chkbIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkbIsActive.Location = new System.Drawing.Point(39, 493);
            this.chkbIsActive.Name = "chkbIsActive";
            this.chkbIsActive.Size = new System.Drawing.Size(27, 28);
            this.chkbIsActive.TabIndex = 42;
            this.chkbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkbIsActive.UncheckedState.BorderRadius = 2;
            this.chkbIsActive.UncheckedState.BorderThickness = 0;
            this.chkbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 7;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Crimson;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(36, 611);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(206, 48);
            this.btnBack.TabIndex = 41;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Crimson;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(868, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 48);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(33, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 30);
            this.label8.TabIndex = 39;
            this.label8.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 7;
            this.txtConfirmPassword.BorderThickness = 2;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(39, 422);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(471, 45);
            this.txtConfirmPassword.TabIndex = 38;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 7;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(37, 322);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(471, 45);
            this.txtPassword.TabIndex = 30;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(366, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "Additional Informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 7;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(37, 206);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(471, 45);
            this.txtUsername.TabIndex = 27;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserID.Location = new System.Drawing.Point(205, 103);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(60, 28);
            this.lblUserID.TabIndex = 26;
            this.lblUserID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "User ID:";
            // 
            // PagePersonInfo
            // 
            this.PagePersonInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PagePersonInfo.Controls.Add(this.btnNext);
            this.PagePersonInfo.Controls.Add(this.ctrlPersonInfoCardWithFilter1);
            this.PagePersonInfo.Location = new System.Drawing.Point(184, 4);
            this.PagePersonInfo.Name = "PagePersonInfo";
            this.PagePersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PagePersonInfo.Size = new System.Drawing.Size(1100, 690);
            this.PagePersonInfo.TabIndex = 0;
            this.PagePersonInfo.Text = "Person Info";
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 7;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Crimson;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(842, 598);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(188, 48);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // TabControlUserInfo
            // 
            this.TabControlUserInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControlUserInfo.Controls.Add(this.PagePersonInfo);
            this.TabControlUserInfo.Controls.Add(this.PageAdditionalUserInfo);
            this.TabControlUserInfo.ItemSize = new System.Drawing.Size(180, 48);
            this.TabControlUserInfo.Location = new System.Drawing.Point(12, 12);
            this.TabControlUserInfo.Name = "TabControlUserInfo";
            this.TabControlUserInfo.SelectedIndex = 0;
            this.TabControlUserInfo.Size = new System.Drawing.Size(1288, 698);
            this.TabControlUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.TabControlUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.TabControlUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.TabControlUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.TabControlUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlUserInfo.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.TabControlUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.TabControlUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControlUserInfo.TabButtonSize = new System.Drawing.Size(180, 48);
            this.TabControlUserInfo.TabIndex = 6;
            this.TabControlUserInfo.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(21, 6);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(1009, 584);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 0;
            this.ctrlPersonInfoCardWithFilter1.OnPersonSelected += new System.EventHandler<Hospital_Presentation.People.Controls.ctrlPersonInfoCardWithFilter.PersonInfoEventArgs>(this.ctrlPersonInfoCardWithFilter1_OnPersonSelected);
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 778);
            this.Controls.Add(this.TabControlUserInfo);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddUpdateUser";
            this.Text = "frmAdUpdateUser";
            this.Load += new System.EventHandler(this.frmAdUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epValidations)).EndInit();
            this.PageAdditionalUserInfo.ResumeLayout(false);
            this.PageAdditionalUserInfo.PerformLayout();
            this.PagePersonInfo.ResumeLayout(false);
            this.TabControlUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.ErrorProvider epValidations;
        private Guna.UI2.WinForms.Guna2TabControl TabControlUserInfo;
        private System.Windows.Forms.TabPage PagePersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.Controls.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.TabPage PageAdditionalUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chkbIsActive;
    }
}