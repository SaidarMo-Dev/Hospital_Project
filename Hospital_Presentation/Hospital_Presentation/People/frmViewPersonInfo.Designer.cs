namespace Hospital_Presentation.People
{
    partial class frmViewPersonInfo
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
            this.ctrlPersonInfoCardWithFilter1 = new Hospital_Presentation.People.Controls.ctrlPersonInfoCardWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoCardWithFilter1
            // 
            this.ctrlPersonInfoCardWithFilter1.Location = new System.Drawing.Point(12, 95);
            this.ctrlPersonInfoCardWithFilter1.Name = "ctrlPersonInfoCardWithFilter1";
            this.ctrlPersonInfoCardWithFilter1.Size = new System.Drawing.Size(1009, 587);
            this.ctrlPersonInfoCardWithFilter1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(309, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for  a  person";
            // 
            // frmViewPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPersonInfoCardWithFilter1);
            this.Name = "frmViewPersonInfo";
            this.Text = "frmViewPersonInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPersonInfoCardWithFilter ctrlPersonInfoCardWithFilter1;
        private System.Windows.Forms.Label label1;
    }
}