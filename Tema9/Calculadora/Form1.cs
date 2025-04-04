namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);
                string selOperator = (string)(cmbOperator.SelectedItem);
                switch (selOperator)
                {
                    case "+":
                        lblResult.Text = "" + (number1 + number2);
                        break;
                    case "-":
                        lblResult.Text = "" + (number1 - number2);
                        break;
                    case "*":
                        lblResult.Text = "" + (number1 * number2);
                        break;
                    case "/":
                        lblResult.Text = "" + (number1 / number2);
                        break;
                }
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
