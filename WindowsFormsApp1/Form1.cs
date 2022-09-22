using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Double value = 0;
        String operation = "";
        bool operation_pressed = false;



        public Form1()
        {
            InitializeComponent();
        }

      
        private void button_Click(object sender, EventArgs e)
        {

            if ((resultt.Text == "0")||(operation_pressed))
                resultt.Clear();

            operation_pressed = false;

            Button b = (Button)sender;

            resultt.Text = resultt.Text + b.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            resultt.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(resultt.Text);
            operation_pressed = true;
            label1.Text = value + " " + operation;
            //test
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label1.Text = "";


            switch (operation)
            {
                case "+":
                    resultt.Text = (value +  Double.Parse(resultt.Text)).ToString();
                    break;


                case "-":
                    resultt.Text = (value - Double.Parse(resultt.Text)).ToString();
                    break;


                case "*":
                    resultt.Text = (value * Double.Parse(resultt.Text)).ToString();
                    break;


                case "/":
                    resultt.Text = (value / Double.Parse(resultt.Text)).ToString();
                    break;

                default:
                    break;

            }
            

        }

        private void button35_Click(object sender, EventArgs e)
        {
            resultt.Text="0";
            value = 0;

        }
    }
}
