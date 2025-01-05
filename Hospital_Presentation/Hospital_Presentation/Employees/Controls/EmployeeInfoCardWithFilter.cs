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


namespace Hospital_Presentation.Employees.Controls
{
    public partial class EmployeeInfoCardWithFilter : UserControl
    {

        event EventHandler<EmployeeInfoEventArgs> OnEmployeeSelecetd;
        public EmployeeInfoCardWithFilter()
        {
            InitializeComponent();
            btnFind .Enabled = false;
        }



        public clsEmployee SelectedEmployeeeInfo
        {
            get
            {
                return ctrlEmployeeInfo1.SelectedEmployeeInfo;

            }

        }

        public void LoadData(int employeeID)
        {
            tbSearchByEmployeeID.Text = employeeID.ToString();

            _LoadData();

        }
        private void _LoadData()
        {
            int EmpID = Convert.ToInt16(tbSearchByEmployeeID.Text);


            ctrlEmployeeInfo1.LoadData(EmpID);

         
            if (ctrlEmployeeInfo1.EmployeeFound)
            {
                OnEmployeeSelecetd?.Invoke(this, new EmployeeInfoEventArgs(EmpID));
            }
        }



        private void EmployeeInfoCardWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();

        }

        private void tbSearchByEmployeeID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearchByEmployeeID.Text.Trim()))
            {
                btnFind.Enabled = true;
            }
            else
                btnFind.Enabled = false;
        }

        private void tbSearchByEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }

    public class EmployeeInfoEventArgs : EventArgs
    {
        public int EmployeeID { set; get; }

        public EmployeeInfoEventArgs(int EmployeeID)
        {

            this.EmployeeID = EmployeeID;

        }

    }


}
