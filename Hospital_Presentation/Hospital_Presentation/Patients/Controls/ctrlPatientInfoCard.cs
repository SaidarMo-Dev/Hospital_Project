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

namespace Hospital_Presentation.Patients.Controls
{
    public partial class ctrlPatientInfoCard : UserControl
    {
        public ctrlPatientInfoCard()
        {
            InitializeComponent();
        }

        private int _patientID ;

        
     
        public clsPatient SelectedPatientInfo
        {
            get { return ctrlPatientInfo1.SelectedPatientInfo; }
        }

        public void LoadData(int PatientID)
        {
            _patientID = PatientID;

            ctrlPatientInfo1.LoadData(PatientID);

            _LoadPatientPrescriptionsInfo();

        }
        private void _LoadPatientPrescriptionsInfo()
        {
           
            var PatientPrescriptions = clsPrescription.PatientPrescriptions(_patientID);

            if (PatientPrescriptions == null || !(PatientPrescriptions.Rows.Count > 0))
                return;


            var columnsToExtract = new string[] { "PrescriptionID", "PatientFullName", 
                "MedicalName","Dosage", "Frequency", "SpecialInstructions" };

            var TargetPatientPrescriptionColumns = PatientPrescriptions.DefaultView
                                                    .ToTable(false,columnsToExtract);



            dgvPatientRecords.DataSource = TargetPatientPrescriptionColumns;

			lblTitle.Text = "Patient Prescriptions";

            if (dgvPatientRecords.RowCount > 0)
            {


                dgvPatientRecords.Columns[0].HeaderText = "Prescription ID";
                dgvPatientRecords.Columns[0].Width = 135;

                dgvPatientRecords.Columns[1].HeaderText = "Patient FullName";
                dgvPatientRecords.Columns[1].Width = 180;


                dgvPatientRecords.Columns[2].HeaderText = "Medical Name";
                dgvPatientRecords.Columns[2].Width = 150;


                dgvPatientRecords.Columns[3].HeaderText = "Dosage";
                dgvPatientRecords.Columns[3].Width = 120;


                dgvPatientRecords.Columns[4].HeaderText = "Frequency";
                dgvPatientRecords.Columns[4].Width = 120;

                dgvPatientRecords.Columns[5].HeaderText = "Special Instractions";
                dgvPatientRecords.Columns[5].Width = 185;

            }
        }

        private void _LoadPatientMedicalRecords()
        {
      

            var PatientMedicalRecords = clsMedicalRecord.PatientRecords(_patientID);


			if (PatientMedicalRecords == null || !(PatientMedicalRecords.Rows.Count > 0))
				return;



			var ColumnsToExctact = new string[] { "MedicalRecordId", "PatientName", "Visitdescription",
                "Diagnosis", "AdditionalNotes" };


            var TargetColumns = PatientMedicalRecords.DefaultView.ToTable(false, ColumnsToExctact);


            dgvPatientRecords.DataSource = TargetColumns;

            lblTitle.Text = "Patient Medical Records";


            if (dgvPatientRecords.RowCount > 0)
            {
				dgvPatientRecords.Columns[0].HeaderText = "Record ID";
				dgvPatientRecords.Columns[0].Width = 120;

				dgvPatientRecords.Columns[1].HeaderText = "Patient Name";
				dgvPatientRecords.Columns[1].Width = 200;

				dgvPatientRecords.Columns[2].HeaderText = "Visit Description";
                dgvPatientRecords.Columns[2].Width = 210;

                dgvPatientRecords.Columns[3].HeaderText = "Diagnosis";
                dgvPatientRecords.Columns[3].Width = 160;


                dgvPatientRecords.Columns[4].HeaderText = "Additional Notes";
                dgvPatientRecords.Columns[4].Width = 200;

            }
        }
        private void ctrlPatientInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            _LoadPatientPrescriptionsInfo();

        }

		private void btnMedicalRecords_Click(object sender, EventArgs e)
		{
			_LoadPatientMedicalRecords();
		}
	}
}
