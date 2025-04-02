using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;

namespace Hospital_Presentation.Prescriptions
{
	public partial class frmAddPrescriptions : Form
	{
		private int _appointmentId;

		public frmAddPrescriptions(int appointmentId)
		{
			_appointmentId = appointmentId;
			InitializeComponent();
			
		}

		private clsAppointment _appointment = new clsAppointment();

		private void _resetDefaultValues()
		{
			
			_appointment = clsAppointment.FindByID (_appointmentId);

			if (_appointment == null)
			{
				MessageBox.Show($"There is no appointment with id = {_appointmentId}",
					"Not found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();

				return;
			}

			if (_appointment.MedicalRecordID == -1)
			{
				MessageBox.Show($"This appointment does not have a medical record, Create it first",
					"Not Allowed ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;

			}


			lblPatientName.Text = _appointment.PatientInfo.PersonInfo.FullName + " Prescription";


		}

		private void _Save()
		{
			if (this.ValidateChildren())
			{

				if (MessageBox.Show("Are you sure you want to Save this Prescription", "Confirm",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

					== DialogResult.OK)
				{
					var prescription = new clsPrescription();

					prescription .MedicalRecordID = _appointment.MedicalRecordID;
					prescription.MedicalName = tbMedicalName.Text.Trim();
					prescription.Dosage = tbDosage.Text.Trim();
					prescription.Frequency = tbFrequency.Text.Trim();
					prescription.StartDate = DateTimePickerStartDate.Value;
					prescription.EndDate = DateTimePickerEndDate.Value;
					prescription.SpecialInstructions = tbSpecialInstractions.Text.Trim();
					prescription .CreatedByUserID = Global.CurrentUser.UserID;

					if (!prescription.Save())
					{
						MessageBox.Show("Sommething wrong, we Can't save this record",
							"Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}


					MessageBox.Show("Record Saved Successfull",
							"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// change status to complete
					_appointment.SetComplete();

					lblPrescriptionId.Text = prescription.PrescriptionID.ToString();


				}
			}
			else
			{
				MessageBox.Show("Error Sommething wrong : Put the mouse on the red Icon to see the Error", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);


			}

		}

		private void frmAddPrescriptions_Load(object sender, EventArgs e)
		{
			_resetDefaultValues();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_Save();

		}

		private void tbMedicalName_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbMedicalName.Text))
				errorProviderValidations.SetError(tbMedicalName, "This field is required");
			else
				errorProviderValidations.SetError(tbMedicalName, "");

		}

		private void tbDosage_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbDosage.Text))
				errorProviderValidations.SetError(tbDosage, "This field is required");
			else
				errorProviderValidations.SetError(tbDosage, "");

		}

		private void tbFrequency_Validating(object sender, CancelEventArgs e)
		{

			if (string.IsNullOrWhiteSpace(tbFrequency.Text))
				errorProviderValidations.SetError(tbFrequency, "This field is required");
			else
				errorProviderValidations.SetError(tbFrequency, "");

		}
	
	
	
	}
}
