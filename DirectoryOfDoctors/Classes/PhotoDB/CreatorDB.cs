using System.Threading.Tasks;
using System.Data.SqlClient;
using System;

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal static class CreatorDB
    {
        private static readonly string connectionString = ConnectionString.GetDirectoryOfDoctorsConnectionString();

        internal static async Task CreateDB()
        {
            string sqlExpression = "CREATE DATABASE PhotoDB";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("База данных PhotosDB уже создана!");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
