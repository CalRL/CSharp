using System.Windows.Forms.Design.Behavior;

namespace Lab5Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            decimal baseNumber = numericUpDown1.Value;
            decimal exponentNumber = numericUpDown2.Value;
            double val1 = Decimal.ToDouble(baseNumber);
            double val2 = Decimal.ToDouble(exponentNumber);
            double answer = Math.Pow(val1, val2);
            MessageBox.Show("Answer: " + answer.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}