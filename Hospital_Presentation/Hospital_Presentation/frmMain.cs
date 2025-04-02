using System;
using System.Windows.Forms;
using Hospital_Presentation.Appointments;
using Hospital_Presentation.Dashboard;
using Hospital_Presentation.Doctors;
using Hospital_Presentation.Employees;
using Hospital_Presentation.GlobalClasses;
using Hospital_Presentation.MedicalRecords;
using Hospital_Presentation.Patients;
using Hospital_Presentation.People;
using Hospital_Presentation.Prescriptions;
using Hospital_Presentation.Users;



namespace Hospital_Presentation
{
	public partial class frmMain : Form
	{
		public frmMain(frmLogin LoginForm)
		{
			InitializeComponent();

			_customizeDesign();

			_LoginForm = LoginForm;

		}
		public frmMain()
		{
			InitializeComponent();

			_customizeDesign();

		}

		frmLogin _LoginForm;

		private void _customizeDesign()
		{

			panelPeopleSubMenu.Visible = false;
			panelEmployeesSubMenu.Visible = false;
			panelDoctorsSubMenu.Visible = false;
			panelPatientsSubMenu.Visible = false;
			panelUsersSubMenu.Visible = false;
			panelAppointmentSubMenu.Visible = false;


			_ShowChildForm(new frmDasboard());



		}
		private void _HideSubMenus()
		{
			if (panelPeopleSubMenu.Visible)
				panelPeopleSubMenu.Visible = false;

			if (panelEmployeesSubMenu.Visible)
				panelEmployeesSubMenu.Visible = false;

			if (panelDoctorsSubMenu.Visible)
				panelDoctorsSubMenu.Visible = false;

			if (panelPatientsSubMenu.Visible)
				panelPatientsSubMenu.Visible = false;

			if (panelUsersSubMenu.Visible)
				panelUsersSubMenu.Visible = false;

			if (panelAppointmentSubMenu.Visible)
				panelAppointmentSubMenu.Visible = false;

		}
		private void _ShowsubMenu(Panel subMenu)
		{

			if (!subMenu.Visible)
			{
				_HideSubMenus();

				subMenu.Visible = true;
				return;

			}

			subMenu.Visible = false;


		}

		private void _HideAllMenus()
		{
			_HideSubMenus();

			btnDashboard.Visible = false;
			btnPeopleMenu.Visible = false;
			btnEmployeesMenu.Visible = false;
			btnDoctorsMenu.Visible = false;
			btnPatientsMenu.Visible = false;
			btnAppointmentsMenu.Visible = false;
			btnUsersMenu.Visible = false;
			btnMedicalRecords.Visible = false;
			btnPrescriptions.Visible = false;
			btnHelp.Visible = false;
		}

		private void _ShowAllMenus()
		{

			btnDashboard.Visible = true;
			btnPeopleMenu.Visible = true;
			btnEmployeesMenu.Visible = true;
			btnDoctorsMenu.Visible = true;
			btnPatientsMenu.Visible = true;
			btnAppointmentsMenu.Visible = true;
			btnUsersMenu.Visible = true;
			btnMedicalRecords.Visible = true;
			btnPrescriptions.Visible = true;
			btnHelp.Visible = true;
		}

		Form _ActiveForm = null;

		private void _ShowChildForm(Form childForm)
		{
			if (_ActiveForm != null)
				_ActiveForm.Close();


			_ActiveForm = childForm;


			childForm.TopLevel = false;
			childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			panelContainer.Controls.Add(childForm);

			childForm.Show();



		}


		private void guna2Button1_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelPeopleSubMenu);
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelEmployeesSubMenu);

		}

		private void btnPatientsMenu_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelPatientsSubMenu);

		}

		private void guna2Button18_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelAppointmentSubMenu);

		}

		private void btnUsersMenu_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelUsersSubMenu);

		}

		private void btnMedicalRecords_Click(object sender, EventArgs e)
		{
			_HideSubMenus();
			new frmManageMedicalRecords().ShowDialog();


		}

		private void btnPrescriptions_Click(object sender, EventArgs e)
		{
			_HideSubMenus();
			new frmManagePrescriptions().ShowDialog();

		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			_HideSubMenus();

			MessageBox.Show("This feture not emplemented yet...",
				"Comming soon", MessageBoxButtons.OK,
				MessageBoxIcon.Information);

		}

		private void btnDoctorsMenu_Click(object sender, EventArgs e)
		{
			_ShowsubMenu(panelDoctorsSubMenu);

		}

		private void btnAddPerson_Click(object sender, EventArgs e)
		{
			new frmAddUpdatePerson().ShowDialog();

		}

		private void btnManagePeople_Click(object sender, EventArgs e)
		{

			var managePeople = new frmManagePeople();

			managePeople.ShowDialog();


		}

		private void btnViewPerson_Click(object sender, EventArgs e)
		{
			var viewPerson = new frmViewPersonInfo();

			viewPerson.ShowDialog();


		}

		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
			var Employee = new frmAddUpdateEmployee();

			Employee.ShowDialog();

		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			var empployees = new frmManageEmployees();

			empployees.ShowDialog();

		}

		private void btnViewEmployee_Click(object sender, EventArgs e)
		{
			var ViewEmployee = new frmViewEmployeeInfo();


			ViewEmployee.ShowDialog();
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{

			_ShowChildForm(new frmDasboard());

		}

		private void btnAddNewPatient_Click(object sender, EventArgs e)
		{
			var addPatient = new frmAddUpdatePatient();

			addPatient.ShowDialog();

		}

		private void btnViewPatient_Click(object sender, EventArgs e)
		{
			var ViewPatient = new frmViewPatient();

			ViewPatient.ShowDialog();

		}

		private void btnManagePatient_Click(object sender, EventArgs e)
		{
			var patients = new frmManagePatient();
			patients.ShowDialog();

		}

		private void guna2Button12_Click(object sender, EventArgs e)
		{
			new frmAddUpdateDoctor()

				.ShowDialog();
		}

		private void btnViewDoctorInfo_Click(object sender, EventArgs e)
		{
			new frmViewDoctor()

				.ShowDialog();
		}

		private void btnManageDoctors_Click(object sender, EventArgs e)
		{
			new frmManageDoctors().ShowDialog();

		}

		private void btnViewUser_Click(object sender, EventArgs e)
		{
			new frmViewUserInfo()
				.ShowDialog();

		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			new frmAddUpdateUser()

				.ShowDialog();
		}

		private void btnManageusers_Click(object sender, EventArgs e)
		{
			new frmManageUsers()

				.ShowDialog();
		}

		private void btnAddAppointment_Click(object sender, EventArgs e)
		{
			new frmAddUpdateAppointment().ShowDialog();

		}

		private void btnManageAppointments_Click(object sender, EventArgs e)
		{
			new frmManageAppointments().ShowDialog();

		}

		private void guna2Button1_Click_1(object sender, EventArgs e)
		{

		}

		private void frmMain_Load(object sender, EventArgs e)
		{


		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{

			this.Close();
			//_LoginForm.Show();

		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmChangePassword(Global.CurrentUser.UserID)
				.ShowDialog();
		}

		private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmShowUserInfo(Global.CurrentUser.UserID)
				.ShowDialog();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			if (btnPeopleMenu.Visible)
				_HideAllMenus();

			else
				_ShowAllMenus();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
			_LoginForm.ShowDialog();

		}
	}
}
