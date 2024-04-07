namespace Admission_system
{
    partial class StudentManagement
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
            txtFullname = new TextBox();
            txtPhone = new TextBox();
            txtCode = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            txtAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            chkMale = new CheckBox();
            chkFemale = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(271, 82);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(318, 50);
            txtFullname.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(271, 149);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(318, 47);
            txtPhone.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(271, 14);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(318, 50);
            txtCode.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(271, 283);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 50);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 85);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 1;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 154);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 17);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 1;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 286);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(47, 662);
            button1.Name = "button1";
            button1.Size = new Size(167, 80);
            button1.TabIndex = 2;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(271, 662);
            button3.Name = "button3";
            button3.Size = new Size(174, 80);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(751, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1389, 728);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(271, 415);
            txtAddress.Margin = new Padding(5);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(318, 164);
            txtAddress.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(271, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(318, 39);
            dateTimePicker1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 218);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 1;
            label5.Text = "BirthDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 415);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 1;
            label6.Text = "Address";
            // 
            // button2
            // 
            button2.Location = new Point(505, 662);
            button2.Name = "button2";
            button2.Size = new Size(147, 80);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 357);
            label7.Name = "label7";
            label7.Size = new Size(51, 32);
            label7.TabIndex = 8;
            label7.Text = "Sex";
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(271, 357);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(99, 36);
            chkMale.TabIndex = 9;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(466, 357);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(123, 36);
            chkFemale.TabIndex = 10;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // StudentManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(2144, 862);
            Controls.Add(chkFemale);
            Controls.Add(chkMale);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(txtPhone);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtCode);
            Controls.Add(txtFullname);
            Controls.Add(dateTimePicker1);
            Name = "StudentManagement";
            Text = "StudentManagement";
            Load += StudentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private TextBox txtPhone;
        private TextBox txtCode;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private DateTimePicker dateTimePicker1;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label7;
        private CheckBox chkMale;
        private CheckBox chkFemale;
    }
}