namespace StringVariableDemo
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            fullNameTextLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            fullNameLabel = new Label();
            showNameButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(59, 23);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(120, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Enter your first name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(59, 56);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(118, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Enter your last name:";
            // 
            // fullNameTextLabel
            // 
            fullNameTextLabel.AutoSize = true;
            fullNameTextLabel.Location = new Point(59, 93);
            fullNameTextLabel.Name = "fullNameTextLabel";
            fullNameTextLabel.Size = new Size(122, 15);
            fullNameTextLabel.TabIndex = 2;
            fullNameTextLabel.Text = "This is your full name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(201, 20);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(201, 53);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 4;
            // 
            // fullNameLabel
            // 
            fullNameLabel.BorderStyle = BorderStyle.FixedSingle;
            fullNameLabel.Location = new Point(201, 85);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(100, 23);
            fullNameLabel.TabIndex = 5;
            fullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showNameButton
            // 
            showNameButton.Location = new Point(94, 134);
            showNameButton.Name = "showNameButton";
            showNameButton.Size = new Size(83, 23);
            showNameButton.TabIndex = 6;
            showNameButton.Text = "Show Name";
            showNameButton.UseVisualStyleBackColor = true;
            showNameButton.Click += showNameButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(188, 134);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(83, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 175);
            Controls.Add(exitButton);
            Controls.Add(showNameButton);
            Controls.Add(fullNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(fullNameTextLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label fullNameTextLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label fullNameLabel;
        private Button showNameButton;
        private Button exitButton;
    }
}
