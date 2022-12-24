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
    public partial class FilterDoctors : Form
    {
        private Point LastPoint;
        private Main main;
        private string ActiveFilter;
        private List<RadioButton> filters;

        public FilterDoctors(Main main)
        {
            InitializeComponent();
            this.main = main;
            ActiveFilter = main.ActiveFilter;
            filters = new List<RadioButton>
            {
                FirstNameRadioButton,
                LastNameRadioButton,
                PatronymicRadioButton,
                PostRadioButton,
                NoFilterRadioButton
            };
            filters.Single(f => f.Text == ActiveFilter).Checked = true;
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
            main.ActiveFilter = ActiveFilter;
            Color color = ActiveFilter == "Без фильтров" ? Color.White : Color.LightGray;
            main.FilterButton.BackColor = color;
            main.FilterButton.FlatAppearance.MouseDownBackColor = color;
            main.FilterButton.FlatAppearance.MouseOverBackColor = color;
            Close();
            main.FinderButton_Click(main.FinderButton, null);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActiveFilter = filters.Single(f => f.Checked).Text;
        }
    }
}
