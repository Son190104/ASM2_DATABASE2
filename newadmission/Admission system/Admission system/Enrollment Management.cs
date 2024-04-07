using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Admission_system
{
    public partial class Enrollment_Management : Form
    {
        private int selectedRowIndex = -1; // Biến lưu chỉ số hàng được chọn
        

        public Enrollment_Management()
        {
            InitializeComponent();
            LoadData();
            GetData();
        }
        private void GetData()
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Enrollment_code AS ID, Student_code AS STUDENTCODE, Major_code AS MAJORCODE FROM Enrollment";

                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                using (SqlCommand command = sqlCommand)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Bind data to DataGridView
                    dataGridView1.DataSource = dataTable;

                }

            }
        }
        private void LoadData()
        {
            // Khởi tạo kết nối
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Truy vấn để lấy danh sách ngành học
                string query = "SELECT Major_code FROM Major ";
                SqlCommand command = new SqlCommand(query, connection);

                // Sử dụng SqlDataReader để đọc dữ liệu
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Đọc từng dòng dữ liệu và thêm vào ComboBox
                    while (reader.Read())
                    {
                        comboBoxMajor.Items.Add(reader["Major_code"].ToString());

                    }
                }

            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy chỉ số hàng được chọn
                selectedRowIndex = e.RowIndex;

                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Hiển thị dữ liệu của hàng được chọn lên các ô nhập liệu
                txtEnrollmentCode.Text = selectedRow.Cells["ID"].Value.ToString();
                txtStudentCode.Text = selectedRow.Cells["STUDENTCODE"].Value.ToString();
                comboBoxMajor.SelectedItem = selectedRow.Cells["MAJORCODE"].Value.ToString();

                // Đổi nút "Create" thành "Update"
                button1.Text = "Update";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID của hàng được chọn từ cột đầu tiên trong DataGridView
                int enrollmentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Xoá bản ghi tương ứng trong cơ sở dữ liệu
                string deleteQuery = "DELETE FROM Enrollment WHERE Enrollment_code = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", enrollmentId);
                        command.ExecuteNonQuery();
                    }
                }

                // Xoá hàng được chọn từ DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string enrollmentcode = txtEnrollmentCode.Text;
            string studentcode = txtStudentCode.Text;
            string majorcode = comboBoxMajor.SelectedItem.ToString();

            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (button1.Text == "Create")
                {
                    // Thêm mới
                    string insertQuery = "INSERT INTO Enrollment (Enrollment_code, Student_code, Major_code) " +
                                         "VALUES (@ID, @StudentCode, @MajorCode)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", enrollmentcode);
                        command.Parameters.AddWithValue("@StudentCode", studentcode);
                        command.Parameters.AddWithValue("@MajorCode", majorcode);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully.");
                }
                else if (button1.Text == "Update" && selectedRowIndex >= 0)
                {
                    // Cập nhật
                    string updateQuery = "UPDATE Enrollment SET Enrollment_code = @ID, Student_code = @StudentCode, " +
                                         "Major_code = @MajorCode" +
                                         "WHERE Enrollment_code = @ID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EnrollmentCode", enrollmentcode);
                        command.Parameters.AddWithValue("@StudentCode", studentcode);
                        command.Parameters.AddWithValue("@MajorCode", majorcode);
                        command.Parameters.AddWithValue("@ID", dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully.");
                }
                // Clear input fields after insertion/update
                txtEnrollmentCode.Text = "";
                txtStudentCode.Text = "";



                // Đổi nút "Update" thành "Create"
                button1.Text = "Create";

                // Refresh data in DataGridView
                GetData();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }

        private void Enrollment_Management_Load(object sender, EventArgs e)
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



