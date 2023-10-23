using System.Text.RegularExpressions;

namespace Lab5Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string count = (textBox1.Text = rgx.Replace(textBox1.Text, "")).Length.ToString();

            MessageBox.Show(count);
        }
    }
}