
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

    public class clsPrescriptions
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int PrescriptionID { set; get; }
        public int MedicalRecordID { set; get; }
        public string MedicalName { set; get; }
        public string Dosage { set; get; }
        public string Frequency { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime NedDate { set; get; }
        public string SpecialInstructions { set; get; }
        public int CreatedByUserID { set; get; }


        public clsUser UsersInfo { set; get; }
        public clsMedicalRecords MedicalRecordsInfo { set; get; }



        public clsPrescriptions()
        {
            this._Mode = enMode.AddNew;

            this.PrescriptionID = -1;
            this.MedicalRecordID = -1;
            this.MedicalName = " ";
            this.Dosage = " ";
            this.Frequency = " ";
            this.StartDate = DateTime.Now;
            this.NedDate = DateTime.Now;
            this.SpecialInstructions = " ";
            this.CreatedByUserID = -1;


            this.UsersInfo = null;
            this.MedicalRecordsInfo = null;

        }

        private clsPrescriptions(int PrescriptionID, int MedicalRecordID, string MedicalName, string Dosage, string Frequency, DateTime StartDate, DateTime NedDate, string SpecialInstructions, int CreatedByUserID)
        {
            this._Mode = enMode.Update;

            this.PrescriptionID = PrescriptionID;
            this.MedicalRecordID = MedicalRecordID;
            this.MedicalName = MedicalName;
            this.Dosage = Dosage;
            this.Frequency = Frequency;
            this.StartDate = StartDate;
            this.NedDate = NedDate;
            this.SpecialInstructions = SpecialInstructions;
            this.CreatedByUserID = CreatedByUserID;


            this.UsersInfo = clsUser.FindByID(CreatedByUserID);
            this.MedicalRecordsInfo = clsMedicalRecords.FindByID(MedicalRecordID);



        }

        public static clsPrescriptions FindByID(int PrescriptionID)
        {
            int MedicalRecordID = -1;
            string MedicalName = " ";
            string Dosage = " ";
            string Frequency = " ";
            DateTime StartDate = DateTime.Now;
            DateTime NedDate = DateTime.Now;
            string SpecialInstructions = " ";
            int CreatedByUserID = -1;


            if (clsPrescriptionsDataAccess.GetPrescriptionsInfoByID(PrescriptionID, ref MedicalRecordID, ref MedicalName, ref Dosage, ref Frequency, ref StartDate, ref NedDate, ref SpecialInstructions, ref CreatedByUserID))
            {
                return new clsPrescriptions(PrescriptionID, MedicalRecordID, MedicalName, Dosage, Frequency, StartDate, NedDate, SpecialInstructions, CreatedByUserID);

            }

            return null;

        }

        private bool _AddNewPrescriptions()
        {
            this.PrescriptionID = clsPrescriptionsDataAccess.AddNewPrescriptions(this.MedicalRecordID, this.MedicalName, this.Dosage, this.Frequency, this.StartDate, this.NedDate, this.SpecialInstructions, this.CreatedByUserID);

            return (this.PrescriptionID != -1);

        }
        private bool _UpdatePrescriptions()
        {
            return clsPrescriptionsDataAccess.UpdatePrescriptions(this.PrescriptionID, this.MedicalRecordID, this.MedicalName, this.Dosage, this.Frequency, this.StartDate, this.NedDate, this.SpecialInstructions, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPrescriptions())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdatePrescriptions();

                default:
                    return false;

            }

        }
        public static bool DeletePrescriptions(int PrescriptionID)
        {
            return clsPrescriptionsDataAccess.DeletePrescriptions(PrescriptionID);

        }
        public static DataTable GetListPrescriptions()
        {

            return clsPrescriptionsDataAccess.GetListPrescriptions();
        }

     
        public static bool IsPrescriptionsExisteByID(int PrescriptionID)
        {
            return clsPrescriptionsDataAccess.IsPrescriptionsExisteByID(PrescriptionID);

        }

    }
}