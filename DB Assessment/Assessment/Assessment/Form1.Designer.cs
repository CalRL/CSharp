namespace Assessment
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
            TextBox usernameTextbox;
            button1 = new Button();
            checkTextBox = new TextBox();
            registerButton = new Button();
            label1 = new Label();
            usernameTextbox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(47, 824);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(273, 126);
            button1.TabIndex = 0;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkTextBox
            // 
            checkTextBox.Location = new Point(47, 773);
            checkTextBox.Margin = new Padding(6, 6, 6, 6);
            checkTextBox.Name = "checkTextBox";
            checkTextBox.Size = new Size(270, 39);
            checkTextBox.TabIndex = 1;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(393, 769);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(150, 46);
            registerButton.TabIndex = 2;
            registerButton.Text = "register";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 154);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(89, 220);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(200, 39);
            usernameTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(usernameTextbox);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(checkTextBox);
            Controls.Add(button1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox checkTextBox;
        private Button registerButton;
        private Label label1;
    }
}