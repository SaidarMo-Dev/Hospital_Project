namespace Hospital_Presentation.Patients
{
    partial class frmShowPatientInfo
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
            this.ctrlPatientInfoCard1 = new Hospital_Presentation.Patients.Controls.ctrlPatientInfoCard();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPatientInfoCard1
            // 
            this.ctrlPatientInfoCard1.Location = new System.Drawing.Point(3, 41);
            this.ctrlPatientInfoCard1.Name = "ctrlPatientInfoCard1";
            this.ctrlPatientInfoCard1.Size = new System.Drawing.Size(1414, 632);
            this.ctrlPatientInfoCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Profile";
            // 
            // frmShowPatientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPatientInfoCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPatientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowPatientInfo";
            this.Load += new System.EventHandler(this.frmShowPatientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPatientInfoCard ctrlPatientInfoCard1;
        private System.Windows.Forms.Label label1;
    }
}