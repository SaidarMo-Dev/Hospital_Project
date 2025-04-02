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
using Hospital_Presentation.GlobalClasses;

namespace Hospital_Presentation.Appointments
{
	public partial class frmShowAppointmentInfo : Form
	{
		private int _appointmentId;
		public frmShowAppointmentInfo(int appointmentId)
		{
			_appointmentId = appointmentId;
			InitializeComponent();
		}

		private clsAppointment _appointment;

		private void _loadData()
		{
			_appointment = clsAppointment.FindByID(_appointmentId);

			if (_appointment == null)
			{
				MessageBox.Show($"No appointment found with Id = {_appointmentId} " +
					$"this form will closed", "Not Found", MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return;
			}

			// this lines will execute only if appointment not null ;

			lblAppointmentID.Text = _appointment.AppointmentID.ToString();
			lblPatientName.Text = _appointment.PatientInfo.PersonInfo.FullName;
			lblPatientAge .Text = _appointment.PatientInfo.PersonInfo.Age.ToString();
			lblDoctorName.Text = _appointment.DoctorInfo.PersonInfo.FullName;
			lblDoctorLicenseNumber.Text = _appointment.DoctorInfo.LicenseNumber;
			lblAppointmentDate.Text = _appointment.AppointmentDate.ToString("d");
			lblNotes.Text = _appointment.Notes;
			lblAppStatus.Text = _appointment.StatusString;
			lblCreatedBy.Text = Global.CurrentUser.Username;

		}

		private void frmShowAppointmentInfo_Load(object sender, EventArgs e)
		{
			_loadData();
		}
	}
}
