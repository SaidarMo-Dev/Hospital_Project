using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;

namespace Hospital_Presentation.Employees
{
	public partial class frmAddUpdateEmployee : Form
	{
		enum enMode { AddNew, Update };

		private enMode _Mode;

		private int _EmployeeID = -1;
		private clsEmployee _EmployeeInfo;


		public frmAddUpdateEmployee()
		{
			_Mode = enMode.AddNew;
			_EmployeeID = -1;

			InitializeComponent();

			_CustomizeDesign();

		}


		public frmAddUpdateEmployee(int PersonID)
		{
			_Mode = enMode.Update;
			_EmployeeID = PersonID;

			InitializeComponent();
			_CustomizeDesign();

		}



		private void _CustomizeDesign()
		{

			cbEmployeeStatus.SelectedIndex = 0;

		}

		private void _FillDepartementsInComboBox()
		{
			DataTable Departements = clsDepartement.ListDepartements();


			foreach (DataRow row in Departements.Rows)
			{
				cbDepartements.Items.Add(row["DepartementName"]);
			}


		}

		private void _resetDefaultValues()
		{
			_FillDepartementsInComboBox();

			if (_Mode == enMode.AddNew)
			{
				_EmployeeInfo = new clsEmployee();

				this.Text = "Add New Employee";

				cbEmployeeStatus.Enabled = false;

			}

			cbDepartements.SelectedIndex = 0;

		}

		private void _LoadData()
		{
			_EmployeeInfo = clsEmployee.FindByID(_EmployeeID);

			if (_EmployeeInfo == null)
			{
				MessageBox.Show("There is no Empoyee with ID  = " + _EmployeeID + "This Form will Closed."
					, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			// this code will execute if the employee found

			ctrlPersonInfoCardWithFilter1.LoadData(_EmployeeInfo.PersonID);

			lblEmployeeID.Text = _EmployeeInfo.EmployeeID.ToString();
			txtJobTitle.Text = _EmployeeInfo.JobTitle;
			txtHireDate.Text = Format.ConvertDateTimeToStringFormat(_EmployeeInfo.HireDate);
			cbDepartements.SelectedIndex = cbDepartements.FindString(_EmployeeInfo.DepartementInfo.DepartementName);
			txtSalary.Text = _EmployeeInfo.Salary.ToString();

			cbEmployeeStatus.SelectedIndex = _EmployeeInfo.EmployeeStatus - 1;

			// you cannot change - Hire date - in Update Mode
			txtHireDate.Enabled = false;


		}

		private void _SetEmployeeInfo()
		{


			_EmployeeInfo.PersonID = ctrlPersonInfoCardWithFilter1.SelectedPersonInfo.PersonID;
			_EmployeeInfo.JobTitle = txtJobTitle.Text.Trim();
			_EmployeeInfo.HireDate = DateTime.ParseExact(txtHireDate.Text.Trim(), "dd/mm/yyyy", null);
			_EmployeeInfo.DepartementID = clsDepartement.FindDepartementID(cbDepartements.SelectedItem.ToString());
			_EmployeeInfo.Salary = Convert.ToInt16(txtSalary.Text.Trim());


			_EmployeeInfo.EmployeeStatus = Convert.ToByte(cbEmployeeStatus.SelectedIndex + 1);

			if (string.IsNullOrEmpty(txtLeaveDate.Text.Trim()))
			{
				_EmployeeInfo.LeaveDate = null;

			}
			else
				_EmployeeInfo.LeaveDate = DateTime.ParseExact(txtLeaveDate.Text.Trim(), "dd/mm/yyyy", null);



		}

		private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
		{
			cbEmployeeStatus.SelectedIndex = 0;

			_resetDefaultValues();

			if (_Mode == enMode.Update)
			{
				cbEmployeeStatus.Enabled = true;

				_LoadData();

			}
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			TabControlEmployeeInfo.SelectedTab = PageAdditionalEmployeeInfo;


		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			TabControlEmployeeInfo.SelectedTab = PagePersonInfo;

		}

		private void txtJobTitle_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtJobTitle.Text.ToString()))
			{
				epValidations.SetError(txtJobTitle, "This field is requied");
			}
			else
				epValidations.SetError(txtJobTitle, "");
		}

		private void txtHireDate_Validating(object sender, CancelEventArgs e)
		{

			if (string.IsNullOrEmpty(txtHireDate.Text.Trim()))
			{
				epValidations.SetError(txtHireDate, "This field is required!");

			}
			else if (!clsValidating.ValidateDateStringFormat(txtHireDate.Text.Trim()))
			{
				epValidations.SetError(txtHireDate, "Please Respect the suggested format");
			}
			else
			{
				epValidations.SetError(txtHireDate, "");
			}

		}

		private void txtSalary_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(txtSalary.Text.ToString()))
			{
				epValidations.SetError(txtSalary, "This field is requied");
			}
			else
				epValidations.SetError(txtSalary, "");

		}

		private void txtLeaveDate_Validating(object sender, CancelEventArgs e)
		{

			if (!clsValidating.ValidateDateStringFormat(txtLeaveDate.Text.Trim()) && !string.IsNullOrEmpty(txtLeaveDate.Text.Trim()))
			{
				epValidations.SetError(txtLeaveDate, "Please Respect the suggested format");
			}
			else
			{
				epValidations.SetError(txtLeaveDate, "");
			}
		}

		private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl((e.KeyChar)) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;

			}

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren())
			{
				if (MessageBox.Show("Are you sure you want to save this Employee ?", "Confirm",

				  MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
				{
					_SetEmployeeInfo();

					if (_EmployeeInfo.Save())
					{
						MessageBox.Show("Employee Saved Successfuly", " Employee Saved",

							MessageBoxButtons.OK, MessageBoxIcon.Information);

						lblEmployeeID.Text = _EmployeeInfo.PersonID.ToString();
						ctrlPersonInfoCardWithFilter1.Enabled = false;


					}
					else
					{
						MessageBox.Show("Error Counld not save this Employee", "Error",

						   MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


				}
			}
		}

		private void ctrlPersonInfoCardWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonInfoCardWithFilter.PersonInfoEventArgs e)
		{


		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			TabControlEmployeeInfo.SelectedTab = PagePersonInfo;

		}
	}
}
