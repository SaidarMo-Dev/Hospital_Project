using System;
using System.ComponentModel;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;


namespace Hospital_Presentation.Doctors
{
	public partial class frmAddUpdateDoctor : Form
	{
		private enum enMode { AddNew, Update }

		private enMode _Mode = enMode.AddNew;

		private int _DoctorID = 0;

		clsDoctor _doctor;
		public frmAddUpdateDoctor()
		{
			_Mode = enMode.AddNew;

			InitializeComponent();
		}

		public frmAddUpdateDoctor(int DoctorID)
		{
			_DoctorID = DoctorID;
			_Mode = enMode.Update;

			InitializeComponent();
		}


		private void _resetDefaultValues()
		{
			btnNext.Enabled = false;

			if (_Mode == enMode.AddNew)
			{
				_doctor = new clsDoctor();

				this.Text = "Add New Doctor";




			}

			lblCreatedByUser.Text = Global.CurrentUser.Username;


		}

		private void LoadData()
		{
			_doctor = clsDoctor.FindByID(_DoctorID);

			if (_doctor == null)
			{
				MessageBox.Show("there is no doctor with ID = " + _DoctorID + " this form will be closed",
					"Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			// this code will execute only if the doctor found

			ctrlPersonInfoCardWithFilter1.LoadData(_doctor.PersonID);

			txtSpecialization.Text = _doctor.Specialization;
			txtDoctorSalary.Text = _doctor.MonthlySalary.ToString();
			txtLiceseNumber.Text = _doctor.LicenseNumber.ToString();
			txtWorkingTime.Text = _doctor.WrokingTime.ToString();






		}


		private void _fillDoctorInfo()
		{
			_doctor.PersonID = ctrlPersonInfoCardWithFilter1.SelectedPersonInfo.PersonID;
			_doctor.Specialization = txtSpecialization.Text.Trim();
			_doctor.LicenseNumber = txtLiceseNumber.Text.Trim();
			_doctor.WrokingTime = txtWorkingTime.Text.Trim();
			_doctor.MonthlySalary = Convert.ToInt32(txtDoctorSalary.Text.Trim());

			// this id = 1 just for test 
			_doctor.CreatedByUserID = 1;


		}

		private void frmAddUpdateDoctor_Load(object sender, EventArgs e)
		{
			_resetDefaultValues();

			if (_Mode == enMode.Update)
			{
				LoadData();

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				if (MessageBox.Show("Are you sure you want to save this doctor?", "Confirm",
						   MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
					   == DialogResult.OK)
				{
					_fillDoctorInfo();

					if (_doctor.Save())
					{
						MessageBox.Show("Dctor saved Successfully", "Saved",
								MessageBoxButtons.OK, MessageBoxIcon.Information);

						lblDoctorID.Text = _doctor.DoctorID.ToString();

					}
					else
					{
						MessageBox.Show("Error cannot save this doctor verify your informations and try later",
							"Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("We cannot perform this operation make sure you filled all fields correctly",
							"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void txtSpecialization_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtSpecialization.Text.Trim()))
			{
				epValidations.SetError(txtSpecialization, "This Field IS required");
			}
			else
				epValidations.SetError(txtSpecialization, "");
		}

		private void txtDoctorSalary_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtDoctorSalary.Text.Trim()))
			{
				epValidations.SetError(txtDoctorSalary, "This Field IS required");
			}
			else
				epValidations.SetError(txtDoctorSalary, "");
		}

		private void txtLiceseNumber_Validating(object sender, CancelEventArgs e)
		{

			if (string.IsNullOrEmpty(txtLiceseNumber.Text.Trim()))
			{
				epValidations.SetError(txtLiceseNumber, "This Field IS required");
			}
			else
				epValidations.SetError(txtLiceseNumber, "");
		}

		private void txtWorkingTime_Validating(object sender, CancelEventArgs e)
		{

			if (string.IsNullOrEmpty(txtWorkingTime.Text.Trim()))
			{
				epValidations.SetError(txtWorkingTime, "This Field IS required");
			}
			else
				epValidations.SetError(txtWorkingTime, "");
		}

		private void txtDoctorSalary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

			{
				e.Handled = true;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ctrlPersonInfoCardWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonInfoCardWithFilter.PersonInfoEventArgs e)
		{
			btnNext.Enabled = true;
		}

		private void txtLiceseNumber_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			TabControlEmployeeInfo.SelectedTab = PageAdditionalEmployeeInfo;
		}
	}
}
