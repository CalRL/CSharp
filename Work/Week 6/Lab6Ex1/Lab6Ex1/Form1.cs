using System;
using System.Collections.Generic;
using System.IO;

namespace Lab6Ex1
{
    public partial class Form1 : Form
    {
        private StreamWriter fil;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("saying.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                label1.Text = exc.Message;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fil.WriteLine(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();

            } catch (Exception exc)
            {
                label1.Text = exc.Message;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            } catch
            {
                label1.Text = "File did not close properly";
            }
        }
    }
}