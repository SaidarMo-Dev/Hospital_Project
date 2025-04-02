
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsAppointmentDataAccess
    {

        
        public static bool GetAppointmentsInfoByID(int AppointmentID, ref int PatientID,
                                         ref int DoctorID, ref DateTime AppointmentDate,
                                         ref byte AppointmentStatus,
                                         ref DateTime LastStatusDate, ref string Notes,
                                         ref int MedicalRecordID,ref int PaymentID,
                                         ref DateTime CreatedDate,
                                         ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Appointments Where AppointmentID = @AppointmentID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                PatientID = (int)reader["PatientID"];
                                DoctorID = (int)reader["DoctorID"];
                                AppointmentDate = (DateTime)reader["AppointmentDate"];
                                AppointmentStatus = (byte)reader["AppointmentStatus"];
                                LastStatusDate = (DateTime)reader["LastStatusDate"];
                                Notes = (string)(reader["Notes"] == System.DBNull.Value ? "" : reader["Notes"]);
                                MedicalRecordID = (reader["MedicalRecordID"] == System.DBNull.Value ? -1 : Convert.ToInt16(reader["MedicalRecordID"]));
                                PaymentID = (reader["PaymentID"] == System.DBNull.Value ? -1 : Convert.ToInt16(reader["PaymentID"]));
                                CreatedDate = (DateTime)reader["CreatedDate"];
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
       
        
        public static int AddNewAppointments(int PatientID, int DoctorID,
                DateTime AppointmentDate, byte AppointmentStatus, 
                DateTime LastStatusDate, string Notes, int MedicalRecordID,
                int PaymentID, DateTime CreatedDate, int CreatedByUserID)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Appointments(PatientID, DoctorID, AppointmentDate, AppointmentStatus, LastStatusDate, Notes, MedicalRecordID, PaymentID, CreatedDate, CreatedByUserID)
                                   
                                       VALUES (@PatientID, @DoctorID, @AppointmentDate, @AppointmentStatus, @LastStatusDate, @Notes, @MedicalRecordID, @PaymentID, @CreatedDate, @CreatedByUserID) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

                        if (string.IsNullOrEmpty(Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", Notes);

                        }
                        if (MedicalRecordID == -1)
                        {
                            command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

                        }
                        else
                            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

                        if (PaymentID == -1)
                        {
                            command.Parameters.AddWithValue("@PaymentID", DBNull.Value);
                        }
                        else
                            command.Parameters.AddWithValue("@PaymentID", PaymentID);


                        command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


                        object Result = command.ExecuteScalar();

                        int ID = 0;

                        if (Result != null && int.TryParse(Result.ToString(), out ID))
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
        
        public static bool UpdateAppointments(int AppointmentID, int PatientID,
                int DoctorID, DateTime AppointmentDate, byte AppointmentStatus,
                DateTime LastStatusDate, string Notes, int MedicalRecordID, 
                int PaymentID, DateTime CreatedDate, int CreatedByUserID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Appointments SET PatientID = @PatientID,DoctorID = @DoctorID,AppointmentDate = @AppointmentDate,AppointmentStatus = @AppointmentStatus,LastStatusDate = @LastStatusDate,Notes = @Notes,MedicalRecordID = @MedicalRecordID,PaymentID = @PaymentID,CreatedDate = @CreatedDate,CreatedByUserID = @CreatedByUserID

                                    WHERE AppointmentID= @AppointmentID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@AppointmentStatus", AppointmentStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);

                        if (string.IsNullOrEmpty(Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", Notes);

                        }

                        if (MedicalRecordID == -1)
                        {
                            command.Parameters.AddWithValue("@MedicalRecordID", DBNull.Value);

                        }
                        else
                            command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

                        if (PaymentID == -1)
                        {
                            command.Parameters.AddWithValue("@PaymentID", DBNull.Value);
                        }
                        else
                            command.Parameters.AddWithValue("@PaymentID", PaymentID);


                        command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
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
      
        public static DataTable GetListAppointments()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                  

                    using (SqlCommand command = new SqlCommand("SP_GetAppointments", connection))
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
        public static bool DeleteAppointments(int AppointmentID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Appointments Where AppointmentID = @AppointmentID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsAppointmentsExisteByID(int AppointmentID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Appointments Where AppointmentID = @AppointmentID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppointmentID", AppointmentID);


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

        public static DataTable getActiveAppointmentsForDoctor(int DoctorID)
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" 

                        select AppointmentID , PatientID, AppointmentDate, Notes ,MedicalRecordID 

                        from Appointments

                        where DoctorID =  @DoctorID And AppointmentStatus = 1";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

						command.Parameters.AddWithValue("@DoctorId", DoctorID);


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

        public static DataTable getCompletedAppointmentsForDoctor(int DoctorID)
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" 

                        select AppointmentID , PatientID, AppointmentDate, Notes ,MedicalRecordID 

                        from Appointments

                        where DoctorID =  @DoctorID And AppointmentStatus = 3";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DoctorId", DoctorID);

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
        public static bool SetMedicalRecordIdToAppointment(int appointmentId , int medicalRecordId)
        {
            int RowsAffected = -1;

            try
            {
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					string Query = @" UPDATE Appointments  

                                    SET  MedicalRecordID = @MedicalRecordId
                                    WHERE AppointmentId = @AppointmentId;";


					using (var cmd = new SqlCommand(Query, conn))
					{
						cmd.Parameters.AddWithValue("@MedicalRecordId", medicalRecordId);
						cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                        conn.Open();

                        RowsAffected = cmd.ExecuteNonQuery();

					}
				}

			}
            catch 
            {
                RowsAffected = -1; 


            }

            return (RowsAffected > 0 );


		}

        public static bool UpdateStatus(int AppointmentId ,int status)
        {
			int RowsAffected = -1;

			try
			{
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					string Query = @" UPDATE Appointments  

                                    SET  AppointmentStatus = @Status
                                    WHERE AppointmentId = @AppointmentId;";


					using (var cmd = new SqlCommand(Query, conn))
					{
						cmd.Parameters.AddWithValue("@Status", status);
						cmd.Parameters.AddWithValue("@AppointmentId", AppointmentId);

						conn.Open();

						RowsAffected = cmd.ExecuteNonQuery();

					}
				}

			}
			catch
			{
				RowsAffected = -1;


			}

			return (RowsAffected > 0);
            

		}
        public static bool HasMedicalRecord(int appointmentId)
        {
            bool IsFound = false;

			try
			{
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					string Query = @" 

                                SELECT  found = 1 FROM Appointments 
                                WHERE AppointmentID = @AppointmentId and MedicalRecordID is not null ;";


					using (var cmd = new SqlCommand(Query, conn))
					{
						
						cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

						conn.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
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
	
       
    }
}