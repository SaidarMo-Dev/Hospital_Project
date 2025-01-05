using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Hospital_Business;

namespace Hospital_Presentation.Users
{
    public partial class frmAddUpdateUser : Form
    {
        enum enMde { AddNew, Update};

        enMde _mode = enMde.AddNew;

        private clsUser _user;

        private int _userID;

        public frmAddUpdateUser(int userID)
        {
            _mode = enMde.Update;
            _userID = userID;

            InitializeComponent();

        }


        public frmAddUpdateUser()
        {
            _mode = enMde.AddNew;

            InitializeComponent();
        }
        private void _resetDefaultValue()
        {

            if (_mode == enMde.AddNew )
            {

                _user = new clsUser();

                this.Text = "Add New User";
                chkbIsActive.Checked = true;

                return;

            }

            btnNext .Enabled = false;
            lblUserID.Text = "[????]";

        }

        private void _LoadData()
        {
            _user = clsUser.FindByID(_userID);

            if (_user == null)
            {
                _resetDefaultValue();

                MessageBox.Show("There is no user with ID = " + _userID + " this form will Closed !",
                    "Not Fouund", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            // this code will execute only if the user is found 

            ctrlPersonInfoCardWithFilter1.LoadData(_user.PersonID);
            ctrlPersonInfoCardWithFilter1.Enabled = false;

            lblUserID.Text = _user.UserID.ToString();
            txtUsername.Text = _user.Username;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;
            chkbIsActive .Checked = _user .IsActive ;

        }


        private void frmAdUpdateUser_Load(object sender, EventArgs e)
        {
            _resetDefaultValue();

            if (_mode == enMde.Update)
            {
                _LoadData();

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this .ValidateChildren())
            {

                if (this.ValidateChildren())
                {
                    if (MessageBox.Show("Are you sure you want to save this User?", "Confirm",
                               MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                           == DialogResult.OK)
                    {

                        _user.PersonID = ctrlPersonInfoCardWithFilter1.SelectedPersonInfo.PersonID;
                        _user.Username = txtUsername.Text.Trim();
                        _user .Password = txtPassword.Text.Trim();
                        _user.IsActive = chkbIsActive.Checked;

                        if (_user.Save())
                        {
                            MessageBox.Show("User saved Successfully", "Saved",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lblUserID.Text = _user.UserID.ToString();

                            ctrlPersonInfoCardWithFilter1.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("Error cannot save this user verify your informations and try later",
                                "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("We cannot perform this operation make sure you filled all fields correctly",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string .IsNullOrEmpty(txtUsername.Text))
            {
                epValidations.SetError(txtUsername, "This Field is required");
            }
            else
                epValidations.SetError(txtUsername, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                epValidations.SetError(txtPassword, "This Field is required");
            }
            else
                epValidations.SetError(txtPassword , "");
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                epValidations.SetError(txtConfirmPassword, "This Field is required");
            }
            else if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
                epValidations.SetError(txtConfirmPassword, "Passwords does not match!");
            else
                epValidations.SetError(txtConfirmPassword, "");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TabControlUserInfo.SelectedTab = PageAdditionalUserInfo;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TabControlUserInfo .SelectedTab = PagePersonInfo;
        }

        private void ctrlPersonInfoCardWithFilter1_OnPersonSelected(object sender, People.Controls.ctrlPersonInfoCardWithFilter.PersonInfoEventArgs e)
        {
            btnNext .Enabled = true;
         
        }
    }
}
