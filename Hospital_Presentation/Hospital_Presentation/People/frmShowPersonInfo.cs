using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.People
{
    public partial class frmShowPersonInfo : Form
    {
        public frmShowPersonInfo(int personId)
        {
            _personId = personId;
            InitializeComponent();
        }

        private int _personId ;

		private void btnClose_Click(object sender, EventArgs e)
		{
            this.Close();

		}

		private void frmShowPersonInfo_Load(object sender, EventArgs e)
		{
            ctrlPersonInfoCard1.LoadPersonInfo(_personId);
		}
	}
}
