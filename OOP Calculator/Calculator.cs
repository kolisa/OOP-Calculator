using OOP_Calculator.Classes;

namespace OOP_Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool isNewCalc = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumbers_click(object sender, EventArgs e)
        {
            if ((tbResults.Text == "0") || (isOperationPerformed))
                tbResults.Clear();
           
            if (isNewCalc) { tbResults.Clear(); resultValue = 0; }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbResults.Text.Contains("."))
                    tbResults.Text = tbResults.Text + button.Text;

            }
            else
                tbResults.Text = tbResults.Text + button.Text;
            isNewCalc = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
               
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(tbResults.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            isNewCalc = false;
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {

            _ = operationPerformed switch
            {
                "+" => tbResults.Text = new AdditionOperation(resultValue, Double.Parse(tbResults.Text)).Calculate().ToString(),
                "-" => tbResults.Text = new SubtractionOperation(resultValue, Double.Parse(tbResults.Text)).Calculate().ToString(),
                "*" => tbResults.Text = new MultiplicationOperation(resultValue, Double.Parse(tbResults.Text)).Calculate().ToString(),
                "/" => tbResults.Text = new DivisionOperation(resultValue, Double.Parse(tbResults.Text)).Calculate().ToString(),
                _ => "0"
            };

            resultValue = Double.Parse(tbResults.Text);
            labelCurrentOperation.Text = "";
            isNewCalc = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
            resultValue = 0;
            isNewCalc = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tbResults.Text = "0";
            resultValue = 0;
            isNewCalc = false;
        }
    }
}