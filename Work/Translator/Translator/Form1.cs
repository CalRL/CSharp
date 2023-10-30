namespace Translator
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

        private void italianButton_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "Bongiorno";
        }


        private void germanButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Guten Morgen";
        }
            private void spanishButton_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "Buenos Dias";
        }
    }
}