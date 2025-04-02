using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Presentation.GlobalClasses;

namespace Hospital_Presentation.Users
{
	public partial class frmChangePassword : Form
	{
		public frmChangePassword(int UserId)
		{
			userId = UserId;
			InitializeComponent();
		}

		private int userId;
		private void frmChangePassword_Load(object sender, EventArgs e)
		{
			ctrlUserInfoCardV21.LoadData(userId);
		}

		private void tbOldPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbOldPassword.Text))
				errorProvider1.SetError(tbOldPassword, "This feild is required");
			else if (tbOldPassword.Text.ToString() != Global.CurrentUser.Password)
				errorProvider1.SetError(tbOldPassword, "Incorrect Password");
			else
				errorProvider1.SetError(tbOldPassword, "");


		}

		private void tbNewPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
				errorProvider1.SetError(tbNewPassword, "This feild is required");
			else
				errorProvider1.SetError(tbNewPassword, "");
		}

		private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
				errorProvider1.SetError(tbConfirmPassword, "This feild is required");
			
			else if (tbNewPassword.Text != tbConfirmPassword.Text)
				errorProvider1.SetError(tbConfirmPassword, "Passwords does not match");
			
			else
				errorProvider1.SetError(tbConfirmPassword, "");
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if(this.ValidateChildren())
			{
				if(
					MessageBox.Show("Are you sure you want to change the password?",
					"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) 
					== DialogResult.OK)
				{
					Global.CurrentUser.Password = tbNewPassword.Text.ToString();

					if (Global.CurrentUser.Save())
					{
						MessageBox.Show("Password Changed Successfull",
						"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					}
					else
						MessageBox.Show("An error ocurred, Cannot change the password ",
						"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
