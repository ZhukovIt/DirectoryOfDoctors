using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DirectoryOfDoctors.Classes;

namespace DirectoryOfDoctors.Windows
{
    public partial class PostsList : Form
    {
        private Main MainWindow;
        private Point LastPoint;
        private string connectionString;
        private string sqlOrder;
        private DataSet ds;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder sqlCommandBuilder;

        public PostsList(Main mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
            connectionString = ConnectionString.GetDirectoryOfDoctorsConnectionString();
            sqlOrder = "SELECT p.id as Номер, p.post as Должность FROM posts as p;";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlOrder, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns["Номер"].ReadOnly = true;
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

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRowCollection rows = ds.Tables[0].Rows;
            int LastIndex = (int)rows[rows.Count - 1][0];
            DataRow row = ds.Tables[0].NewRow();
            rows.Add(row);
            row[0] = LastIndex + 1;
            row[1] = "";
            Console.WriteLine(dataGridView1.Size);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlOrder, connection);
                sqlCommandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("sp_CreatePost", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 0, "Номер"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@post", SqlDbType.NVarChar, 100, "Должность"));

                adapter.Update(ds);

                MainWindow.UpdateAllDoctors();
                Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }    
        }
    }
}
