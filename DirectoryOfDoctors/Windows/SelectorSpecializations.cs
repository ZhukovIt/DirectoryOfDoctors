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
    public partial class SelectorSpecializations : Form
    {
        private Point LastPoint;
        private List<string> Specializations;
        private List<string> SelectSpecializations;
        private readonly AddDoctorForm AddDoctorForm;

        public SelectorSpecializations(AddDoctorForm addDoctorForm, List<string> specializations, List<string> selectSpecializations)
        {
            InitializeComponent();
            AddDoctorForm = addDoctorForm;
            Specializations = specializations;
            SelectSpecializations = selectSpecializations;
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            for (int i = 0; i < Specializations.Count; i++)
            {
                string temp = Specializations[i];
                dataGridView1.Rows.Add(SelectSpecializations.Contains(temp), temp);
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

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            List<string> tempSelectSpecializations = new List<string>();
            for (int i = 0; i < Specializations.Count; i++)
            {
                string temp = (string)dataGridView1.Rows[i].Cells[1].Value;
                if (!string.IsNullOrEmpty(temp) && (bool)dataGridView1.Rows[i].Cells[0].Value)
                {
                    tempSelectSpecializations.Add(temp);
                }
            }
            AddDoctorForm.SetSelectSpecializations(tempSelectSpecializations);
            Close();
        }
    }
}
