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
            this.ctrlUserInfoCard1 = new Hospital_Presentation.Users.Controls.ctrlUserInfoCard();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(38, 74);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(1015, 631);
            this.ctrlUserInfoCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(446, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Info";
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlUserInfoCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowUserInfo";
            this.Text = "Show User Info";
            this.Load += new System.EventHandler(this.frmShowUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlUserInfoCard ctrlUserInfoCard1;
        private System.Windows.Forms.Label label1;
    }
}