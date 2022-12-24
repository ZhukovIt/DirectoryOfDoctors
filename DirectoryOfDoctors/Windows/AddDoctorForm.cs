using DirectoryOfDoctors.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryOfDoctors.Windows
{
    public partial class AddDoctorForm : Form
    {
        private Point LastPoint;
        private int Id;
        private DBConnector dbConnector;
        private readonly Main main;
        private TypeOperation operation;
        private List<string> selectSpecializations = new List<string>();

        public AddDoctorForm(Main main)
        {
            InitializeComponent();
            this.main = main;
            dbConnector = new DBConnector(this.main.GetConnectionString());
            Id = GetLastIdDoctor();
            operation = TypeOperation.Add;
            FirstNameTextBox.Validating += FirstNameTextBox_Validating;
            LastNameTextBox.Validating += LastNameTextBox_Validating;
            SexComboBox.Validating += SexComboBox_Validating;
            SnilsTextBox4.Validating += Snils_Validating;
            OpenImage.Filter = "Фотографии (*.jpg)|*.jpg|Фотографии (*.png)|*.png";
            FillPostComboBox();
        }

        internal AddDoctorForm(Main main, int id, Doctor doctor) : this(main)
        {
            Id = id;
            operation = TypeOperation.Change;
            SetParametersForChange(doctor);
        }

        private void SetParametersForChange(Doctor doctor)
        {
            TitleLabel.Text = "Изменение доктора";
            AddDoctor.Text = "Изменить данные";
            FirstNameTextBox.Text = doctor.FirstName;
            LastNameTextBox.Text = doctor.LastName;
            DoctorPhoto.Image = doctor.GetPhotoForPictureBox();
            SexComboBox.Text = doctor.Sex == "male" ? "Мужской" : "Женский";
            if (doctor.Patronymic != null)
            {
                PatronymicTextBox.Text = doctor.Patronymic;
            }
            if (doctor.Birthday != null)
            {
                BirthdayDateTimePicker.Value = (DateTime)doctor.Birthday;
            }
            if (doctor.Snils != null)
            {
                string[] tempSnils = doctor.Snils.ToString().Split();
                string[] snils = tempSnils[0].Split('-');
                SnilsTextBox1.Text = snils[0];
                SnilsTextBox2.Text = snils[1];
                SnilsTextBox3.Text = snils[2];
                SnilsTextBox4.Text = tempSnils[1];
            }
            PostComboBox.Text = doctor.Post;
            selectSpecializations = doctor.Specializations;
            SetSelectSpecializations(selectSpecializations);
        }

        public void SetSelectSpecializations(List<string> items)
        {
            selectSpecializations = items;
            int count = selectSpecializations.Count;
            if (count == 1)
            {
                SpecializationsClicker.Text = selectSpecializations[0];
            }
            else if (count == 2)
            {
                SpecializationsClicker.Text = selectSpecializations[0] + ", " + selectSpecializations[1];
            }
            else if (count > 2)
            {
                SpecializationsClicker.Text = selectSpecializations[0] + ", " + selectSpecializations[1] + "...";
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

        private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                ValidationError.SetError(FirstNameLabel, "Не указано имя");
            }
            else
            {
                ValidationError.Clear();
            }
        }

        private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                ValidationError.SetError(LastNameLabel, "Не указана фамилия");
            }
            else
            {
                ValidationError.Clear();
            }
        }

        private void SexComboBox_Validating(object sender, CancelEventArgs e)
        {
            string[] correctSelect = new string[] { "Мужской", "Женский"};

            if (string.IsNullOrEmpty(SexComboBox.Text))
            {
                ValidationError.SetError(SexLabel, "Не указан пол");
            }
            else if (!correctSelect.Contains(SexComboBox.Text))
            {
                ValidationError.SetError(SexLabel, "Указано неверное значение");
            }
            else
            {
                ValidationError.Clear();
            }
        }

        private string GetSnils()
        {
            string first = SnilsTextBox1.Text, second = SnilsTextBox2.Text;
            string third = SnilsTextBox3.Text, four = SnilsTextBox4.Text;
            return $"{first}-{second}-{third} {four}";
        }

        private void Snils_Validating(object sender, CancelEventArgs e)
        {
            string snils = GetSnils();
            if (!new Snils(snils).IsValid)
            {
                ValidationError.SetError(SnilsLabel, "Контрольное число неверное");
            }
            else
            {
                ValidationError.Clear();
            }
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = OpenImage.FileName;
            DoctorPhoto.Image = Image.FromFile(fileName);
            int width = DoctorPhoto.Image.Width;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
            tableLayoutPanel1.ColumnStyles[0].Width = width + 20;
        }

        private void SnilsTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (SnilsTextBox1.Text.Length == 3)
            {
                SnilsTextBox2.Focus();
            }
        }

        private void SnilsTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (SnilsTextBox2.Text.Length == 3)
            {
                SnilsTextBox3.Focus();
            }
        }

        private void SnilsTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (SnilsTextBox3.Text.Length == 3)
            {
                SnilsTextBox4.Focus();
            }
        }

        private void FillPostComboBox()
        {
            string readSQL = "SELECT post FROM posts;";
            List<string> posts = (List<string>)dbConnector.dbWorker.Connect(dbConnector.GetAllPostsFromDB, readSQL);
            foreach (string post in posts)
            {
                PostComboBox.Items.Add(post);
            }
        }

        private void SpecializationsClicker_Click(object sender, EventArgs e)
        {
            string readSQL = "SELECT specialization FROM specializations;";
            List<string> specializations = (List<string>)dbConnector.dbWorker.Connect(dbConnector.GetAllSpecializationsFromDB, readSQL);
            SelectorSpecializations selector = new SelectorSpecializations(this, specializations, selectSpecializations);
            selector.ShowDialog();
        }

        private int GetLastIdDoctor()
        {
            string firstOrder = "SELECT COUNT(*) FROM doctors WHERE id = ";
            string secondOrder = " GROUP BY id;";
            return dbConnector.GetLastIdDoctor(firstOrder, secondOrder);
        }

        private bool IsCorrectValidation()
        {
            string first_name = FirstNameTextBox.Text;
            string last_name = LastNameTextBox.Text;
            string sex = SexComboBox.Text;
            string[] correctSelect = new string[] { "Мужской", "Женский" };
            if (string.IsNullOrEmpty(first_name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(last_name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(sex) || !correctSelect.Contains(sex))
            {
                return false;
            }
            return true;
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            if (IsCorrectValidation())
            {
                string first_name = FirstNameTextBox.Text;
                string last_name = LastNameTextBox.Text;
                string patronymic = PatronymicTextBox.Text;
                string sex = SexComboBox.Text;
                DateTime birthday = BirthdayDateTimePicker.Value;
                string snils = GetSnils();
                string post = PostComboBox.Text;
                Human doctor = new Doctor(Id, first_name, last_name, post, selectSpecializations, patronymic, sex);
                doctor.SetBirthday(birthday).SetSnils(snils);
                if (operation == TypeOperation.Add)
                {
                    main.AddDoctorFromDB((Doctor)doctor);
                }
                else if (operation == TypeOperation.Change)
                {
                    main.ChangeDoctorFromDB((Doctor)doctor);
                }
                Close();
            }
        }
    }
}
