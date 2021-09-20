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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, textBox1.Text);
                    }
                }
            }
            textBox1.Clear();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Безымянный";
            saveFile.Filter = "Текстовый файл|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string str = textBox1.SelectedText.ToString();
                Clipboard.SetText(str);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            textBox1.Paste(Clipboard.GetText());
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
            if (textBox1.Text != "")
            {
                string str = textBox1.SelectedText.ToString();
                Clipboard.SetText(str);
            }
        }

        private void выркзатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste(Clipboard.GetText());
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult result = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.FileName = "Безымянный";
                    saveFile.Filter = "Текстовый файл|*.txt";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFile.FileName, textBox1.Text);
                    }
                }
            }
            textBox1.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Безымянный";
            saveFile.Filter = "Текстовый файл|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
