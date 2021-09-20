using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб28
{
    public partial class Form4 : Form
    {
        public int kol_prav, kol;
        public Form4()
        {
            InitializeComponent();
            kol = 0;
            kol_prav = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(textBox1.Text))
                    MessageBox.Show("Введите число.");
                else
                {
                    int a = Convert.ToInt32(label3.Text);
                    int b = Convert.ToInt32(label5.Text);
                    int c = Convert.ToInt32(textBox1.Text);
                    int d = a + b;
                    if (c == d)
                    {
                        label6.Text = "ПРАВИЛЬНО";
                        kol_prav++;
                    }
                    else
                        label6.Text = "НЕ ПРАВИЛЬНО";
                    kol++;
                    Random rnd = new Random();
                    int x = rnd.Next(1, 9);
                    label3.Text = x.ToString();
                    x = rnd.Next(1, 9);
                    label5.Text = x.ToString();
                    textBox1.Text = "";
                }
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Вы правильно ответили на " + kol_prav + " примеров из " + kol);
        }
    }
}
