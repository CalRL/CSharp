namespace Lab5Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numberDec = numericUpDown1.Value;
            int number = Convert.ToInt32(numberDec);
            if (IsPrime(number)) {
                MessageBox.Show($"{number} is a prime");
            }
            else
            {
                MessageBox.Show($"{number} aint a prime u cappin");
            }
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; 
            }

            if (number <= 3)
            {
                return true; 
            }

            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}