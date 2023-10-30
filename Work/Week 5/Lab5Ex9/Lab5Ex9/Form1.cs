using System.ComponentModel;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Lab5Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            static bool IsPalindrome(int number)
            {
                string numberString = number.ToString();
                string reversedString = new string(numberString.ToCharArray().Reverse().ToArray());
                bool answer = numberString.Equals(reversedString);
                MessageBox.Show($"original: {numberString}, reversed: {reversedString}", answer.ToString());
                return numberString == reversedString;
            }
            int inputInt = int.Parse(textBox1.Text);
            IsPalindrome(inputInt);
            
        }
    }
}