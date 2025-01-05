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
using Hospital_Presentation.GlobalClasses;


namespace Hospital_Presentation.Patients.Controls
{
    public partial class ctrlPatientInfo : UserControl
    {
        public ctrlPatientInfo()
        {
            InitializeComponent();
        }

        public bool IsFound = false;
        
        private int _PatientID;

       
        private clsPatient _PatienInfo;

        public clsPatient SelectedPatientInfo
        {
            get { return _PatienInfo; }
        }

        private void _resetPatientInfo()
        {
            lblFullName.Text = "[????)";
            lblMobile.Text = "[????)";
            lblEmail.Text = "[????)";
            lblAddress.Text = "[????)";
            lblDateOfBirth.Text = "[????)";
            lblCountry.Text = "[????)";
            lblAssuranceNumber.Text = "[????)";

        }
   
        private void _fillPatientInfo ()
        {
            lblFullName.Text = _PatienInfo.PersonInfo.FullName;
            lblMobile.Text = _PatienInfo.PersonInfo.Phone;
            lblEmail.Text = _PatienInfo.PersonInfo.Email;
            lblAddress.Text = _PatienInfo.PersonInfo.Address;
            lblDateOfBirth.Text = Format.ConvertDateTimeToStringFormat(_PatienInfo.PersonInfo.DateOfBirth);
            lblCountry.Text = _PatienInfo.PersonInfo .CountryInfo.CountryName;
            lblAssuranceNumber.Text = _PatienInfo.AssuranceNumber;


        }


        public void LoadData(int PatientID)
        {
            _PatientID = PatientID;

            _PatienInfo = clsPatient.FindByID(PatientID);

            if (_PatienInfo == null)
            {
                MessageBox.Show("Patient with ID = " + PatientID + " Not Found",
                    " Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);


                _resetPatientInfo();

                return;

            }

            IsFound = true;

            _fillPatientInfo();


        }

    }
}
