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
        public int znak, q = 10;

        public Form1()
        {
            InitializeComponent();
            radioButton3.Checked = true;
            radioButton5.Checked = true;
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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Введите число");
            else
            {
                textBox1.Text = string.Format("{0}", Math.Pow(double.Parse(textBox1.Text), 2.0));
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                MessageBox.Show("Введите число");
            else
            {
                textBox1.Text = string.Format("{0}", Math.Pow(double.Parse(textBox1.Text), 3.0));
            }
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
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            radioButton6.Enabled = false;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (q == 16)
                {
                    a = Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 2);
                }
                if (q == 10)
                {
                    a = Convert.ToInt32(textBox1.Text, 10);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 2);
                }
                if (q == 8)
                {
                    a = Convert.ToInt32(textBox1.Text, 8);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 2);
                }
                if (q == 2)
                    textBox1.Text = textBox1.Text;
            }
            q = 2;
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
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            radioButton6.Enabled = false;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (q == 16)
                {
                    a = Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 8);
                }
                if (q == 10)
                {
                    a = Convert.ToInt32(textBox1.Text, 10);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 8);
                }
                if (q == 8)
                {
                    textBox1.Text = textBox1.Text;
                }
                if (q == 2)
                {
                    a = Convert.ToInt32(textBox1.Text, 2);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 8);
                }
            }
            q = 8;
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
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton4.Enabled = true;
            radioButton6.Enabled = true;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (q == 16)
                {
                    a = Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 10);
                }
                if (q == 10)
                    textBox1.Text = textBox1.Text;
                if (q == 8)
                {
                    a = Convert.ToInt32(textBox1.Text, 8);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 10);
                }
                if (q == 2)
                {
                    a = Convert.ToInt32(textBox1.Text, 2);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 10);
                }
            }
            q = 10;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") a = double.Parse(textBox1.Text);
            else a = 0;
            znak = 5;
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                a = 0;
            else
                a = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Sin(a)); 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                a = 0;
            else
                a = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Cos(a));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                a = 0;
            else
                a = double.Parse(textBox1.Text);
            textBox1.Text = String.Format("{0}", Math.Tan(a));
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton4.Enabled = true;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                a = Convert.ToInt32(textBox1.Text);
                c = a * 3.1415 / 180;
                textBox1.Text = String.Format("{0}", c);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton4.Enabled = false;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                a = Convert.ToInt32(textBox1.Text);
                c = a * 3.1415 / 180;
                textBox1.Text = String.Format("{0}", c);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                a = 0;
            else
                a = double.Parse(textBox1.Text);
            if (a > 0)
                textBox1.Text = String.Format("{0}", Math.Log(a));
            else
            {
                MessageBox.Show("Невозможно взять логорифм из 0 или отрицательного числа.");
                textBox1.Clear();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            radioButton6.Enabled = false;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (q == 16)
                {
                    a = Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 16);
                }
                if (q == 10)
                {
                    a = Convert.ToInt32(textBox1.Text, 10);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 16);
                }
                if (q == 8)
                {
                    a = Convert.ToInt32(textBox1.Text, 8);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 16);
                }
                if (q == 2)
                {
                    a = Convert.ToInt32(textBox1.Text, 2);
                    textBox1.Text = String.Format("{0}", a);
                    textBox1.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text), 16);
                }
            }
            q = 16;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                a = 0;
            else
                a = double.Parse(textBox1.Text);
            if (a > 0)
                textBox1.Text = String.Format("{0}", Math.Log10(a));
            else
            {
                MessageBox.Show("Невозможно взять логорифм из 0 или отрицательного числа.");
                textBox1.Clear();
            }
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
