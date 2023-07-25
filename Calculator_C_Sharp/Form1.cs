using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_C_Sharp
{
    public partial class Form1 : Form
    {
        private string currentInput;
        private double result;
        private char currentOperator;
        private bool isFirstOperator;
        private bool isCalculatorOn;
        public Form1()
        {
            InitializeComponent();
            currentInput = "";
            result = 0;
            currentOperator = ' ';
            isFirstOperator = true;
            isCalculatorOn = false;
            ToggleCalculator();
        }
        private void ToggleCalculator()
        {
            isCalculatorOn = !isCalculatorOn;
            buttonOnOff.Text = isCalculatorOn ? "OFF" : "ON";
            textBoxDisplay.Text = isCalculatorOn ? "0" : "OFF";
            foreach (Control control in Controls)
            {
                if (control is Button && control != buttonOnOff)
                    control.Enabled = isCalculatorOn;
            }
        }
        private void AppendToInput(string value)
        {
            currentInput += value;
            textBoxDisplay.Text = currentInput;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Calculate();
            currentOperator = ' ';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }
        private void Calculate()
        {
            if (currentInput == "")
                return;

            double num = double.Parse(currentInput);

            switch (currentOperator)
            {
                case '+':
                    result += num;
                    break;
                case '-':
                    result -= num;
                    break;
                case '*':
                    result *= num;
                    break;
                case '/':
                    if (num != 0)
                        result /= num;
                    else
                        MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            textBoxDisplay.Text = result.ToString();
            currentInput = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isCalculatorOn) return;
            Button button = (Button)sender;
            char op = button.Text[0];

            if (!isFirstOperator)
                Calculate();
            else
            {
                result = double.Parse(currentInput);
                isFirstOperator = false;
            }

            currentInput = "";
            currentOperator = op;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!isCalculatorOn) return;
            Button button = (Button)sender;
            char op = button.Text[0];

            if (!isFirstOperator)
                Calculate();
            else
            {
                result = double.Parse(currentInput);
                isFirstOperator = false;
            }

            currentInput = "";
            currentOperator = op;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!isCalculatorOn) return;
            Button button = (Button)sender;
            char op = button.Text[0];

            if (!isFirstOperator)
                Calculate();
            else
            {
                result = double.Parse(currentInput);
                isFirstOperator = false;
            }

            currentInput = "";
            currentOperator = op;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!isCalculatorOn) return;
            Button button = (Button)sender;
            char op = button.Text[0];

            if (!isFirstOperator)
                Calculate();
            else
            {
                result = double.Parse(currentInput);
                isFirstOperator = false;
            }

            currentInput = "";
            currentOperator = op;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            currentOperator = ' ';
            textBoxDisplay.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ToggleCalculator();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendToInput(button.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
