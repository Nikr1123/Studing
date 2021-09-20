using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _32_Текстовый_редактор_Ржевского_Никиты
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Поиск по файлу";
            textBox1.ForeColor = Color.Gray;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, richTextBox1.Text);
                    }
                }
            }
            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "Безымянный";
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, richTextBox1.Text);
                    }
                }
            }
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
            toolStripStatusLabel1.Text = openFile.FileName;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Безымянный";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Безымянный";
            saveFile.Filter = "Текстовый файл|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, richTextBox1.Text);
            }
            else
            {
                richTextBox1.Clear();
            }
            toolStripStatusLabel1.Text = "Сохранено";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string str = richTextBox1.SelectedText.ToString();
                Clipboard.SetText(str);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                string str = richTextBox1.SelectedText.ToString();
                Clipboard.SetText(str);
            }
        }

        private void выркзатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, richTextBox1.Text);
                    }
                }
            }
            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "Безымянный";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (richTextBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, richTextBox1.Text);
                    }
                }
            }
            openFile.Filter = "Текстовый файл|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFile.FileName);
            }
            toolStripStatusLabel1.Text = openFile.FileName;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сохранение…";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Безымянный";
            saveFile.Filter = "Текстовый файл|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, richTextBox1.Text);
            }
            else
            {
                richTextBox1.Clear();
            }
            toolStripStatusLabel1.Text = "Сохранено";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            int i = 0;
            int n = 1;
            int check = 1;
            if (richTextBox1.Text.IndexOf(textBox1.Text) != -1)
            {
                for (i = 0; i < richTextBox1.TextLength; i++)
                {
                    if ((richTextBox1.Text[i] == textBox1.Text[0]) && (i + textBox1.TextLength <= richTextBox1.TextLength))
                    {
                        for (n = 1; n < textBox1.TextLength; n++)
                        {
                            if (richTextBox1.Text[i + n] == textBox1.Text[n])
                            {
                                check++;
                            }
                        }
                        if (check == textBox1.TextLength)
                        {
                            richTextBox1.SelectionStart = i;
                            richTextBox1.SelectionLength = textBox1.Text.Length;
                            if (richTextBox1.SelectionColor == Color.Red)
                                richTextBox1.SelectionColor = Color.Green;
                            else
                                richTextBox1.SelectionColor = Color.Red;
                        }
                        check = 1;
                    }
                }
            }
            else
                MessageBox.Show("Совпадений не найдено.");
        }
     
        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox1.ForeColor = Color.Black;
        }
    }
}