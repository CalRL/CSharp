namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "France";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Finland";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Germany";
        }

    }
}