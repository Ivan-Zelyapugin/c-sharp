using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Cursuch
{
    public partial class Form1 : Form
    {
        //Загрузка формы
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            chart1.Titles.Add("Сортировка Шелла");
            chart1.ChartAreas[0].AxisX.Title = "Количество элементов";
            chart1.ChartAreas[0].AxisY.Title = "Время";
            
        }

        //Создание и заполнение упорядоченного двусвязного списка
        public LinkedList<int> Init_ordered(int N)
        {
            Random rnd = new Random();
            LinkedList<int> list_2 = new LinkedList<int>();
            list_2.AddLast(rnd.Next(0, 5));
            for (int i = 1; i < N; i++)
            {
                list_2.AddLast(list_2.Last() + rnd.Next(0, 5));
            }
            return list_2;
        }

        //Создание и заполнение неупорядоченного двусвязного списка
        public LinkedList<int> Init_unordered(int N)
        {
            Random rnd = new Random();
            LinkedList<int> list_1 = new LinkedList<int>();
            for (int i = 0; i < N; i++)
            {
                list_1.AddLast(rnd.Next(0, N));
            }
            return list_1;
        }

        //Создание и заполнение упорядоченного в обратном порядке двусвязного списка
        public LinkedList<int> Init_ordered_back(int N)
        {
            Random rnd = new Random();
            LinkedList<int> list_3 = new LinkedList<int>();
            list_3.AddFirst(rnd.Next(0, 5));
            for (int i = 1; i < N; i++)
            {
                list_3.AddFirst(list_3.Last() + rnd.Next(0, 5));
            }
            return list_3;
        }

        //Создание и заполнение частично упорядоченного двусвязного списка
        public LinkedList<int> Init_partially_ordered(int N)
        {
            Random rnd = new Random();
            LinkedList<int> list_4 = new LinkedList<int>();
            int persent_s = N * (int)persent_sort.Value/100;
            list_4.AddLast(rnd.Next(0, 5));
            for (int i = 1; i < persent_s; i++)
            {
                list_4.AddLast(list_4.Last() + rnd.Next(0, 5));
            }
            for (int i = persent_s; i < N; i++)
            {
                list_4.AddLast(rnd.Next(0, N));
            }
            return list_4;
        }

        //Функция которая заменит [] в двусвязном списке
        public void Replace(LinkedList<int> list,int index, int value)
        {
            var currentNode = list.First;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Value = value;
        }

        //Сортиовка Шелла, алгоритм вычисления шага - Вирт
        public void Sort_Shell_Virt(int N, LinkedList<int> list)
        {
            int gaps = 1;
            while (gaps < N)
            {
                gaps = 2 * gaps + 1;
            }
            while (gaps > 0)
            {
                for (int i = gaps; i < N; i++)
                {
                    int temp = list.ElementAt(i);
                    int j = i;
                    while (j >= gaps && list.ElementAt(j-gaps) > temp)
                    {
                        Replace(list, j, list.ElementAt(j-gaps));
                        j -= gaps;
                    }
                    Replace(list, j, temp);
                }
                gaps /= 2;
            }
        }

        //Сортиовка Шелла, алгоритм вычисления шага - Кнут
        public void Sort_Shell_Knut(int N, LinkedList<int> list)
        { 
            int gap = 1;
            while (gap < N / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap > 0)
            {
                for (int i = gap; i < N; i++)
                {
                    int temp = list.ElementAt(i);
                    int j = i;
                    while (j >= gap && list.ElementAt(j-gap) > temp)
                    {
                        Replace(list, j, list.ElementAt(j - gap));
                        j -= gap;
                    }
                    Replace(list, j, temp);
                }
                gap /= 3;
            }
        }

        //Сортиовка Шелла, алгоритм вычисления шага - Деление пополам
        public void Sort_Shell_Del(int N, LinkedList<int> list)
        {
            int gap = N / 2;
            while (gap > 0)
            {
                // Сортировать элементы, разделенные шагом
                for (int i = 0; i < N - gap; i++)
                {
                    // Сравнить элементы, разделенные шагом
                    int temp = list.ElementAt(i);
                    int j = i + gap;
                    while (j < N && list.ElementAt(j) < temp)
                    {
                        Replace(list, (j - gap), list.ElementAt(j));
                        j += gap;
                    }
                    Replace(list, (j - gap), temp);
                }
                // Уменьшить шаг
                gap /= 2;
            }
        }

        //Выход из приложения
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Заполнение таблицы
        private void completion(string type, LinkedList<int> time, int j, LinkedList<int> size)
        {
            dataGridView1.Rows[j].Cells[0].Value = type;
            for (int i = 0; time.Count > i; i++)
            {
                dataGridView1.Columns[i+1].HeaderText = size.ElementAt(i).ToString();
                dataGridView1.Rows[j].Cells[i + 1].Value = time.ElementAt(i).ToString();
            }
        }

        //Сортировка(для свича)
        private int Sorting(int i,int n, LinkedList<int> list, string[] step)
        {
            int start = Environment.TickCount;
            if (i == 0)
            {
                Sort_Shell_Del(n, list);
            }
            if (i == 1)
            {
                Sort_Shell_Knut(n, list);
            }
            if (i == 2)
            {
                Sort_Shell_Virt(n, list);
            }
            int result = Environment.TickCount - start;
            return result;
        }

        //Обработчик клика на кнопку сортировать
        private void sort_Click(object sender, EventArgs e)
        {
            int n = (int)list_lenght.Value;
            string type;
            LinkedList<int> list = new LinkedList<int>();
            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Пожалуйста, выберите тип последовательности!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                LinkedList<int> listSize = new LinkedList<int>();
                for (int k=1; k<=10; k++)
                {
                    listSize.AddLast(n/10*k);
                }
                //int[] arraySizes = { 500, 1000, 1500, 2000, 2500, 3000, 3500, 4000, 4500,5000};
                if (radioButton1.Checked)
                {
                    type = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    type = radioButton2.Text;
                }
                else if (radioButton3.Checked)
                {
                    type =radioButton3.Text;
                }
                else          
                { 
                    type = radioButton4.Text; 
                }
                string[] step = { "Деление пополам", "Кнут", "Вирт" };
                switch (type)
                {
                    case "Упорядоченная":
                        for (int i = 0; i < step.Length; i++)
                        {
                            Series series = new Series(step[i]);
                            series.ChartType = SeriesChartType.Line;
                            LinkedList<int> time = new LinkedList<int>();
                            foreach (var size in listSize)
                            {
                                list = Init_ordered(size);
                                time.AddLast(Sorting(i, size, list, step));
                            }
                            completion(step[i], time, i, listSize);
                            chart1.Series[i].Points.Clear();
                            int x = listSize.ElementAt(0);
                            int y = 0;
                            chart1.Series[i].Points.AddXY(0, 0);
                            while (x <= listSize.ElementAt(9))
                            {
                                chart1.Series[i].Points.AddXY(x, time.ElementAt(y));
                                x += listSize.ElementAt(0);
                                y++;
                            }

                        }
                        
                        break;
                    case "Неупорядоченная":           
                        for (int i = 0; i < step.Length; i++)
                        {
                            LinkedList<int> time = new LinkedList<int>();
                            foreach (var size in listSize)
                            {
                                list = Init_unordered(size);
                                time.AddLast(Sorting(i, size, list, step));
                            }
                            completion(step[i], time, i, listSize);
                            chart1.Series[i].Points.Clear();
                            int x = listSize.ElementAt(0);
                            int y = 0;
                            chart1.Series[i].Points.AddXY(0, 0);
                            while (x <= listSize.ElementAt(9))
                            {
                                chart1.Series[i].Points.AddXY(x, time.ElementAt(y));
                                x += listSize.ElementAt(0);
                                y++;
                            }
                        }
                        break;
                    case "Частично упорядоченная":
                       
                        for (int i = 0; i < step.Length; i++)
                        {
                            
                            LinkedList<int> time = new LinkedList<int>();
                            foreach (var size in listSize)
                            {
                                list = Init_partially_ordered(size);
                                time.AddLast(Sorting(i, size, list, step));
                            }
                            completion(step[i], time, i, listSize);
                            chart1.Series[i].Points.Clear();
                            int x = listSize.ElementAt(0);
                            int y = 0;
                            chart1.Series[i].Points.AddXY(0, 0);
                            while (x <= listSize.ElementAt(9))
                            {
                                chart1.Series[i].Points.AddXY(x, time.ElementAt(y));
                                x += listSize.ElementAt(0);
                                y++;
                            }

                        }
                        break;
                    case "Упорядоченная в обратном порядке":
                        
                        for (int i = 0; i < step.Length; i++)
                        {
                            
                            LinkedList<int> time = new LinkedList<int>();
                            foreach (var size in listSize)
                            {
                                list = list = Init_ordered_back(size);
                                time.AddLast(Sorting(i, size, list, step));
                            }
                            completion(step[i], time, i, listSize);
                            chart1.Series[i].Points.Clear();
                            int x = listSize.ElementAt(0);
                            int y = 0;
                            chart1.Series[i].Points.AddXY(0, 0);
                            while (x <= listSize.ElementAt(9))
                            {
                                chart1.Series[i].Points.AddXY(x, time.ElementAt(y));
                                x += listSize.ElementAt(0);
                                y++;
                            }

                        }
                        break;
                }

                
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                chart1.Series.Clear();
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Нет отображенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
