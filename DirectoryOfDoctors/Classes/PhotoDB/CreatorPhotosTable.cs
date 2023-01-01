﻿using System.Data.SqlClient;
using System.Threading.Tasks;
using System;

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal class CreatorPhotosTable
    {
        private static readonly string connectionString = ConnectionString.GetPhotoDBConnectionString();

        internal static async Task CreateTable(string nameTable)
        {
            string sqlExpression = $"CREATE TABLE {nameTable}" + @" 
                                (id INT PRIMARY KEY IDENTITY, 
                                 title NVARCHAR(50) NOT NULL, 
                                 fileName NVARCHAR(50) NOT NULL,
                                 imageData varbinary(MAX))";
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
                    Console.WriteLine($"Таблица {nameTable} в базе данных PhotoDB уже создана!");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
