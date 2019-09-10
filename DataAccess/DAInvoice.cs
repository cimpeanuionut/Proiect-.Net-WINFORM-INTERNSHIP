using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInvoice
    {
        public DAInvoice()
        {

        }
        public int InsertInvoice(string invoiceNumber, DateTime invoiceDate, string clientFullName, string clientAddress, int userId, string obs )
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                
                    SqlCommand command = new SqlCommand("InsertInvoice", connection);
                    
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", invoiceNumber));
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", invoiceDate));
                    command.Parameters.Add(new SqlParameter("@ClientFullName", clientFullName));
                    command.Parameters.Add(new SqlParameter("@ClientAddress", clientAddress));
                    command.Parameters.Add(new SqlParameter("@UserId", userId));
                    command.Parameters.Add(new SqlParameter("@Observation", obs));
                    var returnParameter = command.Parameters.Add(new SqlParameter("@ReturnInvoiceId", SqlDbType.Int));
                    returnParameter.Direction = ParameterDirection.ReturnValue;               

                 command.ExecuteNonQuery();
                 return  Convert.ToInt32(returnParameter.Value);

            }
            catch (SqlException se)
            {
                throw se;
            }

            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable GetInvoice(int? invoiceId, DateTime startDate, DateTime endDate, string invoiceNumber, string clientFullName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetInvoices", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@InvoiceId", invoiceId.GetValueOrDefault()));
                command.Parameters.Add(new SqlParameter("@StartDate", startDate));
                command.Parameters.Add(new SqlParameter("@EndDate", endDate));
                command.Parameters.Add(new SqlParameter("@InvoiceNumber", invoiceNumber));
                command.Parameters.Add(new SqlParameter("@ClientFullName", clientFullName));

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);

                connection.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dataTable;
        }

        public void DeleteInvoice(int invoiceId)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteInvoice", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@InvoiceId", invoiceId));

                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void UpdateInvoice(int invoiceId, string invoiceNumber, DateTime invoiceDate, string observation, string clientName, string clientAddress)
        {
            SqlConnection connection = null;            

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();                

                    SqlCommand command = new SqlCommand("UpdateInvoice", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@InvoiceId", invoiceId));
                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", invoiceNumber));
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", invoiceDate));
                    command.Parameters.Add(new SqlParameter("@Observation", observation));
                    command.Parameters.Add(new SqlParameter("@ClientFullName", clientName));
                    command.Parameters.Add(new SqlParameter("@ClientAddress", clientAddress));

                command.ExecuteNonQuery();                                
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        
    }
}
