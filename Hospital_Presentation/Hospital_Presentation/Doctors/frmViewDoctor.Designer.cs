namespace Hospital_Presentation.Doctors
{
    partial class frmViewDoctor
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
            this.ctrlShowDoctorInfoCardWithFilter_1 = new Hospital_Presentation.Doctors.Controls.ctrlShowDoctorInfoCardWithFilter_();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlShowDoctorInfoCardWithFilter_1
            // 
            this.ctrlShowDoctorInfoCardWithFilter_1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowDoctorInfoCardWithFilter_1.Name = "ctrlShowDoctorInfoCardWithFilter_1";
            this.ctrlShowDoctorInfoCardWithFilter_1.Size = new System.Drawing.Size(1223, 672);
            this.ctrlShowDoctorInfoCardWithFilter_1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 7;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1027, 692);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            // 
            // frmViewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1231, 753);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlShowDoctorInfoCardWithFilter_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmViewDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmViewDoctor";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlShowDoctorInfoCardWithFilter_ ctrlShowDoctorInfoCardWithFilter_1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}