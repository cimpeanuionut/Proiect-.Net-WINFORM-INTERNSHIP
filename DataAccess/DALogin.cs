using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DALogin
    {
        public DALogin()
        {

        }

        public DataTable CheckUser(string userName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select UserId, UserName, UserPassword from TERPUser " +
                                         " where UserName = @UserName";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 256;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = userName;

                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;


                adapter.Fill(dataTable);                

            }catch (Exception e)
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

        public void UpdateDateTime(DateTime date, int userId)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("UpdateLastLogin", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@LastLogin", date));
                command.Parameters.Add(new SqlParameter("@UserId", userId));

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
