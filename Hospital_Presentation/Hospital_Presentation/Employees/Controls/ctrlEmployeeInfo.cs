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
using Hospital_Presentation.GlobalClasses;


namespace Hospital_Presentation.Employees.Controls
{
    public partial class ctrlEmployeeInfo : UserControl
    {
        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }

        public bool EmployeeFound = false;

        private clsEmployee _employeeInfo;

        private int _employeeID = 0;

        public clsEmployee SelectedEmployeeInfo
        {
            get { return _employeeInfo; }
        }

		private void _ShowEmployeeImage()
		{
			try
			{
				if (string.IsNullOrEmpty(_employeeInfo.PersonInfo.ImagePath))
				{
					if (_employeeInfo.PersonInfo.Gendor == 0)
						pictureEmployeeImage.Image = Properties.Resources.Male;
					else
						pictureEmployeeImage.Image = Properties.Resources.Female;

				}
				else
					pictureEmployeeImage.Load(_employeeInfo.PersonInfo.ImagePath);

			}
			catch
			{

				if (_employeeInfo.PersonInfo.Gendor == 0)
					pictureEmployeeImage.Image = Properties.Resources.Male;
				else
					pictureEmployeeImage.Image = Properties.Resources.Female;


				//pictureEmployeeImage.Image = Properties.Resources.Male;
			}



		}
		public void LoadData(int EmployeeID)
        {
            _employeeID = EmployeeID;

            _employeeInfo = clsEmployee.FindByID(EmployeeID);

            if (_employeeInfo == null)
            {
                MessageBox.Show($"There is no Employee With ID = {EmployeeID}", 
                      "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _resetDefaultValues();


                return;

            }

            // these lines will executed only if the employee found 


            _fillEmployeeInfo();




        }

        private void _fillEmployeeInfo()
        {
            lblEmployeeID.Text = _employeeInfo.EmployeeID.ToString();
            lblFullName.Text = _employeeInfo.PersonInfo.FullName;
            lblAge.Text = _employeeInfo.PersonInfo.Age.ToString();
            lblJobTitle.Text = _employeeInfo.JobTitle;
            lblNationality.Text = _employeeInfo.PersonInfo.CountryInfo.CountryName;
            lblHireDate.Text = Format.ConvertDateTimeToStringFormat(_employeeInfo.HireDate);
            lblLeaveDate.Text = _employeeInfo.LeaveDate == null ? "Employee Active" : Format.ConvertDateTimeToStringFormat(_employeeInfo.LeaveDate);
            lblDepartement.Text = _employeeInfo.DepartementInfo.DepartementName;
            lblStatus.Text = _employeeInfo.EmployeeStatusString;
            lblSalary.Text = _employeeInfo.Salary.ToString();   

            _ShowEmployeeImage();


        }
        private void _resetDefaultValues()
        {

            lblEmployeeID.Text = "[????]";
            lblFullName.Text = "[????]";
            lblAge.Text = "[????]";
            lblJobTitle.Text = "[????]";
            lblNationality.Text = "[????]";
            lblHireDate.Text = "[????]";
            lblLeaveDate.Text = "[????]";
            lblDepartement.Text = "[????]";
            lblStatus.Text = "[????]";
            lblSalary.Text = "[????]";

            pictureEmployeeImage.Image = Properties.Resources.Male;


        }

		private void pictureEmployeeImage_Click(object sender, EventArgs e)
		{

		}
	}
}

   
