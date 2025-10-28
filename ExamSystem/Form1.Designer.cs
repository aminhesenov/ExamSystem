namespace ExamSystem
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label5 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            maskedTextBox6 = new MaskedTextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            nameSurname = new DataGridViewTextBoxColumn();
            studentID = new DataGridViewTextBoxColumn();
            result = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(367, 35);
            label1.Name = "label1";
            label1.Size = new Size(303, 34);
            label1.TabIndex = 1;
            label1.Text = "Imtahan sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 124);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "SDF 1: ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(85, 124);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(46, 23);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(85, 176);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(46, 23);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.ValidatingType = typeof(int);
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 176);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "SDF 2: ";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(85, 232);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(46, 23);
            maskedTextBox3.TabIndex = 6;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 235);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 5;
            label4.Text = "FF: ";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(85, 285);
            maskedTextBox4.Mask = "00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(46, 23);
            maskedTextBox4.TabIndex = 8;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 285);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 7;
            label5.Text = "Seminar: ";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(85, 337);
            maskedTextBox5.Mask = "00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(46, 23);
            maskedTextBox5.TabIndex = 10;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 337);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 9;
            label6.Text = "Final: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ad və soyad";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(maskedTextBox6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(164, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 236);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tələbənin məlumatları";
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(20, 184);
            button2.Name = "button2";
            button2.Size = new Size(174, 30);
            button2.TabIndex = 14;
            button2.Text = "Xanaları sıfırla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(20, 135);
            button1.Name = "button1";
            button1.Size = new Size(174, 30);
            button1.TabIndex = 13;
            button1.Text = "Hesabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(20, 83);
            maskedTextBox6.Mask = "000000000";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(174, 23);
            maskedTextBox6.TabIndex = 12;
            maskedTextBox6.ValidatingType = typeof(int);
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(670, 380);
            button3.Name = "button3";
            button3.Size = new Size(70, 29);
            button3.TabIndex = 13;
            button3.Text = "Çıxış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameSurname, studentID, result });
            dataGridView1.Location = new Point(396, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 231);
            dataGridView1.TabIndex = 14;
            // 
            // nameSurname
            // 
            nameSurname.HeaderText = "Ad və soyad";
            nameSurname.Name = "nameSurname";
            // 
            // studentID
            // 
            studentID.HeaderText = "Tələbə nömrəsi";
            studentID.Name = "studentID";
            // 
            // result
            // 
            result.HeaderText = "Nəticə";
            result.Name = "result";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(766, 421);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox5);
            Controls.Add(label6);
            Controls.Add(maskedTextBox4);
            Controls.Add(label5);
            Controls.Add(maskedTextBox3);
            Controls.Add(label4);
            Controls.Add(maskedTextBox2);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam system";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox4;
        private Label label5;
        private MaskedTextBox maskedTextBox5;
        private Label label6;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private MaskedTextBox maskedTextBox6;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameSurname;
        private DataGridViewTextBoxColumn studentID;
        private DataGridViewTextBoxColumn result;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ToolTip toolTip1;
        private NotifyIcon notifyIcon1;
    }
}
