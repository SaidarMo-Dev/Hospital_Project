namespace Hospital_Presentation.Employees
{
    partial class frmViewEmployeeInfo
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
            this.employeeInfoCardWithFilter1 = new Hospital_Presentation.Employees.Controls.EmployeeInfoCardWithFilter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // employeeInfoCardWithFilter1
            // 
            this.employeeInfoCardWithFilter1.Location = new System.Drawing.Point(31, 48);
            this.employeeInfoCardWithFilter1.Name = "employeeInfoCardWithFilter1";
            this.employeeInfoCardWithFilter1.Size = new System.Drawing.Size(1036, 624);
            this.employeeInfoCardWithFilter1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(880, 678);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(184, 49);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmViewEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 738);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.employeeInfoCardWithFilter1);
            this.Name = "frmViewEmployeeInfo";
            this.Text = "frmViewEmployeeInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EmployeeInfoCardWithFilter employeeInfoCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}