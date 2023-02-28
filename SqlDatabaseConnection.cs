using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon
{
    public class SqlDatabaseConnection
    {
        public SqlConnection Connection()
        {
            SqlConnection connection =
                new SqlConnection(
                    @"Data Source=DESKTOP-U0NLI58\MSSQLSERVER01;Initial Catalog=TicariOtomasyon;Integrated Security=True");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
