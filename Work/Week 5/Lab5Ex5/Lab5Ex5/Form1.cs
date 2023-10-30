namespace Lab5Ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string answer = "";
            decimal parsedNumber;
            if(Decimal.TryParse(number, out parsedNumber))
            {
                if (parsedNumber % 1 == 0)
                {
                    answer = "true";
                }
                else
                {
                    answer = "false";
                }
            } else
            {
                MessageBox.Show("failed");
            }
            
            MessageBox.Show(answer);
        }
    }
}