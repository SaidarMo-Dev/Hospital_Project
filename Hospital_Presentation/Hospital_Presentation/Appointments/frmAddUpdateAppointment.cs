using System;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;
using Hospital_Presentation.Patients;

namespace Hospital_Presentation.Appointments
{
	public partial class frmAddUpdateAppointment : Form
	{
		enum enMode { AddNew, Update }

		enMode _Mode = enMode.AddNew;


		private int _appointmentID;
		public frmAddUpdateAppointment(int appointmentID)
		{
			_Mode = enMode.Update;
			_appointmentID = appointmentID;
			InitializeComponent();
		}

		public frmAddUpdateAppointment()
		{
			_Mode = enMode.AddNew;
			InitializeComponent();

		}

		private clsAppointment _AppointmentInfo;

		private void _resetDefaultValues()
		{

			if (_Mode == enMode.AddNew)
			{
				_AppointmentInfo = new clsAppointment();

				this.Text = "Add new Appointment";



			}

			dateTimePickerAppointmentDate.MinDate = DateTime.Now.AddDays(1);
			dateTimePickerAppointmentDate.Value = DateTime.Now.AddDays(1);


		}

		private void _loadData()
		{
			_AppointmentInfo = clsAppointment.FindByID(_appointmentID);


			if (_AppointmentInfo == null)
			{

				MessageBox.Show($"Appointment with ID = {_appointmentID} Not Found This Form Will Closed"
							, " Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// this code will execute only if the appointment found 
			txtSearchByDoctorID.Text = _AppointmentInfo.DoctorID.ToString();
			txtSearchByPatientID.Text = _AppointmentInfo.PatientID.ToString();

			txtSearchByPatientID.Enabled = false;
			txtSearchByDoctorID.Enabled = false;

			btnFindDoctor.Enabled = false;
			btnFindPatient.Enabled = false;


			ctrlPatientInfo1.LoadData(_AppointmentInfo.PatientID);
			ctrlShowDoctorInfo1.LoadData(_AppointmentInfo.DoctorID);


			if (_Mode == enMode.Update)
				dateTimePickerAppointmentDate.MinDate = _AppointmentInfo.AppointmentDate;

			dateTimePickerAppointmentDate.Value = _AppointmentInfo.AppointmentDate;
			txtNotes.Text = _AppointmentInfo.Notes;



		}


		private void _Save()
		{

			_AppointmentInfo.PatientID = ctrlPatientInfo1.SelectedPatientInfo.PatientID;
			_AppointmentInfo.DoctorID = ctrlShowDoctorInfo1.SelectedDoctorInfo.DoctorID;
			_AppointmentInfo.AppointmentDate = dateTimePickerAppointmentDate.Value;
			_AppointmentInfo.AppointmentStatus = 1;
			_AppointmentInfo.LastStatusDate = DateTime.Now;
			_AppointmentInfo.Notes = txtNotes.Text.ToString();
			_AppointmentInfo.CreatedDate = DateTime.Now;
			_AppointmentInfo.CreatedByUserID = Global.CurrentUser.UserID;


			if (_AppointmentInfo.Save())
			{

				MessageBox.Show("Appointment Saved Successfull with ID = " + _AppointmentInfo.AppointmentID
							, "Saved Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

				lblAppointmentID.Text = _AppointmentInfo.AppointmentID.ToString();

			}
			else
			{

				MessageBox.Show("Cannot save this Appointment Make sure all informations are correct"
							, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

		private void txtSearchByPatientID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtSearchByDoctorID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnFindPatient_Click(object sender, EventArgs e)
		{
			ctrlPatientInfo1.LoadData(Convert.ToInt32(txtSearchByPatientID.Text.ToString()));

		}

		private void btnFindDoctor_Click(object sender, EventArgs e)
		{
			ctrlShowDoctorInfo1.LoadData(Convert.ToInt32(txtSearchByDoctorID.Text.ToString()));
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren() && ctrlPatientInfo1.IsFound && ctrlShowDoctorInfo1.IsFound)
			{
				if (MessageBox.Show("Are You sure you want to save this Appointment ?",
					"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

					== DialogResult.OK)
				{
					_Save();

				}

			}
			else
			{
				MessageBox.Show("We cannot perform this Operation make sure All informations filled correctly",
					"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

			}

		}

		private void frmAddUpdateAppointment_Load(object sender, EventArgs e)
		{
			_resetDefaultValues();

			if (_Mode == enMode.Update)
			{
				_loadData();

			}

		}

		// add new patient

		public void sendData(object sender, int PatientId)
		{
			txtSearchByPatientID.Text = PatientId.ToString();

			ctrlPatientInfo1.LoadData(PatientId);


		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			var createPatient = new frmAddUpdatePatient();

			createPatient.DataToSend += sendData;

			createPatient.ShowDialog();
		}
	}
}
