using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Текстовый_редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = "";
            }catch{};
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        private void Paste_Click(object sender, EventArgs e)
        {

            textBox1.SelectedText = Clipboard.GetText();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter SW = new System.IO.StreamWriter("1.txt");
            SW.WriteLine(textBox1.Text);
            SW.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor=Color.White;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Lime;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, float.Parse(comboBox1.Text), textBox1.Font.Style);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader Reader = new System.IO.StreamReader("1.txt");
            textBox1.Text = Reader.ReadLine();
            Reader.Close();
        }
    }
}
