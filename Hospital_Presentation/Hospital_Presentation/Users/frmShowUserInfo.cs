using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Users
{
    public partial class frmShowUserInfo : Form
    {
        private int _userID;
        public frmShowUserInfo(int userID)
        {
            _userID = userID;

            InitializeComponent();
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfoCard1.LoadData(_userID);
        }

    }
}
