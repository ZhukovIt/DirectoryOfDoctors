using System.Data.SqlClient;
using System.Threading.Tasks;
using System;

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal class CreatorPhotosTable
    {
        private static readonly string connectionString = ConnectionString.GetPhotoDBConnectionString();

        internal static void CreateTable(string nameTable)
        {
            string sqlExpression = $"CREATE TABLE {nameTable}" + @" 
                                (id INT PRIMARY KEY IDENTITY, 
                                 title NVARCHAR(50) NOT NULL, 
                                 fileName NVARCHAR(50) NOT NULL,
                                 imageData varbinary(MAX))";
            SqlConnection connection;
            SqlCommand command = null;
            
            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (command = new SqlCommand(sqlExpression, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine($"Таблица {nameTable} в базе данных PhotoDB уже создана!");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (command != null)
                    {
                        command.Dispose();
                    }
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
