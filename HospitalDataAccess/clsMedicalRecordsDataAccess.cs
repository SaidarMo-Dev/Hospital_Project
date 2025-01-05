
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsMedicalRecordsDataAccess
    {

        public static bool GetMedicalRecordsInfoByID(int MedicalRecordID, ref string VisitDescription, ref string Diagnosis, ref string AdditionalNotes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From MedicalRecords Where MedicalRecordID = @MedicalRecordID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                VisitDescription = (string)(reader["VisitDescription"] == System.DBNull.Value ? "" : reader["VisitDescription"]);
                                Diagnosis = (string)(reader["Diagnosis"] == System.DBNull.Value ? "" : reader["Diagnosis"]);
                                AdditionalNotes = (string)(reader["AdditionalNotes"] == System.DBNull.Value ? "" : reader["AdditionalNotes"]);
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
        public static int AddNewMedicalRecords(string VisitDescription, string Diagnosis, string AdditionalNotes, int CreatedByUserID)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO MedicalRecords(VisitDescription, Diagnosis, AdditionalNotes, CreatedByUserID)
                                   
                                       VALUES (@VisitDescription, @Diagnosis, @AdditionalNotes, @CreatedByUserID) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        if (string.IsNullOrEmpty(VisitDescription))
                        {
                            command.Parameters.AddWithValue("@VisitDescription", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@VisitDescription", VisitDescription);

                        }
                        if (string.IsNullOrEmpty(Diagnosis))
                        {
                            command.Parameters.AddWithValue("@Diagnosis", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);

                        }
                        if (string.IsNullOrEmpty(AdditionalNotes))
                        {
                            command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

                        }
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
        public static bool UpdateMedicalRecords(int MedicalRecordID, string VisitDescription, string Diagnosis, string AdditionalNotes, int CreatedByUserID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update MedicalRecords SET VisitDescription = @VisitDescription,Diagnosis = @Diagnosis,AdditionalNotes = @AdditionalNotes,CreatedByUserID = @CreatedByUserID

                                    WHERE MedicalRecordID= @MedicalRecordID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);

                        if (string.IsNullOrEmpty(VisitDescription))
                        {
                            command.Parameters.AddWithValue("@VisitDescription", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@VisitDescription", VisitDescription);

                        }
                        if (string.IsNullOrEmpty(Diagnosis))
                        {
                            command.Parameters.AddWithValue("@Diagnosis", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Diagnosis", Diagnosis);

                        }
                        if (string.IsNullOrEmpty(AdditionalNotes))
                        {
                            command.Parameters.AddWithValue("@AdditionalNotes", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@AdditionalNotes", AdditionalNotes);

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
        public static DataTable GetListMedicalRecords()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From MedicalRecords";


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
        public static bool DeleteMedicalRecords(int MedicalRecordID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From MedicalRecords Where MedicalRecordID = @MedicalRecordID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsMedicalRecordsExisteByID(int MedicalRecordID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From MedicalRecords Where MedicalRecordID = @MedicalRecordID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MedicalRecordID", MedicalRecordID);


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
    }
}