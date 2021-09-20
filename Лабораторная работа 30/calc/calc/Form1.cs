using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public double a, b, c;
        public int znak;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Format("{0}", -double.Parse(textBox1.Text));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (DS_Count(textBox1.Text) == 0)
                textBox1.Text = (textBox1.Text + ",");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 4;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 3;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 2;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 1;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            switch (znak)
            {
                case 1:
                    c = a + b;
                    break;
                case 2:
                    c = a - b;
                    break;
                case 3:
                    c = a * b;
                    break;
                case 4:
                    if (b == 0)
                    {
                        MessageBox.Show("Невозможно разделить на 0.");
                        textBox1.Clear();
                    }
                    else c = a / b;
                    break;
                case 5:
                   c = Math.Pow(a, b);
                    break;
            }
            textBox1.Text = string.Format("{0}", c);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Math.Pow(a, 2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Math.Pow(a, 3);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = Math.Sqrt(a);
            if (a < 0)
            {
                MessageBox.Show("Невозможно взять корень из отрицательного числа.");
                textBox1.Clear();
            }
            else
                textBox1.Text = string.Format("{0}", b);
        }

        public int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        private void button17_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0]) && (DS_Count(textBox1.Text) < 1));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = true;
            
            textBox1.Text = string.Format("{0}", a);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 5;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
