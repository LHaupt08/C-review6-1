namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal operand1 = Convert.ToDecimal(txtOpe1.Text);
            string operator1 = Convert.ToString(txtOperator.Text);
            decimal operand2 = Convert.ToDecimal(txtOpe2.Text);

            decimal finalValue = Calculate(operand1, operator1, operand2);
            txtResult.Text = finalValue.ToString();

        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            return operator1 switch
            {
                "+" => operand1 + operand2,
                "-" => operand1 - operand2,
                "*" => operand1 * operand2,
                "/" => operand1 / operand2,
                "%" => operand1 % operand2,
                _ => 0,
            };

        }

        private void ClearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
