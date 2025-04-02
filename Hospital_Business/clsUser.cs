
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

    public class clsUser
    {

        enum enMode { AddNew, Update };

        enMode _Mode;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }


        public clsPerson PersonInfo { set; get; }



        public clsUser()
        {
            this._Mode = enMode.AddNew;

            this.UserID = -1;
            this.PersonID = -1;
            this.Username = " ";
            this.Password = " ";
            this.IsActive = false;


            this.PersonInfo = null;

        }

        private clsUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            this._Mode = enMode.Update;

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;


            this.PersonInfo = clsPerson.FindByID(PersonID);



        }

        public static clsUser FindByID(int UserID)
        {
            int PersonID = -1;
            string Username = " ";
            string Password = " ";
            bool IsActive = false;


            if (clsUserDataAccess.GetUserInfoByID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Username, Password, IsActive);

            }

            return null;

        }

		public static clsUser FindByUsernameAndPassword(string Username, string Password)
		{
			
            int UserID = -1;
			int PersonID = -1;
			bool IsActive = false;


			if (clsUserDataAccess.GetUserInfoByUsernameAndPassword(Username, Password,ref UserID, ref PersonID, ref IsActive))
			{
				return new clsUser(UserID, PersonID, Username, Password, IsActive);

			}

			return null;

		}


		private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);

            return (this.UserID != -1);

        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.Username, this.Password, this.IsActive);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {

                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:

                    return _UpdateUser();

                default:
                    return false;

            }

        }
        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);

        }
        public static DataTable GetListUsers()
        {

            return clsUserDataAccess.GetListUsers();
        }

        public static bool IsUserExisteByID(int UserID)
        {
            return clsUserDataAccess.IsUserExisteByID(UserID);

        }

        public static int UsersCount()
        {
            return clsUserDataAccess.UsersCount();

        }

        public static bool IsPersonHasUser(int personId)
        {
            return clsUserDataAccess.IsPersonHasUser(personId);

        }
    
    }
}