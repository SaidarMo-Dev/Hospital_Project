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

namespace Hospital_Presentation.Doctors.Controls
{
    public partial class ctrlShowDoctorInfo : UserControl
    {
        public ctrlShowDoctorInfo()
        {
            InitializeComponent();
        }

        public bool IsFound = false;


        private clsDoctor _doctor;

        public clsDoctor SelectedDoctorInfo
        {
            get { return _doctor; }

        }

        public void LoadData(int doctorID)
        {

            _doctor = clsDoctor.FindByID(doctorID);

            if (_doctor == null)
            {
                MessageBox.Show("doctor with ID = " + " Not found ", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                _resetInfo();
                return;

            }



            IsFound = true;

            lblFullName.Text = _doctor.PersonInfo.FullName;
            lblEmail.Text = _doctor.PersonInfo.Email;
            lblSpecialization.Text = _doctor.Specialization;
            lblWorkingTime.Text = _doctor.WrokingTime;
            lblLicenseNumber.Text = _doctor.LicenseNumber;
            lblCountry.Text = _doctor.PersonInfo.CountryInfo.CountryName;
            lblSalary.Text = _doctor.MonthlySalary.ToString();



        }
        private void _resetInfo()
        {
            lblFullName.Text = "[????]";
            lblEmail.Text = "[????]";
            lblSpecialization.Text = "[????]";
            lblWorkingTime.Text = "[????]";
            lblLicenseNumber.Text = "[????]";
            lblCountry.Text = "[????]";
            lblSalary.Text = "[????]";

        }

    }
}
