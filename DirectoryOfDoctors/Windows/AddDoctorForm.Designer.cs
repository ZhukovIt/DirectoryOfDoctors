namespace DirectoryOfDoctors.Windows
{
    partial class AddDoctorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctorForm));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImageButton = new System.Windows.Forms.Button();
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SnilsTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SnilsTextBox2 = new System.Windows.Forms.TextBox();
            this.SnilsTextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SnilsTextBox4 = new System.Windows.Forms.TextBox();
            this.PostComboBox = new System.Windows.Forms.ComboBox();
            this.SpecializationsClicker = new System.Windows.Forms.Label();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.ValidationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPhoto)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationError)).BeginInit();
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
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(600, 33);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(220, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(175, 21);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Добавление доктора";
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
            this.CloseLabel.Location = new System.Drawing.Point(577, 0);
            this.CloseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(21, 22);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // AddDoctor
            // 
            this.AddDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDoctor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.AddDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoctor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDoctor.Location = new System.Drawing.Point(319, 314);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(150, 40);
            this.AddDoctor.TabIndex = 1;
            this.AddDoctor.Text = "Добавить доктора";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(600, 374);
            this.MainPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AddDoctor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImageButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DoctorPhoto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ImageButton
            // 
            this.ImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImageButton.Location = new System.Drawing.Point(35, 306);
            this.ImageButton.Name = "ImageButton";
            this.ImageButton.Size = new System.Drawing.Size(117, 56);
            this.ImageButton.TabIndex = 1;
            this.ImageButton.Text = "Вставка изображения";
            this.ImageButton.UseVisualStyleBackColor = true;
            this.ImageButton.Click += new System.EventHandler(this.ImageButton_Click);
            // 
            // DoctorPhoto
            // 
            this.DoctorPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoctorPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorPhoto.Image = ((System.Drawing.Image)(resources.GetObject("DoctorPhoto.Image")));
            this.DoctorPhoto.Location = new System.Drawing.Point(15, 58);
            this.DoctorPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel2.Controls.Add(this.FirstNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PatronymicTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LastNameTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.SexComboBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.BirthdayDateTimePicker, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.PostComboBox, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.SpecializationsClicker, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(190, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(408, 293);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLabel.Location = new System.Drawing.Point(92, 8);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(40, 19);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // PatronymicLabel
            // 
            this.PatronymicLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PatronymicLabel.AutoSize = true;
            this.PatronymicLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicLabel.Location = new System.Drawing.Point(56, 44);
            this.PatronymicLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PatronymicLabel.Name = "PatronymicLabel";
            this.PatronymicLabel.Size = new System.Drawing.Size(76, 19);
            this.PatronymicLabel.TabIndex = 1;
            this.PatronymicLabel.Text = "Отчество:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(57, 80);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(75, 19);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // SexLabel
            // 
            this.SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexLabel.Location = new System.Drawing.Point(93, 116);
            this.SexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(39, 19);
            this.SexLabel.TabIndex = 3;
            this.SexLabel.Text = "Пол:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayLabel.Location = new System.Drawing.Point(17, 152);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(115, 19);
            this.BirthdayLabel.TabIndex = 4;
            this.BirthdayLabel.Text = "Дата рождения:";
            // 
            // SnilsLabel
            // 
            this.SnilsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SnilsLabel.AutoSize = true;
            this.SnilsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsLabel.Location = new System.Drawing.Point(76, 188);
            this.SnilsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SnilsLabel.Name = "SnilsLabel";
            this.SnilsLabel.Size = new System.Drawing.Size(56, 19);
            this.SnilsLabel.TabIndex = 5;
            this.SnilsLabel.Text = "Снилс:";
            // 
            // PostLabel
            // 
            this.PostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PostLabel.AutoSize = true;
            this.PostLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostLabel.Location = new System.Drawing.Point(44, 224);
            this.PostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostLabel.Name = "PostLabel";
            this.PostLabel.Size = new System.Drawing.Size(88, 19);
            this.PostLabel.TabIndex = 6;
            this.PostLabel.Text = "Должность:";
            // 
            // SpecializationsLabel
            // 
            this.SpecializationsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpecializationsLabel.AutoSize = true;
            this.SpecializationsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationsLabel.Location = new System.Drawing.Point(13, 263);
            this.SpecializationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpecializationsLabel.Name = "SpecializationsLabel";
            this.SpecializationsLabel.Size = new System.Drawing.Size(119, 19);
            this.SpecializationsLabel.TabIndex = 7;
            this.SpecializationsLabel.Text = "Специальности:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(158, 5);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(226, 26);
            this.FirstNameTextBox.TabIndex = 8;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatronymicTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(158, 41);
            this.PatronymicTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(226, 26);
            this.PatronymicTextBox.TabIndex = 9;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(158, 77);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(226, 26);
            this.LastNameTextBox.TabIndex = 10;
            // 
            // SexComboBox
            // 
            this.SexComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SexComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SexComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.SexComboBox.Location = new System.Drawing.Point(158, 112);
            this.SexComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(226, 27);
            this.SexComboBox.TabIndex = 11;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthdayDateTimePicker.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(158, 149);
            this.BirthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(226, 26);
            this.BirthdayDateTimePicker.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.Controls.Add(this.SnilsTextBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.SnilsTextBox2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.SnilsTextBox3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.SnilsTextBox4, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(136, 182);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(270, 32);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // SnilsTextBox1
            // 
            this.SnilsTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SnilsTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsTextBox1.Location = new System.Drawing.Point(0, 3);
            this.SnilsTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.SnilsTextBox1.MaxLength = 3;
            this.SnilsTextBox1.Name = "SnilsTextBox1";
            this.SnilsTextBox1.Size = new System.Drawing.Size(60, 26);
            this.SnilsTextBox1.TabIndex = 0;
            this.SnilsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SnilsTextBox1.TextChanged += new System.EventHandler(this.SnilsTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(62, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // SnilsTextBox2
            // 
            this.SnilsTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SnilsTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsTextBox2.Location = new System.Drawing.Point(75, 3);
            this.SnilsTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.SnilsTextBox2.MaxLength = 3;
            this.SnilsTextBox2.Name = "SnilsTextBox2";
            this.SnilsTextBox2.Size = new System.Drawing.Size(56, 26);
            this.SnilsTextBox2.TabIndex = 0;
            this.SnilsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SnilsTextBox2.TextChanged += new System.EventHandler(this.SnilsTextBox2_TextChanged);
            // 
            // SnilsTextBox3
            // 
            this.SnilsTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SnilsTextBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsTextBox3.Location = new System.Drawing.Point(148, 3);
            this.SnilsTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.SnilsTextBox3.MaxLength = 3;
            this.SnilsTextBox3.Name = "SnilsTextBox3";
            this.SnilsTextBox3.Size = new System.Drawing.Size(56, 26);
            this.SnilsTextBox3.TabIndex = 0;
            this.SnilsTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SnilsTextBox3.TextChanged += new System.EventHandler(this.SnilsTextBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // SnilsTextBox4
            // 
            this.SnilsTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SnilsTextBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SnilsTextBox4.Location = new System.Drawing.Point(210, 3);
            this.SnilsTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.SnilsTextBox4.MaxLength = 2;
            this.SnilsTextBox4.Name = "SnilsTextBox4";
            this.SnilsTextBox4.Size = new System.Drawing.Size(56, 26);
            this.SnilsTextBox4.TabIndex = 0;
            this.SnilsTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PostComboBox
            // 
            this.PostComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostComboBox.FormattingEnabled = true;
            this.PostComboBox.Location = new System.Drawing.Point(158, 220);
            this.PostComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(226, 27);
            this.PostComboBox.TabIndex = 14;
            // 
            // SpecializationsClicker
            // 
            this.SpecializationsClicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpecializationsClicker.AutoSize = true;
            this.SpecializationsClicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecializationsClicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationsClicker.ForeColor = System.Drawing.Color.Blue;
            this.SpecializationsClicker.Location = new System.Drawing.Point(237, 263);
            this.SpecializationsClicker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpecializationsClicker.Name = "SpecializationsClicker";
            this.SpecializationsClicker.Size = new System.Drawing.Size(67, 19);
            this.SpecializationsClicker.TabIndex = 15;
            this.SpecializationsClicker.Text = "Выбрать";
            this.SpecializationsClicker.Click += new System.EventHandler(this.SpecializationsClicker_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.FileName = "openFileDialog1";
            // 
            // ValidationError
            // 
            this.ValidationError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ValidationError.ContainerControl = this;
            this.ValidationError.RightToLeft = true;
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDoctorForm";
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddDoctor;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ImageButton;
        private System.Windows.Forms.OpenFileDialog OpenImage;
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
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox SnilsTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SnilsTextBox2;
        private System.Windows.Forms.TextBox SnilsTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SnilsTextBox4;
        private System.Windows.Forms.ComboBox PostComboBox;
        private System.Windows.Forms.Label SpecializationsClicker;
        private System.Windows.Forms.ErrorProvider ValidationError;
    }
}