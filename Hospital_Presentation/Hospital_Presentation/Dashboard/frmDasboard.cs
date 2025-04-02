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


namespace Hospital_Presentation.Dashboard
{
    public partial class frmDasboard : Form
    {
        public frmDasboard()
        {
            InitializeComponent();
        }

		private void _PerformCounting()
		{
			lblPeopleCount.Text = clsPerson.PeopleCount().ToString();
			lblUsersCount.Text = clsUser.UsersCount().ToString();
			lblPatientsCount.Text = clsPatient.PatientsCount().ToString();
			lblEmployeesCount.Text = clsEmployee.EmployeesCount().ToString();
			lblDoctorsCount.Text = clsDoctor.DoctorsCount().ToString();

		}

		private void frmDasboard_Load(object sender, EventArgs e)
		{
		
			_PerformCounting();
		}

		private void dgvListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
