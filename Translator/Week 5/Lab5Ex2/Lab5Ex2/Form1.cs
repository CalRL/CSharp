using System.Windows.Forms;

namespace Lab5Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            List<decimal> myList = new List<decimal> { };
            myList.Add(numericUpDown1.Value);
            myList.Add(numericUpDown2.Value);
            myList.Add(numericUpDown3.Value);
            myList.Add(numericUpDown4.Value);
            myList.Add(numericUpDown5.Value);
            myList.Sort();
            decimal firstNumber = myList[0];
            decimal lastNumber = myList[myList.Count - 1];
            MessageBox.Show("First number " + firstNumber.ToString() + ", Last number " + lastNumber.ToString());

        }
    }
}