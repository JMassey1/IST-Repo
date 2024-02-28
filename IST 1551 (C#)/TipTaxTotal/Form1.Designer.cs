namespace TipTaxTotal
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
            foodChargeTextLabel = new Label();
            tipAmountTextLabel = new Label();
            taxAmountTextLabel = new Label();
            totalAmountTextLabel = new Label();
            tipLabel = new Label();
            taxLabel = new Label();
            totalLabel = new Label();
            foodChargeTextBox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // foodChargeTextLabel
            // 
            foodChargeTextLabel.AutoSize = true;
            foodChargeTextLabel.Location = new Point(69, 7);
            foodChargeTextLabel.Name = "foodChargeTextLabel";
            foodChargeTextLabel.Size = new Size(78, 15);
            foodChargeTextLabel.TabIndex = 0;
            foodChargeTextLabel.Text = "Food Charge:";
            // 
            // tipAmountTextLabel
            // 
            tipAmountTextLabel.AutoSize = true;
            tipAmountTextLabel.Location = new Point(91, 45);
            tipAmountTextLabel.Name = "tipAmountTextLabel";
            tipAmountTextLabel.Size = new Size(56, 15);
            tipAmountTextLabel.TabIndex = 1;
            tipAmountTextLabel.Text = "Tip (15%)";
            // 
            // taxAmountTextLabel
            // 
            taxAmountTextLabel.AutoSize = true;
            taxAmountTextLabel.Location = new Point(96, 77);
            taxAmountTextLabel.Name = "taxAmountTextLabel";
            taxAmountTextLabel.Size = new Size(51, 15);
            taxAmountTextLabel.TabIndex = 2;
            taxAmountTextLabel.Text = "Tax (7%)";
            // 
            // totalAmountTextLabel
            // 
            totalAmountTextLabel.AutoSize = true;
            totalAmountTextLabel.Location = new Point(115, 110);
            totalAmountTextLabel.Name = "totalAmountTextLabel";
            totalAmountTextLabel.Size = new Size(32, 15);
            totalAmountTextLabel.TabIndex = 3;
            totalAmountTextLabel.Text = "Total";
            // 
            // tipLabel
            // 
            tipLabel.BorderStyle = BorderStyle.FixedSingle;
            tipLabel.Location = new Point(153, 41);
            tipLabel.Name = "tipLabel";
            tipLabel.Size = new Size(100, 23);
            tipLabel.TabIndex = 4;
            tipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            taxLabel.BorderStyle = BorderStyle.FixedSingle;
            taxLabel.Location = new Point(153, 73);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(100, 23);
            taxLabel.TabIndex = 5;
            taxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.FixedSingle;
            totalLabel.Location = new Point(153, 110);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 23);
            totalLabel.TabIndex = 6;
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodChargeTextBox
            // 
            foodChargeTextBox.Location = new Point(153, 4);
            foodChargeTextBox.Name = "foodChargeTextBox";
            foodChargeTextBox.Size = new Size(100, 23);
            foodChargeTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(87, 146);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(168, 146);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 181);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(foodChargeTextBox);
            Controls.Add(totalLabel);
            Controls.Add(taxLabel);
            Controls.Add(tipLabel);
            Controls.Add(totalAmountTextLabel);
            Controls.Add(taxAmountTextLabel);
            Controls.Add(tipAmountTextLabel);
            Controls.Add(foodChargeTextLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label foodChargeTextLabel;
        private Label tipAmountTextLabel;
        private Label taxAmountTextLabel;
        private Label totalAmountTextLabel;
        private Label tipLabel;
        private Label taxLabel;
        private Label totalLabel;
        private TextBox foodChargeTextBox;
        private Button calculateButton;
        private Button exitButton;
    }
}
