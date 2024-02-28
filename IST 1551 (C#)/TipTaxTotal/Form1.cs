namespace TipTaxTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Tip Tax and Total";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var foodCharge = double.Parse(foodChargeTextBox.Text);
            var tipAmount = (0.15 * foodCharge);
            var taxAmount = (0.07 * foodCharge);

            tipLabel.Text = tipAmount.ToString("C");
            taxLabel.Text = taxAmount.ToString("C");
            totalLabel.Text = (foodCharge + tipAmount + taxAmount).ToString("C");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
