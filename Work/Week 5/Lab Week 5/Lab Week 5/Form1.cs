namespace Lab_Week_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            decimal answer = numberInput1.Value + numberInput2.Value;
            MessageBox.Show(answer.ToString());
        }
    }
}