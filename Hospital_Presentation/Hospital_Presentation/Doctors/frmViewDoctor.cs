using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Doctors
{
    public partial class frmViewDoctor : Form
    {
        public frmViewDoctor()
        {
            InitializeComponent();
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void ctrlShowDoctorInfoCardWithFilter_1_Load(object sender, EventArgs e)
		{

		}
	}
}
