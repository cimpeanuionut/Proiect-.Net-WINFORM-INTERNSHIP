using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInvoiceDetail
    {
        public DAInvoiceDetail()
        {

        }

        public void PrepareInvoiceDetail(BindingList<InvoiceDetailModel> listDetail)
        {
           foreach (InvoiceDetailModel iv in listDetail)
            {
                if (iv.status == 0)
                {
                    InsertInvoiceDetail(iv);
                }
                else if (iv.status == 1)
                {
                    UpdateInvoiceDetail(iv);
                }
                else if (iv.status == 2)
                {
                    DeleteInvoiceDetail(iv);
                }
            }
        }

        public void InsertInvoiceDetail(InvoiceDetailModel detail)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();


                SqlCommand command = new SqlCommand("InsertInvoiceDetail", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
               
                command.Parameters.Add(new SqlParameter("@InvoiceId", detail.invoiceId));
                command.Parameters.Add(new SqlParameter("@ItemId", detail.itemId));
                command.Parameters.Add(new SqlParameter("@Qtty", detail.qtty));
                command.Parameters.Add(new SqlParameter("@Price", detail.price));
                command.Parameters.Add(new SqlParameter("@Amount", detail.amount));
                command.Parameters.Add(new SqlParameter("@Observation", detail.observation));

                command.ExecuteNonQuery();
                command.Parameters.Clear();
                

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

        public void UpdateInvoiceDetail(InvoiceDetailModel detail)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();


                SqlCommand command = new SqlCommand("UpdateInvoiceDetail", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@InvoiceDetailId", detail.invoiceDetailId));
                command.Parameters.Add(new SqlParameter("@ItemId", detail.itemId));
                command.Parameters.Add(new SqlParameter("@Qtty", detail.qtty));
                command.Parameters.Add(new SqlParameter("@Price", detail.price));
                command.Parameters.Add(new SqlParameter("@Amount", detail.amount));
                command.Parameters.Add(new SqlParameter("@Observation", detail.observation));

                command.ExecuteNonQuery();
                command.Parameters.Clear();

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

        public void DeleteInvoiceDetail(InvoiceDetailModel detail)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();


                SqlCommand command = new SqlCommand("DeleteInvoiceDetail", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@InvoiceDetailId", detail.invoiceDetailId));      
             
                command.ExecuteNonQuery();
                command.Parameters.Clear();

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

        public DataTable GetInvoiceDetail(int invoiceId, int? invoiceDetailId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetInvoiceDetail", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@InvoiceId", invoiceId));

                command.Parameters.Add(new SqlParameter("@InvoiceDetailId", invoiceDetailId.GetValueOrDefault()));

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
    }
}
