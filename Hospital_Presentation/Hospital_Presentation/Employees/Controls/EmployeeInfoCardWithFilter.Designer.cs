namespace Hospital_Presentation.Employees.Controls
{
    partial class EmployeeInfoCardWithFilter
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
            this.ctrlEmployeeInfo1 = new Hospital_Presentation.Employees.Controls.ctrlEmployeeInfo();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearchByEmployeeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ctrlEmployeeInfo1
            // 
            this.ctrlEmployeeInfo1.Location = new System.Drawing.Point(3, 84);
            this.ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            this.ctrlEmployeeInfo1.Size = new System.Drawing.Size(1034, 538);
            this.ctrlEmployeeInfo1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.LightGray;
            this.btnFind.BorderRadius = 15;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFind.FillColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Location = new System.Drawing.Point(762, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(122, 55);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbSearchByEmployeeID
            // 
            this.tbSearchByEmployeeID.BorderRadius = 15;
            this.tbSearchByEmployeeID.BorderThickness = 0;
            this.tbSearchByEmployeeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByEmployeeID.DefaultText = "";
            this.tbSearchByEmployeeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchByEmployeeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchByEmployeeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchByEmployeeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchByEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchByEmployeeID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbSearchByEmployeeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchByEmployeeID.Location = new System.Drawing.Point(127, 20);
            this.tbSearchByEmployeeID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tbSearchByEmployeeID.Name = "tbSearchByEmployeeID";
            this.tbSearchByEmployeeID.PasswordChar = '\0';
            this.tbSearchByEmployeeID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchByEmployeeID.PlaceholderText = "Enter Employee ID";
            this.tbSearchByEmployeeID.SelectedText = "";
            this.tbSearchByEmployeeID.Size = new System.Drawing.Size(615, 55);
            this.tbSearchByEmployeeID.TabIndex = 3;
            this.tbSearchByEmployeeID.TextChanged += new System.EventHandler(this.tbSearchByEmployeeID_TextChanged);
            this.tbSearchByEmployeeID.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearchByEmployeeID_Validating);
            // 
            // EmployeeInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbSearchByEmployeeID);
            this.Controls.Add(this.ctrlEmployeeInfo1);
            this.Name = "EmployeeInfoCardWithFilter";
            this.Size = new System.Drawing.Size(1036, 624);
            this.Load += new System.EventHandler(this.EmployeeInfoCardWithFilter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlEmployeeInfo ctrlEmployeeInfo1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchByEmployeeID;
    }
}
