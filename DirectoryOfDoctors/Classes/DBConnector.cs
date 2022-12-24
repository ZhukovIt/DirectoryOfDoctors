using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DirectoryOfDoctors.Classes
{
    internal class DBConnector
    {
        private readonly string connectionString = ConnectionString.GetDirectoryOfDoctorsConnectionString();
        private readonly string sqlOrder;
        public readonly DBWorkerSingleton dbWorker;

        public DBConnector()
        {
            dbWorker = DBWorkerSingleton.GetInstance(connectionString);
        }

        public DBConnector(string sqlOrder) : this()
        {
            this.sqlOrder = sqlOrder;
        }

        public void NonQuery(SqlCommand command)
        {
            command.ExecuteNonQuery();
        }

        public int GetIntScalar(SqlCommand command)
        {
            object obj = command.ExecuteScalar();
            return Convert.ToInt32(obj);
        }

        public int GetLastIdDoctor(string firstOrder, string secondOrder)
        {
            int counter = 1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                while (true)
                {
                    string sql = firstOrder + counter.ToString() + secondOrder;
                    SqlCommand command = new SqlCommand(sql, connection);
                    if (command.ExecuteScalar() == null)
                    {
                        return counter;
                    }
                    counter++;
                }
            }
        }

        public IEnumerable<string> GetAllSpecializationsFromDB(SqlCommand command)
        {
            List<string> specializations = new List<string>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        specializations.Add(reader.GetString(0));
                    }
                }
            }
            return specializations;
        }

        public IEnumerable<string> GetAllPostsFromDB(SqlCommand command)
        {
            List<string> posts = new List<string>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        posts.Add(reader.GetString(0));
                    }
                }
            }
            return posts;
        }
        
        public IEnumerable<Doctor> GetAllDoctorsFromDB(SqlCommand command)
        {
            List<Doctor> doctors = new List<Doctor>();
            Dictionary<int, Doctor> map = new Dictionary<int, Doctor>();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string first_name = reader.GetString(1);
                        string last_name = reader.GetString(2);
                        string sex = reader.GetString(4);
                        string patronymic = GetCorrectDataOrNull(reader.GetString, 3);
                        DateTime? birthday = GetCorrectDataOrNull(reader.GetDateTime, 5);
                        string snils = GetCorrectDataOrNull(reader.GetString, 6);
                        string post = GetCorrectDataOrNull(reader.GetString, 7);
                        string specialization = GetCorrectDataOrNull(reader.GetString, 8);
                        if (map.ContainsKey(id))
                        {
                            map[id].AddSpecialization(specialization);
                        }
                        else
                        {
                            List<string> specializations = new List<string> { specialization };
                            Human doctor = new Doctor(id, first_name, last_name, post, specializations, patronymic, sex);
                            doctor.SetBirthday(birthday).SetSnils(snils);
                            map[id] = (Doctor)doctor;
                            doctors.Add((Doctor)doctor);
                        }
                    }
                }
            }
            return doctors;
        }

        private T GetCorrectDataOrNull<T>(Func<int, T> func, int index)
        {
            try
            {
                T result = func(index);
                return result;
            }
            catch (System.Data.SqlTypes.SqlNullValueException)
            {
                return default(T);
            }
        }
    }
}
