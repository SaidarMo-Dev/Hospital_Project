
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

    public class clsPerson
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
        public int Age
        {
            get { return _GetAge(); }

            set { Age = value; }
        }


        public clsCountries CountryInfo { set; get; }



        public clsPerson()
        {
            this._Mode = enMode.AddNew;

            this.PersonID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Email = "";
            this.Phone = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";


            this.CountryInfo = null;

        }

        private clsPerson(int PersonID, string FirstName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Email, string Phone, int NationalityCountryID, string ImagePath)
        {
            this._Mode = enMode.Update;

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Email = Email;
            this.Phone = Phone;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;


            this.CountryInfo = clsCountries.FindByID(NationalityCountryID);



        }

        public static clsPerson FindByID(int PersonID)
        {
            string FirstName = " ";
            string LastName = " ";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;
            string Address = " ";
            string Email = " ";
            string Phone = " ";
            int NationalityCountryID = -1;
            string ImagePath = " ";


            if (clsPeopleDataAccess.GetPersonInfoByID(PersonID, ref FirstName, ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Email, ref Phone, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, FirstName, LastName, DateOfBirth, Gendor, Address, Email, Phone, NationalityCountryID, ImagePath);

            }

            return null;

        }

        private int _GetAge()
        {
            int Age = DateTime.Now.Year - this.DateOfBirth.Year; 
            if (this .DateOfBirth .Month < DateTime .Now .Month 
                 &&
                this .DateOfBirth .Day < DateTime .Now .Day)
            {
                return (Age- 1 );
            }

            return Age;

        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.FirstName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Email, this.Phone, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);

        }
        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.LastName, this.DateOfBirth, this.Gendor, this.Address, this.Email, this.Phone, this.NationalityCountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPerson())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdatePerson();

                default:
                    return false;

            }

        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleDataAccess.DeletePerson(PersonID);

        }
        public static DataTable GetListPeople()
        {

            return clsPeopleDataAccess.GetListPeople();
        }

        public static bool IsPersonExisteByID(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExisteByID(PersonID);

        }

        public static int PeopleCount()
        {
            return clsPeopleDataAccess.PeopleCount();

        }
    }
}