using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Patients
{
    public partial class frmShowPatientInfo : Form
    {
        private int _patientID = -1;

        public frmShowPatientInfo(int patientID)
        {
            _patientID = patientID;

            InitializeComponent();
        }

        private void frmShowPatientInfo_Load(object sender, EventArgs e)
        {
            ctrlPatientInfoCard1.LoadData(_patientID);
        }
    }
}
