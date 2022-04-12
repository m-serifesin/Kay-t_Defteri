namespace KayıtDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label9.Text = comboBox1.Text;
            label11.Text = textBox3.Text;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}