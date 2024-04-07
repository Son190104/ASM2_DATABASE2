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
    public partial class Information_Management : Form
    {

        public Information_Management()
        {
            InitializeComponent();
            GetData();
        }

        private string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentcode = txtStudentcode.Text;

            string query = "SELECT " +
                           "P.Parent_code, " +
                           "P.Student_code AS Parent_Student_code, " +
                           "P.Parent_name, " +
                           "P.Phone_number AS Parent_Phone, " +
                           "P.Email AS Parent_Email, " +
                           "P.Address AS Parent_Address, " +
                           "S.Student_code AS Student_Student_code, " +
                           "S.Student_name, " +
                           "S.Date_birth, " +
                           "S.Phone_number AS Student_Phone_number, " +
                           "S.Email AS Student_Email, " +
                           "S.Address AS Student_Address, " +
                           "S.Sex " +
                           "FROM Student S " +
                           "JOIN Parent P ON S.Student_code = P.Student_code " +
                           "WHERE S.Student_code = @Studentcode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Studentcode", studentcode);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    // Bind data to DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void GetData()
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Truy vấn để lấy thông tin học sinh và thông tin phụ huynh
                string selectQuery = "SELECT " +
                           "P.Parent_code, " +
                           "P.Student_code AS Parent_Student_code, " +
                           "P.Parent_name, " +
                           "P.Phone_number AS Parent_Phone, " +
                           "P.Email AS Parent_Email, " +
                           "P.Address AS Parent_Address, " +
                           "S.Student_code AS Student_Student_code, " +
                           "S.Student_name, " +
                           "S.Date_birth, " +
                           "S.Phone_number AS Student_Phone_number, " +
                           "S.Email AS Student_Email, " +
                           "S.Address AS Student_Address, " +
                           "S.Sex " +
                           "FROM Student S " +
                           "JOIN Parent P ON S.Student_code = P.Student_code " +
                           "WHERE S.Student_code = @Studentcode";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Bind data to DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }

        private void Information_Management_Load(object sender, EventArgs e)
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
        }
    }
}
