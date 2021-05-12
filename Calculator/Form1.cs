using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Variables
        Double resultValue = 0;
        String oparationPerformed = "";
        bool isOperationPerformed = false;
        Double memoryVar;
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonResult_TextChanged(object sender, EventArgs e)
        {

        }
        //For numbers
        private void number_Click(object sender, EventArgs e)
        {
            if (buttonResult.Text == "0" || (isOperationPerformed))
            {
                buttonResult.Clear();
            }
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!buttonResult.Text.Contains("."))
                {
                    buttonResult.Text = buttonResult.Text + button.Text;
                }
            }
            else
            {
                buttonResult.Text = buttonResult.Text + button.Text;
            }
                isOperationPerformed = false;
        }
        //Operator
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                oparationPerformed = button.Text;
                resultValue = Double.Parse(buttonResult.Text);
                isOperationPerformed = true;
                currentOperation.Text = resultValue + " " + oparationPerformed;
            }
            else
            {
                oparationPerformed = button.Text;
                resultValue = Double.Parse(buttonResult.Text);
                isOperationPerformed = true;
                currentOperation.Text = resultValue + " " + oparationPerformed;
            }
        }
        //Memory
        private void buttonMemory(object sender, EventArgs e)
        {
            /*The calculator has one memory that can be used for storing values temporarily. */
            switch (oparationPerformed)
            {
                //To clear the memory (set it's value to 0), press the key 'MC'.
                case "MC":
                    memoryVar = 0;
                    break;
                //To recall the value stored in memory use the key 'MR'.
                case "MR":
                    buttonResult.Text = memoryVar.ToString();
                    break;
                //MS = Memory Store puts the number on the display into the memory
                case "MS":
                    memoryVar = resultValue;
                    break;
                //To add to the value in memory, press 'M+'.
                case "M+":
                    memoryVar += resultValue;
                    break;
                //To subtract a value from the memory use the key 'M-'
                case "M-":
                    memoryVar -= resultValue;
                    break;
            }
        }
        //Delete
        private void clear(object sender, EventArgs e)
        {
            buttonResult.Text = "0";
        }
        private void clear2(object sender, EventArgs e)
        {
            buttonResult.Text = "0";
            resultValue = 0;
            currentOperation.Text = "";
        }
        private void removeLast(object sender, EventArgs e)
        {
            buttonResult.Text = buttonResult.Text.Remove(buttonResult.TextLength - 1);
        }
        private void equal(object sender, EventArgs e)
        {
            switch (oparationPerformed)
            {
                case "+":
                    buttonResult.Text = (resultValue + Double.Parse(buttonResult.Text)).ToString();
                    break;
                case "-":
                    buttonResult.Text = (resultValue - Double.Parse(buttonResult.Text)).ToString();
                    break;
                case "*":
                    buttonResult.Text = (resultValue * Double.Parse(buttonResult.Text)).ToString();
                    break;
                case "/":
                    buttonResult.Text = (resultValue / Double.Parse(buttonResult.Text)).ToString();
                    break;
                case "%":
                    buttonResult.Text = ((resultValue / 100) * Double.Parse(buttonResult.Text)).ToString();
                    break;
                case "√":
                    if (resultValue != 0)
                    {
                        buttonResult.Text = (resultValue * Math.Sqrt(Double.Parse(buttonResult.Text))).ToString();
                    }
                    else
                    {
                        buttonResult.Text = Math.Sqrt(Double.Parse(buttonResult.Text)).ToString();
                    }
                    break;
                case "^":
                    buttonResult.Text = Math.Pow(resultValue, Double.Parse(buttonResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(buttonResult.Text);
            currentOperation.Text = "";
        }
    }
}
