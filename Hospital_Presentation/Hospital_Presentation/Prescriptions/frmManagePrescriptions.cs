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

namespace Hospital_Presentation.Prescriptions
{
	public partial class frmManagePrescriptions : Form
	{
		public frmManagePrescriptions()
		{
			InitializeComponent();
		}

		DataTable _dtPatientPrescriptions = new DataTable();
		
		private void _loadPatientprescriptions(int patientId)
		{
			_dtPatientPrescriptions = clsPrescription.PatientPrescriptions(patientId);

			dgvPatientPrescriptions.DataSource = _dtPatientPrescriptions;
			lblRecordsCount.Text = dgvPatientPrescriptions.RowCount.ToString();

			
			cbSortBy.Enabled = false;

			if (dgvPatientPrescriptions .RowCount> 0)
			{
				cbSortBy.Enabled = true;

				dgvPatientPrescriptions.Columns[0].HeaderText = "Prescription ID ";
				dgvPatientPrescriptions.Columns[0].Width = 110;

				dgvPatientPrescriptions.Columns[1].HeaderText = "Patient ID ";
				dgvPatientPrescriptions.Columns[1].Width = 110;

				dgvPatientPrescriptions.Columns[1].HeaderText = "Appointment ID ";
				dgvPatientPrescriptions.Columns[1].Width = 110;

				dgvPatientPrescriptions.Columns[2].HeaderText = "Patient FulllName ";
				dgvPatientPrescriptions.Columns[2].Width = 250;

				dgvPatientPrescriptions.Columns[3].HeaderText = "Medical Name ";
				dgvPatientPrescriptions.Columns[3].Width = 150;

				dgvPatientPrescriptions.Columns[4].HeaderText = "Dosage";
				dgvPatientPrescriptions.Columns[4].Width = 150;

				dgvPatientPrescriptions.Columns[5].HeaderText = "Frequency ";
				dgvPatientPrescriptions.Columns[5].Width = 150;

				dgvPatientPrescriptions.Columns[6].HeaderText = "Start Date ";
				dgvPatientPrescriptions.Columns[6].Width = 200;
				
				dgvPatientPrescriptions.Columns[7].HeaderText = "End Date";
				dgvPatientPrescriptions.Columns[7].Width = 200;

				dgvPatientPrescriptions.Columns[8].HeaderText = "Special Instractions ";
				dgvPatientPrescriptions.Columns[8].Width = 200;



			}
		}
		
		private void _loadData()
		{
			if (string.IsNullOrWhiteSpace(tbSearchByPatientID.Text))
			{
				MessageBox.Show("Patient Id is  null make sure to enter the Patient Id",
					"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}

			_loadPatientprescriptions(Convert.ToInt32(tbSearchByPatientID.Text));
		}

		private void _Sort()
		{


			switch (cbSortBy.SelectedItem.ToString())
			{
				case "Prescription Id":
					_dtPatientPrescriptions.DefaultView.Sort = "PrescriptionId";
					break;

				case "PatientId":
					_dtPatientPrescriptions.DefaultView.Sort = "PatientId";
					break;

				case "Patient Name":
					_dtPatientPrescriptions.DefaultView.Sort = "PatientFullName";
					break;

				default:
					_dtPatientPrescriptions.DefaultView.Sort = "PrescriptionId";
					break;

			}


		}
		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dgvPatientPrescriptions.RowCount > 0)
			{
				_Sort();

			}
		}

		private void tbSearchByPatientID_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			_loadData();

		}

		private void frmManagePrescriptions_Load(object sender, EventArgs e)
		{

			cbSortBy.SelectedIndex = 0;
			cbSortBy.Enabled = false;
		}
	}
}
