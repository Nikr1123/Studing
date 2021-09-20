using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб27_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                errors.AppendLine("Введите первое число.");
            if (String.IsNullOrWhiteSpace(textBox2.Text))
                errors.AppendLine("Введите второе число.");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = a + b;
            textBox3.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(textBox4.Text))
                errors.AppendLine("Введите первое число.");
            if (String.IsNullOrWhiteSpace(textBox5.Text))
                errors.AppendLine("Введите второе число.");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = a * b;
            textBox6.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
