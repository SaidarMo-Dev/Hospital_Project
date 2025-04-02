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

namespace Hospital_Presentation
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}


		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
		{
			
		}

		private void tbPasssword_Validating(object sender, CancelEventArgs e)
		{

			if (string.IsNullOrWhiteSpace(tbPassword.Text))
				errorProvider1.SetError(tbPassword, "This Field is required");
			else
				errorProvider1.SetError(tbPassword, "");
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(this.ValidateChildren())
			{
				var user = clsUser.FindByUsernameAndPassword(tbUsername.Text.Trim(),
													tbPassword.Text.Trim());

				if(user == null)
				{
					MessageBox.Show("Incorrect Username Or Password Try Again!"
						,"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if(!user.IsActive)
				{

					MessageBox.Show("User Not Active. Contact your Admin!"
						, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				Global.CurrentUser= user;

				new frmMain(this).ShowDialog();
				//this.Hide();

			
			}

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.Close();

		}

		private void tbUsername_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbUsername.Text))
				errorProvider1.SetError(tbUsername, "This Field is required");
			else
				errorProvider1.SetError(tbUsername, "");
		}

		private void tbPassword_IconRightClick(object sender, EventArgs e)
		{
			if (tbPassword.PasswordChar == '*')
			{
				tbPassword.PasswordChar = default;
				tbPassword.IconRight = Properties.Resources.IconshowPassword; 
			}
				
			else
			{
				tbPassword.PasswordChar = '*';
				tbPassword.IconRight = Properties.Resources.IconHidePassword;
			}

		}


	}
}
