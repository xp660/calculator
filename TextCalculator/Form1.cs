using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {

                double number1 = Double.Parse(textBoxNumber1.Text);
                double number2 = Double.Parse(textBoxNumber2.Text);
                string op = comboBoxOp.Text;
                double result = 0.0;
                //  MessageBox.Show(number1 + op + number2 + "=");

                switch (op)
                {
                    case "+": result = number1 + number2; break;
                    case "-": result = number1 - number2; break;
                    case "*": result = number1 * number2; break;
                    case "/": result = number1 / number2; break;

                    default: throw new Exception("op=" + op + ":Error");
                }

                textBoxResult.Text = result.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }



        }
    }
}
