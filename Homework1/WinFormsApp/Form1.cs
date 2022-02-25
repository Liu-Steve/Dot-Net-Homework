using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            labelInfo.Text = "";
            labelRes.Text = "";
            string numstr1 = textBox1.Text;
            string numstr2 = textBox2.Text;
            string op = comboBoxOp.Text;
            int num1, num2;
            if(!int.TryParse(numstr1, out num1))
            {
                labelInfo.Text = "Number1 parse Error!";
                return;
            }
            if (!int.TryParse(numstr2, out num2))
            {
                labelInfo.Text = "Number2 parse Error!";
                return;
            }
            if (op == "/" && num2 == 0)
            {
                labelInfo.Text = "Number2 is 0! Couldn't calculate";
                return;
            }
            switch (op)
            {
                case "+":
                    labelRes.Text = $"{num1 + num2}";
                    break;
                case "-":
                    labelRes.Text = $"{num1 - num2}";
                    break;
                case "*":
                    labelRes.Text = $"{num1 * num2}";
                    break;
                case "/":
                    labelRes.Text = $"{num1 / num2}";
                    break;
                default:
                    labelInfo.Text = "Operator is empty!";
                    break;
            }
        }
    }
}
