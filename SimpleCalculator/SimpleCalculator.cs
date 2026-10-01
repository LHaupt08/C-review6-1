namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {

            decimal operand1 = Convert.ToDecimal(txtOpe1.Text);
            string operator1 = Convert.ToString(txtOpe1.Text);
            decimal operand2 = Convert.ToDecimal(txtOpe2.Text);

            decimal finalValue = operand1+operand2;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
