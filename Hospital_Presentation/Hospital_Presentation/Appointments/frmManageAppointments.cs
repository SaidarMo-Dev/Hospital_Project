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

             lblPatientCount.Text = dgvListAppointments.RowCount.ToString();

            if (dgvListAppointments.RowCount > 0)
            {
                dgvListAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvListAppointments.Columns[0].Width = 100;

                dgvListAppointments.Columns[1].HeaderText = "Patient ID";
                dgvListAppointments.Columns[1].Width = 100;


                dgvListAppointments.Columns[2].HeaderText = "Doctor ID";
                dgvListAppointments.Columns[2].Width = 100;
             
                dgvListAppointments.Columns[3].HeaderText = "Appointment Date";
                dgvListAppointments.Columns[3].Width = 150;


                dgvListAppointments.Columns[4].HeaderText = "Status";
                dgvListAppointments.Columns[4].Width = 100;

                dgvListAppointments.Columns[5].HeaderText = "Notes";
                dgvListAppointments.Columns[5].Width = 250;


                dgvListAppointments.Columns[6].HeaderText = "Created Date";
                dgvListAppointments.Columns[6].Width = 150;

                dgvListAppointments.Columns[7].HeaderText = "Created User ID";
                dgvListAppointments.Columns[7].Width = 120;




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


            }
        }

        private void frmManageAppointments_Load(object sender, EventArgs e)
        {
            cbSortBy.SelectedIndex = 0;

            _LoadAppointments();
        }
    }
}
