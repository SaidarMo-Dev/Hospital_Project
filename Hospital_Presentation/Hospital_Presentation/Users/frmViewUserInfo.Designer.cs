namespace Hospital_Presentation.Users
{
    partial class frmViewUserInfo
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
            this.ctrlShowuserInfoCardWithFilter1 = new Hospital_Presentation.Users.Controls.ctrlShowuserInfoCardWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlShowuserInfoCardWithFilter1
            // 
            this.ctrlShowuserInfoCardWithFilter1.Location = new System.Drawing.Point(59, 116);
            this.ctrlShowuserInfoCardWithFilter1.Name = "ctrlShowuserInfoCardWithFilter1";
            this.ctrlShowuserInfoCardWithFilter1.Size = new System.Drawing.Size(1015, 708);
            this.ctrlShowuserInfoCardWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(357, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "View User Informations";
            // 
            // frmViewUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 833);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlShowuserInfoCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmViewUserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlShowuserInfoCardWithFilter ctrlShowuserInfoCardWithFilter1;
        private System.Windows.Forms.Label label1;
    }
}