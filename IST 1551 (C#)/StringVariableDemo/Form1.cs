namespace StringVariableDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "StringVariableDemo";
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            fullNameLabel.Text = $"{firstNameTextBox.Text} {lastNameTextBox.Text}";

            if (fullNameLabel.Text.Equals(" "))
            {
                fullNameLabel.Text = "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
