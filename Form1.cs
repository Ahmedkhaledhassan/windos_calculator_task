using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolator
{
    public partial class Form1 : Form
    {
        string operation="";
        double res = 0;
        bool click = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text== "0" || click == true)
            {
                textBox1.Clear();
            }
            if (but.Text ==".") 
            {
               if(!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + but.Text;
                }
               
            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            click = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            res = double.Parse (textBox1.Text);
            click = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBox1.Text = (res + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (res - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (res * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (res / double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            res = 0;
        }
    }
}
