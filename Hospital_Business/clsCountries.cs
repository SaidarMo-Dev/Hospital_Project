
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

    public class clsCountries
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int CountryID { set; get; }
        public string CountryName { set; get; }





        public clsCountries()
        {
            this._Mode = enMode.AddNew;

            this.CountryID = -1;
            this.CountryName = " ";



        }

        private clsCountries(int CountryID, string CountryName)
        {
            this._Mode = enMode.Update;

            this.CountryID = CountryID;
            this.CountryName = CountryName;





        }

        public static clsCountries FindByID(int CountryID)
        {
            string CountryName = " ";


            if (clsCountriesDataAccess.GetCountriesInfoByID(CountryID, ref CountryName))
            {
                return new clsCountries(CountryID, CountryName);

            }

            return null;

        }

        private bool _AddNewCountries()
        {
            this.CountryID = clsCountriesDataAccess.AddNewCountries(this.CountryName);

            return (this.CountryID != -1);

        }
        private bool _UpdateCountries()
        {
            return clsCountriesDataAccess.UpdateCountries(this.CountryID, this.CountryName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCountries())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateCountries();

                default:
                    return false;

            }

        }
        public static bool DeleteCountries(int CountryID)
        {
            return clsCountriesDataAccess.DeleteCountries(CountryID);

        }
        public static DataTable GetListCountries()
        {

            return clsCountriesDataAccess.GetListCountries();
        }

        public static bool IsCountriesExisteByID(int CountryID)
        {
            return clsCountriesDataAccess.IsCountriesExisteByID(CountryID);

        }

        public static int GetCountryID(string countryName)
        {
            return clsCountriesDataAccess.GetCountryID(countryName);
        }
    }
}