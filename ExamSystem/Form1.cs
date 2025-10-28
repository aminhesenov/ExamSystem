namespace ExamSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(maskedTextBox1, "0-10 arasında qiymət daxil edin");
            toolTip1.SetToolTip(maskedTextBox2, "0-10 arasında qiymət daxil edin");
            toolTip1.SetToolTip(maskedTextBox3, "0-10 arasında qiymət daxil edin");
            toolTip1.SetToolTip(maskedTextBox4, "0-20 arasında qiymət daxil edin");
            toolTip1.SetToolTip(maskedTextBox5, "0-50 arasında qiymət daxil edin");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(maskedTextBox1, "Qiymət daxil edin");
            errorProvider2.SetError(maskedTextBox2, "Qiymət daxil edin");
            errorProvider3.SetError(maskedTextBox3, "Qiymət daxil edin");
            errorProvider4.SetError(maskedTextBox4, "Qiymət daxil edin");
            errorProvider5.SetError(maskedTextBox5, "Qiymət daxil edin");
            errorProvider6.SetError(textBox1, "Ad və soyad daxil edin");
            errorProvider7.SetError(maskedTextBox6, "Tələbə nömrəsini daxil edin");

            if (maskedTextBox1.Text != "" || maskedTextBox2.Text != ""
                 || maskedTextBox3.Text != "" || maskedTextBox4.Text != "" || maskedTextBox5.Text != ""
                  || maskedTextBox6.Text != "" || textBox1.Text != "")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();
                errorProvider4.Clear();
                errorProvider5.Clear();
                errorProvider6.Clear();
                errorProvider7.Clear();

                int sdf1 = Convert.ToInt32(maskedTextBox1.Text);
                int sdf2 = Convert.ToInt32(maskedTextBox2.Text);
                int ff = Convert.ToInt32(maskedTextBox3.Text);
                int s = Convert.ToInt32(maskedTextBox4.Text);
                int final = Convert.ToInt32(maskedTextBox5.Text);

                int sum = sdf1 + sdf2 + ff + s + final;
                if (sum >= 91 && sum <= 100 && final >= 17)
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - A");

                }
                else if (sum >= 81 && sum <= 90 && final >= 17)
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - B");
                }
                else if (sum >= 71 && sum <= 80 && final >= 17)
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - C");
                }
                else if (sum >= 61 && sum <= 70 && final >= 17)
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - D");
                }
                else if (sum >= 51 && sum <= 60 && final >= 17)
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - E");
                }
                else
                {
                    dataGridView1.Rows.Add(textBox1.Text, maskedTextBox6.Text, sum + " - F");
                }
                notifyIcon1.BalloonTipTitle = "Uğurlu Əməliyyat";
                notifyIcon1.BalloonTipText = "Tələbə məlumatları əlavə edildi.";
                notifyIcon1.ShowBalloonTip(8000);
                notifyIcon1.Icon = SystemIcons.Information;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıxmaq istədiyinizə əminsiniz?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            textBox1.Clear();

        }
    }
}
