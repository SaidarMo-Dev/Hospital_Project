using System;
using System.Data;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Doctors
{
	public partial class frmManageDoctors : Form
	{
		private DataTable _doctors;

		public frmManageDoctors()
		{
			InitializeComponent();
		}

		private void _LoadDoctors()
		{
			_doctors = clsDoctor.GetListDoctors();

			dgvListDoctors.DataSource = _doctors;

			lblEmployeesCountCount.Text = dgvListDoctors.Rows.Count.ToString();

			if (dgvListDoctors.Rows.Count > 0)
			{
				dgvListDoctors.Columns[0].HeaderText = "Doctor ID";
				dgvListDoctors.Columns[0].Width = 100;

				dgvListDoctors.Columns[1].HeaderText = "Full Name";
				dgvListDoctors.Columns[1].Width = 200;



				dgvListDoctors.Columns[2].HeaderText = "Email";
				dgvListDoctors.Columns[2].Width = 230;



				dgvListDoctors.Columns[3].HeaderText = "Gendor";
				dgvListDoctors.Columns[3].Width = 100;

				dgvListDoctors.Columns[4].HeaderText = "Specialization";
				dgvListDoctors.Columns[4].Width = 200;

				dgvListDoctors.Columns[5].HeaderText = "Monthly Salary";
				dgvListDoctors.Columns[5].Width = 180;

				dgvListDoctors.Columns[6].HeaderText = "License Number";
				dgvListDoctors.Columns[6].Width = 200;

				dgvListDoctors.Columns[7].HeaderText = "Working Time";
				dgvListDoctors.Columns[7].Width = 140;




			}

		}

		private void Sort()
		{
			switch (cbSortBy.SelectedItem.ToString())
			{
				case "Doctor ID":

					_doctors.DefaultView.Sort = "DoctorID";
					break;
				case "Full Name":

					_doctors.DefaultView.Sort = "FullName";
					break;

				case "License Number":

					_doctors.DefaultView.Sort = "LicenseNumber";
					break;

				case "Salary":

					_doctors.DefaultView.Sort = "MonthlySalary";
					break;

				default:
					_doctors.DefaultView.Sort = "DoctorID";
					break;

			}
		}

		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dgvListDoctors.RowCount > 0)
			{

				Sort();
			}
		}

		private void tbSearchForEmployee_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearchByName.Text.ToString()))
			{
				_doctors.DefaultView.RowFilter = "";

			}
			else
			{
				_doctors.DefaultView.RowFilter = "FullName Like '" + tbSearchByName.Text.ToString() + "%'";

			}


			_doctors.DefaultView.RowFilter = "FullName LIKE '" + tbSearchByName.Text.ToString() + "%'";


		}

		private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmAddUpdateDoctor().ShowDialog();

		}

		private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmAddUpdateDoctor(Convert.ToInt16(dgvListDoctors.CurrentRow.Cells[0].Value))

				.ShowDialog();
		}

		private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this Doctor?",
			   "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

			   == DialogResult.OK)
			{
				if (clsDoctor.DeleteDoctor(Convert.ToInt32(dgvListDoctors.CurrentRow.Cells[0].Value)))
				{
					MessageBox.Show("Doctor deleted Successfuly.",
							"Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);



				}
				else
				{
					MessageBox.Show("Cannot Delete this Doctor try Later...",
						   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);


				}
			}
		}

		private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmShowDoctorInfo(Convert.ToInt32(dgvListDoctors.CurrentRow.Cells[0].Value))

				.ShowDialog();
		}

		private void frmManageDoctors_Load(object sender, EventArgs e)
		{
			cbSortBy.SelectedIndex = 0;

			_LoadDoctors();

		}

		private void btnAddNewPerson_Click(object sender, EventArgs e)
		{
			new frmAddUpdateDoctor().ShowDialog();

			_LoadDoctors();
		}
	}
}
