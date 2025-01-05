using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Patients.Controls
{
    public partial class ctrlPatientInfoCardWithFilter : UserControl
    {
        public ctrlPatientInfoCardWithFilter()
        {
            InitializeComponent();
        }

        private void _LoadPatientInformations()
        {
            int patientID = Convert.ToInt16(txtSearchByPatientID.Text);

            ctrlPatientInfoCard1.LoadData(patientID);


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadPatientInformations();

        }
    }
}
