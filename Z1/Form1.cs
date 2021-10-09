using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lenghtBox1.Text = Properties.Settings.Default.lenghtBox1_value;
            widthBox2.Text = Properties.Settings.Default.widthBox2_value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String str = Logic.Check(lenghtBox1.Text, widthBox2.Text);
            answerBox1.Enabled = true;
            answerBox1.Text = str;
        }
        private void lenghtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            double n1 = 0;
            bool r = double.TryParse(lenghtBox1.Text, out n1);
            if (e.KeyCode == Keys.Enter)
            {
                if (r)
                {
                    widthBox2.Focus();
                }
                else
                {
                    answerBox1.Enabled = true;
                    answerBox1.Text = "Вы ввели не правильное значение";
                }
            }
        }
        private void widthBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lenghtBox1.Clear();
            widthBox2.Clear();
            answerBox1.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lenghtBox1_value = lenghtBox1.Text;
            Properties.Settings.Default.widthBox2_value = widthBox2.Text;
            Properties.Settings.Default.Save();
        }
    }
    public class Logic
    {
        public static string Check(string sa, string sb)
        {
            string outMessage = "";
            double n1 = 0;
            bool r = double.TryParse(sa, out n1);
            bool t = double.TryParse(sb, out n1);
            if (r && t)
            {
                outMessage = cut(sa, sb);
            }
            else
            {
                outMessage = "Вы ввели не правильное значение";
            }
            return outMessage;
        }
        public static string cut(string sa, string sb)
        {
            string outMessage = "";
             int a = Convert.ToInt32(sa);
                int b = Convert.ToInt32(sb);
                int i = 0;

                for (int t = 0; t != 1; i++)
                {
                    if (a > b)                  //Вычисляется наименьшая сторона 
                    {

                        outMessage = outMessage + "Разрезан на квадрат размером " + b + "\n";
                        a = a - b;                          //Отрезается от прямоугольника квадрат размером наименьшей стороны прямоугольника
                        outMessage = outMessage + "Прямоугольник размером: " + a + " " + b + "\n";
                    }
                    else
                    {
                        if (a < b)
                        {
                            outMessage = outMessage + "Разрезан на квадрат размером " + a + "\n";
                            b = b - a;                      //Отрезается от прямоугольника квадрат размером наименьшей стороны прямоугольника
                            outMessage = outMessage + "Прямоугольник размером: " + a + " " + b + "\n";
                        }
                        else
                        {
                            if (a == b)      //Если прямоугольник это квадрат то отрезается весь прямоугольник
                            {
                                outMessage = outMessage + "Разрезан на квадрат размером " + a + "\n";
                                t = 1;                          //Конец цикла
                            }
                        }
                    }
                }
                outMessage = outMessage + "Количество квадратов: " + i + "\n";
            
            return outMessage;
        }
    }
}
