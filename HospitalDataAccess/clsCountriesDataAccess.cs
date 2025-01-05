
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsCountriesDataAccess
    {

        public static bool GetCountriesInfoByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Countries Where CountryID = @CountryID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                CountryName = (string)(reader["CountryName"] == System.DBNull.Value ? "" : reader["CountryName"]);

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
        public static int AddNewCountries(string CountryName)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Countries(CountryName)
                                   
                                       VALUES (@CountryName) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", CountryName);


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
        public static bool UpdateCountries(int CountryID, string CountryName)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Countries SET CountryName = @CountryName

                                    WHERE CountryID= @CountryID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        command.Parameters.AddWithValue("@CountryName", CountryName);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static DataTable GetListCountries()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    
                    using (SqlCommand command = new SqlCommand("SP_GetCountries", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

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
        public static bool DeleteCountries(int CountryID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Countries Where CountryID = @CountryID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsCountriesExisteByID(int CountryID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Countries Where CountryID = @CountryID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);


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


        public static int GetCountryID(string countryName)
        {
             
             int countryID = -1;


            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select CountryID From Countries Where CountryName = @countryName";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@countryName", countryName);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                countryID = (int)(reader["CountryID"]);

                            }
                        }



                    }
                }
            }
            catch
            {
                

            }

            return countryID;

        
        }
   
    
    
    }
}