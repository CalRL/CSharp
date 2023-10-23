namespace Lab5Ex4P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            decimal chickenCount = numericUpDown1.Value;
            decimal horseCount = numericUpDown2.Value;
            decimal cowCount = numericUpDown3.Value;
            decimal chickenLegs = chickenCount * 2;
            decimal horseLegs = horseCount * 4;
            decimal cowLegs = cowCount * 4;
            decimal totalLegs = cowLegs + horseLegs + cowLegs;
            MessageBox.Show("Chicken Legs, Cow Legs, Horse Legs: " + chickenLegs.ToString() + " " + horseLegs.ToString() + " " + cowLegs.ToString() + "\nTotal Legs: " + totalLegs.ToString());

        }
    }
}