using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb12_13
{
    public partial class Form1 : Form
    {
        
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 7;       
            dataGridView1.ColumnCount = 5;
            dataGridView1.Rows[0].Cells[1].Value = "Обмен";
            dataGridView1.Rows[1].Cells[1].Value = "Выбор";
            dataGridView1.Rows[2].Cells[1].Value = "Включение";
            dataGridView1.Rows[3].Cells[1].Value = "Шелла";
            dataGridView1.Rows[4].Cells[1].Value = "Быстрая";
            dataGridView1.Rows[5].Cells[1].Value = "Линейная";
            dataGridView1.Rows[6].Cells[1].Value = "Встроенная";
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = false;
            }

        }
        private int[] BubbleSort(int[] arr)
        {
            int compr = 0;
            int replace = 0;
            int start = Environment.TickCount;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool check = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    compr++;
                    if (arr[j] > arr[j + 1])
                    {
                        replace++;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        check = false;
                    }
                }
                if (check)
                {
                    break;
                }
            }
            int res = Environment.TickCount - start;
            int[] result = {compr, replace, res};
            return result;

        }

        private int[] Select(int[] arr)
        {
            int compr = 0;
            int replace = 0;
            int start = Environment.TickCount;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int max = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    compr++;
                    if (arr[j] > arr[max])
                        max = j;

                }
                replace++;
                int temp = arr[i];
                arr[i] = arr[max];
                arr[max] = temp;
            }
            int res = Environment.TickCount - start;
            int[] result = {compr, replace, res };
            return result;
        }
        private void sort_Click(object sender, EventArgs e)
        {       
            int N = (int)numericUpDown1.Value;
            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(0, N);
            }

            //Пузырёк
            if ((bool)dataGridView1.Rows[0].Cells[0].Value)
            {
                int[] copy = (int[])mas.Clone();
                int[] res = BubbleSort(copy);
                dataGridView1.Rows[0].Cells[2].Value = res[0];
                dataGridView1.Rows[0].Cells[3].Value = res[1];
                dataGridView1.Rows[0].Cells[4].Value = res[2];
            }
            else
            {
                for (int i = 2; i < 5; i++)
                {
                    dataGridView1.Rows[0].Cells[i].Value = null;
                }
            }

            //Прямой выбор
            if ((bool)dataGridView1.Rows[1].Cells[0].Value)
            {
                int[] copy = (int[])mas.Clone();
                int[] res = Select(copy);
                dataGridView1.Rows[1].Cells[2].Value = res[0];
                dataGridView1.Rows[1].Cells[3].Value = res[1];
                dataGridView1.Rows[1].Cells[4].Value = res[2];
            }
            else
            {
                for (int i = 2; i < 5; i++)
                {
                    dataGridView1.Rows[1].Cells[i].Value = null;
                }
            }
        }
    }
}
