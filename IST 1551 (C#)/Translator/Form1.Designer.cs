namespace Translator
{
    partial class Translator
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
            instructionLabel = new Label();
            italianButton = new Button();
            spanishButton = new Button();
            germanButton = new Button();
            translationLabel = new Label();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(26, 13);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(250, 15);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Select a language and I will say Good Morning";
            // 
            // italianButton
            // 
            italianButton.Location = new Point(30, 69);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(75, 23);
            italianButton.TabIndex = 1;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(192, 69);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(75, 23);
            spanishButton.TabIndex = 2;
            spanishButton.Text = "German";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(111, 69);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(75, 23);
            germanButton.TabIndex = 3;
            germanButton.Text = "Spanish";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // translationLabel
            // 
            translationLabel.BorderStyle = BorderStyle.FixedSingle;
            translationLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            translationLabel.Location = new Point(30, 38);
            translationLabel.Name = "translationLabel";
            translationLabel.Size = new Size(237, 23);
            translationLabel.TabIndex = 4;
            translationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Translator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 106);
            Controls.Add(translationLabel);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(italianButton);
            Controls.Add(instructionLabel);
            Name = "Translator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private Button italianButton;
        private Button spanishButton;
        private Button germanButton;
        private Label translationLabel;
    }
}
