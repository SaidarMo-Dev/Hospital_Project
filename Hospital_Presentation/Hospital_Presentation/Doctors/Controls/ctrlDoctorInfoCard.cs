using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Doctors.Controls
{
    public partial class ctrlDoctorInfoCard : UserControl
    {
        private int _doctorID = 0;
        public ctrlDoctorInfoCard()
        {
            InitializeComponent();
        }


        public clsDoctor SelectedDoctorInfo
        {
            get { return ctrlShowDoctorInfo1.SelectedDoctorInfo; }

        }

        public void LoadData(int DoctorID)
        {
            _doctorID = DoctorID;

            ctrlShowDoctorInfo1.LoadData(DoctorID);

            _LoadActiveAppointemets();

        }


        private void _LoadActiveAppointemets()
        {
            
            var apointments = clsDoctor.ActiveAppointmentsForDoctor(_doctorID);

            dgvDoctorAppointments.DataSource = apointments;


            if (dgvDoctorAppointments.RowCount > 0)
            {
                dgvDoctorAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvDoctorAppointments.Columns[0].Width = 90;


                dgvDoctorAppointments.Columns[1].HeaderText = "Patient ID";
                dgvDoctorAppointments.Columns[1].Width = 90;

                dgvDoctorAppointments.Columns[2].HeaderText = "Appointment Date";
                dgvDoctorAppointments.Columns[2].Width = 110;

                dgvDoctorAppointments.Columns[3].HeaderText = "Notes";
                dgvDoctorAppointments.Columns[3].Width = 140;

                dgvDoctorAppointments.Columns[4].HeaderText = "MedicalRecord ID";
                dgvDoctorAppointments.Columns[4].Width = 90;


            }



        }
        private void _LoadCompltedAppointemets()
        {

            var apointments = clsDoctor.CompletedAppointmentsForDoctor(_doctorID);

            dgvDoctorAppointments.DataSource = apointments;


            if (dgvDoctorAppointments.RowCount > 0)
            {
                dgvDoctorAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvDoctorAppointments.Columns[0].Width = 90;


                dgvDoctorAppointments.Columns[1].HeaderText = "Patient ID";
                dgvDoctorAppointments.Columns[1].Width = 90;

                dgvDoctorAppointments.Columns[2].HeaderText = "Appointment Date";
                dgvDoctorAppointments.Columns[2].Width = 110;

                dgvDoctorAppointments.Columns[3].HeaderText = "Notes";
                dgvDoctorAppointments.Columns[3].Width = 140;

                dgvDoctorAppointments.Columns[4].HeaderText = "MedicalRecord ID";
                dgvDoctorAppointments.Columns[4].Width = 90;


            }


        }

      

        private void btnCompletedAppointments_Click(object sender, EventArgs e)
        {
            _LoadCompltedAppointemets();

        }

        private void btnActiveAppointements_Click(object sender, EventArgs e)
        {
            _LoadActiveAppointemets();

        }
    }
}
