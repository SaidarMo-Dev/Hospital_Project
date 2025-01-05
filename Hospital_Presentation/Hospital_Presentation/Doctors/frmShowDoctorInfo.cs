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
    public partial class frmShowDoctorInfo : Form
    {
        private int _doctorID;
     
        public frmShowDoctorInfo(int doctorID)
        {
            _doctorID = doctorID;

            InitializeComponent();
        }

        private void frmShowDoctorInfo_Load(object sender, EventArgs e)
        {
            ctrlDoctorInfoCard1.LoadData(_doctorID);

        }
    }
}
