
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO.IsolatedStorage;


namespace Hospital_DataAccessLayer
{

    public class clsPrescriptionDataAccess
    {

        public static bool GetPrescriptionInfoByID(int PrescriptionID, ref int MedicalRecordID, ref string MedicalName, ref string Dosage, ref string Frequency, ref DateTime StartDate, ref DateTime NedDate, ref string SpecialInstructions, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Prescriptions Where PrescriptionID = @PrescriptionID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                MedicalRecordID = (int)reader["MedicalRecordID"];
                                MedicalName = (string)(reader["MedicalName"] == System.DBNull.Value ? "" : reader["MedicalName"]);
                                Dosage = (string)(reader["Dosage"] == System.DBNull.Value ? "" : reader["Dosage"]);
                                Frequency = (string)(reader["Frequency"] == System.DBNull.Value ? "" : reader["Frequency"]);
                                StartDate = (DateTime)reader["StartDate"];
                                NedDate = (DateTime)reader["NedDate"];
                                SpecialInstructions = (string)(reader["SpecialInstructions"] == System.DBNull.Value ? "" : reader["SpecialInstructions"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];

                            }
                        }



                    }
                }
            }
            catch
            {
                IsFound = false;

            }

            return IsFound;

        }
        public static int AddNewPrescription(int MedicalRecordID, string MedicalName, string Dosage,
                                        string Frequency, DateTime StartDate, DateTime EndDate, 
                                        string SpecialInstructions, int CreatedByUserID)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Prescriptions(MedicalRecordID, MedicalName, Dosage, Frequency, StartDate, EndDate, SpecialInstructions, CreatedByUserID)
                                   
                                       VALUES (@MedicalRecordID, @MedicalName, @Dosage, @Frequency, @StartDate, @EndDate, @SpecialInstructions, @CreatedByUserID) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        command.Parameters.AddWithValue("@MedicalName", MedicalName);

                        if (string.IsNullOrEmpty(Dosage))
                        {
                            command.Parameters.AddWithValue("@Dosage", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Dosage", Dosage);

                        }
                        if (string.IsNullOrEmpty(Frequency))
                        {
                            command.Parameters.AddWithValue("@Frequency", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Frequency", Frequency);

                        }
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@EndDate", EndDate);

                        if (string.IsNullOrEmpty(SpecialInstructions))
                        {
                            command.Parameters.AddWithValue("@SpecialInstructions", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);

                        }
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                        object Result = command.ExecuteScalar();

                     

                        if (Result != null && int.TryParse(Result.ToString(), out int ID))
                        {
                            InsertedID = ID;

                        }

                    }
                }
            }
            catch
            {


            }

            return InsertedID;

        }
        public static bool UpdatePrescription(int PrescriptionID, int MedicalRecordID, string MedicalName, string Dosage, string Frequency, DateTime StartDate, DateTime NedDate, string SpecialInstructions, int CreatedByUserID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Prescriptions SET MedicalRecordID = @MedicalRecordID,MedicalName = @MedicalName,Dosage = @Dosage,Frequency = @Frequency,StartDate = @StartDate,NedDate = @NedDate,SpecialInstructions = @SpecialInstructions,CreatedByUserID = @CreatedByUserID

                                    WHERE PrescriptionID= @PrescriptionID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);
                        command.Parameters.AddWithValue("@MedicalName", MedicalName);

                        if (string.IsNullOrEmpty(Dosage))
                        {
                            command.Parameters.AddWithValue("@Dosage", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Dosage", Dosage);

                        }
                        if (string.IsNullOrEmpty(Frequency))
                        {
                            command.Parameters.AddWithValue("@Frequency", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Frequency", Frequency);

                        }
                        command.Parameters.AddWithValue("@StartDate", StartDate);
                        command.Parameters.AddWithValue("@NedDate", NedDate);

                        if (string.IsNullOrEmpty(SpecialInstructions))
                        {
                            command.Parameters.AddWithValue("@SpecialInstructions", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@SpecialInstructions", SpecialInstructions);

                        }
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static DataTable GetListPrescriptions()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Prescriptions";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {

                                dtList.Load(reader);

                            }
                        }



                    }
                }
            }
            catch
            {


            }

            return dtList;

        }
        public static bool DeletePrescriptions(int PrescriptionID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Prescriptions Where PrescriptionID = @PrescriptionID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
    
        public static bool IsPrescriptionsExisteByID(int PrescriptionID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Prescriptions Where PrescriptionID = @PrescriptionID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;


                            }
                        }



                    }
                }
            }
            catch
            {
                IsFound = false;

            }

            return IsFound;

        }
    
        public static  bool IsMedicalRecordHasPrescriptions(int medicalRecordId)
        {
			bool isFound = false;

			try
            {


                using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string Query = @"
                            SELECT Found = 1 FROM Prescriptions
                            WHERE MedicalRecordID = @MedicalRecord;
                            
                              ";

                    using (var cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicalRecord", medicalRecordId);

                        conn.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isFound = true;
                            }
                        }
                    }
                }

            }
            catch
            { 
                isFound = false;

            }
        
            return isFound;


        }

   
        public static DataTable PatientPrescriptions(int PatientId)
        {
			DataTable dtPatientPrescriptions = new DataTable();

			try
			{
				
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					using (var cmd = new SqlCommand("[SP_GetPatientPrescriptions]", conn))
					{
                        conn.Open();

						cmd.CommandType = CommandType.StoredProcedure;

						cmd.Parameters.AddWithValue("@PatientId", PatientId);

						using (var reader = cmd.ExecuteReader())
						{
							if (reader.HasRows)
							{
								dtPatientPrescriptions.Load(reader);

							}
						}
					}
				}

			}
            catch
            {

            }
            return dtPatientPrescriptions;

        }
    
    }
}