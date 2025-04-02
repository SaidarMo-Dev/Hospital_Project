namespace Hospital_Presentation.MedicalRecords
{
	partial class frmManageMedicalRecords
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblRecordsCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSortBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tbSearchByPatientID = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvPatientMedicalRecords = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnFind = new Guna.UI2.WinForms.Guna2Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedicalRecords)).BeginInit();
			this.SuspendLayout();
			// 
			// lblRecordsCount
			// 
			this.lblRecordsCount.AutoSize = true;
			this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 17.75F);
			this.lblRecordsCount.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lblRecordsCount.Location = new System.Drawing.Point(21, 67);
			this.lblRecordsCount.Name = "lblRecordsCount";
			this.lblRecordsCount.Size = new System.Drawing.Size(39, 48);
			this.lblRecordsCount.TabIndex = 41;
			this.lblRecordsCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.75F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(64, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 30);
			this.label3.TabIndex = 42;
			this.label3.Text = "Records";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(193, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 28);
			this.label4.TabIndex = 43;
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
            "Medical Record Id",
            "Patient Id",
            "Patient Name"});
			this.cbSortBy.Location = new System.Drawing.Point(283, 70);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(373, 47);
			this.cbSortBy.TabIndex = 44;
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
			this.tbSearchByPatientID.Location = new System.Drawing.Point(898, 72);
			this.tbSearchByPatientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSearchByPatientID.Name = "tbSearchByPatientID";
			this.tbSearchByPatientID.PasswordChar = '\0';
			this.tbSearchByPatientID.PlaceholderText = "Patient Id";
			this.tbSearchByPatientID.SelectedText = "";
			this.tbSearchByPatientID.Size = new System.Drawing.Size(315, 47);
			this.tbSearchByPatientID.TabIndex = 45;
			this.tbSearchByPatientID.TextOffset = new System.Drawing.Point(2, 0);
			this.tbSearchByPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchByPatientID_KeyPress);
			// 
			// dgvPatientMedicalRecords
			// 
			this.dgvPatientMedicalRecords.AllowUserToAddRows = false;
			this.dgvPatientMedicalRecords.AllowUserToDeleteRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
			this.dgvPatientMedicalRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dgvPatientMedicalRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPatientMedicalRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dgvPatientMedicalRecords.ColumnHeadersHeight = 45;
			this.dgvPatientMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPatientMedicalRecords.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPatientMedicalRecords.DefaultCellStyle = dataGridViewCellStyle15;
			this.dgvPatientMedicalRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientMedicalRecords.Location = new System.Drawing.Point(20, 144);
			this.dgvPatientMedicalRecords.Name = "dgvPatientMedicalRecords";
			this.dgvPatientMedicalRecords.ReadOnly = true;
			this.dgvPatientMedicalRecords.RowHeadersVisible = false;
			this.dgvPatientMedicalRecords.RowHeadersWidth = 62;
			this.dgvPatientMedicalRecords.RowTemplate.DividerHeight = 1;
			this.dgvPatientMedicalRecords.RowTemplate.Height = 45;
			this.dgvPatientMedicalRecords.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPatientMedicalRecords.Size = new System.Drawing.Size(1350, 542);
			this.dgvPatientMedicalRecords.TabIndex = 40;
			this.dgvPatientMedicalRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientMedicalRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPatientMedicalRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPatientMedicalRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPatientMedicalRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPatientMedicalRecords.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientMedicalRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvPatientMedicalRecords.ThemeStyle.HeaderStyle.Height = 45;
			this.dgvPatientMedicalRecords.ThemeStyle.ReadOnly = true;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.Height = 45;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.dgvPatientMedicalRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
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
			this.btnFind.Location = new System.Drawing.Point(1229, 72);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(141, 45);
			this.btnFind.TabIndex = 46;
			this.btnFind.Text = "Find";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(22, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 41);
			this.label1.TabIndex = 56;
			this.label1.Text = "Patient Records";
			// 
			// frmManageMedicalRecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1393, 701);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lblRecordsCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbSortBy);
			this.Controls.Add(this.tbSearchByPatientID);
			this.Controls.Add(this.dgvPatientMedicalRecords);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmManageMedicalRecords";
			this.Text = "frmManageMedicalRecords";
			this.Load += new System.EventHandler(this.frmManageMedicalRecords_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedicalRecords)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRecordsCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ComboBox cbSortBy;
		private Guna.UI2.WinForms.Guna2TextBox tbSearchByPatientID;
		private Guna.UI2.WinForms.Guna2DataGridView dgvPatientMedicalRecords;
		private Guna.UI2.WinForms.Guna2Button btnFind;
		private System.Windows.Forms.Label label1;
	}
}