using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hospital_DataAccessLayer;

namespace Hospital_Business
{
    public class clsDepartement
    {

        enum enMode { AddNew, Update };

        private enMode _Mode =  enMode.AddNew;

        public int DepartementID { get; set; }
        public string DepartementName { set; get; }


        public clsDepartement ()
        {
            this.DepartementID = -1;
            this.DepartementName = "";


        }

        private clsDepartement (int ID , string DepartementName)
        {
            this.DepartementID = ID;
            this.DepartementName = DepartementName;

        }


        private bool _AddNew()
        {

            this .DepartementID =  clsDepartemenData.AddNewCountries(this.DepartementName);

            return (this.DepartementID != -1);
        }
    
        private bool _Update()
        {
            return clsDepartemenData.UpdateDepartement(this.DepartementID, this.DepartementName);

        }
    

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew : 
                    if (_AddNew ())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }

                    return false;

                case  enMode.Update :
                    return _Update();

                default :
                    return false;

            }
        }
    

        public static clsDepartement FindByID(int DepartementID)
        {
            string Name = "";

            if (clsDepartemenData.GetDepartementInfoByID(DepartementID, ref Name))
            {
                return new clsDepartement(DepartementID, Name);

            }

            return null;

        }
   
        public static DataTable ListDepartements()
        {
            return clsDepartemenData.GetListDepartements();

        }
    
        public static int FindDepartementID(string DepartementName)
        {

            return clsDepartemenData.GetDepartementID(DepartementName);

        }

    }
}
