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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Admission_system
{
    public partial class ParentManagement : Form
    {
        private int selectedRowIndex = -1;
        public ParentManagement()
        {
            InitializeComponent();
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string parentcode = txtParentcode.Text;
            string studentcode = txtStudentcode.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (button1.Text == "Create")
                {
                    // Thêm mới
                    string insertQuery = "INSERT INTO Parent (Parent_name, Parent_code, Student_code, Phone_number, Email, Address) " +
                                         "VALUES (@FullName, @Parentcode, @Studentcode , @Phone, @Email, @Address)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullname);
                        command.Parameters.AddWithValue("@Parentcode", parentcode);
                        command.Parameters.AddWithValue("@Studentcode", studentcode);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data inserted successfully.");
                }
                else if (button1.Text == "Update" && selectedRowIndex >= 0)
                {
                    // Cập nhật
                    string updateQuery = "UPDATE Parent SET Parent_name = @FullName, Parent_code = @Parentcode, " +
                                         "Phone_number = @Phone, Email = @Email, Address = @Address " +
                                         "WHERE Parent_code = @SelectedCode";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullname);
                        command.Parameters.AddWithValue("@Parentcode", parentcode);
                        command.Parameters.AddWithValue("@Studentcode", studentcode);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@SelectedCode", dataGridView1.Rows[selectedRowIndex].Cells["ParentCode"].Value.ToString());


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully.");
                }

                // Clear input fields after insertion/update
                txtFullname.Text = "";
                txtParentcode.Text = "";
                txtStudentcode.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";

                // Đổi nút "Update" thành "Create"
                button1.Text = "Create";

                // Refresh data in DataGridView
                GetData();
            }

        }

        private void ParentManagement_Load(object sender, EventArgs e)
        {
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
                txtParentcode.Text = selectedRow.Cells["PARENTCODE"].Value.ToString();
                txtStudentcode.Text = selectedRow.Cells["STUDENTCODE"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["EMAIL"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["PHONE"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["ADDRESS"].Value.ToString();



                // Đổi nút "Create" thành "Update"
                button1.Text = "Update";
            }
        }
        private void GetData()
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Parent_name AS FULLNAME, Parent_code AS PARENTCODE, Student_code AS STUDENTCODE, Email, Phone_number AS PHONE, Address FROM Parent";

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=SON\MSSQLSERVER01;Initial Catalog=BTEC-Database;Integrated Security=True;Max Pool Size=100;";
            // Check if a row is selected
            if (selectedRowIndex < 0 || selectedRowIndex >= dataGridView1.Rows.Count)
            {
                MessageBox.Show("Please select a parent to delete.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Parent WHERE Parent_code = @Code";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    try
                    {
                        // Get the parent code from the selected row
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                        string parentCode = selectedRow.Cells["PARENTCODE"].Value.ToString();

                        // Add parameters
                        command.Parameters.AddWithValue("@Code", parentCode);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Parent deleted successfully.");
                            // Refresh data in DataGridView
                            GetData();
                        }
                        else
                        {
                            MessageBox.Show("No parent was deleted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting parent: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.ShowDialog();
        }
    }
}
