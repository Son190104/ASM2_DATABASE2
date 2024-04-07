namespace Admission_system
{
    partial class ParentManagement
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
            ParentCode = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtParentcode = new TextBox();
            txtStudentcode = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            txtPhone = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ParentCode
            // 
            ParentCode.AutoSize = true;
            ParentCode.Location = new Point(90, 48);
            ParentCode.Name = "ParentCode";
            ParentCode.Size = new Size(137, 32);
            ParentCode.TabIndex = 0;
            ParentCode.Text = "ParentCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 148);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 0;
            label2.Text = "StudentCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 245);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 0;
            label3.Text = "Fullname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 348);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 541);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 0;
            label6.Text = "Address";
            // 
            // txtParentcode
            // 
            txtParentcode.Location = new Point(282, 48);
            txtParentcode.Multiline = true;
            txtParentcode.Name = "txtParentcode";
            txtParentcode.Size = new Size(321, 46);
            txtParentcode.TabIndex = 1;
            // 
            // txtStudentcode
            // 
            txtStudentcode.Location = new Point(282, 148);
            txtStudentcode.Multiline = true;
            txtStudentcode.Name = "txtStudentcode";
            txtStudentcode.Size = new Size(321, 46);
            txtStudentcode.TabIndex = 1;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(282, 245);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(321, 47);
            txtFullname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(282, 348);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(321, 47);
            txtEmail.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(282, 541);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(321, 152);
            txtAddress.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(764, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1328, 714);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(72, 736);
            button1.Name = "button1";
            button1.Size = new Size(169, 57);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(306, 736);
            button3.Name = "button3";
            button3.Size = new Size(183, 57);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 451);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 0;
            label1.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(282, 451);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(321, 45);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(548, 736);
            button2.Name = "button2";
            button2.Size = new Size(172, 57);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ParentManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(2092, 852);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(txtStudentcode);
            Controls.Add(txtParentcode);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ParentCode);
            Name = "ParentManagement";
            Text = "ParentManagement";
            Load += ParentManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ParentCode;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtParentcode;
        private TextBox txtStudentcode;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Label label1;
        private TextBox txtPhone;
        private Button button2;
    }
}