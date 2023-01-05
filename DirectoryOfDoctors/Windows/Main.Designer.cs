namespace DirectoryOfDoctors
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SetIconsFromForm()
        {
            this.FilterButton.Image = System.Drawing.Image.FromFile(new DirectoryOfDoctors.Classes.PhotoDB.SaverFilesFromDB("Icons", System.IO.Directory.GetCurrentDirectory(), "icons", "filter.png", "Кнопка фильтра").GetFilePath());
            this.FinderButton.Image = System.Drawing.Image.FromFile(new DirectoryOfDoctors.Classes.PhotoDB.SaverFilesFromDB("Icons", System.IO.Directory.GetCurrentDirectory(), "icons", "finder.png", "Кнопка поиска").GetFilePath());
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Close_Label = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.AllSelectButton = new System.Windows.Forms.Button();
            this.DeleteDoctorButton = new System.Windows.Forms.Button();
            this.ChangeDoctorButton = new System.Windows.Forms.Button();
            this.PostsListButton = new System.Windows.Forms.Button();
            this.SpecializationsListButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.DoctorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinderButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.FindFildTextBox = new System.Windows.Forms.TextBox();
            this.Title_Panel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Title_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_Panel.Controls.Add(this.TitleLabel);
            this.Title_Panel.Controls.Add(this.Close_Label);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Panel.Location = new System.Drawing.Point(0, 0);
            this.Title_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(1552, 40);
            this.Title_Panel.TabIndex = 1;
            this.Title_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.Title_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(664, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(211, 27);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Справочник врачей";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // Close_Label
            // 
            this.Close_Label.AutoSize = true;
            this.Close_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Label.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Label.ForeColor = System.Drawing.Color.White;
            this.Close_Label.Location = new System.Drawing.Point(1524, 0);
            this.Close_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close_Label.Name = "Close_Label";
            this.Close_Label.Size = new System.Drawing.Size(26, 28);
            this.Close_Label.TabIndex = 0;
            this.Close_Label.Text = "X";
            this.Close_Label.Click += new System.EventHandler(this.Close_Label_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 40);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(279, 712);
            this.MenuPanel.TabIndex = 2;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 1;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddDoctorButton, 0, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.AllSelectButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.DeleteDoctorButton, 0, 4);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ChangeDoctorButton, 0, 5);
            this.ButtonsTableLayoutPanel.Controls.Add(this.PostsListButton, 0, 2);
            this.ButtonsTableLayoutPanel.Controls.Add(this.SpecializationsListButton, 0, 3);
            this.ButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 6;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(277, 710);
            this.ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDoctorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.AddDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoctorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDoctorButton.Location = new System.Drawing.Point(38, 155);
            this.AddDoctorButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(200, 49);
            this.AddDoctorButton.TabIndex = 0;
            this.AddDoctorButton.Text = "Добавить доктора";
            this.AddDoctorButton.UseVisualStyleBackColor = true;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // AllSelectButton
            // 
            this.AllSelectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllSelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllSelectButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.AllSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AllSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AllSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllSelectButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSelectButton.Location = new System.Drawing.Point(38, 35);
            this.AllSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.AllSelectButton.Name = "AllSelectButton";
            this.AllSelectButton.Size = new System.Drawing.Size(200, 49);
            this.AllSelectButton.TabIndex = 0;
            this.AllSelectButton.Text = "Выбрать всех";
            this.AllSelectButton.UseVisualStyleBackColor = true;
            this.AllSelectButton.Click += new System.EventHandler(this.AllSelectButton_Click);
            // 
            // DeleteDoctorButton
            // 
            this.DeleteDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDoctorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.DeleteDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DeleteDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDoctorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDoctorButton.Location = new System.Drawing.Point(38, 512);
            this.DeleteDoctorButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteDoctorButton.Name = "DeleteDoctorButton";
            this.DeleteDoctorButton.Size = new System.Drawing.Size(200, 49);
            this.DeleteDoctorButton.TabIndex = 0;
            this.DeleteDoctorButton.Text = "Удалить";
            this.DeleteDoctorButton.UseVisualStyleBackColor = true;
            this.DeleteDoctorButton.Visible = false;
            this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
            // 
            // ChangeDoctorButton
            // 
            this.ChangeDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeDoctorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ChangeDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ChangeDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ChangeDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeDoctorButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeDoctorButton.Location = new System.Drawing.Point(38, 627);
            this.ChangeDoctorButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeDoctorButton.Name = "ChangeDoctorButton";
            this.ChangeDoctorButton.Size = new System.Drawing.Size(200, 49);
            this.ChangeDoctorButton.TabIndex = 0;
            this.ChangeDoctorButton.Text = "Изменить данные";
            this.ChangeDoctorButton.UseVisualStyleBackColor = true;
            this.ChangeDoctorButton.Visible = false;
            this.ChangeDoctorButton.Click += new System.EventHandler(this.ChangeDoctorButton_Click);
            // 
            // PostsListButton
            // 
            this.PostsListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PostsListButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.PostsListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PostsListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PostsListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostsListButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostsListButton.Location = new System.Drawing.Point(38, 266);
            this.PostsListButton.Margin = new System.Windows.Forms.Padding(4);
            this.PostsListButton.Name = "PostsListButton";
            this.PostsListButton.Size = new System.Drawing.Size(200, 68);
            this.PostsListButton.TabIndex = 1;
            this.PostsListButton.Text = "Список должностей";
            this.PostsListButton.UseVisualStyleBackColor = true;
            this.PostsListButton.Click += new System.EventHandler(this.PostsListButton_Click);
            // 
            // SpecializationsListButton
            // 
            this.SpecializationsListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpecializationsListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpecializationsListButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SpecializationsListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SpecializationsListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SpecializationsListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpecializationsListButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecializationsListButton.Location = new System.Drawing.Point(38, 384);
            this.SpecializationsListButton.Margin = new System.Windows.Forms.Padding(4);
            this.SpecializationsListButton.Name = "SpecializationsListButton";
            this.SpecializationsListButton.Size = new System.Drawing.Size(200, 71);
            this.SpecializationsListButton.TabIndex = 2;
            this.SpecializationsListButton.Text = "Список специальностей";
            this.SpecializationsListButton.UseVisualStyleBackColor = true;
            this.SpecializationsListButton.Click += new System.EventHandler(this.SpecializationsListButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.DoctorTableLayoutPanel);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContentPanel.Location = new System.Drawing.Point(279, 74);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1273, 678);
            this.ContentPanel.TabIndex = 3;
            // 
            // DoctorTableLayoutPanel
            // 
            this.DoctorTableLayoutPanel.AutoScroll = true;
            this.DoctorTableLayoutPanel.ColumnCount = 3;
            this.DoctorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.DoctorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.DoctorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.DoctorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.DoctorTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DoctorTableLayoutPanel.Name = "DoctorTableLayoutPanel";
            this.DoctorTableLayoutPanel.RowCount = 3;
            this.DoctorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.DoctorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.DoctorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.DoctorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoctorTableLayoutPanel.Size = new System.Drawing.Size(1271, 676);
            this.DoctorTableLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FinderButton);
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.FindFildTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(279, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 2, 3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.panel1.Size = new System.Drawing.Size(1273, 34);
            this.panel1.TabIndex = 4;
            // 
            // FinderButton
            // 
            this.FinderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FinderButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.FinderButton.FlatAppearance.BorderSize = 0;
            this.FinderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FinderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FinderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinderButton.Location = new System.Drawing.Point(1100, 0);
            this.FinderButton.Margin = new System.Windows.Forms.Padding(0);
            this.FinderButton.Name = "FinderButton";
            this.FinderButton.Size = new System.Drawing.Size(37, 32);
            this.FinderButton.TabIndex = 2;
            this.FinderButton.UseVisualStyleBackColor = true;
            this.FinderButton.Click += new System.EventHandler(this.FinderButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.White;
            this.FilterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FilterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FilterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(1221, 0);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(0);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(37, 32);
            this.FilterButton.TabIndex = 1;
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // FindFildTextBox
            // 
            this.FindFildTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindFildTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FindFildTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindFildTextBox.Location = new System.Drawing.Point(1, 0);
            this.FindFildTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.FindFildTextBox.Name = "FindFildTextBox";
            this.FindFildTextBox.Size = new System.Drawing.Size(1099, 30);
            this.FindFildTextBox.TabIndex = 0;
            this.FindFildTextBox.TextChanged += new System.EventHandler(this.FindFildTextBox_TextChanged);
            this.FindFildTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindFildTextBox_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1552, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Title_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1700, 800);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.Label Close_Label;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button AllSelectButton;
        private System.Windows.Forms.TableLayoutPanel DoctorTableLayoutPanel;
        private System.Windows.Forms.Button DeleteDoctorButton;
        private System.Windows.Forms.Button ChangeDoctorButton;
        private System.Windows.Forms.Button PostsListButton;
        private System.Windows.Forms.Button SpecializationsListButton;
        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button FinderButton;
        public System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox FindFildTextBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

