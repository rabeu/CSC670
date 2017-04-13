using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//NU CSC670, Week 1 Assignment, Professor Ogun Tigli, Marceu Martins De Souza Filho
namespace week1assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            sum = Convert.ToDouble(input1.Text) + Convert.ToDouble(input2.Text);
            resultText.Text = "The sum of " + input1.Text+" and " + input2.Text + " is " + Convert.ToString(sum);
        }

        private void diffButton_Click(object sender, EventArgs e)
        {
            double diff;
            diff = Convert.ToDouble(input1.Text) - Convert.ToDouble(input2.Text);
            resultText.Text = "The diff of " + input1.Text + " and " + input2.Text + " is " + Convert.ToString(diff);
        }

        private void prodButton_Click(object sender, EventArgs e)
        {
            double prod;
            prod = Convert.ToDouble(input1.Text) * Convert.ToDouble(input2.Text);
            resultText.Text = "The prod of " + input1.Text + " and " + input2.Text + " is " + Convert.ToString(prod);
        }

        private void quotButton_Click(object sender, EventArgs e)
        {
            long quot;
            quot = Convert.ToInt64(input1.Text) / Convert.ToInt64(input2.Text);
            resultText.Text = "The quotient of " + input1.Text + " and " + input2.Text + " is " + Convert.ToString(quot);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            input1.Text = "0";
            input2.Text = "0";
            resultText.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
