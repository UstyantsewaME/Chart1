using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Чарт_без_видео_
{
    public partial class Form1 : Form
    {
        double x;
        double y;
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        double h;
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox6.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox6.Clear();
            }
        }


        double a;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox1.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox4.Clear();
            }
        }

        double b;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(textBox5.Text, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                textBox4.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            a = Convert.ToDouble(textBox4.Text);
            b = Convert.ToDouble(textBox5.Text);
            h = Convert.ToDouble(textBox6.Text);
            x = a;
            while (x <= b)
            {
                y = Math.Sin(Convert.ToDouble(textBox1.Text)*x+ Convert.ToDouble(textBox2.Text))+ Convert.ToDouble(textBox3.Text);
                chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
            if (checkBox1.Checked)
            {
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x);
                    chart1.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
                chart1.Series[1].Points.Clear();
            if (checkBox2.Checked)
            {
                x = a;
                while (x <= b)
                {
                    y = Math.Cos(x);
                    chart1.Series[2].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
                chart1.Series[2].Points.Clear();
            if (checkBox3.Checked)
            {
                x = a;
                while (x <= b)
                {
                    y = Math.Sin(x) + Math.Cos(x);
                    chart1.Series[3].Points.AddXY(x, y);
                    x += h;
                }
            }
            else
                chart1.Series[3].Points.Clear();
        }
    }
}
