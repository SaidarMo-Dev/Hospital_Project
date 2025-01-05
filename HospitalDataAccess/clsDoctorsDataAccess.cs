
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsDoctorsDataAccess
    {

        public static bool GetDoctorsInfoByID(int DoctorID, ref int PersonID, ref string Specialization, ref int MonthlySalary, ref string LicenseNumber, ref string WrokingTime, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Doctors Where DoctorID = @DoctorID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                Specialization = (string)(reader["Specialization"] == System.DBNull.Value ? "" : reader["Specialization"]);
                                MonthlySalary = Convert.ToInt32(reader["MonthlySalary"]);
                                LicenseNumber = (string)(reader["LicenseNumber"] == System.DBNull.Value ? "" : reader["LicenseNumber"]);
                                WrokingTime = (string)(reader["WrokingTime"] == System.DBNull.Value ? "" : reader["WrokingTime"]);
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


        public static int AddNewDoctors(int PersonID, string Specialization,
                                 int MonthlySalary, string LicenseNumber,
                                 string WrokingTime, int CreatedByUserID)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Doctors(PersonID, Specialization, MonthlySalary, LicenseNumber, WrokingTime, CreatedByUserID)
                                   
                                       VALUES (@PersonID, @Specialization, @MonthlySalary, @LicenseNumber, @WrokingTime, @CreatedByUserID) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@MonthlySalary", MonthlySalary);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@WrokingTime", WrokingTime);
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

        public static bool UpdateDoctors(int DoctorID, int PersonID, string Specialization, int MonthlySalary, string LicenseNumber, string WrokingTime, int CreatedByUserID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Doctors SET PersonID = @PersonID,Specialization = @Specialization,MonthlySalary = @MonthlySalary,LicenseNumber = @LicenseNumber,WrokingTime = @WrokingTime,CreatedByUserID = @CreatedByUserID

                                    WHERE DoctorID= @DoctorID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@MonthlySalary", MonthlySalary);
                        command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
                        command.Parameters.AddWithValue("@WrokingTime", WrokingTime);
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
        public static DataTable GetListDoctors()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {

                    using (SqlCommand command = new SqlCommand("SP_GetDoctors", connection))
                    {

                        connection.Open();

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
        public static bool DeleteDoctors(int DoctorID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Doctors Where DoctorID = @DoctorID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsDoctorsExisteByID(int DoctorID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Doctors Where DoctorID = @DoctorID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);


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