namespace Admission_system
{
    partial class Enrollment_Management
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEnrollmentCode = new TextBox();
            txtStudentCode = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBoxMajor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(892, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(702, 768);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 90);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 1;
            label1.Text = "EnrollmentCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 193);
            label2.Name = "label2";
            label2.Size = new Size(153, 32);
            label2.TabIndex = 2;
            label2.Text = "StudentCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 295);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 3;
            label3.Text = "MajorCode";
            // 
            // txtEnrollmentCode
            // 
            txtEnrollmentCode.Location = new Point(370, 90);
            txtEnrollmentCode.Name = "txtEnrollmentCode";
            txtEnrollmentCode.Size = new Size(256, 39);
            txtEnrollmentCode.TabIndex = 4;
            // 
            // txtStudentCode
            // 
            txtStudentCode.Location = new Point(370, 202);
            txtStudentCode.Name = "txtStudentCode";
            txtStudentCode.Size = new Size(256, 39);
            txtStudentCode.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(106, 435);
            button1.Name = "button1";
            button1.Size = new Size(154, 55);
            button1.TabIndex = 7;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(370, 435);
            button2.Name = "button2";
            button2.Size = new Size(156, 55);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(620, 435);
            button3.Name = "button3";
            button3.Size = new Size(161, 55);
            button3.TabIndex = 9;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBoxMajor
            // 
            comboBoxMajor.FormattingEnabled = true;
            comboBoxMajor.Location = new Point(370, 295);
            comboBoxMajor.Name = "comboBoxMajor";
            comboBoxMajor.Size = new Size(256, 40);
            comboBoxMajor.TabIndex = 10;
            // 
            // Enrollment_Management
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1603, 788);
            Controls.Add(comboBoxMajor);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtStudentCode);
            Controls.Add(txtEnrollmentCode);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Enrollment_Management";
            Text = "Enrollment_Management";
            Load += Enrollment_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEnrollmentCode;
        private TextBox txtStudentCode;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBoxMajor;
    }
}