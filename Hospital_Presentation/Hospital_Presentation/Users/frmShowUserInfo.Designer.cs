namespace Hospital_Presentation.Users
{
    partial class frmShowUserInfo
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
			this.label1 = new System.Windows.Forms.Label();
			this.ctrlUserInfoCardV21 = new Hospital_Presentation.Users.Controls.ctrlUserInfoCardV2();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(18, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "User Info";
			// 
			// ctrlUserInfoCardV21
			// 
			this.ctrlUserInfoCardV21.Location = new System.Drawing.Point(12, 67);
			this.ctrlUserInfoCardV21.Name = "ctrlUserInfoCardV21";
			this.ctrlUserInfoCardV21.Size = new System.Drawing.Size(1002, 396);
			this.ctrlUserInfoCardV21.TabIndex = 2;
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
			this.btnClose.Location = new System.Drawing.Point(834, 474);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(180, 45);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmShowUserInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1036, 536);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.ctrlUserInfoCardV21);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmShowUserInfo";
			this.Text = "Show User Info";
			this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
		private Controls.ctrlUserInfoCardV2 ctrlUserInfoCardV21;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}