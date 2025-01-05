namespace Hospital_Presentation.Patients
{
    partial class frmAddUpdatePatient
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
            this.TabControlPatinetInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.PagePersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonInfoCardWithFilter1 = new Hospital_Presentation.People.Controls.ctrlPersonInfoCardWithFilter();
            this.PagePatientInfo = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPatientBloodType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssuranceNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabControlPatinetInfo.SuspendLayout();
            this.PagePersonInfo.SuspendLayout();
            this.PagePatientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlPatinetInfo
            // 
            this.TabControlPatinetInfo.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControlPatinetInfo.Controls.Add(this.PagePersonInfo);
            this.TabControlPatinetInfo.Controls.Add(this.PagePatientInfo);
            this.TabControlPatinetInfo.ItemSize = new System.Drawing.Size(180, 48);
            this.TabControlPatinetInfo.Location = new System.Drawing.Point(8, 12);
            this.TabControlPatinetInfo.Name = "TabControlPatinetInfo";
            this.TabControlPatinetInfo.SelectedIndex = 0;
            this.TabControlPatinetInfo.Size = new System.Drawing.Size(1288, 698);
            this.TabControlPatinetInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlPatinetInfo.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.TabControlPatinetInfo.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlPatinetInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlPatinetInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.TabControlPatinetInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlPatinetInfo.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.TabControlPatinetInfo.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlPatinetInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControlPatinetInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.TabControlPatinetInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControlPatinetInfo.TabButtonSelectedState.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.TabControlPatinetInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlPatinetInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.DimGray;
            this.TabControlPatinetInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabControlPatinetInfo.TabButtonSize = new System.Drawing.Size(180, 48);
            this.TabControlPatinetInfo.TabIndex = 1;
            this.TabControlPatinetInfo.TabMenuBackColor = System.Drawing.Color.White;
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
            this.btnNext.Location = new System.Drawing.Point(849, 613);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(225, 54);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(21, 6);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(1009, 584);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 0;
            // 
            // PagePatientInfo
            // 
            this.PagePatientInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PagePatientInfo.Controls.Add(this.guna2Button1);
            this.PagePatientInfo.Controls.Add(this.btnSave);
            this.PagePatientInfo.Controls.Add(this.label2);
            this.PagePatientInfo.Controls.Add(this.cbPatientBloodType);
            this.PagePatientInfo.Controls.Add(this.label4);
            this.PagePatientInfo.Controls.Add(this.label3);
            this.PagePatientInfo.Controls.Add(this.txtAssuranceNumber);
            this.PagePatientInfo.Controls.Add(this.lbPatientID);
            this.PagePatientInfo.Controls.Add(this.label1);
            this.PagePatientInfo.Location = new System.Drawing.Point(184, 4);
            this.PagePatientInfo.Name = "PagePatientInfo";
            this.PagePatientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.PagePatientInfo.Size = new System.Drawing.Size(1100, 690);
            this.PagePatientInfo.TabIndex = 1;
            this.PagePatientInfo.Text = "Patient Info";
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
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(32, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 35;
            this.label2.Text = "Blod Type ";
            // 
            // cbPatientBloodType
            // 
            this.cbPatientBloodType.BackColor = System.Drawing.Color.Transparent;
            this.cbPatientBloodType.BorderRadius = 7;
            this.cbPatientBloodType.BorderThickness = 0;
            this.cbPatientBloodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPatientBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPatientBloodType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPatientBloodType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPatientBloodType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPatientBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPatientBloodType.ItemHeight = 39;
            this.cbPatientBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cbPatientBloodType.Location = new System.Drawing.Point(38, 315);
            this.cbPatientBloodType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPatientBloodType.Name = "cbPatientBloodType";
            this.cbPatientBloodType.Size = new System.Drawing.Size(469, 45);
            this.cbPatientBloodType.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(370, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "Additional patient Informations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(33, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Asurance Number";
            // 
            // txtAssuranceNumber
            // 
            this.txtAssuranceNumber.BorderRadius = 7;
            this.txtAssuranceNumber.BorderThickness = 0;
            this.txtAssuranceNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAssuranceNumber.DefaultText = "";
            this.txtAssuranceNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAssuranceNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAssuranceNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssuranceNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAssuranceNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAssuranceNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAssuranceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAssuranceNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAssuranceNumber.Location = new System.Drawing.Point(37, 206);
            this.txtAssuranceNumber.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtAssuranceNumber.Name = "txtAssuranceNumber";
            this.txtAssuranceNumber.PasswordChar = '\0';
            this.txtAssuranceNumber.PlaceholderText = "Enter Assurance Number";
            this.txtAssuranceNumber.SelectedText = "";
            this.txtAssuranceNumber.Size = new System.Drawing.Size(471, 45);
            this.txtAssuranceNumber.TabIndex = 27;
            this.txtAssuranceNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAssuranceNumber_Validating);
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPatientID.Location = new System.Drawing.Point(205, 103);
            this.lbPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(60, 28);
            this.lbPatientID.TabIndex = 26;
            this.lbPatientID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(33, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patinet ID :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 782);
            this.Controls.Add(this.TabControlPatinetInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddUpdatePatient";
            this.Text = "frmAddUpdatePatient";
            this.Load += new System.EventHandler(this.frmAddUpdatePatient_Load);
            this.TabControlPatinetInfo.ResumeLayout(false);
            this.PagePersonInfo.ResumeLayout(false);
            this.PagePatientInfo.ResumeLayout(false);
            this.PagePatientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabControlPatinetInfo;
        private System.Windows.Forms.TabPage PagePersonInfo;
        private People.Controls.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.TabPage PagePatientInfo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbPatientBloodType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAssuranceNumber;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
    }
}