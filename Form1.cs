namespace Calculator
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a + b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a - b;
            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}
