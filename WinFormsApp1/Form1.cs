using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = Convert.ToDouble(textBox3.Text);

                double s = (2 * Math.Cos(x - 2.0 / 3.0))
                         / (0.5 + Math.Pow(Math.Sin(y), 2))
                         * (1 + Math.Pow(z, 2) /
                         (3 - Math.Pow(z, 2) / 5));

                textBox4.Text = s.ToString("F6");
            }
            catch
            {
                MessageBox.Show("Неправильно введені дані!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}