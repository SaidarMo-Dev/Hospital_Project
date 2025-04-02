
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Hospital_DataAccessLayer;


namespace Hospital_Business
{

    public class clsPatient
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int PatientID { set; get; }
        public int PersonID { set; get; }
        public string BloodType { set; get; }
        public string AssuranceNumber { set; get; }


        public clsPerson PersonInfo { set; get; }



        public clsPatient()
        {
            this._Mode = enMode.AddNew;

            this.PatientID = -1;
            this.PersonID = -1;
            this.BloodType = " ";
            this.AssuranceNumber = " ";


            this.PersonInfo = null;

        }

        private clsPatient(int PatientID, int PersonID, string BloodType, string AssuranceNumber)
        {
            this._Mode = enMode.Update;

            this.PatientID = PatientID;
            this.PersonID = PersonID;
            this.BloodType = BloodType;
            this.AssuranceNumber = AssuranceNumber;


            this.PersonInfo = clsPerson.FindByID(PersonID);



        }

        public static clsPatient FindByID(int PatientID)
        {
            int PersonID = -1;
            string BloodType = " ";
            string AssuranceNumber = " ";


            if (clsPatientDataAccess.GetPatientsInfoByID(PatientID, ref PersonID, ref BloodType, ref AssuranceNumber))
            {
                return new clsPatient(PatientID, PersonID, BloodType, AssuranceNumber);

            }

            return null;

        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientDataAccess.AddNewPatients(this.PersonID, this.BloodType, this.AssuranceNumber);

            return (this.PatientID != -1);

        }
        private bool _UpdatePatient()
        {
            return clsPatientDataAccess.UpdatePatients(this.PatientID, this.PersonID, this.BloodType, this.AssuranceNumber);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPatient())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdatePatient();

                default:
                    return false;

            }

        }
        public static bool DeletePatient(int PatientID)
        {
            return clsPatientDataAccess.DeletePatients(PatientID);

        }
        public static DataTable GetListPatients()
        {

            return clsPatientDataAccess.GetListPatients();
        }

        public static bool IsPatientsExisteByID(int PatientID)
        {
            return clsPatientDataAccess.IsPatientsExisteByID(PatientID);

        }
        public static int PatientsCount()
        {
            return clsPatientDataAccess.PatientsCount();
        }

    }
}