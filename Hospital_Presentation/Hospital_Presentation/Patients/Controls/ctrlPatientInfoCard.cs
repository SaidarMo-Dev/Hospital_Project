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
            //dgvPatientRecords.DataSource = clsPrescriptions.GetPatientPrescriptions(_patientID);

            lblTitle.Text = "Patient Prescriptions";

            if (dgvPatientRecords.RowCount > 0)
            {
                dgvPatientRecords.Columns[0].HeaderText = "Medical Name";
                dgvPatientRecords.Columns[0].Width = 100;

                dgvPatientRecords.Columns[1].HeaderText = "Dosage";
                dgvPatientRecords.Columns[1].Width = 100;


                dgvPatientRecords.Columns[2].HeaderText = "Frequency";
                dgvPatientRecords.Columns[2].Width = 100;



            }
        }

        private void _LoadPatientMedicalRecords()
        {
            //dgvPatientRecords.DataSource = clsMedicalRecords.GetPatientMedicalRecords(_patientID);

            lblTitle.Text = "Patient Medical Records";


            if (dgvPatientRecords.RowCount > 0)
            {
                dgvPatientRecords.Columns[0].HeaderText = "Visit Description";
                dgvPatientRecords.Columns[0].Width = 120;

                dgvPatientRecords.Columns[1].HeaderText = "Diagnosis";
                dgvPatientRecords.Columns[1].Width = 100;


                dgvPatientRecords.Columns[2].HeaderText = "Additional Notes";
                dgvPatientRecords.Columns[2].Width = 120;



            }
        }


        private void ctrlPatientInfo1_Load(object sender, EventArgs e)
        {

        }


   
        private void btnMedicalRecords_Click(object sender, EventArgs e)
        {
            _LoadPatientMedicalRecords();
        }

        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            _LoadPatientPrescriptionsInfo();

        }
    }
}
