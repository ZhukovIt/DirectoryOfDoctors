using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace DirectoryOfDoctors.Classes.PhotoDB
{
    internal class SaverFilesFromDB
    {
        private string ConnectionString { get; set; }
        private string TableName { get; set; }
        private string FileBeforePath { get; set; }
        private string FileName { get; set; }
        private string FileDirectory { get; set; }
        private string Title { get; set; }
        private Task Task { get; set; }

        public SaverFilesFromDB(string tableName, string fileBeforePath, string fileDirectory, string fileName, string title)
        {
            ConnectionString = Classes.ConnectionString.GetPhotoDBConnectionString();
            TableName = tableName;
            FileBeforePath = fileBeforePath;
            FileDirectory = fileDirectory;
            FileName = fileName;
            Title = title;
            CheckExistsDirectory();
            object locker = new object();
            lock (locker)
            {
                Task = CheckExistsFile();
            }
        }

        public string GetFilePath()
        {
            return $"{FileBeforePath}\\{FileDirectory}\\{FileName}";
        }

        private void CheckExistsDirectory()
        {
            string directoryPath = $"{FileBeforePath}\\{FileDirectory}";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        private async Task CheckExistsFile()
        {
            string filePath = $"{FileBeforePath}\\{FileDirectory}\\{FileName}";
            bool IsExistsLocal = File.Exists(filePath);

            if (IsExistsLocal)
            {
                if (!HasFileFromDB())
                {
                    await SaveFileFromDB(filePath);
                }
            }
            else
            {
                if (HasFileFromDB())
                {
                    ReadFileFromDB(filePath);
                }
            }
        }

        private bool HasFileFromDB()
        {
            string sqlExpression = $"SELECT COUNT(*) FROM {TableName} WHERE fileName = '{FileName}'";
            SqlConnection connection;
            SqlCommand command = null;

            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                command = new SqlCommand(sqlExpression, connection);
                int count = (int)command.ExecuteScalar();

                if (command != null)
                {
                    command.Dispose();
                }
                connection.Close();

                return count > 0;
            }
        }

        private async Task SaveFileFromDB(string fileFullPath)
        {
            string sqlExpression = $"INSERT INTO {TableName} VALUES (@title, @fileName, @imageData)";
            SqlConnection connection;
            SqlCommand command = null;

            using (connection = new SqlConnection(ConnectionString))
            {
                await connection.OpenAsync();

                command = new SqlCommand(sqlExpression, connection);

                command.Parameters.Add("@fileName", SqlDbType.NVarChar, 50);
                command.Parameters.Add("@title", SqlDbType.NVarChar, 50);

                byte[] imageData;
                using (FileStream fs = new FileStream(fileFullPath, FileMode.Open))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                    command.Parameters.Add("@imageData", SqlDbType.Image, Convert.ToInt32(fs.Length));
                }

                command.Parameters["@fileName"].Value = FileName;
                command.Parameters["@title"].Value = Title;
                command.Parameters["@imageData"].Value = imageData;

                await command.ExecuteNonQueryAsync();

                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
        }

        private void ReadFileFromDB(string filePath)
        {
            string sqlExpression = $"SELECT title, fileName, imageData FROM {TableName} WHERE fileName = '{FileName}'";
            ImageFromDB img;
            SqlConnection connection;
            SqlCommand command = null;
            SqlDataReader reader;

            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                command = new SqlCommand(sqlExpression, connection);
                using (reader = command.ExecuteReader())
                {
                    reader.Read();
                    string title = reader.GetString(0);
                    string fileName = reader.GetString(1);
                    byte[] imageData = (byte[])reader.GetValue(2);

                    img = new ImageFromDB(fileName, title, imageData);

                    using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                    {
                        fs.Write(imageData, 0, imageData.Length);
                    }

                    reader.Close();
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
    }
}
