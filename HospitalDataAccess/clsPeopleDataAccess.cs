
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer;
using System.Xml.Schema;


namespace Hospital_DataAccessLayer
{

    public class clsPeopleDataAccess
    {

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Email, ref string Phone, ref int NationalityCountryID, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From People Where PersonID = @PersonID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                FirstName = (string)(reader["FirstName"] == System.DBNull.Value ? "" : reader["FirstName"]);
                                LastName = (string)(reader["LastName"] == System.DBNull.Value ? "" : reader["LastName"]);
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)(reader["Address"] == System.DBNull.Value ? "" : reader["Address"]);
                                Email = (string)(reader["Email"] == System.DBNull.Value ? "" : reader["Email"]);
                                Phone = (string)(reader["Phone"] == System.DBNull.Value ? "" : reader["Phone"]);
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                ImagePath = (string)(reader["ImagePath"] == System.DBNull.Value ? "" : reader["ImagePath"]);

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
        public static int AddNewPerson(string FirstName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Email, string Phone, int NationalityCountryID, string ImagePath)
        {
            int InsertedID = -1;
            
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    //string query = @"INSERT INTO People(FirstName, LastName, DateOfBirth, Gendor, Address, Email, Phone, NationalityCountryID, ImagePath)
                                   
                    //                   VALUES (@FirstName, @LastName, @DateOfBirth, @Gendor, @Address, @Email, @Phone, @NationalityCountryID, @ImagePath) 
                
                    //            SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand("SP_AddPerson", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        if (string.IsNullOrEmpty(FirstName))
                        {
                            command.Parameters.AddWithValue("@FirstName", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName);

                        } 
                        
                        
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);

                        if (string.IsNullOrEmpty(Address))
                        {
                            command.Parameters.AddWithValue("@Address", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Address", Address);

                        }
                        
                        command.Parameters.AddWithValue("@Email", Email);

                        if (string.IsNullOrEmpty(Phone))
                        {
                            command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Phone", Phone);

                        } 
                        
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (string.IsNullOrEmpty(ImagePath))
                        {
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        }

                        var OutputIDParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        
                        command.Parameters.Add(OutputIDParam);

                        connection.Open();

                        command.ExecuteNonQuery();

                        InsertedID = (int)OutputIDParam.Value;

                        //object Result = command.ExecuteScalar();

                        //int ID = 0;

                        //if (Result != null && int.TryParse(Result.ToString(), out ID))
                        //{
                        //    InsertedID = ID;

                        //}

                    }
                }
            }
            catch
            {


            }

            return InsertedID;

        }
        public static bool UpdatePerson(int PersonID, string FirstName, string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Email, string Phone, int NationalityCountryID, string ImagePath)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                   
                    //string query = @"Update People SET FirstName = @FirstName,LastName = @LastName,DateOfBirth = @DateOfBirth,Gendor = @Gendor,Address = @Address,Email = @Email,Phone = @Phone,NationalityCountryID = @NationalityCountryID,ImagePath = @ImagePath

                    //                WHERE PersonID= @PersonID";


                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {

                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        if (string.IsNullOrEmpty(FirstName))
                        {
                            command.Parameters.AddWithValue("@FirstName", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@FirstName", FirstName);

                        } command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);

                        if (string.IsNullOrEmpty(Address))
                        {
                            command.Parameters.AddWithValue("@Address", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Address", Address);

                        } command.Parameters.AddWithValue("@Email", Email);

                        if (string.IsNullOrEmpty(Phone))
                        {
                            command.Parameters.AddWithValue("@Phone", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Phone", Phone);

                        } command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

                        if (string.IsNullOrEmpty(ImagePath))
                        {
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        }


                        connection.Open();


                        object testRowsaffected  = command.ExecuteScalar();
                        
                        RowsAffected = (int)testRowsaffected;




                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static DataTable GetListPeople()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

 //                   string query = @"Select PersonID, FirstName, LastName, 
 //                                       case gendor
		
	//	                                when  0 then 'Male'
	//	                                else 'Female'

	//	                                end as Gendor,

	//	                                Address, Email , phone , countryName as Nationality
                       
	//                                From People				
		                                
 //                                   inner join countries 
	//	                                on people.NationalityCountryID = countries.CountryID
             
	//";


                    using (SqlCommand command = new SqlCommand("Sp_GetPeople", connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            command.CommandType = CommandType.StoredProcedure;

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
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From People Where PersonID = @PersonID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsPersonExisteByID(int PersonID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From People Where PersonID = @PersonID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static int PeopleCount()
        {
            int Count = 0;

            try
            {
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					string Query = @" SELECT count(personId) As PeopleCount FROM people ";

					using (var cmd = new SqlCommand(Query, conn))
					{
						conn.Open();

						using (var reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								Count = Convert.ToInt32(reader["PeopleCount"]);

							}
						}


					}

				}
			}
            catch
            {
                Count = 0;
            }

			return Count;

        }
    
    }
}