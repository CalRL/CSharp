using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Lab6Ex2
{
    public partial class Form1 : Form
    {
        private StreamReader inFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string? inValue;
            string filePath = "E:\\GitHub\\CSharp\\Work\\Week 6\\Lab6Ex2\\Lab6Ex2\\name.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    inFile = new StreamReader(filePath);
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.listBox1.Items.Add(inValue);
                    }
                }
                catch (System.IO.IOException exc)
                {
                    label1.Text = exc.Message;
                }
            } else {
                label1.Text = "file unavailable";
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }
            catch { }

        }
    }
}