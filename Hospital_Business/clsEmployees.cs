
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

    public class clsEmployee
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int EmployeeID { set; get; }
        public int PersonID { set; get; }
        public string JobTitle { set; get; }
        public DateTime HireDate { set; get; }
        //public DateTime LeaveDate { set; get; }
        public Nullable<DateTime> LeaveDate { set; get; }
        public int DepartementID { set; get; }
        public byte EmployeeStatus { set; get; }
        public int Salary { set; get; }
     
        public clsPerson PersonInfo { set; get; }
        public clsDepartement DepartementInfo { set; get; }


        public string EmployeeStatusString
        {
            get 
            {
                switch (this.EmployeeStatus)
                {

                    case 1:
                        return "Active";
                    case 2:
                        return "Vacation";

                    case 3:
                        return "Leave";

                    default:
                        return "Inknow";
                }
                
            }
        }
        public clsEmployee()
        {
            this._Mode = enMode.AddNew;

            this.EmployeeID = -1;
            this.PersonID = -1;
            this.JobTitle = "";
            this.HireDate = DateTime.Now;
            this.LeaveDate = null;
            this.DepartementID = -1;
            this.EmployeeStatus = 0;
            this.Salary = -1;
           
            this.PersonInfo = null;
            this.DepartementInfo = null;
        }

        private clsEmployee(int EmployeeID, int PersonID, string JobTitle, DateTime HireDate, Nullable<DateTime> LeaveDate, int DepartementID, byte EmployeeStatus, int Salary)
        {
            this._Mode = enMode.Update;

            this.EmployeeID = EmployeeID;
            this.PersonID = PersonID;
            this.JobTitle = JobTitle;
            this.HireDate = HireDate;
            this.LeaveDate = LeaveDate;
            this.DepartementID = DepartementID;
            this.EmployeeStatus = EmployeeStatus;
            this.Salary = Salary;


            this.PersonInfo = clsPerson.FindByID(PersonID);
            this.DepartementInfo = clsDepartement.FindByID(DepartementID);


        }

        public static clsEmployee FindByID(int EmployeeID)
        {
            int PersonID = -1;
            string JobTitle = "";
            DateTime HireDate = DateTime.Now;
            Nullable<DateTime> LeaveDate = null;
            int DepartementID = -1;
            byte EmployeeStatus = 0;
            int Salary = -1;


            if (clsEmployeeDataAccess.GetEmployeeInfoByID(EmployeeID, ref PersonID, ref JobTitle,
                                                ref HireDate, ref LeaveDate, ref DepartementID, 
                                                ref EmployeeStatus, ref Salary))
            {
                return new clsEmployee(EmployeeID, PersonID, JobTitle, HireDate, LeaveDate,
                                        DepartementID, EmployeeStatus, Salary);

            }

            return null;

        }

        private bool _AddNewEmployees()
        {
            this.EmployeeID = clsEmployeeDataAccess.AddNewEmployee(this.PersonID, this.JobTitle,
                                                this.HireDate, this.LeaveDate, this.DepartementID,
                                                this.EmployeeStatus, this.Salary);

            return (this.EmployeeID != -1);

        }
        private bool _UpdateEmployees()
        {
            return clsEmployeeDataAccess.UpdateEmployee(this.EmployeeID, this.PersonID, this.JobTitle,
                                        this.HireDate, this.LeaveDate, this.DepartementID,
                                        this.EmployeeStatus, this.Salary);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewEmployees())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                   
                    return false;

                case enMode.Update:

                    return _UpdateEmployees();

                default:
                    return false;

            }

        }
        public static bool DeleteEmployees(int EmployeeID)
        {
            return clsEmployeeDataAccess.DeleteEmployee(EmployeeID);

        }
        public static DataTable GetListEmployees()
        {

            return clsEmployeeDataAccess.GetListEmployees();
        }

        public static bool IsEmployeesExisteByID(int EmployeeID)
        {
            return clsEmployeeDataAccess.IsEmployeeExisteByID(EmployeeID);

        }

    }
}