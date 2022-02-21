using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_1.Classes;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        private void Delete()
        {
            InputStr.Text = String.Empty;
            ResultStr.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = Calculator.GetLength(InputStr.Text);
            }
            else ResultStr.Text = "Длину чего мерять изволите?";
        }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ReplaceBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (textBox2.Text != String.Empty)
                {
                    ResultStr.Text = InputStr.Text.Replace(textBox1.Text, textBox2.Text);
                }
                else ResultStr.Text = "Введите подстроку, которая изменяет";
            }
            else if (textBox1.Text == String.Empty)
            {
                ResultStr.Text = "Введите подстроку для изменения";
            }
        }

        private void DeleteSubstr_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                ResultStr.Text = InputStr.Text.Replace(textBox1.Text, String.Empty);
            }
            else ResultStr.Text = "Введите подстроку для удаления";
        }

        private void SymbolByIndexBut_Click(object sender, EventArgs e)
        {
            try
            {
                ResultStr.Text = String.Empty;
                int index = int.Parse(textBox3.Text);
                char res = InputStr.Text[index];
                ResultStr.Text += res;
            }
            catch(IndexOutOfRangeException ex)
            {
                ResultStr.Text = ex.Message;
            }
            
        }

        private void VowBut_Click(object sender, EventArgs e)
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = Calculator.WordCount(InputStr.Text);
            }
            else ResultStr.Text = "Error";
        }

        private void ConsBut_Click(object sender, EventArgs e)
        {
            if (InputStr.Text != String.Empty)
            {
                var result = Calculator.ConsonantsAndVowels(InputStr.Text);
                textBox4.Text = result[0].ToString();
                textBox5.Text = result[1].ToString();
            }
            else ResultStr.Text = "Гласные и согласные откуда брать?";
        }

        private void SenBut_Click(object sender, EventArgs e)
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = Calculator.SenCount(InputStr.Text);
            }
            else ResultStr.Text = "Error";
        }
    }
}
