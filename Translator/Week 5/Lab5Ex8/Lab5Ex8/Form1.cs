using System.Text.RegularExpressions;

namespace Lab5Ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textContent = textBox1.Text;
            bool match = Regex.IsMatch(textContent, "[^a\\d]");
            if (textContent.Length == 4 || textContent.Length == 6)
            {
                if (match == true)
                {
                    MessageBox.Show("invalid");
                }
                else
                {
                    MessageBox.Show("valid");
                }
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}