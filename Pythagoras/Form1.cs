namespace Pythagoras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b))
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                textBox3.Text = c.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
