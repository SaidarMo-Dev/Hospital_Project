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

namespace Hospital_Presentation.People.Controls
{
    public partial class ctrlPersonInfoCard : UserControl
    {
        public ctrlPersonInfoCard()
        {
            InitializeComponent();
        }

        public bool IsPersonFound = false;


        int _personID = 0;

        clsPerson _personInfo;


        public clsPerson SelectedPersonInfo
        {
            get { return _personInfo; }
        }

        public int SelectedPersonID
        {
            get { return _personID; }
        }


        private void _ShowPersonImage()
        {
            try
            {
                if (string.IsNullOrEmpty(_personInfo.ImagePath))
                {
                    if (_personInfo.Gendor == 0)
                        picturePersonImage.Image = Properties.Resources.Male;
                    else
                        picturePersonImage.Image = Properties.Resources.Female;

                }
                else
                    picturePersonImage.Load(_personInfo.ImagePath);

            }
            catch
            {
                picturePersonImage.Image = Properties.Resources.Male;
            }



        }



        public void resetDefaultValues()
        {

            lblPersonID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblAge.Text = "[????]";
            lblMobileNumber.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPersonAddress.Text = "[????]";
            lblPersonGendor.Text = "[????]";
            lblNationality.Text = "[????]";

            picturePersonImage.Image = Properties.Resources.Male;


        }



        public void LoadPersonInfo(int PersonID)
        {
            _personID = PersonID;

            _personInfo = clsPerson.FindByID(PersonID);

            if (_personInfo == null)
            {
                MessageBox.Show("The Person With ID = " + PersonID + " Not Found", "not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


                resetDefaultValues();

                return;
            }

            // these lines will executed only if the person is found

            IsPersonFound = true;

            lblPersonID.Text = PersonID.ToString();
            lblFullName.Text = _personInfo.FullName;
            lblAge.Text = _personInfo.Age.ToString();
            lblMobileNumber.Text = _personInfo.Phone;
            lblEmail.Text = _personInfo.Email;
            lblPersonAddress.Text = _personInfo.Address;
            lblPersonGendor.Text = (_personInfo.Gendor == 0) ? "Male" : "Female";

            lblNationality.Text = _personInfo.CountryInfo.CountryName;

            _ShowPersonImage();



        }




        private void ctrlPersonInfoCard_Load(object sender, EventArgs e)
        {

        }

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
