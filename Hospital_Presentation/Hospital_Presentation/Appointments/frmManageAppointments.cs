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
using Hospital_Presentation.MedicalRecords;
using Hospital_Presentation.Prescriptions;

namespace Hospital_Presentation.Appointments
{
    public partial class frmManageAppointments : Form
    {
        public frmManageAppointments()
        {
            InitializeComponent();
        }


        DataTable _Appointments;

        private void _LoadAppointments()
        {
            _Appointments = clsAppointment.GetListAppointments();
            dgvListAppointments.DataSource = _Appointments;


            lblPatientCount.Text = dgvListAppointments.RowCount.ToString();

            if (dgvListAppointments.RowCount > 0)
            {
                dgvListAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvListAppointments.Columns[0].Width = 120;

                dgvListAppointments.Columns[1].HeaderText = "Patient ID";
                dgvListAppointments.Columns[1].Width = 120;


                dgvListAppointments.Columns[2].HeaderText = "Doctor ID";
                dgvListAppointments.Columns[2].Width = 120;
             
                dgvListAppointments.Columns[3].HeaderText = "Appointment Date";
                dgvListAppointments.Columns[3].Width = 270;


                dgvListAppointments.Columns[4].HeaderText = "Status";
                dgvListAppointments.Columns[4].Width = 110;

                dgvListAppointments.Columns[5].HeaderText = "Notes";
                dgvListAppointments.Columns[5].Width = 280;


                dgvListAppointments.Columns[6].HeaderText = "Created Date";
                dgvListAppointments.Columns[6].Width = 270;

                dgvListAppointments.Columns[7].HeaderText = "Created User ID";
                dgvListAppointments.Columns[7].Width = 140;




            }
        }

        private void _Sort()
        {

            
            switch (cbSortBy .SelectedItem.ToString ())
            {
                case "Appointment ID":

                    _Appointments.DefaultView.Sort = "AppointmentID";
                    break;

                case "patient ID":

                    _Appointments.DefaultView.Sort = "PatientID";
                    break;

                case "Doctor ID":

                    _Appointments.DefaultView.Sort = "DoctorID";
                    break;



                default:
                    _Appointments.DefaultView.Sort = "AppointmentID";
                    break;


            }
        }
        
       
        private void frmManageAppointments_Load(object sender, EventArgs e)
        {
            cbSortBy.SelectedIndex = 0;

            _LoadAppointments();
        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbSortBy.SelectedIndex == 0))
            {
                _Sort();

            }
        }

		private void fillMedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new frmMedicalRecord(Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value))
                .ShowDialog();

		}

		private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new frmAddPrescriptions(Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value))
                .ShowDialog();

            
		}

		private void cmsAppointmentsMenu_Opening(object sender, CancelEventArgs e)
		{
            var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);

            var appointment = clsAppointment.FindByID(appointmentId);

            bool HasMedicalRecord = appointment.HasMedicalRecord();

            if (appointment.AppointmentStatus == 3)
            {

                editAppointmentToolStripMenuItem.Enabled = false;
                editAppointmentToolStripMenuItem.ForeColor = Color.DarkGray;

			}

			if (!HasMedicalRecord)
            {
                MedicalRecordToolStripMenuItem.Enabled = true;
                prescriptionToolStripMenuItem.Enabled = false;

                prescriptionToolStripMenuItem.ForeColor = Color.DarkGray;

                return;

            }

		
            var hasPrescription = appointment.HasPrescriptions();

            if (!hasPrescription && HasMedicalRecord)
            {
				MedicalRecordToolStripMenuItem.Enabled = false;
				prescriptionToolStripMenuItem.Enabled = true;

                MedicalRecordToolStripMenuItem.ForeColor = Color.DarkGray;
				return;
            }

			MedicalRecordToolStripMenuItem.Enabled = false;
			prescriptionToolStripMenuItem.Enabled = false;

			MedicalRecordToolStripMenuItem.ForeColor = Color.DarkGray;
			prescriptionToolStripMenuItem.ForeColor = Color.DarkGray;
           
          

		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void addNewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new frmAddUpdateAppointment().ShowDialog();

		}

		private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);
            new frmAddUpdateAppointment(appointmentId).ShowDialog();

            _LoadAppointments();
		}

		private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			

        }

		private void deleteAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

			var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);

			var appointment = clsAppointment.FindByID(appointmentId);

			bool HasMedicalRecord = appointment.HasMedicalRecord();

			if (appointment.AppointmentStatus == 3 || appointment.AppointmentStatus == 2)
			{

				editAppointmentToolStripMenuItem.Enabled = false;
				MedicalRecordToolStripMenuItem.Enabled = false;
				prescriptionToolStripMenuItem.Enabled = false;
				deleteAppointmentToolStripMenuItem.Enabled = false;
				cancelAppointmentToolStripMenuItem.Enabled = false;

				return;
			}

			editAppointmentToolStripMenuItem.Enabled = true;
			deleteAppointmentToolStripMenuItem.Enabled = true;
			cancelAppointmentToolStripMenuItem.Enabled = true;


			if (!HasMedicalRecord)
			{
				MedicalRecordToolStripMenuItem.Enabled = true;
				prescriptionToolStripMenuItem.Enabled = false;

				
				return;

			}


			var hasPrescription = appointment.HasPrescriptions();

			if (!hasPrescription && HasMedicalRecord)
			{
				MedicalRecordToolStripMenuItem.Enabled = false;
				prescriptionToolStripMenuItem.Enabled = true;

				return;
			}

			MedicalRecordToolStripMenuItem.Enabled = false;
			prescriptionToolStripMenuItem.Enabled = false;

			


		}

		private void showAppointmentInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{

			var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);
			new frmShowAppointmentInfo(appointmentId).ShowDialog();

		}

		private void takeAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void cancelAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are You sure you want to Cancel this appointment?",
					"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);

				var appointment = clsAppointment.FindByID(appointmentId);

				appointment.Cancel();

				_LoadAppointments();

			}

		}

		private void deleteAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are You sure you want to delete this Person ?",
					"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				var appointmentId = Convert.ToInt16(dgvListAppointments.CurrentRow.Cells[0].Value);

				if (clsAppointment.DeleteAppointments(appointmentId))
				{
					MessageBox.Show("Person Deleted Successfuly",
					"Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

					_LoadAppointments();

				}
				else
				{
					MessageBox.Show("Error: Cannot Delete this person",
					"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
		}

		private void takeAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void editAppointmentToolStripMenuItem_Click_1(object sender, EventArgs e)
		{

			new frmAddUpdateAppointment(Convert.ToInt32(dgvListAppointments.CurrentRow.Cells[0].Value))
				.ShowDialog();
		}

		private void addNewAppointmentToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			new frmAddUpdateAppointment()
				.ShowDialog();

		}

		private void MedicalRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmMedicalRecord(Convert.ToInt32(dgvListAppointments.CurrentRow.Cells[0].Value))
				.ShowDialog();
		}

		private void prescriptionToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			new frmAddPrescriptions((Convert.ToInt32(dgvListAppointments.CurrentRow.Cells[0].Value)))
				.ShowDialog();

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			new frmAddUpdateAppointment()
				.ShowDialog();

		}
	}
}
