namespace Hospital_Presentation.Prescriptions
{
	partial class frmManagePrescriptions
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tbSearchByPatientID = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvPatientPrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatientPrescriptions)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.BorderRadius = 5;
			this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnFind.FillColor = System.Drawing.Color.LightSkyBlue;
			this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFind.Location = new System.Drawing.Point(1233, 76);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(141, 45);
			this.btnFind.TabIndex = 54;
			this.btnFind.Text = "Find";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 15.75F);
			this.lblRecordsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblRecordsCount.Location = new System.Drawing.Point(25, 71);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(37, 45);
			this.lblRecordsCount.TabIndex = 49;
			this.lblRecordsCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(68, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 30);
			this.label3.TabIndex = 50;
			this.label3.Text = "Records";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(197, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 51;
			this.label4.Text = "Sort By :";
			// 
			// cbSortBy
			// 
			this.cbSortBy.BackColor = System.Drawing.Color.Transparent;
			this.cbSortBy.BorderRadius = 7;
			this.cbSortBy.BorderThickness = 0;
			this.cbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSortBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSortBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbSortBy.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbSortBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbSortBy.ItemHeight = 41;
			this.cbSortBy.Items.AddRange(new object[] {
            "None",
            "Prescription Id",
            "Patient Id",
            "Patient Name"});
			this.cbSortBy.Location = new System.Drawing.Point(287, 74);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 47);
			this.cbSortBy.TabIndex = 52;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
			// 
			// tbSearchByPatientID
			// 
			this.tbSearchByPatientID.BorderRadius = 7;
			this.tbSearchByPatientID.BorderThickness = 0;
			this.tbSearchByPatientID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearchByPatientID.DefaultText = "";
			this.tbSearchByPatientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearchByPatientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearchByPatientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByPatientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearchByPatientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByPatientID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbSearchByPatientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearchByPatientID.Location = new System.Drawing.Point(902, 76);
			this.tbSearchByPatientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSearchByPatientID.Name = "tbSearchByPatientID";
			this.tbSearchByPatientID.PasswordChar = '\0';
			this.tbSearchByPatientID.PlaceholderText = "Patient Id";
			this.tbSearchByPatientID.SelectedText = "";
			this.tbSearchByPatientID.Size = new System.Drawing.Size(315, 47);
			this.tbSearchByPatientID.TabIndex = 53;
			this.tbSearchByPatientID.TextOffset = new System.Drawing.Point(2, 0);
			this.tbSearchByPatientID.TextChanged += new System.EventHandler(this.tbSearchByPatientID_TextChanged);
			// 
			// dgvPatientPrescriptions
			// 
			this.dgvPatientPrescriptions.AllowUserToAddRows = false;
			this.dgvPatientPrescriptions.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dgvPatientPrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvPatientPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPatientPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvPatientPrescriptions.ColumnHeadersHeight = 45;
			this.dgvPatientPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPatientPrescriptions.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPatientPrescriptions.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvPatientPrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientPrescriptions.Location = new System.Drawing.Point(24, 148);
			this.dgvPatientPrescriptions.Name = "dgvPatientPrescriptions";
			this.dgvPatientPrescriptions.ReadOnly = true;
			this.dgvPatientPrescriptions.RowHeadersVisible = false;
			this.dgvPatientPrescriptions.RowHeadersWidth = 62;
			this.dgvPatientPrescriptions.RowTemplate.DividerHeight = 1;
			this.dgvPatientPrescriptions.RowTemplate.Height = 45;
			this.dgvPatientPrescriptions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPatientPrescriptions.Size = new System.Drawing.Size(1350, 542);
			this.dgvPatientPrescriptions.TabIndex = 48;
			this.dgvPatientPrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientPrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPatientPrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPatientPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPatientPrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPatientPrescriptions.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientPrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPatientPrescriptions.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvPatientPrescriptions.ThemeStyle.ReadOnly = true;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.Height = 45;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvPatientPrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
			this.label2.Location = new System.Drawing.Point(17, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(287, 41);
			this.label2.TabIndex = 56;
			this.label2.Text = "Patient Prescriptions";
			// 
			// frmManagePrescriptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1387, 708);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.tbSearchByPatientID);
			this.Controls.Add(this.dgvPatientPrescriptions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManagePrescriptions";
			this.Text = "frmManagePrescriptions";
			this.Load += new System.EventHandler(this.frmManagePrescriptions_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatientPrescriptions)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private System.Windows.Forms.Label lblRecordsCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
		private Guna.UI2.WinForms.Guna2TextBox tbSearchByPatientID;
		private Guna.UI2.WinForms.Guna2DataGridView dgvPatientPrescriptions;
		private System.Windows.Forms.Label label2;
	}
}