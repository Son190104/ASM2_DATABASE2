using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission_system
{
    public partial class MajorManagement : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataSet dataSet;

        public MajorManagement()
        {
            InitializeComponent();
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            connection = new SqlConnection(connectionString);
            dataSet = new DataSet();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                connection.Open();
                // Lấy thông tin về ngành học và các môn học của ngành đó
                string query = "SELECT Major.Major_code, Major.Major_name, Subject.Subject_code, Subject.Subject_name " +
                               "FROM Major " +
                               "INNER JOIN Subject ON Major.Major_code = Subject.Major_code";
                adapter = new SqlDataAdapter(query, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "MajorSubject");

                // Hiển thị thông tin các ngành học và các môn học trong DataGridView
                // Hiển thị thông tin các ngành học và các môn học trong DataGridView
                dataGridView1.DataSource = dataSet.Tables["MajorSubject"]; // Set DataSource của DataGridView bằng DataTable trong DataSet


                connection.Close();

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi: ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }

        private void MajorManagement_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            // Set the form's location to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadData();

        }

    }
}
