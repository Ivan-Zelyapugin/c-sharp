using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb5
{
    public partial class Form1 : Form
    {
        private const int N = 100000000;

        private int[] mas = new int[N + 1];
        private const int Nwile = 1000000;
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            mas[0] = rnd.Next(1, 5);
            for (int i = 1; i < N; i++)
                mas[i] = mas[i - 1] + rnd.Next(1, 5);
        }

        private void find_Click(object sender, EventArgs e)
        {
            // бинарный неоптимальный
            long x = (long)key.Value;
            long i =0;
            long l;
            long r;
            int StartTime_1 = Environment.TickCount;
            for (int j = 0; j < Nwile; j++)
            {
                l = 0;
                r = N - 1;
                i = 0;
                while (r >= l)
                {
                    i = (l + r) / 2;
                    if (x == mas[i])
                    {
                        break;
                    }
                    else if (x < mas[i])
                    {
                        r = i - 1;
                    }
                    else
                    {
                        l = i + 1;
                    }
                }
            }
            int ResultTime_1 = Environment.TickCount - StartTime_1;
            time_1.Text = ResultTime_1.ToString();
            if (x == mas[i])
            {
                index_1.Text = i.ToString();
            }
            else
            {
                index_1.Text = "Отсутствует";
            }
            //бинарный оптимальный
            int StartTime_2 = Environment.TickCount;
            for(int j = 0;j < Nwile; j++)
            {
                l = 0;
                r = N - 1;
                i = 0;
                while (r > l)
                {
                    i = (l + r) / 2;
                    if (x <= mas[i])
                    {
                        r = i;
                    }
                    else
                    {
                        l = i + 1;
                    }
                }
                if (x == mas[r])
                {
                    i = r;
                }
            }
            int ResultTime_2 = Environment.TickCount - StartTime_2;
            time_2.Text = ResultTime_2.ToString();
            if (mas[i]==x)
            {
                index_2.Text = i.ToString();
            }
            else
            {
                index_2.Text = "Отсутствует";
            }

            //Интерполяционный 
            int StartTime_3 = Environment.TickCount;
            for (int j = 0; j<Nwile;j++)
            {
                l = 0;
                r = N - 1;
                i = 0;
                while (mas[l] < x && x < mas[r])
                {
                    i = l + (x - mas[l]) * (r - l) / (mas[r] - mas[l]);
                    if (x == mas[i])
                    {
                        break;
                    }
                    if (x < mas[i])
                    {
                        r = i - 1;
                    }
                    if (x > mas[i])
                    {
                        l = i + 1;
                    }
                }
                if (x == mas[l])
                {
                    i = l;
                }
                else if (x == mas[r])
                {
                    i = r;
                }
            }
            int ResultTime_3 = Environment.TickCount - StartTime_3;
            time_3.Text = ResultTime_3.ToString();
            if (mas[i] == x)
            {
                index_3.Text = i.ToString();
            }
            else
            {
                index_3.Text = "Отсутствует";
            }

            // Последовательный бинарный
            int p = 0;
            int b = 0;
            int StartTime_4 = Environment.TickCount;
            for (int j = 0; j < Nwile; j++)
            {
                p = 0;
                b = N / 2;
                while (b > 0)
                {
                    while (p + b < N && mas[p + b] <= x)
                    {
                        p += b;
                    }
                    b /= 2;
                }
            }
            int ResultTime_4 = Environment.TickCount - StartTime_4;
            time_4.Text = ResultTime_4.ToString();
            if (mas[p] == x)
            {
                index_4.Text = p.ToString();
            }
            else
            {
                index_4.Text = "Отсутствует";
            }

            //последовательный оптимальный
            mas[N] = (int)x;
            int StartTime_5 = Environment.TickCount;   
            for (int j=0; j < 100; j++)
            {
                i = 0;
                while (x > mas[i])
                {
                    i++;
                }
            }

            int ResultTime_5 = Environment.TickCount - StartTime_5;
            time_5.Text = (Nwile/100*ResultTime_5).ToString();
            if (x != mas[i])
            {
                index_5.Text = "Отсутствует";
            }
            else
            {
                index_5.Text = i.ToString();
            }
        }
    }
}
