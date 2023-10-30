namespace Lab6Ex4
{
    public partial class Form1 : Form
    {
        StreamReader inFile;
        StreamWriter outFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                inFile = new StreamReader(openFileDialog1.FileName);
                label1.Text = "File " + openFileDialog1.FileName;
                inFile.Close();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                string testValue = "This is an example using dialog boxesl;";
                outFile = new StreamWriter(saveFileDialog1.FileName);
                outFile.WriteLine(testValue);
                outFile.Close();
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}