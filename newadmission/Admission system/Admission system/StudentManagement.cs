using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Admission_system
{
    public partial class StudentManagement : Form
    {
        string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
        private int selectedRowIndex = -1; // Biến lưu chỉ số hàng được chọn
        private object sex;

        public StudentManagement()
        {
            InitializeComponent();
            GetData();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            // Gắn sự kiện CellClick cho DataGridView
            dataGridView1.CellClick += dataGridView1_CellClick;
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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy chỉ số hàng được chọn
                selectedRowIndex = e.RowIndex;

                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                // Hiển thị dữ liệu của hàng được chọn lên các ô nhập liệu
                txtFullname.Text = selectedRow.Cells["FULLNAME"].Value.ToString();
                txtCode.Text = selectedRow.Cells["CODE"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["EMAIL"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["PHONE"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["ADDRESS"].Value.ToString();


                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["DATEBIRTH"].Value);

                // Đổi nút "Create" thành "Update"
                button1.Text = "Update";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string code = txtCode.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            DateTime birthDate = dateTimePicker1.Value;
            // Lấy giá trị của CheckBox Nam và Nữ
            string sex = "";
            if (chkMale.Checked)
            {
                sex = "Male";

            }
            else if (chkFemale.Checked)
            {
                sex = "Female";

            }

            if (!DateTime.TryParse(dateTimePicker1.Text, out birthDate))
            {
                MessageBox.Show("Invalid birth date format. Please enter the birth date in correct format (YYYY-MM-DD).");
                return;
            }

            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (button1.Text == "Create")
                {
                    // Thêm mới
                    string insertQuery = "INSERT INTO Student (Student_name, Student_code, Phone_number, Email, Date_birth,Sex, Address) " +
                                         "VALUES (@FullName, @Code, @Phone, @Email, @BirthDate,@Sex, @Address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullname);
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@Sex", sex);
                        string sexValue = "";
                        if (chkMale.Checked)
                        {
                            sexValue = "Male";


                        }
                        else if (chkFemale.Checked)
                        {
                            sexValue = "Female";

                        }


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully.");
                }
                else if (button1.Text == "Update" && selectedRowIndex >= 0)
                {
                    // Cập nhật
                    string updateQuery = "UPDATE Student SET Student_name = @FullName, Student_code = @Code, " +
                                         "Phone_number = @Phone, Email = @Email, Date_birth = @BirthDate, Address = @Address, Sex = @UpdateSex " +
                                         "WHERE Student_code = @SelectedCode";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullname);
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@BirthDate", birthDate);
                        command.Parameters.AddWithValue("@SelectedCode", dataGridView1.Rows[selectedRowIndex].Cells["CODE"].Value.ToString());
                        command.Parameters.AddWithValue("@UpdateSex", sex);
                        command.ExecuteNonQuery();
                        string sexValue = "";
                        if (chkMale.Checked)
                        {
                            sexValue = "Male";
                        }
                        else if (chkFemale.Checked)
                        {
                            sexValue = "Female";
                        }
                        command.Parameters.AddWithValue("@Sex", sexValue);

                        command.ExecuteNonQuery();

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully.");
                }

                // Clear input fields after insertion/update
                txtFullname.Text = "";
                txtCode.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";

                // Đổi nút "Update" thành "Create"
                button1.Text = "Create";

                // Refresh data in DataGridView
                GetData();
            }
        }



        private void GetData()
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Student_name AS FULLNAME, Student_code AS CODE, Email, Phone_number AS PHONE, Address, Date_birth AS DATEBIRTH, Sex AS Sex FROM Student";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    // Bind data to DataGridView
                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy ID của hàng được chọn từ cột đầu tiên trong DataGridView
                string studentCode = dataGridView1.SelectedRows[0].Cells["CODE"].Value.ToString();

                // Kiểm tra có tham chiếu trong bảng khác không
                string checkReferencesQuery = "SELECT COUNT(*) FROM Enrollment WHERE Student_code = @Code";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand checkCommand = new SqlCommand(checkReferencesQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Code", studentCode);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This student has references in other tables. Please delete the references first.");
                            return;
                        }
                    }

                    // Nếu không có tham chiếu, tiến hành xóa sinh viên
                    string deleteQuery = "DELETE FROM Student WHERE Student_code = @Code";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Code", studentCode);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student deleted successfully.");

                                // Xoá hàng được chọn từ DataGridView
                                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("No student was deleted.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting student: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }

    }
}

