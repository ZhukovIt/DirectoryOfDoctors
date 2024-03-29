﻿using System.Threading.Tasks;
using System.Data.SqlClient;
using System;

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal static class CreatorDB
    {
        private static readonly string connectionString = ConnectionString.GetDirectoryOfDoctorsConnectionString();

        internal static void CreateDB()
        {
            string sqlExpression = "CREATE DATABASE PhotoDB";
            SqlConnection connection;
            SqlCommand command = null;

            using (connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("База данных PhotosDB уже создана!");
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
