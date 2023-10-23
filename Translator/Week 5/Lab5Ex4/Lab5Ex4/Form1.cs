namespace Lab5Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string userString = textBox1.Text;
            string resultedString = userString + "YORKSJ";
            MessageBox.Show(resultedString);
        }
    }
}