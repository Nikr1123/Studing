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
    public partial class Form2 : Form
    {
        public int kol_prav, kol;
        public Form2()
        {
            InitializeComponent();
            kol = 0;
            kol_prav = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("правильно ответил на " + kol_prav + " примеров " + kol);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    int a = Convert.ToInt32(label3.Text);
                    int b = Convert.ToInt32(label5.Text);
                    int c = Convert.ToInt32(textBox1.Text);
                    int d = a * b;

                    kol++;

                    if (c == d)
                    {
                        label6.Text = "ПРАВИЛЬНО";

                        kol_prav++;
                    }
                    else
                        label6.Text = "НЕ ПРАВИЛЬНО ";
                    Random rnd = new Random();
                    int x = rnd.Next(1, 9);
                    label3.Text = x.ToString();
                    x = rnd.Next(1, 9);
                    label5.Text = x.ToString();
                }
                else
                    MessageBox.Show("введите число ");
                textBox1.Text = "";
            }
        }
    }
}
