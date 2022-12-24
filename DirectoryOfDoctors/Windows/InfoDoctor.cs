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
    public partial class InfoDoctor : Form
    {
        private Point LastPoint;

        internal InfoDoctor(Doctor doctor)
        {
            InitializeComponent();
            SetParameters(doctor);
        }

        private void SetParameters(Doctor doctor)
        {
            FirstName.Text = doctor.FirstName;
            LastName.Text = doctor.LastName;
            DoctorPhoto.Image = doctor.GetPhotoForPictureBox();
            Sex.Text = doctor.Sex == "male" ? "Мужской" : "Женский";
            if (doctor.Patronymic != null)
            {
                Patronymic.Text = doctor.Patronymic;
            }
            if (doctor.Birthday != null)
            {
                Birthday.Text = doctor.Birthday.ToString().Split()[0];
            }
            if (doctor.Snils != null)
            {
                Snils.Text = doctor.Snils.ToString();
            }
            Post.Text = doctor.Post;
            Specializations.Text = SetSpecializations(doctor.Specializations);
        }

        private string SetSpecializations(List<string> specializations)
        {
            int length = specializations.Count;
            if (length == 0)
            {
                return "Данные отсутствуют";
            }
            if (length == 1)
            {
                return specializations[0];
            }
            if (length == 2)
            {
                return specializations[0] + ", " + specializations[1];
            }
            if (length == 3)
            {
                return specializations[0] + ", " + specializations[1] + ", " + specializations[2];
            }
            return specializations[0] + ", " + specializations[1] + ", " + specializations[2] + "...";
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

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
