using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAItem
    {
        public DAItem()
        {

        }

        public DataTable GetItem()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("GetItem", connection);

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
    }
}
