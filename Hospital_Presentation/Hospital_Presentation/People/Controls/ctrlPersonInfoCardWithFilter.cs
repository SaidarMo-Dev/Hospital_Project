using System;
using System.Windows.Forms;
using Hospital_Business;


namespace Hospital_Presentation.People.Controls
{
	public partial class ctrlPersonInfoCardWithFilter : UserControl
	{


		public class PersonInfoEventArgs : EventArgs
		{
			public int personID { set; get; }

			public PersonInfoEventArgs(int personID)
			{

				this.personID = personID;

			}

		}
		public event EventHandler<PersonInfoEventArgs> OnPersonSelected;


		public ctrlPersonInfoCardWithFilter()
		{
			InitializeComponent();
		}



		public clsPerson SelectedPersonInfo
		{
			get
			{
				return ctrlPersonInfoCard1.SelectedPersonInfo;

			}

		}

		public void LoadData(int PersonID)
		{
			tbSearchByPersonId.Text = PersonID.ToString();

			_LoadData();

		}
		private void _LoadData()
		{
			ctrlPersonInfoCard1.LoadPersonInfo(Convert.ToInt16(tbSearchByPersonId.Text));

			if (ctrlPersonInfoCard1.IsPersonFound)
			{
				OnPersonSelected?.Invoke(this, new PersonInfoEventArgs(ctrlPersonInfoCard1.SelectedPersonID));

			}

		}



		private void ctrlPersonInfoCardWithFilter_Load(object sender, EventArgs e)
		{

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			_LoadData();
		}

		public void sendDataBack(object sender, int PersonId)
		{
			tbSearchByPersonId.Text = PersonId.ToString();
			ctrlPersonInfoCard1.LoadPersonInfo(PersonId);
		}

		private void btnAddNewPerson_Click(object sender, EventArgs e)
		{
			var frmAddPerson = new frmAddUpdatePerson();

			frmAddPerson.DataToSend += sendDataBack;

			frmAddPerson.ShowDialog();

		}
	}




}
