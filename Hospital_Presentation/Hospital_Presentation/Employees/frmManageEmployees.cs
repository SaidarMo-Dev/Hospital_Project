using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Employees
{
	public partial class frmManageEmployees : Form
	{
		public frmManageEmployees()
		{
			InitializeComponent();

			_CustomazeDesign();


		}

		private void _CustomazeDesign()
		{
			// txtSearchValue.Visible = false;
			cbSortBy.SelectedIndex = 0;

		}

		private DataTable _dtEmployees;


		private void _LoadEmployeesData()
		{
			_dtEmployees = clsEmployee.GetListEmployees();

			dgvListEmployees.DataSource = _dtEmployees;
			lblEmployeesCountCount.Text = dgvListEmployees.RowCount.ToString();

			tbSearchForEmployee.Enabled = false;

			if (dgvListEmployees.RowCount > 0)
			{
				tbSearchForEmployee.Enabled = true;

				dgvListEmployees.Columns[0].HeaderText = "Employee ID";
				dgvListEmployees.Columns[0].Width = 100;

				dgvListEmployees.Columns[1].HeaderText = "Person ID";
				dgvListEmployees.Columns[1].Width = 100;

				dgvListEmployees.Columns[2].HeaderText = "Full Name";
				dgvListEmployees.Columns[2].Width = 160;

				dgvListEmployees.Columns[3].HeaderText = "Job Title";
				dgvListEmployees.Columns[3].Width = 200;


				dgvListEmployees.Columns[4].HeaderText = "Hire Date";
				dgvListEmployees.Columns[4].Width = 200;

				dgvListEmployees.Columns[5].HeaderText = "Leave Date";
				dgvListEmployees.Columns[5].Width = 200;

				dgvListEmployees.Columns[6].HeaderText = "Departement ";
				dgvListEmployees.Columns[6].Width = 150;

				dgvListEmployees.Columns[7].HeaderText = "Status";
				dgvListEmployees.Columns[7].Width = 100;


				dgvListEmployees.Columns[8].HeaderText = "Salary";
				dgvListEmployees.Columns[8].Width = 100;




			}

		}

		private void _Sort()
		{
			switch (cbSortBy.SelectedItem.ToString())
			{

				case "Employee Id":
					_dtEmployees.DefaultView.Sort = "EmployeeID";
					break;


				case "Hire Date":
					_dtEmployees.DefaultView.Sort = "HireDate";
					break;

				case "Full Name":
					_dtEmployees.DefaultView.Sort = "Full_Name";
					break;


				case "Salary":
					_dtEmployees.DefaultView.Sort = "Salary";
					break;

				default:
					_dtEmployees.DefaultView.Sort = "EmployeeID";
					break;



			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void frmManageEmployees_Load(object sender, EventArgs e)
		{
			_LoadEmployeesData();

		}

		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (dgvListEmployees.RowCount > 0)
				_Sort();

		}

		private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete this Employee?",
			   "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

			   == DialogResult.OK)
			{
				if (clsEmployee.DeleteEmployees(Convert.ToInt32(dgvListEmployees.CurrentRow.Cells[0].Value)))
				{
					MessageBox.Show("Employee deleted Successfuly.",
							"Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);



				}
				else
				{
					MessageBox.Show("Cannot Delete this Employee try Later...",
						   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);


				}
			}
		}

		private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmAddUpdateEmployee(Convert.ToInt16(dgvListEmployees.CurrentRow.Cells[0].Value))

				.ShowDialog();
		}

		private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmAddUpdateEmployee()

				.ShowDialog();
		}

		private void tbSearchForEmployee_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbSearchForEmployee.Text))
			{
				_dtEmployees.DefaultView.RowFilter = $"Full_Name Like '{tbSearchForEmployee.Text.Trim()}%'";
			}
			else
				_dtEmployees.DefaultView.RowFilter = "";

		}

		private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new frmShowEmployeeInfo
				(Convert.ToInt16(dgvListEmployees.CurrentRow.Cells[0].Value))
				.ShowDialog();
		}

		private void ContextMenuStripPeopleMenu_Opening(object sender, CancelEventArgs e)
		{

		}

		private void btnAddNewPerson_Click(object sender, EventArgs e)
		{
			new frmAddUpdateEmployee().ShowDialog();

			_LoadEmployeesData();
		}
	}
}
