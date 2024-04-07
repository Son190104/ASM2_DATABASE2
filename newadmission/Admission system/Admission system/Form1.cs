namespace Admission_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Calculate the center position of the screen
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;
            // set the form's lacation to center screen
            this.Location = new Point(left, top);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            if (txtusername.Text == "Sonpt0407@gmail.com" && txtpassword.Text == "123456")
            {
                mainForm main = new mainForm();
                main.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Login unsuccessful. Please check your login information again");

            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Close();

        }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {
            this.txtpassword.PasswordChar = '*';
        }
    }
}