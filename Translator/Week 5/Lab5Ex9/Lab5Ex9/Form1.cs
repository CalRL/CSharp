using System.ComponentModel;
using System.Globalization;

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
            
            List<int> listOfInts = new List<int>();
            foreach (int i in textBox1.Text)
            {
                listOfInts.Add(i);
            }
        }
    }
}