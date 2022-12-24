namespace DirectoryOfDoctors.Windows
{
    partial class SelectorSpecializations
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
            this.Close_Label = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TitlePanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.Close_Label);
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
            this.TitleLabel.Location = new System.Drawing.Point(303, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(221, 26);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Специальности врача";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleElement_MouseMove);
            // 
            // Close_Label
            // 
            this.Close_Label.AutoSize = true;
            this.Close_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Label.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Label.ForeColor = System.Drawing.Color.White;
            this.Close_Label.Location = new System.Drawing.Point(775, 0);
            this.Close_Label.Name = "Close_Label";
            this.Close_Label.Size = new System.Drawing.Size(25, 27);
            this.Close_Label.TabIndex = 0;
            this.Close_Label.Text = "X";
            this.Close_Label.Click += new System.EventHandler(this.Close_Label_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.SaveChanges);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 375);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(800, 75);
            this.ButtonPanel.TabIndex = 1;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChanges.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.SaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChanges.Location = new System.Drawing.Point(300, 13);
            this.SaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(200, 49);
            this.SaveChanges.TabIndex = 2;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.Specialization});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // Check
            // 
            this.Check.FillWeight = 106.9519F;
            this.Check.HeaderText = "Выбор";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Width = 125;
            // 
            // Specialization
            // 
            this.Specialization.FillWeight = 93.04813F;
            this.Specialization.HeaderText = "Специальность";
            this.Specialization.MinimumWidth = 6;
            this.Specialization.Name = "Specialization";
            this.Specialization.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Specialization.Width = 700;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 335);
            this.panel1.TabIndex = 2;
            // 
            // SelectorSpecializations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectorSpecializations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectorSpecializations";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Close_Label;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
    }
}