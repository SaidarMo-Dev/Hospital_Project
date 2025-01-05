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
    public partial class ctrlUserInfoCard : UserControl
    {
        public ctrlUserInfoCard()
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
            ctrlPersonInfoCard1 .resetDefaultValues();

            lblUserID.Text = "[????]";
            lblUsername.Text = "[????]";
            lblIsActive.Text = "[????]";


        }
        public void LoadData(int UserID)
        {

            _user  = clsUser .FindByID (UserID);

            if (_user == null)
            {
                _resetData();
                MessageBox.Show ("There is no user with ID = " + UserID , 
                    
                    "Not Found", MessageBoxButtons.OK , MessageBoxIcon.Error);

                return ;

            }

            ctrlPersonInfoCard1.LoadPersonInfo(_user .PersonID);

            lblUserID.Text = _user.UserID.ToString();
            lblUsername.Text = _user.Username;
            lblIsActive .Text = (_user.IsActive ) ? "Yes": "No";

        }
    


    }
}
