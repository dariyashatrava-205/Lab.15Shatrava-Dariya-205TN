using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp15_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0,0";
            textBox2.Text = "0,0";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0.0, y = 0.0;

            if (Double.TryParse(textBox1.Text, out double result))
            { x = Convert.ToDouble(textBox1.Text); }
            else { textBox3.Text = "Введіть число у змінну x"; }

            if (Double.TryParse(textBox2.Text, out double result1))
            { y = Convert.ToDouble(textBox2.Text); }
            else { textBox3.Text = "Введіть число у змінну y"; }

            if (Double.TryParse(textBox1.Text, out double result2) &&
                Double.TryParse(textBox2.Text, out double result3))
            {
                textBox3.Text = Convert.ToString(
                    Math.Log(Math.Abs(
                        (y - Math.Sqrt(Math.Abs(x))) *
                        (x - (y / (x + Math.Pow(x, 2) / 4)))
                    ))
                );
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (Int32.TryParse(textBox4.Text, out int result))
            {
                n = Convert.ToInt32(textBox4.Text);
                textBox5.Text = Convert.ToString(
                    Math.Pow(n, 1) + "  " +
                    Math.Pow(n, 2) + "  " +
                    Math.Pow(n, 3) + "  " +
                    Math.Pow(n, 4)
                );
            }
            else
            {
                textBox5.Text = "Введіть ціле число";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 0.0, b = 0.0, c = 0.0;

            if (Double.TryParse(textBox6.Text, out double r1))
            { a = Convert.ToDouble(textBox6.Text); }
            else { textBox9.Text = "Введіть a"; }

            if (Double.TryParse(textBox7.Text, out double r2))
            { b = Convert.ToDouble(textBox7.Text); }
            else { textBox9.Text = "Введіть b"; }

            if (Double.TryParse(textBox8.Text, out double r3))
            { c = Convert.ToDouble(textBox8.Text); }
            else { textBox9.Text = "Введіть c"; }

            if (Double.TryParse(textBox6.Text, out double r4) &&
                Double.TryParse(textBox7.Text, out double r5) &&
                Double.TryParse(textBox8.Text, out double r6))
            {
                if (a == b || a == c || b == c)
                    textBox9.Text = "true";
                else
                    textBox9.Text = "false";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;

            if (Int32.TryParse(textBox10.Text, out int r1))
            { A = Convert.ToInt32(textBox10.Text); }
            else { textBox12.Text = "Введіть A"; }

            if (Int32.TryParse(textBox11.Text, out int r2))
            { B = Convert.ToInt32(textBox11.Text); }
            else { textBox12.Text = "Введіть B"; }

            if (Int32.TryParse(textBox10.Text, out int r3) &&
                Int32.TryParse(textBox11.Text, out int r4))
            {
                if (A + B > 32767)
                    textBox12.Text = "Переповнення";
                else
                    textBox12.Text = Convert.ToString(A + B);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = 0;

            if (Int32.TryParse(textBox13.Text, out int r1))
            {
                n = Convert.ToInt32(textBox13.Text);
                string res = "";

                for (int i = 1; i <= n; i++)
                {
                    int sq = i * i;
                    if (sq % (int)Math.Pow(10, i.ToString().Length) == i)
                    {
                        res += i + " ";
                    }
                }

                textBox14.Text = res;
            }
            else
            {
                textBox14.Text = "Введіть число";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = textBox15.Text;
            string[] points = input.Split(';');

            double maxDist = 0;
            string res = "";

            for (int i = 0; i < points.Length; i++)
            {
                var p1 = points[i].Split(',');
                double x1 = Convert.ToDouble(p1[0]);
                double y1 = Convert.ToDouble(p1[1]);

                for (int j = i + 1; j < points.Length; j++)
                {
                    var p2 = points[j].Split(',');
                    double x2 = Convert.ToDouble(p2[0]);
                    double y2 = Convert.ToDouble(p2[1]);

                    double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                    if (d > maxDist)
                    {
                        maxDist = d;
                        res = (i + 1) + " і " + (j + 1);
                    }
                }
            }

            textBox16.Text = res;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBox17.Text;

            string[] words = text.Split(new char[] { ' ', ',', '.', '!' });

            string res = "";

            foreach (string w in words)
            {
                if (w.Length == 3)
                {
                    res += w + " ";
                }
            }

            textBox18.Text = res;
        }
    }
}
