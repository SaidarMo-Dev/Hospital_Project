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

namespace Hospital_Presentation.Patients
{
    public partial class frmManagePatient : Form
    {
        private DataTable _Patients;

        public frmManagePatient()
        {
            InitializeComponent();

            
        }

    


        private void _loadPatientsInfo()
        {
            _Patients = clsPatient.GetListPatients();

            dgvListPatients.DataSource = _Patients;

            lblPatientCount.Text = dgvListPatients.RowCount.ToString();

            

            if (dgvListPatients.RowCount > 0)
            {

                cbSortBy.SelectedIndex = 0;

                dgvListPatients.Columns[0].HeaderText = "Patient ID";
                dgvListPatients.Columns[0].Width = 120;

                dgvListPatients.Columns[1].HeaderText = "Person ID";
                dgvListPatients.Columns[1].Width = 120;
               
                dgvListPatients.Columns[2].HeaderText = "Full Name";
                dgvListPatients.Columns[2].Width = 220;
              
                dgvListPatients.Columns[3].HeaderText = "Address";
                dgvListPatients.Columns[3].Width = 280;
             
                dgvListPatients.Columns[4].HeaderText = "Email";
                dgvListPatients.Columns[4].Width = 250;

                dgvListPatients.Columns[5].HeaderText = "Country";
                dgvListPatients.Columns[5].Width = 120;

                dgvListPatients.Columns[6].HeaderText = "Blood Type";
                dgvListPatients.Columns[6].Width = 120;

                dgvListPatients.Columns[7].HeaderText = "Assurance Number";
                dgvListPatients.Columns[7].Width = 230;


            }


        }
    
        private void _PerformeSorting()
        {
            string filter = cbSortBy.SelectedItem.ToString();

            switch (filter)
            {
                case "Patient ID":

                    _Patients.DefaultView.Sort = "PatientID";
                    
                    break;

                case "Person ID":

                    _Patients.DefaultView.Sort = "PersonID";
                    break;

                case "Full Name":

                    _Patients.DefaultView.Sort = "FullName";
                    break;

                case "Assurance Number":

                    _Patients.DefaultView.Sort = "AssuranceNumber";

                    break;

                default:

                    _Patients.DefaultView.Sort = "PatientID";

                    break;
            }

        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvListPatients.RowCount > 0)
            {

                _PerformeSorting();
            }
        }

        private void tbSearchForPersonByName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearchForPersonByName.Text.ToString()))
                _Patients.DefaultView.RowFilter = 
                                    $"FullName LIKE '{tbSearchForPersonByName.Text.Trim()}%'";
            else
                _Patients.DefaultView.RowFilter = "";

        }

        private void frmMaagePatient_Load(object sender, EventArgs e)
        {
            cbSortBy.SelectedIndex = 0;

            _loadPatientsInfo();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addPatient = new frmAddUpdatePatient(); 
            
            addPatient.ShowDialog();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            var UpdatePatient = new frmAddUpdatePatient(Convert.ToInt32(dgvListPatients.CurrentRow.Cells[0].Value));

            UpdatePatient.ShowDialog();
        }

        private void showPatientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowPatientInfo(Convert.ToInt32(dgvListPatients.CurrentRow.Cells[0].Value))
                
                .ShowDialog();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox .Show ("Are you sure you want to delete this Patient?",
                "Confirm",MessageBoxButtons.OKCancel , MessageBoxIcon.Question ) 
                
                == DialogResult.OK)
            {
               if (clsPatient.DeletePatient(Convert.ToInt32(dgvListPatients.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Patient deleted Successfuly.",
                            "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
               else
                {
                    MessageBox.Show("Cannot Delete this patient try Later...",
                           "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }


        
    }
}
