using System;
using System.Data.SqlClient;

namespace DirectoryOfDoctors.Classes
{
    internal class DBWorkerSingleton
    {
        private readonly string ConnectionString;

        private static DBWorkerSingleton dbWorker;

        private DBWorkerSingleton(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public static DBWorkerSingleton GetInstance(string connectionString)
        {
            if (dbWorker == null)
            {
                dbWorker = new DBWorkerSingleton(connectionString);
            }
            return dbWorker;
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

        public TResult Connect<TResult>(Func<SqlCommand, TResult> func, string sqlOrder)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlOrder, connection);
                return func(command);
            }
        }
    }
}
