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
    public class DAClientAddress
    {
        public DAClientAddress()
        {

        }

        public DataTable GetClientAddress(int clientId, int? clientAddressId)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetClientAddress", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ClientId", clientId));

                command.Parameters.Add(new SqlParameter("@ClientAddressId", clientAddressId.GetValueOrDefault()));

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

        public DataTable GetCity()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetCity", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;                

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

        public DataTable GetCounty()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetCounty", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

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

        public void PrepareClientAddress(BindingList<ClientAddressModel> listAddress)
        {

            foreach (ClientAddressModel address in listAddress)
            {
                if (address.status == 0)
                {
                    InsertClientAddress(address);
                    
                }else if (address.status == 1)
                {
                    UpdateClientAddress(address);
                    
                }else if (address.status == 2)
                {
                   DeleteClientAddress(address.ClientAddressId);
                }
                
            }
            
        }

        public void InsertClientAddress(ClientAddressModel address)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
               
                
                    SqlCommand command = new SqlCommand("AddClientAddress", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientId", address.ClientId));
                    command.Parameters.Add(new SqlParameter("@StreetName", address.StreetName));
                    command.Parameters.Add(new SqlParameter("@StreetNo", address.StreetNo));
                    command.Parameters.Add(new SqlParameter("@CityName", address.City.CityName));
                    command.Parameters.Add(new SqlParameter("@CountyName", address.County.CountyName));

                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                connection.Close();
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

        public void DeleteClientAddress(int ClientAddressId)
        {
            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
               

                    SqlCommand command = new SqlCommand("DeleteClientAddress", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientAddressId", ClientAddressId));

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

        public void UpdateClientAddress(ClientAddressModel address)
        {
            SqlConnection connection = null;          

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();             
               
                    SqlCommand command = new SqlCommand("UpdateClientAddress", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientAddressId", address.ClientAddressId));
                    command.Parameters.Add(new SqlParameter("@StreetName", address.StreetName));
                    command.Parameters.Add(new SqlParameter("@StreetNo", address.StreetNo));
                    command.Parameters.Add(new SqlParameter("@CityName", address.City.CityName));
                    command.Parameters.Add(new SqlParameter("@CountyName", address.County.CountyName));
                    
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
