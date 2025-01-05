namespace Hospital_Presentation.Patients
{
    partial class frmViewPatient
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
            this.ctrlPatientInfoCardWithFilter1 = new Hospital_Presentation.Patients.Controls.ctrlPatientInfoCardWithFilter();
            this.SuspendLayout();
            // 
            // ctrlPatientInfoCardWithFilter1
            // 
            this.ctrlPatientInfoCardWithFilter1.Location = new System.Drawing.Point(-4, 10);
            this.ctrlPatientInfoCardWithFilter1.Name = "ctrlPatientInfoCardWithFilter1";
            this.ctrlPatientInfoCardWithFilter1.Size = new System.Drawing.Size(1420, 693);
            this.ctrlPatientInfoCardWithFilter1.TabIndex = 0;
            this.ctrlPatientInfoCardWithFilter1.Load += new System.EventHandler(this.ctrlPatientInfoCardWithFilter1_Load);
            // 
            // frmViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 708);
            this.Controls.Add(this.ctrlPatientInfoCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmViewPatient";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPatientInfoCardWithFilter ctrlPatientInfoCardWithFilter1;
    }
}