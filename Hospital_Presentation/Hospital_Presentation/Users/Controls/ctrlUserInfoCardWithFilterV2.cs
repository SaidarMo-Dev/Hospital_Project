using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Presentation.Users.Controls
{
	public partial class ctrlUserInfoCardWithFilterV2 : UserControl
	{
		public ctrlUserInfoCardWithFilterV2()
		{
			InitializeComponent();
		}

		private void _LoadData(int UserId)
		{
			ctrlUserInfoCardV21.LoadData(UserId);
		}
		private void txtSearchByUserID_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSearchByUserID_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{

				e.Handled = true;

			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearchByUserID.Text.ToString()))
			{

				MessageBox.Show("Please Enter a User Id!", "Not Allowed",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				_LoadData(Convert.ToInt16(txtSearchByUserID.Text.ToString()));
			}

		}

	}
}
