
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsPatientsDataAccess
    {

        public static bool GetPatientsInfoByID(int PatientID, ref int PersonID, ref string BloodType, ref string AssuranceNumber)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Patients Where PatientID = @PatientID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                BloodType = (string)(reader["BloodType"] == System.DBNull.Value ? "" : reader["BloodType"]);
                                AssuranceNumber = (string)(reader["AssuranceNumber"] == System.DBNull.Value ? "" : reader["AssuranceNumber"]);

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
        public static int AddNewPatients(int PersonID, string BloodType, string AssuranceNumber)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Patients(PersonID, BloodType, AssuranceNumber)
                                   
                                       VALUES (@PersonID, @BloodType, @AssuranceNumber) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        if (string.IsNullOrEmpty(BloodType))
                        {
                            command.Parameters.AddWithValue("@BloodType", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@BloodType", BloodType);

                        }
                        if (string.IsNullOrEmpty(AssuranceNumber))
                        {
                            command.Parameters.AddWithValue("@AssuranceNumber", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@AssuranceNumber", AssuranceNumber);

                        }

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
        public static bool UpdatePatients(int PatientID, int PersonID, string BloodType, string AssuranceNumber)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Patients SET PersonID = @PersonID,BloodType = @BloodType,AssuranceNumber = @AssuranceNumber

                                    WHERE PatientID= @PatientID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@PatientID", PatientID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        if (string.IsNullOrEmpty(BloodType))
                        {
                            command.Parameters.AddWithValue("@BloodType", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@BloodType", BloodType);

                        }
                        if (string.IsNullOrEmpty(AssuranceNumber))
                        {
                            command.Parameters.AddWithValue("@AssuranceNumber", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@AssuranceNumber", AssuranceNumber);

                        }

                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static DataTable GetListPatients()
        {
            DataTable dtList = new DataTable();

            try
            {


                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" 
                                select PatientID, Patients.PersonID , People.firstName + ' ' + People.lastname as fullName
			                                , people.address, people.Email, Countries.CountryName 

			                                , Patients.BloodType, Patients.AssuranceNumber
		                                from Patients

		                                inner join People ON Patients.PersonID = people.PersonID
		                                inner join Countries ON Countries.CountryID = People.NationalityCountryID

";


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
        public static bool DeletePatients(int PatientID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Patients Where PatientID = @PatientID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsPatientsExisteByID(int PatientID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Patients Where PatientID = @PatientID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatientID", PatientID);


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