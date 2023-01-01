using System;
using System.Drawing;
using System.Windows.Forms;
using DirectoryOfDoctors.Classes;
using DirectoryOfDoctors.Classes.Filters;
using DirectoryOfDoctors.Classes.PhotoDB;
using DirectoryOfDoctors.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DirectoryOfDoctors
{
    public partial class Main : Form
    {
        private Point LastPoint;
        private IEnumerable<Doctor> doctors;
        private readonly string connectionString;
        private readonly DBConnector dbConnector;
        internal string ActiveFilter = "Без фильтров";

        public Main()
        {
            InitializeComponent();
            connectionString = ConnectionString.GetDirectoryOfDoctorsConnectionString();
            dbConnector = new DBConnector(connectionString);
            UpdateAllDoctors();
            CreatorDB.CreateDB();
            CreatorPhotosTable.CreatePhotosTable();
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        internal void UpdateAllDoctors()
        {
            DoctorTableLayoutPanel.Controls.Clear();
            InstallDoctors();
            SetHandlersForDoctorCheckBox();
            SetHandlersForInfoButtons();
        }

        internal void UpdateAllDoctors(IEnumerable<Doctor> doctors)
        {
            DoctorTableLayoutPanel.Controls.Clear();
            InstallDoctors(doctors);
            SetHandlersForDoctorCheckBox(doctors);
            SetHandlersForInfoButtons(doctors);
        }

        private void SetHandlersForInfoButtons(IEnumerable<Doctor> doctors=null)
        {
            IEnumerable<Doctor> Doctors = doctors;
            if (doctors == null)
            {
                Doctors = this.doctors;
            }
            foreach (Doctor Doctor in Doctors)
            {
                if (!Doctor.HasHandler)
                {
                    Doctor.HasHandler = true;
                    Doctor.InfoButton.Click += InfoButton_Click;
                }
            }
        }

        internal void InfoButton_Click(object sender, EventArgs e)
        {
            Button infoButton = (Button)sender;
            if (infoButton != null)
            {
                int id = Convert.ToInt32(infoButton.Name.Split('n')[2]);
                Doctor doctor = doctors.Single(d => d.Id == id);
                new InfoDoctor(doctor).ShowDialog();
            }
        }

        private void InstallDoctors(IEnumerable<Doctor> doctors=null)
        {
            string readSQL = "SELECT d.id, d.first_name, d.last_name, d.patronymic, d.sex, dd.birthday, dd.snils, p.post, s.specialization FROM doctors as d LEFT JOIN doctors_data as dd ON d.id = dd.doctor_id LEFT JOIN posts as p ON d.post_id = p.id LEFT JOIN doctors_specializations as ds ON d.id = ds.doctor_id LEFT JOIN specializations as s ON ds.specialization_id = s.id;";
            IEnumerable<Doctor> allDoctors = doctors;
            if (doctors == null)
            {
                this.doctors = dbConnector.dbWorker.Connect(dbConnector.GetAllDoctorsFromDB, readSQL);
                allDoctors = this.doctors;
            }
            ControlCountDoctors(allDoctors);
            int rows = DoctorTableLayoutPanel.RowCount, columns = DoctorTableLayoutPanel.ColumnCount;
            int counter = 0, length = allDoctors.Count();
            bool stopFlag = false;
            if (length == 0)
            {
                stopFlag = true;
            }
            for (int i = 0; i < rows; i++)
            {
                if (stopFlag)
                {
                    break;
                }
                for(int j = 0; j < columns; j++)
                {
                    ((List<Doctor>)allDoctors)[counter].InstallDoctorPanel(DoctorTableLayoutPanel, i, j);
                    counter++;
                    if (counter >= length)
                    {
                        stopFlag = true;
                        break;
                    }
                }
            }
        }

        private void SetHandlersForDoctorCheckBox(IEnumerable<Doctor> doctors=null)
        {
            IEnumerable<Doctor> Doctors = doctors;

            if (doctors == null)
            {
                Doctors = this.doctors;
            }
            foreach (var doctor in Doctors)
            {
                CheckBox checkBox = doctor.GetDoctorCheckBox();
                checkBox.CheckedChanged += new EventHandler(DoctorCheckBox_CheckChanged);
                checkBox.CheckedChanged += new EventHandler(CheckChangeButton);
                checkBox.CheckedChanged += new EventHandler(CheckDeleteButton);
            }
        }

        private void CheckDeleteButton(object sender, EventArgs e)
        {
            DeleteDoctorButton.Visible = doctors.Any(d => d.IsChecked());
        }

        private void CheckChangeButton(object sender, EventArgs e)
        {
            int count = doctors.Count(d => d.IsChecked());
            ChangeDoctorButton.Visible = count == 1;
        }

        private void DoctorCheckBox_CheckChanged(object sender, EventArgs e)
        {
            if (!doctors.All(d => d.IsChecked()))
            {
                AllSelectButton.Text = "Выбрать всех";
            }
            else
            {
                AllSelectButton.Text = "Снять выделение";
            }
        }

        private void TitleElement_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TitleElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - LastPoint.X;
                Top += e.Y - LastPoint.Y;
            }
        }

        private void Close_Label_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllSelectButton_Click(object sender, EventArgs e)
        {
            if (!doctors.All(d => d.IsChecked()))
            {
                foreach (var doctor in doctors)
                {
                    doctor.Checked(true);
                }
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    doctor.Checked(false);
                }
            }
        }

        private void FindFildTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                FinderButton_Click(FinderButton, null);
            }
        }

        internal void FinderButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Doctor> filterDoctors;
            string data = FindFildTextBox.Text;
            IFIlter filter = new FinderFilter();
            if (ActiveFilter == "По имени")
            {
                filterDoctors = (IEnumerable<Doctor>)filter.Filter(doctors, new FirstNameSpecification(data));
            }
            else if (ActiveFilter == "По фамилии")
            {
                filterDoctors = (IEnumerable<Doctor>)filter.Filter(doctors, new LastNameSpecification(data));
            }
            else if (ActiveFilter == "По отчеству")
            {
                filterDoctors = (IEnumerable<Doctor>)filter.Filter(doctors, new PatronymicSpecification(data));
            }
            else if (ActiveFilter == "По должности")
            {
                filterDoctors = (IEnumerable<Doctor>)filter.Filter(doctors, new PostSpecification(data));
            }
            else
            {
                if (string.IsNullOrEmpty(data))
                {
                    filterDoctors = doctors;
                }
                else
                {
                    IEnumerable<Doctor> first_name_doctors = (IEnumerable<Doctor>)filter.Filter(doctors, new FirstNameSpecification(data));
                    IEnumerable<Doctor> last_name_doctors = (IEnumerable<Doctor>)filter.Filter(doctors, new LastNameSpecification(data));
                    IEnumerable<Doctor> patronymic_doctors = (IEnumerable<Doctor>)filter.Filter(doctors, new PatronymicSpecification(data));
                    IEnumerable<Doctor> post_doctors = (IEnumerable<Doctor>)filter.Filter(doctors, new PostSpecification(data));
                    filterDoctors = (first_name_doctors).Concat(last_name_doctors).Concat(patronymic_doctors).Concat(post_doctors).Distinct().ToList();
                }
            }
            UpdateAllDoctors(filterDoctors);
        }

        private void PostsListButton_Click(object sender, EventArgs e)
        {
            new PostsList(this).ShowDialog();
        }

        private void SpecializationsListButton_Click(object sender, EventArgs e)
        {
            new SpecializationsList(this).ShowDialog();
        }

        private void ChangeDoctorButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = doctors.Single(d => d.IsChecked());
            if (doctor != null) 
            {
                new AddDoctorForm(this, doctor.Id, doctor).ShowDialog();
            }
        }

        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            List<Doctor> deletedDoctors = doctors.Where(d => d.IsChecked()).ToList();
            foreach (var doctor in deletedDoctors)
            {
                int id = doctor.Id;

                string sqlOrder = $"DELETE doctors WHERE id = {id}";
                dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

                sqlOrder = $"DELETE doctors_specializations WHERE doctor_id = {id}";
                dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

                CheckDeleteButton(null, null);
                CheckChangeButton(null, null);
            }
            UpdateAllDoctors();
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            new AddDoctorForm(this).ShowDialog();
        }

        internal void AddDoctorFromDB(Doctor doctor)
        {
            int id = doctor.Id;
            string first_name = doctor.FirstName;
            string last_name = doctor.LastName;
            string patronymic = doctor.Patronymic;
            string post_id = GetPostId(doctor.Post);
            string sex = doctor.Sex == "Мужской" ? "male" : "female";

            string sqlOrder = "INSERT INTO doctors (id, first_name, last_name, patronymic, post_id, sex) ";
            sqlOrder += $"VALUES ({id}, '{first_name}', '{last_name}', '{patronymic}', {post_id}, '{sex}');";
            dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            string birthday = GetBirthdayFromDB((DateTime)doctor.Birthday);
            string snils;
            if (doctor.Snils == null || string.IsNullOrEmpty(doctor.Snils.ToString()))
            {
                snils = "NULL";
            }
            else
            {
                snils = $"'{doctor.Snils}'";
            }    
            int doctors_data_id = GetDoctorsDataId();

            sqlOrder = "INSERT INTO doctors_data (id, doctor_id, birthday, snils) ";
            sqlOrder += $"VALUES ({doctors_data_id}, {id}, '{birthday}', {snils})";
            dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            string specializations = GetSpecializationsFromDB(doctor.Id, doctor.Specializations);

            if (!string.IsNullOrEmpty(specializations))
            {
                sqlOrder = $"INSERT INTO doctors_specializations (doctor_id, specialization_id) VALUES {specializations}";
                dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);
            }

            UpdateAllDoctors();
        }

        private int GetDoctorsDataId()
        {
            string firstOrder = "SELECT COUNT(*) FROM doctors_data WHERE id = ";
            string secondOrder = " GROUP BY id;";
            return dbConnector.GetLastIdDoctor(firstOrder, secondOrder);
        }

        private string GetPostId(string post)
        {
            string sqlOrder = $"SELECT id FROM posts WHERE post = '{post}';";
            int result = dbConnector.dbWorker.Connect(dbConnector.GetIntScalar, sqlOrder);
            if (result == 0)
            {
                return "NULL";
            }
            return result.ToString();
        }

        private string GetBirthdayFromDB(DateTime birthday)
        {
            return $"{birthday.Year}-{birthday.Month}-{birthday.Day}";
        }

        private string GetSpecializationsFromDB(int doctor_id, List<string> specializations)
        {
            string result = "";
            foreach (string specialization in specializations)
            {
                string sqlOrder = $"SELECT id FROM specializations WHERE specialization = '{specialization}'";
                int id = dbConnector.dbWorker.Connect(dbConnector.GetIntScalar, sqlOrder);
                result += $"({doctor_id}, {id}), ";
            }
            if (string.IsNullOrEmpty(result))
            {
                return result;
            }
            return result.Remove(result.Length - 2, 2);
        }

        internal void ChangeDoctorFromDB(Doctor doctor)
        {
            int id = doctor.Id;
            string first_name = doctor.FirstName;
            string last_name = doctor.LastName;
            string patronymic = doctor.Patronymic;
            string post_id = GetPostId(doctor.Post);
            string sex = doctor.Sex == "Мужской" ? "male" : "female";

            string sqlOrder = $"UPDATE doctors SET first_name = '{first_name}', last_name = '{last_name}', ";
            sqlOrder += $"patronymic = '{patronymic}', post_id = {post_id}, sex = '{sex}' WHERE id = {id}";
            dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            string birthday = GetBirthdayFromDB((DateTime)doctor.Birthday);
            string snils;
            if (doctor.Snils == null || string.IsNullOrEmpty(doctor.Snils.ToString()))
            {
                snils = "NULL";
            }
            else
            {
                snils = $"'{doctor.Snils}'";
            }

            sqlOrder = $"UPDATE doctors_data SET birthday = '{birthday}', snils = {snils}, ";
            sqlOrder += $"doctor_id = {id} WHERE id = {id}";
            dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            string specializations = GetSpecializationsFromDB(doctor.Id, doctor.Specializations);

            sqlOrder = $"DELETE doctors_specializations WHERE doctor_id = {id}";
            dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            if (!string.IsNullOrEmpty(specializations))
            {

                sqlOrder = $"INSERT INTO doctors_specializations (doctor_id, specialization_id) VALUES {specializations}";
                dbConnector.dbWorker.Connect(dbConnector.NonQuery, sqlOrder);

            }

            UpdateAllDoctors();
        }

        private void ControlCountDoctors(IEnumerable<Doctor> doctors)
        {
            int count = doctors.Count();
            if (count > 9)
            {
                int dopRow = (int)Math.Ceiling((double)count / 3) - 3;
                DoctorTableLayoutPanel.RowCount = 3 + dopRow;
                for (int i = 3; i < 3 + dopRow; i++)
                {
                    DoctorTableLayoutPanel.RowStyles.Add(new RowStyle());
                    DoctorTableLayoutPanel.RowStyles[i].SizeType = SizeType.Absolute;
                    DoctorTableLayoutPanel.RowStyles[i].Height = 220;
                }    
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            FilterButton.BackColor = Color.LightGray;
            FilterButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            FilterButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
            new FilterDoctors(this).ShowDialog();
        }

        private void FindFildTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FindFildTextBox.Text))
            {
                FinderButton_Click(FinderButton, null);
            }
        }
    }
}
