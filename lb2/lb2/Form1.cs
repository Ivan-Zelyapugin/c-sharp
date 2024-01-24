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

namespace lb2
{
    public partial class Form1 : Form
    {
        private const int N = 100000000;
        private int[] mas = new int[N+1];
        private int[] mas_2 = new int[N+1];
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();

            for (int i = 0; i < N; i++) 
                mas[i] = rnd.Next(0, N);

            mas_2[0]=rnd.Next(1, 5);
            for (int i = 1;i < N; i++)
                mas_2[i]=mas_2[i-1]+rnd.Next(1, 5);

        }

        private void find_1_Click(object sender, EventArgs e)
        {
            int i;
            int StartTime_1 = Environment.TickCount;
            for (i=0;i < N; i++)
            {
                if (mas[i] == Key_1.Value)
                {
                    int ResultTime_1 = Environment.TickCount - StartTime_1;
                    Time_1.Text = ResultTime_1.ToString();
                    Index_1.Text = i.ToString();
                    break;
                }
            }
            if (i == N)
            {
                int ResultTime_1 = Environment.TickCount - StartTime_1;
                Time_1.Text = ResultTime_1.ToString();
                Index_1.Text = "Отсутствует";
            }


            int StartTime_3 = Environment.TickCount;
            mas[N] = (int)Key_1.Value;
            for (i = 0;; i++)
            {
                if (mas[i] == Key_1.Value)
                {
                    int ResultTime_3 = Environment.TickCount - StartTime_3;
                    Time_3.Text = ResultTime_3.ToString();
                    break;
                }
            }
            if (i == N)
            {
                Index_3.Text = "Отсутствует";
            }
            else
            {
                Index_3.Text = i.ToString();
            }
        }

        private void find_2_Click(object sender, EventArgs e)
        {
            int i;
            int x = (int)Key_2.Value;
            mas_2[N] = x;
            int StartTime_2 = Environment.TickCount;
            for (i = 0;;i++)
            {
                if (mas_2[i] == x)
                {
                    int ResultTime_2 = Environment.TickCount - StartTime_2;
                    Time_2.Text = ResultTime_2.ToString();
                    break;
                }
            }
            if (i == N)
            {
                Index_2.Text = "Отсутствует";
            }
            else
            {
                Index_2.Text = i.ToString();
            }

            mas_2[N] = x+1;
            i = 0;
            int StartTime_4 = Environment.TickCount;
            while (x > mas_2[i])
            {
                i++;
            }
            int ResultTime_4 = Environment.TickCount - StartTime_4;
            Time_4.Text = ResultTime_4.ToString();
            if (x != mas_2[i])
            {
                Index_4.Text = "Отсутствует";
            }
            else
            {
                Index_4.Text = i.ToString();
            }
        }
    }
}
