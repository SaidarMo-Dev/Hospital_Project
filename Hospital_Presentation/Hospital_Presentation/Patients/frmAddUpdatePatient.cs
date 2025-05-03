using System;
using System.ComponentModel;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Patients
{


	public partial class frmAddUpdatePatient : Form
	{
		public delegate void SendDataBackEventHandler(object sender, int PatientId);
		public event SendDataBackEventHandler DataToSend;

		enum enMode { AddNew, Update };

		private enMode _Mode = enMode.AddNew;

		public frmAddUpdatePatient()
		{
			_Mode = enMode.AddNew;

			InitializeComponent();

		}

		public frmAddUpdatePatient(int patientID)
		{
			_Mode = enMode.Update;
			_patientID = patientID;

			InitializeComponent();

		}


		private int _patientID = -1;
		private clsPatient _PatientInfo = null;

		private void _resetDefaultValues()
		{
			if (_Mode == enMode.AddNew)
			{

				_PatientInfo = new clsPatient();
				cbPatientBloodType.SelectedIndex = 0;
				this.Text = "Add Patient";



			}




		}


		private void _loadData()
		{

			_PatientInfo = clsPatient.FindByID(_patientID);

			if (_PatientInfo == null)
			{
				MessageBox.Show("There is no Patient with ID = " + _patientID + " this form will be closed!",
							"Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;


			}

			// these lines will executed only if the patient found

			ctrlPersonInfoCardWithFilter1.LoadData(_PatientInfo.PersonID);
			txtAssuranceNumber.Text = _PatientInfo.AssuranceNumber;
			cbPatientBloodType.SelectedItem = _PatientInfo.BloodType;




		}

		private void _SavePatientInfo()
		{
			_PatientInfo.PersonID = ctrlPersonInfoCardWithFilter1.SelectedPersonInfo.PersonID;
			_PatientInfo.AssuranceNumber = txtAssuranceNumber.Text.Trim();
			_PatientInfo.BloodType = cbPatientBloodType.SelectedItem.ToString();

			if (_PatientInfo.Save())
			{
				lbPatientID.Text = _PatientInfo.PatientID.ToString();

				DataToSend?.Invoke(this, _PatientInfo.PatientID);

				MessageBox.Show("Patient Saved Successfuly ",
							"Patient saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else

			{

				MessageBox.Show("Error We can't save this patient! an Error occured when trying to save the patient ",
							"Patient Not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);


			}

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{

				if (
				   MessageBox.Show("Are you sure you want to save this Patient?",
				   "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
				{
					_SavePatientInfo();

				}

			}
			else
			{

				MessageBox.Show("Some fileds are not  Correctly Put the mouse on the red icon to se the error ",
							"Patient saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}

		}

		private void txtAssuranceNumber_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtAssuranceNumber.Text.Trim()))
				errorProvider1.SetError(txtAssuranceNumber, "This field is required");

			else
				errorProvider1.SetError(txtAssuranceNumber, "");


		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			TabControlPatinetInfo.SelectedTab = PagePersonInfo;

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			TabControlPatinetInfo.SelectedTab = PagePatientInfo;

		}

		private void frmAddUpdatePatient_Load(object sender, EventArgs e)
		{
			_resetDefaultValues();

			if (_Mode == enMode.Update)
			{
				_loadData();

			}
		}
	}
}
