using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб27_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                errors.AppendLine("Введите число.");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            double a = Convert.ToDouble(textBox1.Text);
            double b = 0;
            switch (listBox1.SelectedIndex)
            {
                case 0: b = 0.000001; break;
                case 1: b = 0.001; break;
                case 2: b = 1; break;
                case 3: b = 100; break;
                case 4: b = 1000; break;
            }
            double c = a * b;
            textBox2.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
