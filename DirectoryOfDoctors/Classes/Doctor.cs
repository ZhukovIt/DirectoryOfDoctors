using System.Collections.Generic;
using System.Windows.Forms;

namespace DirectoryOfDoctors.Classes
{
    partial class Doctor : Human
    {
        public string Post { get; private set; }
        public List<string> Specializations { get; private set; }

        private Panel DoctorPanel = new Panel();
        partial void CreateDoctorAsPanel();

        public Doctor(int id, string firstName, string lastName, string post, List<string> spec, string patronymic="", string sex="male") : base(id, firstName, lastName, patronymic, sex)
        {
            Post = post;
            Specializations = spec;
            CreateDoctorAsPanel();
            CorrectLocationElements();
        }

        public void AddSpecialization(string specialization)
        {
            Specializations.Add(specialization);
        }

        public void InstallDoctorPanel(TableLayoutPanel panel, int row, int column)
        {
            panel.Controls.Add(DoctorPanel, column, row);
        }
    }
}
