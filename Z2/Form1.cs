using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.textBox1_value;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            String str = Logic.Check(textBox1.Text);
            textBox2.Enabled = true;
            textBox2.Text = str;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.textBox1_value = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
    public class Logic
    {

        public static string Check(string s)
        {
            string outMessage = "";
            if (!String.IsNullOrWhiteSpace(s))
            {
                double n1 = 0;
                bool r = double.TryParse(s, out n1);
                if (!r)
                {
                    int t = 0;
                    for (int i = 0; i < s.Length; i++) {
                        if (char.IsLetter(s[i]))
                        {
                            t = 1;
                        }
                    }
                    if (t == 0)
                    {
                        outMessage = Sum(s);
                    }
                    else
                    {
                        outMessage = "Вы ввели не правильное выражение";
                    }
                    
                }
                else
                {
                    outMessage = "Вы ввели не правильное выражение";
                }

            }
            else
            {
                outMessage = "Пустая строка";
            }
            return outMessage;
        }
        public static string Sum(string s)
        {
            string outMessage = "";
            int t = 0, z = 0;
           
                    if (s[s.Length - 1] == '+' || s[s.Length - 1] == '-')           //если последний символ + или - то выводит ошибку
                    {
                        z = 1;
                    }
                    else
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s[i] != ' ' || s[i] != '+' || s[i] != '-' || s[i] != '1' || s[i] != '2' || s[i] != '3' || s[i] != '4' || s[i] != '5' || s[i] != '6' || s[i] != '7' || s[i] != '8' || s[i] != '9')    //Проверяет правильно ли введено выражение
                            {
                                t = 1;
                            }
                            if ((s[i] == '+' || s[i] == '-') && (s[i + 1] == '+' || s[i + 1] == '-') && i < (s.Length - 1))         //Если два символа подряд то выводт ошибку
                            {
                                z = 1;
                            }

                        }
                    }
                    if (t == 1 && z == 0 && (s[0] != '+' && s[s.Length - 1] != '-' && s[s.Length - 1] != '+'))   //Если правильно 
                    {
                        int sum = 0, d1 = 0;                //Переменные содержащие информацию о сумме и переменной
                        int i = 0;
                        for (; s[i] != '+' && s[i] != '-'; i++)                     //Первая переменная становится суммой
                        {
                            sum = sum * 10 + Convert.ToInt32(s[i]) - 48;
                        }
                        for (; i < s.Length; i++)
                        {
                            if (s[i] == '+' || s[i] == '-')
                            {
                                i++;
                                for (int j = i; s[j] != '+' && s[j] != '-'; j++)    //Вычисляется вторая переменная
                                {
                                    d1 = d1 * 10 + Convert.ToInt32(s[j]) - 48;
                                    if ((j + 1) == s.Length)
                                    {
                                        break;
                                    }
                                }
                                if (s[i - 1] == '+')                                //Если + то прибавляется эта переменная к сумме
                                {
                                    sum = sum + d1;
                                    d1 = 0;
                                }
                                if (s[i - 1] == '-')                                //Если - то отнимается эта переменная от суммы
                                {
                                    sum = sum - d1;
                                    d1 = 0;
                                }
                            }
                        }
                        outMessage = "Сумма = " + sum;
                    }
                    else
                    {
                        outMessage = "Вы ввели не правильное выражение";                                                //если не правильно
                    }
                
           
            return outMessage;
        }
    }
}
