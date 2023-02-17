using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" && textBox2.Text != "")
            {
                if (operacao == "SOMA")
                {
                    textBox3.Text = txtResultado.Text;
                    txtResultado.Text = Convert.ToString(decimal.Parse(textBox1.Text) + decimal.Parse(textBox3.Text));
                    textBox5.Text = txtResultado.Text;
                    txtResultado.Text = "";
                }
                else if (operacao == "SUB")
                {
                    textBox3.Text = txtResultado.Text;
                    txtResultado.Text = Convert.ToString(decimal.Parse(textBox1.Text) - decimal.Parse(textBox3.Text));
                    textBox5.Text = txtResultado.Text;
                    txtResultado.Text = "";
                }
                else if (operacao == "MULT")
                {
                    textBox3.Text = txtResultado.Text;
                    txtResultado.Text = Convert.ToString(decimal.Parse(textBox1.Text) * decimal.Parse(textBox3.Text));
                    textBox5.Text = txtResultado.Text;
                    txtResultado.Text = "";
                }
                else if (operacao == "DIV")
                {
                    textBox3.Text = txtResultado.Text;
                    txtResultado.Text = Convert.ToString(decimal.Parse(textBox1.Text) / decimal.Parse(textBox3.Text));
                    textBox5.Text = txtResultado.Text;
                    txtResultado.Text = "";
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "-";
                textBox3.Text = "";
                textBox5.Text = "";
                operacao = "SUB";
                txtResultado.Text = "";
            }
            else if (txtResultado.Text != "")
            {
                textBox1.Text = txtResultado.Text;
                textBox2.Text = "-";
                txtResultado.Text = "";
                operacao = "SUB";
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "x";
                textBox3.Text = "";
                textBox5.Text = "";
                operacao = "MULT";
                txtResultado.Text = "";
            }
            else if (txtResultado.Text != "")
            {
                textBox1.Text = txtResultado.Text;
                textBox2.Text = "x";
                txtResultado.Text = "";
                operacao = "MULT";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "/";
                operacao = "DIV";
                txtResultado.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
            }
            else if (txtResultado.Text != "")
            {
                textBox1.Text = txtResultado.Text;
                textBox2.Text = "/";
                txtResultado.Text = "";
                operacao = "DIV";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "+";
                operacao = "SOMA";
                txtResultado.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
            }
            else if (txtResultado.Text != "")
            {
                textBox1.Text = txtResultado.Text;
                textBox2.Text = "+";
                txtResultado.Text = "";
                operacao = "SOMA";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
