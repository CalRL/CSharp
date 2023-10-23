namespace Lab5Ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string answer;
            if (text1.Length == text2.Length) {
                answer = "true";

            }
            else
            {
                answer = "false";
            }
            MessageBox.Show(answer);
        }
    }
}