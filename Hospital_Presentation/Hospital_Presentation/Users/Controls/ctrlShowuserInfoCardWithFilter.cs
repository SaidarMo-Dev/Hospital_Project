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

namespace Hospital_Presentation.Users.Controls
{
    public partial class ctrlShowuserInfoCardWithFilter : UserControl
    {
        public ctrlShowuserInfoCardWithFilter()
        {
            InitializeComponent();
        }

        public clsUser SelectedUser
        {
            get { return ctrlUserInfoCard1.SelectedUser; }
        }

        private void _LoadData(int userID)
        {
            ctrlUserInfoCard1.LoadData(userID);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByUserID.Text.ToString()))
            {
                
                MessageBox.Show("Please Enter a User ID to Search For it", "Not Allowed",

                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _LoadData(Convert.ToInt16(txtSearchByUserID.Text.ToString()));
            }

        }

        private void txtSearchByUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtSearchByUserID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
