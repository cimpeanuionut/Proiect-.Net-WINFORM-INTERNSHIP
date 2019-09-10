using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAClient
    {
        public DAClient()
        {

        }
        public string InsertClient(string ClientName, string ClientSurname, string ClientCode, string PhoneNo, string Email, out int insertedId)
        {
            string info = null;
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                if (UniqueClientValidation(ClientCode, false) == true)
                {
                    SqlCommand command = new SqlCommand("InsertClient", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientName", ClientName));
                    command.Parameters.Add(new SqlParameter("@ClientSurname", ClientSurname));
                    command.Parameters.Add(new SqlParameter("@ClientCode", ClientCode));
                    command.Parameters.Add(new SqlParameter("@PhoneNo", PhoneNo));
                    command.Parameters.Add(new SqlParameter("@Email", Email));
                    var returnParameter = command.Parameters.Add(new SqlParameter("@ReturnClientId", SqlDbType.Int));
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    insertedId =  Convert.ToInt32(returnParameter.Value.ToString());
                }
                else
                {
                    info = "Codul trebuie sa fie unic";
                    insertedId = 0;
                }
                
            }
            catch(SqlException se)
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

            return info;
        }

        public DataTable GetClients(string ClientName, string ClientSurname, string ClientCode, int? ClientId, int? skip_page, int? take_page)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("PaginationGetClient", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ClientName", ClientName));
                command.Parameters.Add(new SqlParameter("@ClientSurname", ClientSurname));
                command.Parameters.Add(new SqlParameter("@ClientCode", ClientCode));
                command.Parameters.Add(new SqlParameter("@ClientId", ClientId.GetValueOrDefault()));
                command.Parameters.Add(new SqlParameter("@skip_page", skip_page.GetValueOrDefault()));
                command.Parameters.Add(new SqlParameter("@take_page", take_page.GetValueOrDefault()));

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

        public string DADeleteClient(int selectedId)
        {
            SqlConnection connection = null;
            if (VerifyDeleteClient(selectedId))
            {
                try
                {
                    connection = new SqlConnection(Properties.Resources.ConnectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("DeleteClient", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientId", selectedId));

                    command.ExecuteNonQuery();
                    return "";
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
            else
            {
                return "Acest client nu se poate sterge deoarece are facturi";
            }
            

        }

        public string DAUpdateClient(string clientName, string clientSurname, string clientCode, string phoneNo, string email, int clientId, bool ok)
        {
            SqlConnection connection = null;
            string info = null;

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
                if (UniqueClientValidation(clientCode, ok) == true)
                {

                    SqlCommand command = new SqlCommand("UpdateClient", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ClientName", clientName));
                    command.Parameters.Add(new SqlParameter("@ClientSurname", clientSurname));
                    command.Parameters.Add(new SqlParameter("@ClientCode", clientCode));
                    command.Parameters.Add(new SqlParameter("@PhoneNo", phoneNo));
                    command.Parameters.Add(new SqlParameter("@Email", email));
                    command.Parameters.Add(new SqlParameter("@ClientId", clientId));

                    command.ExecuteNonQuery();
                }
                else
                {
                    info = "Codul folosit de dv. nu este unic";
                }

                return info;
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

        public bool UniqueClientValidation(string clientCode, bool clientCodeModify)
        {
            if (clientCodeModify == false)
            {

                SqlConnection connection = null;
                try
                {
                    bool ok = false;
                    connection = new SqlConnection(Properties.Resources.ConnectionString);
                    connection.Open();

                    DataTable dataTable = new DataTable();
                    SqlCommand command1 = new SqlCommand();
                    command1.Connection = connection;
                    command1.CommandType = System.Data.CommandType.Text;
                    command1.CommandText = "select ClientCode from TClient " +
                                             " where ClientCode = @ClientCode";
                    command1.Parameters.Add(new SqlParameter("@ClientCode", clientCode));

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command1;
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 0)
                    {
                        ok = true;
                    }

                    return ok;
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
            else
            {
                return true;
            }
        }

        public bool VerifyDeleteClient(int clientId)
        {
            SqlConnection connection = null;
            DataTable dataTable = new DataTable();

            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("VerifyDeleteClient", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ClientId", clientId));

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        
        public int GetTotalRowClient(string clientName, string clientSurname, string clientCode)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();
               
                    SqlCommand command = new SqlCommand("GetTotalRowClient", connection);

                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ClientName", clientName));
                    command.Parameters.Add(new SqlParameter("@ClientSurname", clientSurname));
                    command.Parameters.Add(new SqlParameter("@ClientCode", clientCode));
                    var returnParameter = command.Parameters.Add(new SqlParameter("@ReturnTotalRow", SqlDbType.Int));
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();

                return Convert.ToInt32(returnParameter.Value);
             
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
    }
}
