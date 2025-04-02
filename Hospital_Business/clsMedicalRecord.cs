using System.Data;
using Hospital_DataAccessLayer;


namespace Hospital_Business
{

	public class clsMedicalRecord
	{

		enum enMode { AddNew, Update };

		enMode _Mode;

		public int MedicalRecordID { set; get; }
		public string VisitDescription { set; get; }
		public string Diagnosis { set; get; }
		public string AdditionalNotes { set; get; }
		public int CreatedByUserID { set; get; }


		public clsUser UsersInfo { set; get; }



		public clsMedicalRecord()
		{
			this._Mode = enMode.AddNew;

			this.MedicalRecordID = -1;
			this.VisitDescription = " ";
			this.Diagnosis = " ";
			this.AdditionalNotes = " ";
			this.CreatedByUserID = -1;


			this.UsersInfo = null;

		}

		private clsMedicalRecord(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes, int CreatedByUserID)
		{
			this._Mode = enMode.Update;

			this.MedicalRecordID = MedicalRecordID;
			this.VisitDescription = VisitDescription;
			this.Diagnosis = Diagnosis;
			this.AdditionalNotes = AdditionalNotes;
			this.CreatedByUserID = CreatedByUserID;


			this.UsersInfo = clsUser.FindByID(CreatedByUserID);



		}

		public bool SetMedicalRecordToAppointment(int appointmentId)
		{
			return clsAppointmentDataAccess.SetMedicalRecordIdToAppointment( appointmentId, this.MedicalRecordID);

		}
		public static clsMedicalRecord FindByID(int MedicalRecordID)
		{
			string VisitDescription = " ";
			string Diagnosis = " ";
			string AdditionalNotes = " ";
			int CreatedByUserID = -1;


			if (clsMedicalRecordsDataAccess.GetMedicalRecordsInfoByID(MedicalRecordID, ref VisitDescription, ref Diagnosis, ref AdditionalNotes, ref CreatedByUserID))
			{
				return new clsMedicalRecord(MedicalRecordID, VisitDescription, Diagnosis, AdditionalNotes, CreatedByUserID);

			}

			return null;

		}

		private bool _AddNewMedicalRecord()
		{
			this.MedicalRecordID = clsMedicalRecordsDataAccess.AddNewMedicalRecords(this.VisitDescription, this.Diagnosis, this.AdditionalNotes, this.CreatedByUserID);

			return (this.MedicalRecordID != -1);

		}
		private bool _UpdateMedicalRecord()
		{
			return clsMedicalRecordsDataAccess.UpdateMedicalRecords(this.MedicalRecordID, this.VisitDescription, this.Diagnosis, this.AdditionalNotes, this.CreatedByUserID);
		}

		public bool Save()
		{
			switch (_Mode)
			{
				case enMode.AddNew:

					if (_AddNewMedicalRecord())
					{

						_Mode = enMode.Update;
						return true;
					}
					else
						return false;

				case enMode.Update:

					return _UpdateMedicalRecord();

				default:
					return false;

			}

		}
		public static bool DeleteMedicalRecord(int MedicalRecordID)
		{
			return clsMedicalRecordsDataAccess.DeleteMedicalRecords(MedicalRecordID);

		}
		public static DataTable GetListMedicalRecords()
		{

			return clsMedicalRecordsDataAccess.GetListMedicalRecords();
		}

		public static bool IsMedicalRecordExisteByID(int MedicalRecordID)
		{
			return clsMedicalRecordsDataAccess.IsMedicalRecordsExisteByID(MedicalRecordID);

		}

		public static DataTable PatientRecords(int patientID)
		{
			return clsMedicalRecordsDataAccess.PatientRecords(patientID);
		}

	}
}