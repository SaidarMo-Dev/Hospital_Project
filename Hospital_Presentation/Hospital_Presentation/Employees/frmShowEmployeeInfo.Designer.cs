namespace Hospital_Presentation.Employees
{
    partial class frmShowEmployeeInfo
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
            this.ctrlEmployeeInfo1 = new Hospital_Presentation.Employees.Controls.ctrlEmployeeInfo();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlEmployeeInfo1
            // 
            this.ctrlEmployeeInfo1.Location = new System.Drawing.Point(3, 80);
            this.ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            this.ctrlEmployeeInfo1.Size = new System.Drawing.Size(1034, 538);
            this.ctrlEmployeeInfo1.TabIndex = 0;
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
            this.guna2Button1.Location = new System.Drawing.Point(851, 630);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(184, 49);
            this.guna2Button1.TabIndex = 35;
            this.guna2Button1.Text = "Close";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(404, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 40);
            this.label1.TabIndex = 36;
            this.label1.Text = "Employee Details";
            // 
            // frmShowEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ctrlEmployeeInfo1);
            this.Name = "frmShowEmployeeInfo";
            this.Text = "frmShowEmployeeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlEmployeeInfo ctrlEmployeeInfo1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}