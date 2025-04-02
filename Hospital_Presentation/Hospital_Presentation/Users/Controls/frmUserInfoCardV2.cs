using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Users.Controls
{
	public partial class ctrlUserInfoCardV2 : UserControl
	{
		public ctrlUserInfoCardV2()
		{
			InitializeComponent();
		}


		private clsUser _user;

		public clsUser SelectedUser
		{
			get { return _user; }
		}

		private void _resetData()
		{
			lblPersonID.Text = "[????]";
			lblFullName.Text = "[????]";
			lblAge.Text = "[????]";
			lblMobileNumber.Text = "[????]";
			lblEmail.Text = "[????]";
			lblPersonAddress.Text = "[????]";
			lblPersonGendor.Text = "[????]";
			lblNationality.Text = "[????]";

			lblUserID.Text = "[????]";
			lblUsername.Text = "[????]";
			lblIsActive.Text = "[????]";


		}
		public void LoadData(int UserID)
		{

			_user = clsUser.FindByID(UserID);

			if (_user == null)
			{
				_resetData();
				MessageBox.Show("There is no user with ID = " + UserID,

					"Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;

			}

			//  Person Info 


			lblPersonID.Text = _user.PersonInfo.PersonID.ToString();
			lblFullName.Text = _user.PersonInfo.FullName;
			lblAge.Text = _user.PersonInfo.Age.ToString();
			lblMobileNumber.Text = _user.PersonInfo.Phone;
			lblEmail.Text = _user.PersonInfo.Email;
			lblPersonAddress.Text = _user.PersonInfo.Address;
			lblPersonGendor.Text = (_user.PersonInfo.Gendor == 0) ? "Male" : "Female";
			lblNationality.Text = _user.PersonInfo.CountryInfo.CountryName;

			// User Info 
			lblUserID.Text = _user.UserID.ToString();
			lblUsername.Text = _user.Username;
			lblIsActive.Text = (_user.IsActive) ? "Yes" : "No";

		}



		private void frmUserInfoCardV2_Load(object sender, EventArgs e)
		{

		}
	}
}
