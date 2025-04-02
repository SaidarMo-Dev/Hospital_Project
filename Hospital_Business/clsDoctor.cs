


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Hospital_DataAccessLayer;
using System.Data.SqlTypes;


namespace Hospital_Business
{

    public class clsDoctor
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int DoctorID { set; get; }
        public int PersonID { set; get; }
        public string Specialization { set; get; }
        public int MonthlySalary { set; get; }
        public string LicenseNumber { set; get; }
        public string WrokingTime { set; get; }
        public int CreatedByUserID { set; get; }


        public clsUser UsersInfo { set; get; }
        public clsPerson PersonInfo { set; get; }



        public clsDoctor()
        {
            this._Mode = enMode.AddNew;

            this.DoctorID = -1;
            this.PersonID = -1;
            this.Specialization = " ";
            this.MonthlySalary = -1;
            this.LicenseNumber = " ";
            this.WrokingTime = " ";
            this.CreatedByUserID = -1;


            this.UsersInfo = null;
            this.PersonInfo = null;

        }

        private clsDoctor(int DoctorID, int PersonID, string Specialization, int MonthlySalary, string LicenseNumber, string WrokingTime, int CreatedByUserID)
        {
            this._Mode = enMode.Update;

            this.DoctorID = DoctorID;
            this.PersonID = PersonID;
            this.Specialization = Specialization;
            this.MonthlySalary = MonthlySalary;
            this.LicenseNumber = LicenseNumber;
            this.WrokingTime = WrokingTime;
            this.CreatedByUserID = CreatedByUserID;


            this.UsersInfo = clsUser.FindByID(CreatedByUserID);
            this.PersonInfo = clsPerson.FindByID(PersonID);



        }

        public static clsDoctor FindByID(int DoctorID)
        {
            int PersonID = -1;
            string Specialization = "";
            int MonthlySalary = -1;
            string LicenseNumber = "";
            string WrokingTime = "";
            int CreatedByUserID = -1;


            if (clsDoctorsDataAccess.GetDoctorsInfoByID(DoctorID, ref PersonID, ref Specialization, ref MonthlySalary, ref LicenseNumber, ref WrokingTime, ref CreatedByUserID))
            {
                return new clsDoctor(DoctorID, PersonID, Specialization, MonthlySalary, LicenseNumber, WrokingTime, CreatedByUserID);

            }

            return null;

        }

        private bool _AddNewDoctor()
        {
            this.DoctorID = clsDoctorsDataAccess.AddNewDoctors(this.PersonID, this.Specialization, this.MonthlySalary, this.LicenseNumber, this.WrokingTime, this.CreatedByUserID);

            return (this.DoctorID != -1);

        }
        private bool _UpdateDoctor()
        {
            return clsDoctorsDataAccess.UpdateDoctors(this.DoctorID, this.PersonID, this.Specialization, this.MonthlySalary, this.LicenseNumber, this.WrokingTime, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDoctor())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateDoctor();

                default:
                    return false;

            }

        }
        public static bool DeleteDoctor(int DoctorID)
        {
            return clsDoctorsDataAccess.DeleteDoctors(DoctorID);

        }
        public static DataTable GetListDoctors()
        {

            return clsDoctorsDataAccess.GetListDoctors();
        }

        public static bool IsDoctorsExisteByID(int DoctorID)
        {
            return clsDoctorsDataAccess.IsDoctorsExisteByID(DoctorID);

        }

        public static DataTable ActiveAppointmentsForDoctor(int DoctorID)
        {
            return clsAppointmentDataAccess.getActiveAppointmentsForDoctor(DoctorID);

        }

        public static DataTable CompletedAppointmentsForDoctor(int DoctorID)
        {
            return clsAppointmentDataAccess.getCompletedAppointmentsForDoctor(DoctorID);

        }

        public static int DoctorsCount()
        {
            return clsDoctorsDataAccess.DoctorsCount();

        }


    }
}