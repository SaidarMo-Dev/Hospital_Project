using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;

namespace Hospital_Presentation.MedicalRecords
{
	public partial class frmMedicalRecord : Form
	{
		private int _appointmentId;
		public frmMedicalRecord(int AppointmentId)
		{
			_appointmentId = AppointmentId;
			InitializeComponent();
		}

		private clsAppointment _appointmentInfo = new clsAppointment();

		private void _resetDefaultValues()
		{
			_appointmentInfo = clsAppointment.FindByID(_appointmentId);

			if (_appointmentInfo == null)
			{
				MessageBox.Show($"Appointment with id = {_appointmentId} Not Found this form will closed",
							"Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

				this.Close();

				return;
			}

			lblPatientName.Text = _appointmentInfo.PatientInfo.PersonInfo.FullName + " Record";
			lblCreatedByUsername .Text = Global.CurrentUser.Username;

		
		}

		private void Save()
		{
			if (this.ValidateChildren())
			{
				if (MessageBox.Show("Are you sure you want to Save this data","Confirm",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
					
					== DialogResult.OK)
				{
					clsMedicalRecord medicalRecord = new clsMedicalRecord();

					medicalRecord .VisitDescription = tbVisitdescription.Text .Trim();
					medicalRecord.Diagnosis = tbDiagnosiss.Text.Trim();
					medicalRecord.AdditionalNotes = tbAdditionalNotes.Text.Trim();
					medicalRecord.CreatedByUserID = Global.CurrentUser.UserID;

					if (!medicalRecord.Save())
					{
						MessageBox.Show("Sommething wrong, we Can't save this record",
							"Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (!medicalRecord.SetMedicalRecordToAppointment(_appointmentId))
					{
						MessageBox.Show("Sommething wrong, we Can't include medical record to the spcefiy appointment",
							"Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					MessageBox.Show("Record Saved Successfull",
							"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

					lblMedicalRecordId.Text = medicalRecord.MedicalRecordID.ToString();


				}
			}
			else
			{
				MessageBox.Show("Error Sommething wrong : Put the mouse on the red Icon to see the Error", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);


			}
		}

		private void tbVisitdescription_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbVisitdescription.Text.ToString()))
			{
				errorProvider1.SetError(tbVisitdescription, "his field is required");

			}
			else
				errorProvider1.SetError(tbVisitdescription, "");

		}

		private void tbAdditionalNotes_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbDiagnosiss_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbDiagnosiss.Text.ToString()))
			{
				errorProvider1.SetError(tbDiagnosiss, "his field is required");

			}
			else
				errorProvider1.SetError(tbDiagnosiss, "");
			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{

			this.Close();

		}

		private void frmMedicalRecord_Load(object sender, EventArgs e)
		{
			_resetDefaultValues();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Save();

		}
	}
}
