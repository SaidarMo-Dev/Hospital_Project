namespace Hospital_Presentation.Users.Controls
{
	partial class ctrlUserInfoCardWithFilterV2
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
			this.ctrlUserInfoCardV21 = new Hospital_Presentation.Users.Controls.ctrlUserInfoCardV2();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.txtSearchByUserID = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// ctrlUserInfoCardV21
			// 
			this.ctrlUserInfoCardV21.Location = new System.Drawing.Point(6, 107);
			this.ctrlUserInfoCardV21.Name = "ctrlUserInfoCardV21";
			this.ctrlUserInfoCardV21.Size = new System.Drawing.Size(1002, 396);
			this.ctrlUserInfoCardV21.TabIndex = 0;
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
			this.btnFind.Location = new System.Drawing.Point(749, 22);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(122, 55);
			this.btnFind.TabIndex = 6;
			this.btnFind.Text = "Find";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// txtSearchByUserID
			// 
			this.txtSearchByUserID.BorderRadius = 15;
			this.txtSearchByUserID.BorderThickness = 0;
			this.txtSearchByUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSearchByUserID.DefaultText = "";
			this.txtSearchByUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSearchByUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSearchByUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchByUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSearchByUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchByUserID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtSearchByUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSearchByUserID.Location = new System.Drawing.Point(122, 22);
			this.txtSearchByUserID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.txtSearchByUserID.Name = "txtSearchByUserID";
			this.txtSearchByUserID.PasswordChar = '\0';
			this.txtSearchByUserID.PlaceholderForeColor = System.Drawing.Color.Silver;
			this.txtSearchByUserID.PlaceholderText = "Enter User ID";
			this.txtSearchByUserID.SelectedText = "";
			this.txtSearchByUserID.Size = new System.Drawing.Size(615, 55);
			this.txtSearchByUserID.TabIndex = 5;
			this.txtSearchByUserID.TextChanged += new System.EventHandler(this.txtSearchByUserID_TextChanged);
			this.txtSearchByUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchByUserID_KeyPress);
			// 
			// ctrlUserInfoCardWithFilterV2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtSearchByUserID);
			this.Controls.Add(this.ctrlUserInfoCardV21);
			this.Name = "ctrlUserInfoCardWithFilterV2";
			this.Size = new System.Drawing.Size(1024, 512);
			this.ResumeLayout(false);

		}

		#endregion

		private ctrlUserInfoCardV2 ctrlUserInfoCardV21;
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private Guna.UI2.WinForms.Guna2TextBox txtSearchByUserID;
	}
}
