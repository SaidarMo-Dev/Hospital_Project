using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Employees
{
    public partial class frmShowEmployeeInfo : Form
    {
        private int _eemployeeId;
        public frmShowEmployeeInfo(int EmployeeId)
        {
            _eemployeeId = EmployeeId;
            InitializeComponent();
        }

		private void ctrlEmployeeInfo1_Load(object sender, EventArgs e)
		{

		}

		private void frmShowEmployeeInfo_Load(object sender, EventArgs e)
		{
            ctrlEmployeeInfo1.LoadData(_eemployeeId);
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
