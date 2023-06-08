namespace cheltuieli
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
            string text = textBox1.Text; // Accesați textul introdus în textBox1

            listBox1.Items.Add(text); // Adăugați textul în listBox1

            textBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; // Accesați textul introdus în textBox1

            listBox2.Items.Add(text); // Adăugați textul în listBox2

            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; // Accesați textul introdus în textBox1

            listBox3.Items.Add(text);

            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text; // Accesați textul introdus în textBox1

            listBox4.Items.Add(text);

            textBox1.Text = "";

        }
    }
}