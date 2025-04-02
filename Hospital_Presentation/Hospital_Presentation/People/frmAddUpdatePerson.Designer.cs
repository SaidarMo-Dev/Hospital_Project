namespace Hospital_Presentation.People
{
    partial class frmAddUpdatePerson
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
			this.linkRemovePersonImage = new System.Windows.Forms.LinkLabel();
			this.linklblSelectPersonImage = new System.Windows.Forms.LinkLabel();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.label11 = new System.Windows.Forms.Label();
			this.cbNationality = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbGendor = new Guna.UI2.WinForms.Guna2ComboBox();
			this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtDateOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
			this.picturePersonImage = new Guna.UI2.WinForms.Guna2PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.ErrorPoviderValidations = new System.Windows.Forms.ErrorProvider(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.lblPersonID = new System.Windows.Forms.Label();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			((System.ComponentModel.ISupportInitialize)(this.picturePersonImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ErrorPoviderValidations)).BeginInit();
			this.SuspendLayout();
			// 
			// linkRemovePersonImage
			// 
			this.linkRemovePersonImage.AutoSize = true;
			this.linkRemovePersonImage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.linkRemovePersonImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.linkRemovePersonImage.Location = new System.Drawing.Point(895, 219);
			this.linkRemovePersonImage.Name = "linkRemovePersonImage";
			this.linkRemovePersonImage.Size = new System.Drawing.Size(204, 28);
			this.linkRemovePersonImage.TabIndex = 51;
			this.linkRemovePersonImage.TabStop = true;
			this.linkRemovePersonImage.Text = "Remove Person image";
			this.linkRemovePersonImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemovePersonImage_LinkClicked);
			// 
			// linklblSelectPersonImage
			// 
			this.linklblSelectPersonImage.AutoSize = true;
			this.linklblSelectPersonImage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.linklblSelectPersonImage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.linklblSelectPersonImage.Location = new System.Drawing.Point(677, 21);
			this.linklblSelectPersonImage.Name = "linklblSelectPersonImage";
			this.linklblSelectPersonImage.Size = new System.Drawing.Size(199, 28);
			this.linklblSelectPersonImage.TabIndex = 47;
			this.linklblSelectPersonImage.TabStop = true;
			this.linklblSelectPersonImage.Text = "Choose Person image";
			this.linklblSelectPersonImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSelectPersonImage_LinkClicked);
			// 
			// btnSave
			// 
			this.btnSave.BorderRadius = 5;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(940, 744);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(180, 48);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.label11.ForeColor = System.Drawing.Color.Gray;
			this.label11.Location = new System.Drawing.Point(590, 629);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(114, 30);
			this.label11.TabIndex = 44;
			this.label11.Text = "Nationality";
			// 
			// cbNationality
			// 
			this.cbNationality.BackColor = System.Drawing.Color.Transparent;
			this.cbNationality.BorderRadius = 5;
			this.cbNationality.BorderThickness = 0;
			this.cbNationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNationality.FillColor = System.Drawing.SystemColors.Control;
			this.cbNationality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbNationality.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbNationality.ItemHeight = 44;
			this.cbNationality.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cbNationality.Location = new System.Drawing.Point(595, 676);
			this.cbNationality.Name = "cbNationality";
			this.cbNationality.Size = new System.Drawing.Size(525, 50);
			this.cbNationality.TabIndex = 43;
			this.cbNationality.SelectedIndexChanged += new System.EventHandler(this.cbNationality_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(40, 624);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 30);
			this.label8.TabIndex = 42;
			this.label8.Text = "Gendor";
			// 
			// cbGendor
			// 
			this.cbGendor.BackColor = System.Drawing.Color.Transparent;
			this.cbGendor.BorderRadius = 5;
			this.cbGendor.BorderThickness = 0;
			this.cbGendor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbGendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGendor.FillColor = System.Drawing.SystemColors.Control;
			this.cbGendor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbGendor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbGendor.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.cbGendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbGendor.ItemHeight = 44;
			this.cbGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cbGendor.Location = new System.Drawing.Point(33, 676);
			this.cbGendor.Name = "cbGendor";
			this.cbGendor.Size = new System.Drawing.Size(541, 50);
			this.cbGendor.TabIndex = 41;
			this.cbGendor.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.BorderRadius = 5;
			this.txtPhoneNumber.BorderThickness = 0;
			this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPhoneNumber.DefaultText = "";
			this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPhoneNumber.FillColor = System.Drawing.SystemColors.Control;
			this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPhoneNumber.Location = new System.Drawing.Point(595, 367);
			this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.PasswordChar = '\0';
			this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtPhoneNumber.PlaceholderText = "Enter Mobile Number";
			this.txtPhoneNumber.SelectedText = "";
			this.txtPhoneNumber.Size = new System.Drawing.Size(525, 50);
			this.txtPhoneNumber.TabIndex = 40;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderRadius = 5;
			this.txtEmail.BorderThickness = 0;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.FillColor = System.Drawing.SystemColors.Control;
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(33, 552);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtEmail.PlaceholderText = "Enter Email";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(546, 50);
			this.txtEmail.TabIndex = 37;
			this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
			this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
			// 
			// txtAddress
			// 
			this.txtAddress.BorderRadius = 5;
			this.txtAddress.BorderThickness = 0;
			this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtAddress.DefaultText = "";
			this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtAddress.FillColor = System.Drawing.SystemColors.Control;
			this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtAddress.Location = new System.Drawing.Point(33, 462);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.PasswordChar = '\0';
			this.txtAddress.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtAddress.PlaceholderText = "Enter Address";
			this.txtAddress.SelectedText = "";
			this.txtAddress.Size = new System.Drawing.Size(1087, 50);
			this.txtAddress.TabIndex = 35;
			this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
			// 
			// txtDateOfBirth
			// 
			this.txtDateOfBirth.BorderRadius = 5;
			this.txtDateOfBirth.BorderThickness = 0;
			this.txtDateOfBirth.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDateOfBirth.DefaultText = "";
			this.txtDateOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtDateOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtDateOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDateOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtDateOfBirth.FillColor = System.Drawing.SystemColors.Control;
			this.txtDateOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtDateOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtDateOfBirth.Location = new System.Drawing.Point(29, 367);
			this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
			this.txtDateOfBirth.Name = "txtDateOfBirth";
			this.txtDateOfBirth.PasswordChar = '\0';
			this.txtDateOfBirth.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtDateOfBirth.PlaceholderText = "DD/MM/YYYY";
			this.txtDateOfBirth.SelectedText = "";
			this.txtDateOfBirth.Size = new System.Drawing.Size(545, 50);
			this.txtDateOfBirth.TabIndex = 33;
			this.txtDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.txtDateOfBirth_Validating);
			// 
			// txtLastName
			// 
			this.txtLastName.BorderRadius = 5;
			this.txtLastName.BorderThickness = 0;
			this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLastName.DefaultText = "";
			this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLastName.FillColor = System.Drawing.SystemColors.Control;
			this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLastName.Location = new System.Drawing.Point(595, 271);
			this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.PasswordChar = '\0';
			this.txtLastName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtLastName.PlaceholderText = "Enter Lst Name";
			this.txtLastName.SelectedText = "";
			this.txtLastName.Size = new System.Drawing.Size(525, 50);
			this.txtLastName.TabIndex = 32;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
			this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(12, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 35);
			this.label2.TabIndex = 29;
			this.label2.Text = "Fill Required Fields";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtFirstName
			// 
			this.txtFirstName.BorderRadius = 5;
			this.txtFirstName.BorderThickness = 0;
			this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFirstName.DefaultText = "";
			this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtFirstName.FillColor = System.Drawing.SystemColors.Control;
			this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtFirstName.Location = new System.Drawing.Point(28, 271);
			this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.PasswordChar = '\0';
			this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.txtFirstName.PlaceholderText = "Enter First Name";
			this.txtFirstName.SelectedText = "";
			this.txtFirstName.Size = new System.Drawing.Size(546, 50);
			this.txtFirstName.TabIndex = 28;
			this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
			// 
			// picturePersonImage
			// 
			this.picturePersonImage.BackColor = System.Drawing.Color.Transparent;
			this.picturePersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picturePersonImage.Image = global::Hospital_Presentation.Properties.Resources.Male;
			this.picturePersonImage.ImageRotate = 0F;
			this.picturePersonImage.Location = new System.Drawing.Point(900, 12);
			this.picturePersonImage.Name = "picturePersonImage";
			this.picturePersonImage.Size = new System.Drawing.Size(193, 195);
			this.picturePersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturePersonImage.TabIndex = 46;
			this.picturePersonImage.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// ErrorPoviderValidations
			// 
			this.ErrorPoviderValidations.ContainerControl = this;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.label12.ForeColor = System.Drawing.Color.Gray;
			this.label12.Location = new System.Drawing.Point(28, 217);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(113, 30);
			this.label12.TabIndex = 48;
			this.label12.Text = "Person ID :";
			// 
			// lblPersonID
			// 
			this.lblPersonID.AutoSize = true;
			this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 10.25F);
			this.lblPersonID.ForeColor = System.Drawing.Color.Gray;
			this.lblPersonID.Location = new System.Drawing.Point(170, 216);
			this.lblPersonID.Name = "lblPersonID";
			this.lblPersonID.Size = new System.Drawing.Size(67, 30);
			this.lblPersonID.TabIndex = 49;
			this.lblPersonID.Text = " [????]";
			// 
			// btnClose
			// 
			this.btnClose.BorderRadius = 5;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(33, 744);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(180, 48);
			this.btnClose.TabIndex = 52;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
			// 
			// frmAddUpdatePerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1150, 813);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.linkRemovePersonImage);
			this.Controls.Add(this.lblPersonID);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.linklblSelectPersonImage);
			this.Controls.Add(this.picturePersonImage);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbNationality);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbGendor);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtDateOfBirth);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFirstName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmAddUpdatePerson";
			this.Text = "Add New Person";
			this.Load += new System.EventHandler(this.frmAddUpdatePerson_Load);
			((System.ComponentModel.ISupportInitialize)(this.picturePersonImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ErrorPoviderValidations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRemovePersonImage;
        private System.Windows.Forms.LinkLabel linklblSelectPersonImage;
        private Guna.UI2.WinForms.Guna2PictureBox picturePersonImage;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbNationality;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbGendor;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtDateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider ErrorPoviderValidations;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label12;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}