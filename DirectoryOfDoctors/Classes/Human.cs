using System;

namespace DirectoryOfDoctors.Classes
{
    class Human
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Patronymic { get; private set; }
        public string Sex { get; private set; }
        public DateTime? Birthday { get; private set; } = null;
        public Snils Snils { get; private set; }

        public Human(int id, string firstName, string lastName, string sex)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
        }

        public Human(int id, string firstName, string lastName, string patronymic, string sex) : this(id, firstName, lastName, sex)
        {
            Patronymic = patronymic;
        }

        public Human SetBirthday(string birthday)
        {
            // Строка в формате ДД.ММ.ГГГГ
            string[] tempData = birthday.Split('.');
            int day = int.Parse(tempData[0]), month = int.Parse(tempData[1]), year = int.Parse(tempData[2]);
            Birthday = new DateTime(year, month, day);
            return this;
        }

        public Human SetBirthday(DateTime? birthday)
        {
            Birthday = birthday;
            return this;
        }

        public Human SetSnils(string snils)
        {
            // Строка в формате ххх-ххх-ххх уу
            Snils tempSnils = new Snils(snils);
            if (tempSnils.IsValid)
            {
                Snils = tempSnils;
            }
            return this;
        }
    }
}
