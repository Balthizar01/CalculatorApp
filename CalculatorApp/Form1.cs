using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public string calcDisplay = "";
        public string num1;
        public string num2;
        public string op = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if(op == null)
            {
                calcDisplay += "1";
                num1 += "1";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "1";
                num2 += "1";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "2";
                num1 += "2";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "2";
                num2 += "2";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "3";
                num1 += "3";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "3";
                num2 += "3";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "4";
                num1 += "4";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "4";
                num2 += "4";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "5";
                num1 += "5";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "5";
                num2 += "5";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "6";
                num1 += "6";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "6";
                num2 += "6";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "7";
                num1 += "7";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "7";
                num2 += "7";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "8";
                num1 += "8";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "8";
                num2 += "8";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "9";
                num1 += "9";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "9";
                num2 += "9";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                calcDisplay += "0";
                num1 += "0";

                calculationLabel.Text = calcDisplay;
            }
            else
            {
                calcDisplay += "0";
                num2 += "0";

                calculationLabel.Text = calcDisplay;
            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            calculationLabel.Text = "+";
            op = "+";
            calcDisplay = "";
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            calculationLabel.Text = "-";
            op = "-";
            calcDisplay = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculationLabel.Text = "*";
            op = "*";
            calcDisplay = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            calculationLabel.Text = "/";
            op = "/";
            calcDisplay = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculationLabel.Text = "0";
            num1 = "";
            num2 = "";
            op = null;
            calcDisplay = "";
        }

        private void calcComplete_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(num1);
            int Num2 = int.Parse(num2);
            int result;
            float fresult;
            switch (op)
            {
                case "+":
                    result = Num1 + Num2;
                    calcDisplay = result.ToString();
                    calculationLabel.Text = calcDisplay;
                    break;
                case "-":
                    result = Num1 - Num2;
                    calcDisplay = result.ToString();
                    calculationLabel.Text = calcDisplay;
                    break;
                case "*":
                    result = Num1 * Num2;
                    calcDisplay = result.ToString();
                    calculationLabel.Text = calcDisplay;
                    break;
                case "/":
                    if(Num1 % Num2 == 0)
                    {
                        result = Num1 / Num2;
                        calcDisplay = result.ToString();
                    }
                    else
                    {
                        fresult = Num1 / Num2;
                        calcDisplay = fresult.ToString();
                    }
                    calculationLabel.Text = calcDisplay;
                    break;
            }
        }
    }
}
