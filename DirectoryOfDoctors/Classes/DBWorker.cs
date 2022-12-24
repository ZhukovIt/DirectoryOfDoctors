using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DirectoryOfDoctors.Classes
{
    internal class DBWorker
    {
        private string ConnectionString;

        public DBWorker(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Connect(Action<SqlCommand> action, string sqlOrder)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlOrder, connection);
                action(command);
            }
        }
    }
}
