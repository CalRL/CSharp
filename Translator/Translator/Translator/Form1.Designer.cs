namespace Translator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            italianButton = new Button();
            germanButton = new Button();
            spanishButton = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // italianButton
            // 
            italianButton.Location = new Point(97, 294);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(150, 46);
            italianButton.TabIndex = 0;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(321, 294);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(150, 46);
            germanButton.TabIndex = 1;
            germanButton.Text = "German";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(545, 294);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(150, 46);
            spanishButton.TabIndex = 2;
            spanishButton.Text = "Spanish";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 86);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(206, 177);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(367, 58);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(spanishButton);
            Controls.Add(germanButton);
            Controls.Add(italianButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button italianButton;
        private Button germanButton;
        private Button spanishButton;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}