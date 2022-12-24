namespace DirectoryOfDoctors.Windows
{
    partial class InfoDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoDoctor));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DoctorPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PatronymicLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.SnilsLabel = new System.Windows.Forms.Label();
            this.PostLabel = new System.Windows.Forms.Label();
            this.SpecializationsLabel = new System.Windows.Forms.Label();
            this.Specializations = new System.Windows.Forms.Label();
            this.Post = new System.Windows.Forms.Label();
            this.Snils = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPhoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.CloseLabel);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(800, 40);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(293, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(172, 26);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Данные доктора";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseLabel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(773, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 27);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 40);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 460);
            this.MainPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DoctorPhoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 458);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DoctorPhoto
            // 
            this.DoctorPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoctorPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorPhoto.Image = ((System.Drawing.Image)(resources.GetObject("DoctorPhoto.Image")));
            this.DoctorPhoto.Location = new System.Drawing.Point(46, 139);
            this.DoctorPhoto.Name = "DoctorPhoto";
            this.DoctorPhoto.Size = new System.Drawing.Size(158, 180);
            this.DoctorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DoctorPhoto.TabIndex = 0;
            this.DoctorPhoto.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.Controls.Add(this.FirstNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PatronymicLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LastNameLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SexLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BirthdayLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.SnilsLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.PostLabel, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.SpecializationsLabel, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.Specializations, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.Post, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.Snils, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.Sex, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.LastName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Patronymic, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FirstName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Birthday, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(253, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(544, 452);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(124, 17);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(52, 22);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.Location = new System.Drawing.Point(81, 73);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(95, 22);
            this.PatronymicLabel.TabIndex = 1;
            this.PatronymicLabel.Text = "Отчество:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(81, 129);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(95, 22);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(126, 185);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(50, 22);
            this.SexLabel.TabIndex = 3;
            this.SexLabel.Text = "Пол:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(31, 241);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(145, 22);
            this.BirthdayLabel.TabIndex = 4;
            this.BirthdayLabel.Text = "Дата рождения:";
            // 
            // SnilsLabel
            // 
            this.SnilsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SnilsLabel.AutoSize = true;
            this.SnilsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsLabel.Location = new System.Drawing.Point(106, 297);
            this.SnilsLabel.Name = "SnilsLabel";
            this.SnilsLabel.Size = new System.Drawing.Size(70, 22);
            this.SnilsLabel.TabIndex = 5;
            this.SnilsLabel.Text = "Снилс:";
            // 
            // PostLabel
            // 
            this.PostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PostLabel.AutoSize = true;
            this.PostLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostLabel.Location = new System.Drawing.Point(64, 353);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(112, 22);
            this.PostLabel.TabIndex = 6;
            this.PostLabel.Text = "Должность:";
            // 
            // SpecializationsLabel
            // 
            this.SpecializationsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpecializationsLabel.AutoSize = true;
            this.SpecializationsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationsLabel.Location = new System.Drawing.Point(27, 411);
            this.SpecializationsLabel.Name = "SpecializationsLabel";
            this.SpecializationsLabel.Size = new System.Drawing.Size(149, 22);
            this.SpecializationsLabel.TabIndex = 7;
            this.SpecializationsLabel.Text = "Специальности:";
            // 
            // Specializations
            // 
            this.Specializations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Specializations.AutoSize = true;
            this.Specializations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Specializations.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specializations.ForeColor = System.Drawing.Color.Black;
            this.Specializations.Location = new System.Drawing.Point(268, 411);
            this.Specializations.Name = "Specializations";
            this.Specializations.Size = new System.Drawing.Size(187, 22);
            this.Specializations.TabIndex = 15;
            this.Specializations.Text = "Данные отсутствуют";
            // 
            // Post
            // 
            this.Post.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Post.AutoSize = true;
            this.Post.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Post.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Post.ForeColor = System.Drawing.Color.Black;
            this.Post.Location = new System.Drawing.Point(268, 353);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(187, 22);
            this.Post.TabIndex = 15;
            this.Post.Text = "Данные отсутствуют";
            // 
            // Snils
            // 
            this.Snils.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Snils.AutoSize = true;
            this.Snils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Snils.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Snils.ForeColor = System.Drawing.Color.Black;
            this.Snils.Location = new System.Drawing.Point(268, 297);
            this.Snils.Name = "Snils";
            this.Snils.Size = new System.Drawing.Size(187, 22);
            this.Snils.TabIndex = 15;
            this.Snils.Text = "Данные отсутствуют";
            // 
            // Sex
            // 
            this.Sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sex.AutoSize = true;
            this.Sex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sex.ForeColor = System.Drawing.Color.Black;
            this.Sex.Location = new System.Drawing.Point(268, 185);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(187, 22);
            this.Sex.TabIndex = 15;
            this.Sex.Text = "Данные отсутствуют";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastName.AutoSize = true;
            this.LastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.ForeColor = System.Drawing.Color.Black;
            this.LastName.Location = new System.Drawing.Point(268, 129);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(187, 22);
            this.LastName.TabIndex = 15;
            this.LastName.Text = "Данные отсутствуют";
            // 
            // Patronymic
            // 
            this.Patronymic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Patronymic.AutoSize = true;
            this.Patronymic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patronymic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patronymic.ForeColor = System.Drawing.Color.Black;
            this.Patronymic.Location = new System.Drawing.Point(268, 73);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(187, 22);
            this.Patronymic.TabIndex = 15;
            this.Patronymic.Text = "Данные отсутствуют";
            // 
            // FirstName
            // 
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstName.AutoSize = true;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.ForeColor = System.Drawing.Color.Black;
            this.FirstName.Location = new System.Drawing.Point(268, 17);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(187, 22);
            this.FirstName.TabIndex = 15;
            this.FirstName.Text = "Данные отсутствуют";
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birthday.AutoSize = true;
            this.Birthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Birthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.ForeColor = System.Drawing.Color.Black;
            this.Birthday.Location = new System.Drawing.Point(268, 241);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(187, 22);
            this.Birthday.TabIndex = 15;
            this.Birthday.Text = "Данные отсутствуют";
            // 
            // InfoDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDoctorForm";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPhoto)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox DoctorPhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label SnilsLabel;
        private System.Windows.Forms.Label PostLabel;
        private System.Windows.Forms.Label SpecializationsLabel;
        private System.Windows.Forms.Label Specializations;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.Label Snils;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Birthday;
    }
}