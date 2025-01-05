using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Doctors.Controls
{
    public partial class ctrlShowDoctorInfoCardWithFilter_ : UserControl
    {
        public ctrlShowDoctorInfoCardWithFilter_()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ctrlDoctorInfoCard1.LoadData(Convert.ToInt16(txtSearch.Text));

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar ))
            {
                e.Handled = true;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.ToString()))
                btnFind.Enabled = true;
            else 
                btnFind.Enabled = false;
        }
    }
}
