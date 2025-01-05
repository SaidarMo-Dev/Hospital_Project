namespace Hospital_Presentation.Patients.Controls
{
    partial class ctrlPatientInfoCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchByPatientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPatientInfoCard1 = new Hospital_Presentation.Patients.Controls.ctrlPatientInfoCard();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchByPatientID
            // 
            this.txtSearchByPatientID.BorderRadius = 15;
            this.txtSearchByPatientID.BorderThickness = 0;
            this.txtSearchByPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByPatientID.DefaultText = "";
            this.txtSearchByPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByPatientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByPatientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByPatientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByPatientID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPatientID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchByPatientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByPatientID.Location = new System.Drawing.Point(498, 13);
            this.txtSearchByPatientID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearchByPatientID.Name = "txtSearchByPatientID";
            this.txtSearchByPatientID.PasswordChar = '\0';
            this.txtSearchByPatientID.PlaceholderText = "PatientID";
            this.txtSearchByPatientID.SelectedText = "";
            this.txtSearchByPatientID.Size = new System.Drawing.Size(587, 59);
            this.txtSearchByPatientID.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BorderRadius = 10;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.DimGray;
            this.btnFind.Location = new System.Drawing.Point(1116, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(165, 59);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPatientInfoCard1
            // 
            this.ctrlPatientInfoCard1.Location = new System.Drawing.Point(6, 67);
            this.ctrlPatientInfoCard1.Name = "ctrlPatientInfoCard1";
            this.ctrlPatientInfoCard1.Size = new System.Drawing.Size(1414, 632);
            this.ctrlPatientInfoCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient Profile";
            // 
            // ctrlPatientInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchByPatientID);
            this.Controls.Add(this.ctrlPatientInfoCard1);
            this.Name = "ctrlPatientInfoCardWithFilter";
            this.Size = new System.Drawing.Size(1420, 693);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPatientInfoCard ctrlPatientInfoCard1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByPatientID;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label1;
    }
}
