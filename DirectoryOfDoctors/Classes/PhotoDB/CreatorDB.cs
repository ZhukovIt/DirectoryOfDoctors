using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("База данных создана");
            }
        }
    }
}
