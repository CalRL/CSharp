namespace Lab_Week_5
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
        private void InitializeComponent()
        {
            numberInput1 = new NumericUpDown();
            numberInput2 = new NumericUpDown();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numberInput1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberInput2).BeginInit();
            SuspendLayout();
            // 
            // numberInput1
            // 
            numberInput1.Location = new Point(36, 42);
            numberInput1.Name = "numberInput1";
            numberInput1.Size = new Size(240, 39);
            numberInput1.TabIndex = 0;
            // 
            // numberInput2
            // 
            numberInput2.Location = new Point(35, 101);
            numberInput2.Name = "numberInput2";
            numberInput2.Size = new Size(240, 39);
            numberInput2.TabIndex = 1;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(45, 162);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(150, 46);
            updateButton.TabIndex = 2;
            updateButton.Text = "update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateButton);
            Controls.Add(numberInput2);
            Controls.Add(numberInput1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numberInput1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberInput2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numberInput1;
        private NumericUpDown numberInput2;
        private Button updateButton;
    }
}