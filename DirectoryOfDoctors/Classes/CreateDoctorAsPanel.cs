using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System;
using DirectoryOfDoctors.Classes.PhotoDB;

namespace DirectoryOfDoctors.Classes
{
    partial class Doctor
    {
        private static string AppPath = Directory.GetCurrentDirectory();
        internal Button InfoButton = new Button();
        internal bool HasHandler = false;
        private Label DoctorPatronymicLabel = new Label();
        private Label DoctorLastNameLabel = new Label();
        private CheckBox DoctorCheckBox = new CheckBox();
        private PictureBox DoctorPhoto = new PictureBox();
        private Label DoctorPost = new Label();
        private Label DoctorFirstNameLabel = new Label();

        partial void CreateDoctorAsPanel()
        {
            // 
            // DoctorPanel
            // 
            DoctorPanel.BorderStyle = BorderStyle.FixedSingle;
            DoctorPanel.Controls.Add(InfoButton);
            DoctorPanel.Controls.Add(DoctorPatronymicLabel);
            DoctorPanel.Controls.Add(DoctorLastNameLabel);
            DoctorPanel.Controls.Add(DoctorCheckBox);
            DoctorPanel.Controls.Add(DoctorPhoto);
            DoctorPanel.Controls.Add(DoctorPost);
            DoctorPanel.Controls.Add(DoctorFirstNameLabel);
            DoctorPanel.Dock = DockStyle.Fill;
            DoctorPanel.Location = new Point(2, 2);
            DoctorPanel.Margin = new Padding(2);
            DoctorPanel.Name = $"DoctorPanel{Id}";
            DoctorPanel.Size = new Size(310, 175);
            DoctorPanel.TabIndex = 0;
            // 
            // InfoButton
            // 
            InfoButton.Cursor = Cursors.Hand;
            InfoButton.FlatAppearance.BorderSize = 0;
            InfoButton.FlatAppearance.MouseDownBackColor = Color.White;
            InfoButton.FlatAppearance.MouseOverBackColor = Color.White;
            InfoButton.FlatStyle = FlatStyle.Flat;
            InfoButton.Image = Image.FromFile(new SaverFilesFromDB("Icons", AppPath, "icons", "info.png", "Кнопка инфо").GetFilePath());
            InfoButton.Location = new Point(283, -3);
            InfoButton.Name = $"InfoButton{Id}";
            InfoButton.Size = new Size(28, 28);
            InfoButton.TabIndex = 7;
            InfoButton.UseVisualStyleBackColor = true;
            // 
            // DoctorPatronymicLabel
            // 
            DoctorPatronymicLabel.AutoSize = true;
            DoctorPatronymicLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoctorPatronymicLabel.Margin = new Padding(2, 0, 2, 0);
            DoctorPatronymicLabel.Name = $"DoctorPatronymicLabel{Id}";
            DoctorPatronymicLabel.Size = new Size(125, 19);
            DoctorPatronymicLabel.Location = new Point(228 - DoctorPatronymicLabel.Size.Width / 2, 98);
            DoctorPatronymicLabel.TabIndex = 6;
            DoctorPatronymicLabel.Text = Patronymic;
            DoctorPatronymicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorLastNameLabel
            // 
            DoctorLastNameLabel.AutoSize = true;
            DoctorLastNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoctorLastNameLabel.Margin = new Padding(2, 0, 2, 0);
            DoctorLastNameLabel.Name = $"DoctorLastNameLabel{Id}";
            DoctorLastNameLabel.Size = new Size(51, 19);
            DoctorLastNameLabel.Location = new Point(228 - DoctorPatronymicLabel.Size.Width / 2, 46);
            DoctorLastNameLabel.TabIndex = 5;
            DoctorLastNameLabel.Text = LastName;
            DoctorLastNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorCheckBox
            // 
            DoctorCheckBox.AutoSize = true;
            DoctorCheckBox.Dock = DockStyle.Top;
            DoctorCheckBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoctorCheckBox.Location = new Point(156, 0);
            DoctorCheckBox.Margin = new Padding(2);
            DoctorCheckBox.Name = $"DoctorCheckBox{Id}";
            DoctorCheckBox.Padding = new Padding(15, 0, 0, 0);
            DoctorCheckBox.Size = new Size(152, 23);
            DoctorCheckBox.TabIndex = 4;
            DoctorCheckBox.Text = "Выбрать";
            DoctorCheckBox.UseVisualStyleBackColor = true;
            // 
            // DoctorPhoto
            // 
            DoctorPhoto.Dock = DockStyle.Left;
            DoctorPhoto.Image = GetPhotoForPictureBox();
            DoctorPhoto.Location = new Point(0, 0);
            DoctorPhoto.Margin = new Padding(2);
            DoctorPhoto.Name = $"DoctorPhoto{Id}";
            DoctorPhoto.Size = new Size(156, 173);
            DoctorPhoto.TabIndex = 3;
            DoctorPhoto.TabStop = false;
            // 
            // DoctorPost
            // 
            DoctorPost.AutoSize = true;
            DoctorPost.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoctorPost.Location = new Point(184, 141);
            DoctorPost.Margin = new Padding(2, 0, 2, 0);
            DoctorPost.Name = $"DoctorPost{Id}";
            DoctorPost.Size = new Size(107, 19);
            DoctorPost.TabIndex = 2;
            DoctorPost.Text = Post;
            DoctorPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorFirstNameLabel
            // 
            DoctorFirstNameLabel.AutoSize = true;
            DoctorFirstNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DoctorFirstNameLabel.Margin = new Padding(2, 0, 2, 0);
            DoctorFirstNameLabel.Name = $"DoctorFirstNameLabel{Id}";
            DoctorFirstNameLabel.Size = new Size(58, 19);
            DoctorFirstNameLabel.Location = new Point(228 - DoctorFirstNameLabel.Size.Width / 2, 72);
            DoctorFirstNameLabel.TabIndex = 1;
            DoctorFirstNameLabel.Text = FirstName;
            DoctorFirstNameLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CorrectLocationElements()
        {
            if (Patronymic == null)
            {
                DoctorFirstNameLabel.Location = new Point(228 - DoctorFirstNameLabel.Size.Width / 2, DoctorFirstNameLabel.Location.Y + 20);
                DoctorLastNameLabel.Location = new Point(228 - DoctorLastNameLabel.Size.Width / 2, DoctorLastNameLabel.Location.Y + 10);
            }
            else
            {
                DoctorFirstNameLabel.Location = new Point(228 - DoctorFirstNameLabel.Size.Width / 2, DoctorFirstNameLabel.Location.Y);
                DoctorLastNameLabel.Location = new Point(228 - DoctorLastNameLabel.Size.Width / 2, DoctorLastNameLabel.Location.Y);
            }
            DoctorPatronymicLabel.Location = new Point(228 - DoctorPatronymicLabel.Size.Width / 2, DoctorPatronymicLabel.Location.Y);
        }

        public Image GetPhotoForPictureBox()
        {
            Image img;
            try
            {
                img = Image.FromFile(new SaverFilesFromDB("Photos", AppPath, "photos", $"{Id}.jpg", $"Врач с Id = {Id}").GetFilePath());
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                if (Sex == "female")
                {
                    img = Image.FromFile(new SaverFilesFromDB("Photos", AppPath, "photos", "standartWoman.png", "Стандартное фото женщины").GetFilePath());                }
                else
                {
                    img = Image.FromFile(new SaverFilesFromDB("Photos", AppPath, "photos", "standartMan.jpg", "Стандартное фото мужчины").GetFilePath());
                }
            }
            return img;
        }

        public CheckBox GetDoctorCheckBox()
        {
            return DoctorCheckBox;
        }

        public bool IsChecked()
        {
            return DoctorCheckBox.Checked;
        }

        public void Checked(bool flag)
        {
            DoctorCheckBox.Checked = flag;
        }
    }
}
