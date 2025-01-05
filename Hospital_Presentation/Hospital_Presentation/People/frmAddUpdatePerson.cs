using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Business;
using Hospital_Presentation.GlobalClasses;


namespace Hospital_Presentation.People
{
    public partial class frmAddUpdatePerson : Form
    {

        enum enMode { AddNew, Update };

        private enMode _Mode;

        private int _personID;



        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        public frmAddUpdatePerson(int personID)
        {

            _Mode = enMode.Update;

            _personID = personID;


            InitializeComponent();


        }



        private clsPerson _personInfo;


        private void _resetDeafaultValues()
        {

            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add Person Details";

                _personInfo = new clsPerson();


            }


            cbNationality.SelectedIndex = cbNationality.FindString("Morroco");
            cbGendor.SelectedIndex = 0;

            linkRemovePersonImage.Visible = false;

            lblPersonID.Text = "[????]";


        }

        private void _LoadData()
        {
            _personInfo = clsPerson.FindByID(_personID);

            if (_personInfo == null)
            {
                MessageBox.Show("failed to load person Or There is no person With ID = " + _personID + ", This Form Will Closed",

                    "Load Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.Close();

                return;
            }

            // these lines will not executed if the person is null 

            lblPersonID.Text = _personInfo.PersonID.ToString();
            txtFirstName.Text = _personInfo.FirstName;
            txtLastName.Text = _personInfo.LastName;
            txtDateOfBirth.Text = Format.ConvertDateTimeToStringFormat(_personInfo.DateOfBirth);
            txtAddress.Text = _personInfo.Address;
            txtEmail.Text = _personInfo.Email;
            txtPhoneNumber.Text = _personInfo.Phone;
            cbGendor.SelectedIndex = _personInfo.Gendor;
            cbNationality.SelectedIndex = _personInfo.NationalityCountryID;

            if (_personInfo.ImagePath == "")
            {
                picturePersonImage.Image = Properties.Resources.Male;

            }
            else
                picturePersonImage.ImageLocation = _personInfo.ImagePath;


            linkRemovePersonImage.Visible = (_personInfo.ImagePath != "");





        }

        private void _FillCountriesInComboBox()
        {
            DataTable countries = clsCountries.GetListCountries();

            foreach (DataRow row in countries.Rows)
            {
                cbNationality.Items.Add(row["CountryName"]);


            }


        }

        private void _CollectAndSavePersonInfo()
        {

            _personInfo.FirstName = txtFirstName.Text.Trim();
            _personInfo.LastName = txtLastName.Text.Trim();
            _personInfo.DateOfBirth = DateTime.ParseExact(txtDateOfBirth.Text.Trim(), "dd/mm/yyyy", null);
            _personInfo.Address = txtAddress.Text.Trim();
            _personInfo.Email = txtEmail.Text.Trim();
            _personInfo.Phone = txtPhoneNumber.Text.Trim();
            _personInfo.Gendor = (byte)cbGendor.SelectedIndex;
            _personInfo.NationalityCountryID = clsCountries.GetCountryID(cbNationality.SelectedItem.ToString());

            _HandlePersonImage();


            if (_personInfo.Save())
            {
                MessageBox.Show("Person Saved Successfully", " Person Saved",

                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblPersonID.Text = _personInfo.PersonID.ToString();

            }
            else
            {
                MessageBox.Show("Error Counld not save the person Info", "Error",

                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private bool _HandlePersonImage()
        {

            if (_personInfo.ImagePath != picturePersonImage.ImageLocation)
            {
                if (_personInfo.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_personInfo.ImagePath);
                    }
                    catch
                    {

                    }

                }


                if (picturePersonImage.ImageLocation != null)
                {

                    string sourceFile = picturePersonImage.ImageLocation.ToString();

                    if (Util.SaveImageToPeopleFolderImages(ref sourceFile))
                    {
                        _personInfo.ImagePath = sourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("We could not save the image try later.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return false;
                    }


                }

            }

            return true;

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _resetDeafaultValues(); 

            if(_Mode == enMode.Update)
            {
                _LoadData();    

            }
        }

        private void linklblSelectPersonImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                // process selected file 

                string selectedFilePath = openFileDialog1.FileName;

                picturePersonImage.Load(selectedFilePath);

                picturePersonImage.ImageLocation = selectedFilePath;

                linkRemovePersonImage.Visible = true;

            }



        }

        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (picturePersonImage == null)
            {
                if (cbGendor.SelectedIndex == 0)
                {
                    picturePersonImage.Image = Properties.Resources.Male;

                }
                else
                {
                    picturePersonImage.Image = Properties.Resources.Female;

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this person ?", "Confirm",

                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _CollectAndSavePersonInfo();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this .Close();

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtFirstName, "This Field is required!");
            }
            else
                ErrorPoviderValidations.SetError(txtFirstName, "");

        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtLastName, "This Field is required!");
            }
            else
                ErrorPoviderValidations.SetError(txtLastName, "");

        }

        private void txtDateOfBirth_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtDateOfBirth.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtDateOfBirth, "This field is required!");

            }
            else if (!clsValidating.ValidateDateStringFormat(txtDateOfBirth.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtDateOfBirth, "Please Respect the suggested format");
            }
            else
            {
                ErrorPoviderValidations.SetError(txtDateOfBirth, "");
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtEmail, "This Field is required!");
            }
            else if (!clsValidating.ValidateEmail(txtEmail.Text.Trim()))
            {
                ErrorPoviderValidations.SetError(txtEmail, "Please Enter a valide email");

            }
            else
                ErrorPoviderValidations.SetError(txtEmail, "");


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
