using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Business;

namespace Hospital_Presentation.GlobalClasses
{
    public class Global
    {


        //public static clsUser CurrentUser = new clsUser();



        // just for testing, we will change it later 
        public static clsUser CurrentUser = clsUser.FindByID(1);

    }
}
