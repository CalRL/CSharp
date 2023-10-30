using System;
using System.Windows.Forms;
using System.IO;

namespace Lab6Ex3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string? inValue;
            string filePath = "E:\\GitHub\\CSharp\\Work\\Week 6\\Lab6Ex3\\Lab6Ex3\\name.txt";
            try
            {
                using (StreamReader inFile = new StreamReader(filePath))
                {
                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.listBox1.Items.Add(inValue);

                    }
                }

            } catch (FileNotFoundException exc)
            {
                label1.Text = "File not found! \n" + exc.Message;
                
            } catch (Exception exc)
            {
                label1.Text = exc.Message;
            }
        }
    }
}