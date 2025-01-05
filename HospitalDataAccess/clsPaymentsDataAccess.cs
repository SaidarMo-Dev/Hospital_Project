 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hospital_DataAccessLayer
{

    public class clsPaymentsDataAccess
    {

public static bool GetPaymentsInfoByID(int PaymentID,ref DateTime PaymentDate,ref string PaymentMethod,ref string Notes,ref int AmountPaid)
    {
        bool IsFound  = false;

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @" Select * From Payments Where PaymentID = @PaymentID";
        

                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
			

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                       
                          if (reader.Read())
                          {
                              IsFound = true;

                              PaymentDate = (DateTime)reader["PaymentDate"] ;
PaymentMethod = (string)(reader["PaymentMethod"] == System.DBNull.Value ? "" :reader["PaymentMethod"]) ;
Notes = (string)(reader["Notes"] == System.DBNull.Value ? "" :reader["Notes"]) ;
AmountPaid = (int)reader["AmountPaid"] ;

                          }
                    }
                
                    
            
                }
            }
        }
        catch
        {
            IsFound = false;
        
        }

        return IsFound ;
          
    }public static int AddNewPayments(DateTime PaymentDate,string PaymentMethod,string Notes,int AmountPaid)
    {
        int InsertedID  = -1;

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @"INSERT INTO Payments(PaymentDate, PaymentMethod, Notes, AmountPaid)
                                   
                                       VALUES (@PaymentDate, @PaymentMethod, @Notes, @AmountPaid) 
                
                                SELECT SCOPE_IDENTITY();"; 
        

                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

if ( string.IsNullOrEmpty(Notes))
                                     { 
                                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value );
                                     }
                                     else 
                                     { 
                                        command.Parameters.AddWithValue("@Notes", Notes);
                                      
                                     }command.Parameters.AddWithValue("@AmountPaid", AmountPaid);


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

        return InsertedID ;
          
    }public static bool UpdatePayments(int PaymentID,DateTime PaymentDate, string PaymentMethod, string Notes, int AmountPaid)
    {
        int RowsAffected  = -1;

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @"Update Payments SET PaymentDate = @PaymentDate,PaymentMethod = @PaymentMethod,Notes = @Notes,AmountPaid = @AmountPaid

                                    WHERE PaymentID= @PaymentID";
        

                using (SqlCommand command  = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
			command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);

if ( string.IsNullOrEmpty(Notes))
                                     { 
                                        command.Parameters.AddWithValue("@Notes", System.DBNull.Value );
                                     }
                                     else 
                                     { 
                                        command.Parameters.AddWithValue("@Notes", Notes);
                                      
                                     }command.Parameters.AddWithValue("@AmountPaid", AmountPaid);


                     RowsAffected = command.ExecuteNonQuery();
                
                    
            
                }
            }
        }
        catch
        {
    
        
        }

        return (RowsAffected != -1 ) ;
          
    }public static DataTable GetListPayments()
    {
        DataTable dtList = new DataTable();

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @" Select * From Payments";
        

                using (SqlCommand command  = new SqlCommand(query, connection))
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

        return dtList ;
          
    }public static bool DeletePayments(int PaymentID)
    {
        int RowsAffected  = -1;

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @" Delete From Payments Where PaymentID = @PaymentID";
        

                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
			

                     RowsAffected = command.ExecuteNonQuery();
                
                    
            
                }
            }
        }
        catch
        {
    
        
        }

        return (RowsAffected != -1 ) ;
          
    }public static bool IsPaymentsExisteByID(int PaymentID)
    {
        bool IsFound  = false;

        try 
        {

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            { 
                connection.Open();

                string query = @" Select Found = 1 From Payments Where PaymentID = @PaymentID";
        

                using (SqlCommand command  = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", PaymentID);
			

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

        return IsFound ;
          
    }
   }
}