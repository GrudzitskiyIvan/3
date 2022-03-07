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
    public partial class Form1 : Form
    {
        double func(double x)
        {
            if (radioButton1.Checked)
            {
                return Math.Sinh(x);
            }
            else
                if (radioButton2.Checked)
            {
                return Math.Pow(x, 2);
            }
            else
                return Math.Exp(x);
        }
        double func_1(double x, double y)
        {
            if (x > y)
                return Math.Pow((func(x) - y), 3) + Math.Atan(func(x));
            else
                if (y > x)
                return Math.Pow(y - func(x), 3) + Math.Atan(func(x));
            else
                return Math.Pow(y + func(x), 3) + 0.5;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Результат работы программы ст. Звинаревского С. С.";
            textBox4.Text += Environment.NewLine + (("X = ") + (textBox1.Text == "" ? "0" : textBox1.Text));
            textBox4.Text += Environment.NewLine + (("Y = ") + (textBox2.Text == "" ? "0" : textBox2.Text));
            try
            {
                textBox4.Text += Environment.NewLine + ("d = " + func_1(
                    textBox1.Text == "" ? 0: Convert.ToDouble(textBox1.Text.Replace('.', ',')),
                    textBox2.Text == "" ? 0: Convert.ToDouble(textBox2.Text.Replace('.', ','))));
            }
            catch (Exception ex)
            {
                textBox4.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = "Результат работы программы ст. Звинаревского С. С.";
        }
    }
}
