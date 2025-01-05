namespace Hospital_Presentation.Employees
{
    partial class frmAddUpdateEmployee
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
            this.TabControlEmployeeInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.PagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonInfoCardWithFilter1 = new Hospital_Presentation.People.Controls.ctrlPersonInfoCardWithFilter();
            this.PageAdditionalEmployeeInfo = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLeaveDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDepartements = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmployeeStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHireDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJobTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.epValidations = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControlEmployeeInfo.SuspendLayout();
            this.PagePersonInfo.SuspendLayout();
            this.PageAdditionalEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidations)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlEmployeeInfo
            // 
            this.TabControlEmployeeInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControlEmployeeInfo.Controls.Add(this.PagePersonInfo);
            this.TabControlEmployeeInfo.Controls.Add(this.PageAdditionalEmployeeInfo);
            this.TabControlEmployeeInfo.ItemSize = new System.Drawing.Size(180, 48);
            this.TabControlEmployeeInfo.Location = new System.Drawing.Point(12, 5);
            this.TabControlEmployeeInfo.Name = "TabControlEmployeeInfo";
            this.TabControlEmployeeInfo.SelectedIndex = 0;
            this.TabControlEmployeeInfo.Size = new System.Drawing.Size(1288, 698);
            this.TabControlEmployeeInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlEmployeeInfo.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.TabControlEmployeeInfo.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlEmployeeInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlEmployeeInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.TabControlEmployeeInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlEmployeeInfo.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.TabControlEmployeeInfo.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlEmployeeInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlEmployeeInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.TabControlEmployeeInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlEmployeeInfo.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.TabControlEmployeeInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlEmployeeInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.TabControlEmployeeInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControlEmployeeInfo.TabButtonSize = new System.Drawing.Size(180, 48);
            this.TabControlEmployeeInfo.TabIndex = 0;
            this.TabControlEmployeeInfo.TabMenuBackColor = System.Drawing.Color.White;
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
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(805, 598);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(225, 54);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            // PageAdditionalEmployeeInfo
            // 
            this.PageAdditionalEmployeeInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PageAdditionalEmployeeInfo.Controls.Add(this.guna2Button1);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.btnSave);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label8);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.txtLeaveDate);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label7);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.cbDepartements);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label2);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.cbEmployeeStatus);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label5);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.txtSalary);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label6);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.txtHireDate);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label4);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label3);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.txtJobTitle);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.lblEmployeeID);
            this.PageAdditionalEmployeeInfo.Controls.Add(this.label1);
            this.PageAdditionalEmployeeInfo.Location = new System.Drawing.Point(184, 4);
            this.PageAdditionalEmployeeInfo.Name = "PageAdditionalEmployeeInfo";
            this.PageAdditionalEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PageAdditionalEmployeeInfo.Size = new System.Drawing.Size(1100, 690);
            this.PageAdditionalEmployeeInfo.TabIndex = 1;
            this.PageAdditionalEmployeeInfo.Text = "Employee Info";
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
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 7;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(868, 611);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 54);
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
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 39;
            this.label8.Text = "Leave Date :";
            // 
            // txtLeaveDate
            // 
            this.txtLeaveDate.BorderRadius = 5;
            this.txtLeaveDate.BorderThickness = 0;
            this.txtLeaveDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLeaveDate.DefaultText = "";
            this.txtLeaveDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLeaveDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLeaveDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLeaveDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLeaveDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLeaveDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLeaveDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLeaveDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLeaveDate.Location = new System.Drawing.Point(39, 422);
            this.txtLeaveDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtLeaveDate.Name = "txtLeaveDate";
            this.txtLeaveDate.PasswordChar = '\0';
            this.txtLeaveDate.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtLeaveDate.PlaceholderText = "DD/MM/YYYY";
            this.txtLeaveDate.SelectedText = "";
            this.txtLeaveDate.Size = new System.Drawing.Size(471, 45);
            this.txtLeaveDate.TabIndex = 38;
            this.txtLeaveDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtLeaveDate_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(553, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 30);
            this.label7.TabIndex = 37;
            this.label7.Text = "Dedpartement :";
            // 
            // cbDepartements
            // 
            this.cbDepartements.BackColor = System.Drawing.Color.Transparent;
            this.cbDepartements.BorderRadius = 5;
            this.cbDepartements.BorderThickness = 0;
            this.cbDepartements.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDepartements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartements.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartements.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDepartements.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDepartements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDepartements.ItemHeight = 39;
            this.cbDepartements.Location = new System.Drawing.Point(559, 322);
            this.cbDepartements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartements.Name = "cbDepartements";
            this.cbDepartements.Size = new System.Drawing.Size(469, 45);
            this.cbDepartements.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(553, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Employee Status :";
            // 
            // cbEmployeeStatus
            // 
            this.cbEmployeeStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbEmployeeStatus.BorderRadius = 5;
            this.cbEmployeeStatus.BorderThickness = 0;
            this.cbEmployeeStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmployeeStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployeeStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEmployeeStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEmployeeStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbEmployeeStatus.ItemHeight = 39;
            this.cbEmployeeStatus.Items.AddRange(new object[] {
            "Active",
            "Vactaion",
            "Leave"});
            this.cbEmployeeStatus.Location = new System.Drawing.Point(559, 213);
            this.cbEmployeeStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEmployeeStatus.Name = "cbEmployeeStatus";
            this.cbEmployeeStatus.Size = new System.Drawing.Size(469, 45);
            this.cbEmployeeStatus.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(33, 494);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Salary :";
            // 
            // txtSalary
            // 
            this.txtSalary.BorderRadius = 5;
            this.txtSalary.BorderThickness = 0;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(37, 540);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(6);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSalary.PlaceholderText = "Employee Salary";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(471, 45);
            this.txtSalary.TabIndex = 32;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(31, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hire Date :";
            // 
            // txtHireDate
            // 
            this.txtHireDate.BorderRadius = 5;
            this.txtHireDate.BorderThickness = 0;
            this.txtHireDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHireDate.DefaultText = "";
            this.txtHireDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHireDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHireDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHireDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHireDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHireDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtHireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHireDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHireDate.Location = new System.Drawing.Point(37, 322);
            this.txtHireDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.PasswordChar = '\0';
            this.txtHireDate.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtHireDate.PlaceholderText = "DD/MM/YYYY";
            this.txtHireDate.SelectedText = "";
            this.txtHireDate.Size = new System.Drawing.Size(471, 45);
            this.txtHireDate.TabIndex = 30;
            this.txtHireDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtHireDate_Validating);
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
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Job Title :";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.BorderRadius = 5;
            this.txtJobTitle.BorderThickness = 0;
            this.txtJobTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobTitle.DefaultText = "";
            this.txtJobTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJobTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJobTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJobTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtJobTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtJobTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJobTitle.Location = new System.Drawing.Point(37, 206);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.PasswordChar = '\0';
            this.txtJobTitle.PlaceholderText = "Employee Job Title";
            this.txtJobTitle.SelectedText = "";
            this.txtJobTitle.Size = new System.Drawing.Size(471, 45);
            this.txtJobTitle.TabIndex = 27;
            this.txtJobTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtJobTitle_Validating);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmployeeID.Location = new System.Drawing.Point(205, 103);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(60, 28);
            this.lblEmployeeID.TabIndex = 26;
            this.lblEmployeeID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee ID :";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1064, 711);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(206, 54);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // epValidations
            // 
            this.epValidations.ContainerControl = this;
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 777);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.TabControlEmployeeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateEmployee";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.TabControlEmployeeInfo.ResumeLayout(false);
            this.PagePersonInfo.ResumeLayout(false);
            this.PageAdditionalEmployeeInfo.ResumeLayout(false);
            this.PageAdditionalEmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabControlEmployeeInfo;
        private System.Windows.Forms.TabPage PagePersonInfo;
        private System.Windows.Forms.TabPage PageAdditionalEmployeeInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private People.Controls.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtLeaveDate;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbDepartements;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbEmployeeStatus;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtHireDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtJobTitle;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ErrorProvider epValidations;
    }
}