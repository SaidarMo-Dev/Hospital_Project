using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using Hospital_Business;

namespace Hospital_Presentation.Users
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }

        DataTable _dtListUsers;



        private void _LoadUsers()
        {

            _dtListUsers = clsUser.GetListUsers();


            dgvListPeople.DataSource = _dtListUsers;

           

            lblPeopleCount.Text = dgvListPeople.Rows.Count.ToString();
            lblPeopleCount.Text = dgvListPeople .RowCount .ToString();

            if (dgvListPeople.Rows.Count > 0)
            {

                dgvListPeople.Columns[0].HeaderText = "User ID";
                dgvListPeople.Columns[0].Width = 130;

                dgvListPeople.Columns[1].HeaderText = "Person ID";
                dgvListPeople.Columns[1].Width = 130;

                dgvListPeople.Columns[2].HeaderText = "Full Name";
                dgvListPeople.Columns[2].Width = 495;


                dgvListPeople.Columns[3].HeaderText = "Username";
                dgvListPeople.Columns[3].Width = 250;


                dgvListPeople.Columns[4].HeaderText = "IsActive";
                dgvListPeople.Columns[4].Width = 130;

            }

        }

        private void _Sort()
        {
            string filter = cbSortBy.SelectedItem.ToString();

            switch (filter)
            {

                

                case "User ID":
                    _dtListUsers.DefaultView.Sort = "UserID";
                    break;

                case "Person ID":
                    _dtListUsers.DefaultView.Sort = "PersonID";
                    break;

                case "Username":
                    _dtListUsers.DefaultView.Sort = "Username";
                    break;

                default:
                
                    _dtListUsers.DefaultView.Sort = "UserID";
                    break;




            }

        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvListPeople.RowCount > 0)
            {
                _Sort();
            }
        }

        private void tbSearchForPersonByName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearchForPersonByName.Text.ToString()))
                _dtListUsers.DefaultView.RowFilter = "Username Like '" + tbSearchForPersonByName.Text.ToString() + "%'";
            else
                _dtListUsers.DefaultView.RowFilter = "";


        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cbSortBy.SelectedIndex = 0;

            _LoadUsers();

        }

        private void ShowUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmShowUserInfo(Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value))
                
                .ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddUpdateUser().ShowDialog();

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAddUpdateUser(Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value)).ShowDialog();
        }

        private void deleteUsernToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You sure you want to delete this User ?",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int UserID = Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value);

                if (clsUser .DeleteUser(UserID))
                {
                    MessageBox.Show("User Deleted Successfuly",
                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadUsers();

                }
                else
                {
                    MessageBox.Show("Error: Cannot Delete this User",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
