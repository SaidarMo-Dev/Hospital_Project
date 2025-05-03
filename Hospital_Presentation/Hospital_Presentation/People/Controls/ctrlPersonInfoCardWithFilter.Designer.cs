namespace Hospital_Presentation.People.Controls
{
    partial class ctrlPersonInfoCardWithFilter
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
			this.ctrlPersonInfoCard1 = new Hospital_Presentation.People.Controls.ctrlPersonInfoCard();
			this.tbSearchByPersonId = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// ctrlPersonInfoCard1
			// 
			this.ctrlPersonInfoCard1.Location = new System.Drawing.Point(2, 79);
			this.ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
			this.ctrlPersonInfoCard1.Size = new System.Drawing.Size(927, 456);
			this.ctrlPersonInfoCard1.TabIndex = 0;
			// 
			// tbSearchByPersonId
			// 
			this.tbSearchByPersonId.BorderRadius = 15;
			this.tbSearchByPersonId.BorderThickness = 0;
			this.tbSearchByPersonId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearchByPersonId.DefaultText = "";
			this.tbSearchByPersonId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearchByPersonId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearchByPersonId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByPersonId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByPersonId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByPersonId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.tbSearchByPersonId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByPersonId.Location = new System.Drawing.Point(12, 17);
			this.tbSearchByPersonId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.tbSearchByPersonId.Name = "tbSearchByPersonId";
			this.tbSearchByPersonId.PasswordChar = '\0';
			this.tbSearchByPersonId.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.tbSearchByPersonId.PlaceholderText = "Enter Person ID";
			this.tbSearchByPersonId.SelectedText = "";
			this.tbSearchByPersonId.Size = new System.Drawing.Size(508, 55);
			this.tbSearchByPersonId.TabIndex = 1;
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Transparent;
			this.btnFind.BorderColor = System.Drawing.Color.LightGray;
			this.btnFind.BorderRadius = 15;
			this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnFind.FillColor = System.Drawing.Color.White;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnFind.ForeColor = System.Drawing.Color.Black;
			this.btnFind.Location = new System.Drawing.Point(531, 17);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(172, 55);
			this.btnFind.TabIndex = 2;
			this.btnFind.Text = "Find";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnAddNewPerson
			// 
			this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
			this.btnAddNewPerson.BorderColor = System.Drawing.Color.LightGray;
			this.btnAddNewPerson.BorderRadius = 15;
			this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAddNewPerson.FillColor = System.Drawing.Color.CornflowerBlue;
			this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnAddNewPerson.ForeColor = System.Drawing.Color.Black;
			this.btnAddNewPerson.Location = new System.Drawing.Point(714, 18);
			this.btnAddNewPerson.Name = "btnAddNewPerson";
			this.btnAddNewPerson.Size = new System.Drawing.Size(172, 55);
			this.btnAddNewPerson.TabIndex = 3;
			this.btnAddNewPerson.Text = "Create Person";
			this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
			// 
			// ctrlPersonInfoCardWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnAddNewPerson);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.tbSearchByPersonId);
			this.Controls.Add(this.ctrlPersonInfoCard1);
			this.Name = "ctrlPersonInfoCardWithFilter";
			this.Size = new System.Drawing.Size(935, 540);
			this.Load += new System.EventHandler(this.ctrlPersonInfoCardWithFilter_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfoCard ctrlPersonInfoCard1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchByPersonId;
        private Guna.UI2.WinForms.Guna2Button btnFind;
		private Guna.UI2.WinForms.Guna2Button btnAddNewPerson;
	}
}
