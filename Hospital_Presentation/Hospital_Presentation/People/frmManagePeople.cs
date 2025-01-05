using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.People
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }



        DataTable _dtListPeople;

        private void _LoadPeopleInfo()
        {

            _dtListPeople = clsPerson.GetListPeople();


            dgvListPeople.DataSource = _dtListPeople;

            // cbSortBy.SelectedIndex = 0;
            
            lblPeopleCount.Text = dgvListPeople.Rows.Count.ToString();

            if (dgvListPeople.Rows.Count > 0)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[0].Width = 120;

                dgvListPeople.Columns[1].HeaderText = "First Name";
                dgvListPeople.Columns[1].Width = 130;

                dgvListPeople.Columns[2].HeaderText = "Last Name";
                dgvListPeople.Columns[2].Width = 130;


                dgvListPeople.Columns[3].HeaderText = "Gendor";
                dgvListPeople.Columns[3].Width = 100;


                dgvListPeople.Columns[4].HeaderText = "Address";
                dgvListPeople.Columns[4].Width = 220;


                dgvListPeople.Columns[5].HeaderText = "Email";
                dgvListPeople.Columns[5].Width = 220;

                dgvListPeople.Columns[6].HeaderText = "Phone";
                dgvListPeople.Columns[6].Width = 220;


                dgvListPeople.Columns[7].HeaderText = "Nationality";
                dgvListPeople.Columns[7].Width = 200;


            }

        }


        


        private void btnClose_Click(object sender, EventArgs e)
        {
            this .Close();  

        }

      


        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You sure you want to delete this Person ?",
                    "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int PersonID = Convert.ToInt16(dgvListPeople.CurrentRow.Cells[0].Value);

                if (clsPerson.DeletePerson(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfuly",
                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadPeopleInfo();

                }
                else
                {
                    MessageBox.Show("Error: Cannot Delete this person",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            int personID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells[0].Value);
            var updatePersonForm = new frmAddUpdatePerson(personID);

            updatePersonForm.ShowDialog();

        
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AddPersonForm = new frmAddUpdatePerson();

            AddPersonForm.ShowDialog();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this future not emplemented it will Available soon", 
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this future not emplemented it will Available soon",
              "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showPersonForm = new frmShowPersonInfo();
           
            showPersonForm.ShowDialog();


        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadPeopleInfo();

        }

        private void lblPeopleCount_Click(object sender, EventArgs e)
        {

        }

        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbSortBy.SelectedItem.ToString() == "Person ID")
                _dtListPeople.DefaultView.Sort = "PersonID ";

            else if (cbSortBy.SelectedItem.ToString() == "First Name")
                _dtListPeople.DefaultView.Sort = "FirstName";

            else
                _dtListPeople.DefaultView.Sort = "LastName";

        }

        private void tbSearchForPersonByName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchForPersonByName.Text.Trim()))
                return;


            _dtListPeople.DefaultView.RowFilter = "FirstName LIKE '" + tbSearchForPersonByName.Text.Trim() + "%'";

        }
    }
}
