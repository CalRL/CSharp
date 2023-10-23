namespace Lab5Ex2
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
            update = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            answerBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // update
            // 
            update.Location = new Point(514, 115);
            update.Name = "update";
            update.Size = new Size(150, 46);
            update.TabIndex = 0;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            update.Click += Update_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(27, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(27, 74);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 39);
            numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(27, 138);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(240, 39);
            numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(27, 200);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(240, 39);
            numericUpDown4.TabIndex = 4;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(27, 270);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(240, 39);
            numericUpDown5.TabIndex = 5;
            // 
            // answerBox
            // 
            answerBox.Location = new Point(376, 234);
            answerBox.Name = "answerBox";
            answerBox.Size = new Size(288, 39);
            answerBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerBox);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(update);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private TextBox answerBox;
    }
}