
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Hospital_DataAccessLayer;
using System.Linq.Expressions;


namespace Hospital_Business
{

    public class clsAppointment
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int AppointmentID { set; get; }
        public int PatientID { set; get; }
        public int DoctorID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public byte AppointmentStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public string Notes { set; get; }
        public int MedicalRecordID { set; get; }
        public int PaymentID { set; get; }
        public DateTime CreatedDate { set; get; }
        public int CreatedByUserID { set; get; }

        public string StatusString
        {
            get
            {
                switch (AppointmentStatus)
                {
                    case 1:
                        return "New";

                    case 2:
                        return "Canceled";


                    case 3:
                        return "Completed";

                    default:
                        return "Unknown";

                }
            }
        }

        public clsDoctor DoctorInfo { set; get; }
        public clsUser UserInfo { set; get; }
        public clsPatient PatientInfo { set; get; }
        public clsMedicalRecord MedicalRecordInfo { set; get; }
        public clsPayments PaymentInfo { set; get; }



        public clsAppointment()
        {
            this._Mode = enMode.AddNew;

            this.AppointmentID = -1;
            this.PatientID = -1;
            this.DoctorID = -1;
            this.AppointmentDate = DateTime.Now;
            this.AppointmentStatus = 0;
            this.LastStatusDate = DateTime.Now;
            this.Notes = "";
            this.MedicalRecordID = -1;
            this.PaymentID = -1;
            this.CreatedDate = DateTime.Now;
            this.CreatedByUserID = -1;


            this.DoctorInfo = null;
            this.UserInfo = null;
            this.PatientInfo = null;
            this.MedicalRecordInfo = null;
            this.PaymentInfo = null;

        }

        private clsAppointment(int AppointmentID, int PatientID, int DoctorID, DateTime AppointmentDate, byte AppointmentStatus, DateTime LastStatusDate, string Notes, int MedicalRecordID, int PaymentID, DateTime CreatedDate, int CreatedByUserID)
        {
            this._Mode = enMode.Update;

            this.AppointmentID = AppointmentID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.AppointmentDate = AppointmentDate;
            this.AppointmentStatus = AppointmentStatus;
            this.LastStatusDate = LastStatusDate;
            this.Notes = Notes;
            this.MedicalRecordID = MedicalRecordID;
            this.PaymentID = PaymentID;
            this.CreatedDate = CreatedDate;
            this.CreatedByUserID = CreatedByUserID;


            this.DoctorInfo = clsDoctor.FindByID(DoctorID);
            this.UserInfo = clsUser.FindByID(CreatedByUserID);
            this.PatientInfo = clsPatient.FindByID(PatientID);
            this.MedicalRecordInfo = clsMedicalRecord.FindByID(MedicalRecordID);
            this.PaymentInfo = clsPayments.FindByID(PaymentID);



        }

        public static clsAppointment FindByID(int AppointmentID)
        {
            int PatientID = -1;
            int DoctorID = -1;
            DateTime AppointmentDate = DateTime.Now;
            byte AppointmentStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            string Notes = "";
            int MedicalRecordID = -1;
            int PaymentID = -1;
            DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;


            if (clsAppointmentDataAccess.GetAppointmentsInfoByID(AppointmentID, ref PatientID, ref DoctorID, ref AppointmentDate, ref AppointmentStatus, ref LastStatusDate, ref Notes, ref MedicalRecordID, ref PaymentID, ref CreatedDate, ref CreatedByUserID))
            {
                return new clsAppointment(AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentStatus, LastStatusDate, Notes, MedicalRecordID, PaymentID, CreatedDate, CreatedByUserID);

            }

            return null;

        }

        private bool _AddNewAppointments()
        {
            this.AppointmentID = clsAppointmentDataAccess.AddNewAppointments(this.PatientID, this.DoctorID, this.AppointmentDate, this.AppointmentStatus, this.LastStatusDate, this.Notes, this.MedicalRecordID, this.PaymentID, this.CreatedDate, this.CreatedByUserID);

            return (this.AppointmentID != -1);

        }
        private bool _UpdateAppointments()
        {
            return clsAppointmentDataAccess.UpdateAppointments(this.AppointmentID, this.PatientID, this.DoctorID, this.AppointmentDate, this.AppointmentStatus, this.LastStatusDate, this.Notes, this.MedicalRecordID, this.PaymentID, this.CreatedDate, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewAppointments())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateAppointments();

                default:
                    return false;

            }

        }
        public static bool DeleteAppointments(int AppointmentID)
        {
            return clsAppointmentDataAccess.DeleteAppointments(AppointmentID);

        }
        public static DataTable GetListAppointments()
        {

            return clsAppointmentDataAccess.GetListAppointments();
        }

        public static bool IsAppointmentsExisteByID(int AppointmentID)
        {
            return clsAppointmentDataAccess.IsAppointmentsExisteByID(AppointmentID);

        }

        public bool SetComplete()
        {
            return clsAppointmentDataAccess.UpdateStatus(this.AppointmentID, 3);
        }

        public bool Cancel()
        {
            return clsAppointmentDataAccess.UpdateStatus(this.AppointmentID, 2);

        }
    
        public bool HasMedicalRecord()
        {
            return clsAppointmentDataAccess.HasMedicalRecord(this.AppointmentID);
        }

		public bool HasPrescriptions()
		{
            return clsPrescriptionDataAccess.IsMedicalRecordHasPrescriptions(this.MedicalRecordID);
		}

	}
}