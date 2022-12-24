namespace DirectoryOfDoctors.Windows
{
    partial class FilterDoctors
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameRadioButton = new System.Windows.Forms.RadioButton();
            this.LastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.PatronymicRadioButton = new System.Windows.Forms.RadioButton();
            this.PostRadioButton = new System.Windows.Forms.RadioButton();
            this.NoFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.TitlePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.TitlePanel.Size = new System.Drawing.Size(500, 40);
            this.TitlePanel.TabIndex = 0;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(200, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(99, 26);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Фильтры";
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
            this.CloseLabel.Location = new System.Drawing.Point(473, 0);
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
            this.MainPanel.Size = new System.Drawing.Size(500, 250);
            this.MainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FirstNameRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastNameRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatronymicRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PostRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NoFilterRadioButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 248);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FirstNameRadioButton
            // 
            this.FirstNameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameRadioButton.AutoSize = true;
            this.FirstNameRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameRadioButton.Location = new System.Drawing.Point(191, 11);
            this.FirstNameRadioButton.Name = "FirstNameRadioButton";
            this.FirstNameRadioButton.Size = new System.Drawing.Size(115, 26);
            this.FirstNameRadioButton.TabIndex = 0;
            this.FirstNameRadioButton.Text = "По имени";
            this.FirstNameRadioButton.UseVisualStyleBackColor = true;
            this.FirstNameRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // LastNameRadioButton
            // 
            this.LastNameRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameRadioButton.AutoSize = true;
            this.LastNameRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameRadioButton.Location = new System.Drawing.Point(180, 60);
            this.LastNameRadioButton.Name = "LastNameRadioButton";
            this.LastNameRadioButton.Size = new System.Drawing.Size(138, 26);
            this.LastNameRadioButton.TabIndex = 0;
            this.LastNameRadioButton.Text = "По фамилии";
            this.LastNameRadioButton.UseVisualStyleBackColor = true;
            this.LastNameRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // PatronymicRadioButton
            // 
            this.PatronymicRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatronymicRadioButton.AutoSize = true;
            this.PatronymicRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicRadioButton.Location = new System.Drawing.Point(182, 109);
            this.PatronymicRadioButton.Name = "PatronymicRadioButton";
            this.PatronymicRadioButton.Size = new System.Drawing.Size(133, 26);
            this.PatronymicRadioButton.TabIndex = 0;
            this.PatronymicRadioButton.Text = "По отчеству";
            this.PatronymicRadioButton.UseVisualStyleBackColor = true;
            this.PatronymicRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // PostRadioButton
            // 
            this.PostRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PostRadioButton.AutoSize = true;
            this.PostRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostRadioButton.Location = new System.Drawing.Point(172, 158);
            this.PostRadioButton.Name = "PostRadioButton";
            this.PostRadioButton.Size = new System.Drawing.Size(154, 26);
            this.PostRadioButton.TabIndex = 0;
            this.PostRadioButton.Text = "По должности";
            this.PostRadioButton.UseVisualStyleBackColor = true;
            this.PostRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // NoFilterRadioButton
            // 
            this.NoFilterRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NoFilterRadioButton.AutoSize = true;
            this.NoFilterRadioButton.Checked = true;
            this.NoFilterRadioButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoFilterRadioButton.Location = new System.Drawing.Point(177, 209);
            this.NoFilterRadioButton.Name = "NoFilterRadioButton";
            this.NoFilterRadioButton.Size = new System.Drawing.Size(144, 26);
            this.NoFilterRadioButton.TabIndex = 0;
            this.NoFilterRadioButton.TabStop = true;
            this.NoFilterRadioButton.Text = "Без фильтров";
            this.NoFilterRadioButton.UseVisualStyleBackColor = true;
            this.NoFilterRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // FilterDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 290);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilterDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterDoctors";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton FirstNameRadioButton;
        private System.Windows.Forms.RadioButton LastNameRadioButton;
        private System.Windows.Forms.RadioButton PatronymicRadioButton;
        private System.Windows.Forms.RadioButton PostRadioButton;
        private System.Windows.Forms.RadioButton NoFilterRadioButton;
    }
}