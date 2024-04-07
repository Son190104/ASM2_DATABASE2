namespace Admission_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            btnlogin = new Button();
            btnexit = new Button();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(963, 394);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(963, 210);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.Black;
            btnlogin.Location = new Point(963, 567);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(150, 46);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.ForeColor = Color.Black;
            btnexit.Location = new Point(1193, 567);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(150, 46);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.SeaShell;
            txtpassword.Location = new Point(963, 462);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.RightToLeft = RightToLeft.No;
            txtpassword.Size = new Size(380, 58);
            txtpassword.TabIndex = 8;
            txtpassword.TextChanged += txtpassword_TextChanged_1;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.SeaShell;
            txtusername.Location = new Point(963, 285);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(380, 56);
            txtusername.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSalmon;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 848);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.How_to_Apply_For_College_of_Education_2021_Admission_1_1_;
            pictureBox1.Location = new Point(140, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1046, 73);
            label3.Name = "label3";
            label3.Size = new Size(356, 93);
            label3.TabIndex = 10;
            label3.Text = "welcom";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            CancelButton = btnlogin;
            ClientSize = new Size(1644, 851);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnexit);
            Controls.Add(txtpassword);
            Controls.Add(btnlogin);
            Controls.Add(txtusername);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = Color.SeaShell;
            Name = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnlogin;
        private Button btnexit;
        private TextBox txtpassword;
        private TextBox txtusername;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}