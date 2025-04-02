using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.MedicalRecords
{
	public partial class frmManageMedicalRecords : Form
	{
		public frmManageMedicalRecords()
		{
			InitializeComponent();
		}

		private DataTable _patientRecords = new DataTable();

		private void _loadPatientRecords(int patientId)
		{
			cbSortBy.Enabled = false;


			_patientRecords = clsMedicalRecord.PatientRecords(patientId);

			dgvPatientMedicalRecords.DataSource = _patientRecords;
			lblRecordsCount.Text = dgvPatientMedicalRecords .RowCount .ToString();

			
			if (dgvPatientMedicalRecords.RowCount > 0)
			{

				cbSortBy.Enabled = true;

				dgvPatientMedicalRecords.Columns[0].HeaderText = "Medical RecordID";
				dgvPatientMedicalRecords.Columns[0].Width = 120;

				dgvPatientMedicalRecords.Columns[1].HeaderText = "PatientID";
				dgvPatientMedicalRecords.Columns[1].Width = 120;

				dgvPatientMedicalRecords.Columns[2].HeaderText = "AppointmentID";
				dgvPatientMedicalRecords.Columns[2].Width = 120;

				dgvPatientMedicalRecords.Columns[3].HeaderText = "Patient Full Name";
				dgvPatientMedicalRecords.Columns[3].Width = 250;

				dgvPatientMedicalRecords.Columns[4].HeaderText = "Visit Description";
				dgvPatientMedicalRecords.Columns[4].Width = 220;

				dgvPatientMedicalRecords.Columns[5].HeaderText = "Diagnosis";
				dgvPatientMedicalRecords.Columns[5].Width = 220;
				
				dgvPatientMedicalRecords.Columns[6].HeaderText = "Additional Notes";
				dgvPatientMedicalRecords.Columns[6].Width = 270;


			}
		}
	
		private void _LoadData()
		{
			if(string.IsNullOrWhiteSpace(tbSearchByPatientID.Text))
			{
				MessageBox.Show("Patient Id is  null make sure to enter the Patient Id",
					"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			_loadPatientRecords(Convert.ToInt16(tbSearchByPatientID.Text));

		}

		private void _Sort()
		{
			

			switch (cbSortBy.SelectedItem.ToString())
			{
				case "Medical Record Id":
					_patientRecords.DefaultView.Sort = "MedicalRecordId";
					break;

				case "PatientId":
					_patientRecords.DefaultView.Sort = "PatientId";
					break;

				case "Patient Name":
					_patientRecords.DefaultView.Sort = "PatientName";
					break;

				default:
					_patientRecords.DefaultView.Sort = "MedicalRecordId";
					break;

			}


		}
		private void btnFind_Click(object sender, EventArgs e)
		{
			_LoadData();

		}

		private void tbSearchByPatientID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
			{
				e.Handled = true;

			}
		}

		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
			if(_patientRecords.Rows.Count > 0)
					_Sort();
		}

		private void frmManageMedicalRecords_Load(object sender, EventArgs e)
		{
			cbSortBy.SelectedIndex = 0;
			cbSortBy.Enabled = false;

		}
	
	}
}
