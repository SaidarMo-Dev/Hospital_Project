
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsEmployeeDataAccess
    {

        public static bool GetEmployeeInfoByID(int EmployeeID, ref int PersonID, ref string JobTitle,
                                ref DateTime HireDate, ref Nullable<DateTime> LeaveDate, ref int Departement,
                                ref byte EmployeeStatus, ref int Salary)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select * From Employees Where EmployeeID = @EmployeeID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                JobTitle = (string)(reader["JobTitle"] == System.DBNull.Value ? "" : reader["JobTitle"]);
                                HireDate = (DateTime)reader["HireDate"];
								if ((reader["LeaveDate"] == DBNull.Value))
								{
									LeaveDate = null;
								}
								else
								{
									LeaveDate = (DateTime)reader["LeaveDate"];
								}
								Departement = (int)reader["DepartementID"];
                                EmployeeStatus = (byte)reader["EmployeeStatus"];
                                Salary = (int)reader["Salary"];

                                
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
     
        public static int AddNewEmployee(int PersonID, string JobTitle, DateTime HireDate,
                              Nullable<DateTime> LeaveDate, int DepartementID, byte EmployeeStatus, int Salary)
        {
            int InsertedID = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO Employees(PersonID, JobTitle, HireDate, LeaveDate, DepartementID, EmployeeStatus, Salary)
                                   
                                       VALUES (@PersonID, @JobTitle, @HireDate, @LeaveDate, @DepartementID, @EmployeeStatus, @Salary) 
                
                                SELECT SCOPE_IDENTITY();";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@JobTitle", JobTitle);
                        command.Parameters.AddWithValue("@HireDate", HireDate);

                        if (LeaveDate.HasValue)
                        {
                            command.Parameters.AddWithValue("@LeaveDate", LeaveDate);
                        }
                        else
                            command.Parameters.AddWithValue("@LeaveDate", DBNull.Value);
                       
                        command.Parameters.AddWithValue("@DepartementID", DepartementID);
                        command.Parameters.AddWithValue("@EmployeeStatus", EmployeeStatus);
                        command.Parameters.AddWithValue("@Salary", Salary);


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
    
        public static bool UpdateEmployee(int EmployeeID, int PersonID, string JobTitle,
                                DateTime HireDate,Nullable <DateTime> LeaveDate, int DepartementID,
                                byte EmployeeStatus, int Salary)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @"Update Employees SET PersonID = @PersonID,JobTitle = @JobTitle,
                                                          HireDate = @HireDate,LeaveDate = @LeaveDate,
                                                          DepartementID = @DepartementID,
                                                          EmployeeStatus = @EmployeeStatus,
                                                          Salary = @Salary

                                    WHERE EmployeeID= @EmployeeID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@JobTitle", JobTitle);
                        command.Parameters.AddWithValue("@HireDate", HireDate);
                      
                        if (LeaveDate .HasValue)
                            command.Parameters.AddWithValue("@LeaveDate", LeaveDate);
                        else
                            command.Parameters.AddWithValue("@LeaveDate", DBNull .Value);
                        
                        command.Parameters.AddWithValue("@DepartementID", DepartementID);
                        command.Parameters.AddWithValue("@EmployeeStatus", EmployeeStatus);
                        command.Parameters.AddWithValue("@Salary", Salary);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
      
        public static DataTable GetListEmployees()
        {
            DataTable dtList = new DataTable();

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                  
               

                    using (SqlCommand command = new SqlCommand("SP_GetEmployees", connection))
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
        public static bool DeleteEmployee(int EmployeeID)
        {
            int RowsAffected = -1;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Delete From Employees Where EmployeeID = @EmployeeID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


                        RowsAffected = command.ExecuteNonQuery();



                    }
                }
            }
            catch
            {


            }

            return (RowsAffected != -1);

        }
        public static bool IsEmployeeExisteByID(int EmployeeID)
        {
            bool IsFound = false;

            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();

                    string query = @" Select Found = 1 From Employees Where EmployeeID = @EmployeeID";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", EmployeeID);


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
		public static int EmployeesCount()
		{
			int Count = 0;

			try
			{
				using (var conn = new SqlConnection(clsDataAccessSettings.connectionString))
				{
					string Query = @" SELECT count(*) AS EmployeesCount FROM Employees ";

					using (var cmd = new SqlCommand(Query, conn))
					{
						conn.Open();

						using (var reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								Count = Convert.ToInt32(reader["EmployeesCount"]);

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