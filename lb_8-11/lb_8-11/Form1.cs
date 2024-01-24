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

namespace lb_8_11
{
    public partial class Form1 : Form
    {
        private const int n = 10000;
        private const int value = 20000;
        private const int N = 1000;
        private int[] m = new int[N];
        private Random random = new Random();
        private int compares;
        public Form1()
        {
            InitializeComponent();
        }

        //Метод деления
        public int div(int key)
        {
            return key % 997;
        }

        //Метод середины квадрата
        public long midSquare(long key)
        {
            int n = 3;
            long result = (key * key);
            if (result < N)
            {
                return (int)result;
            }
            int length = (int)(Math.Log10(result) + 1);
            int count = length - n;
            count -= count / 2;
            result = result / (int)Math.Pow(10, count);
            result = (int)(result % Math.Pow(10, n));
            return result;
        }

        //Метод свертывания
        public int fold(int key)
        {
            int result = 0;
            int c = key;
            while (c > 0)
            {
                result += c % n;
                c /= n;
            }
            return (int)(result % n);
        }

        //Метод умножения
        public int mult(int key)
        {
            double A = (Math.Sqrt(5) - 1) / 2;
            return (int)(N * (key * A % 1));
        }

        //Оьработка клика
        private void calculate_Click(object sender, EventArgs e)
        {
            compares = (int)count.Value;
            HashTable[] mas = new HashTable[N];
            int k1, k2, k3, k4;
            int t1 = 0, t2 = 0, t3 = 0, t4 = 0;
            for (int i = 0; i < compares; i++)
            {
                k1 = 0; k2 = 0; k3 = 0; k4 = 0;
                for (int j = 0; j < N; j++)
                {
                    m[j] = random.Next(0, 100000);
                    mas[j] = new HashTable();
                }

                for (int k = 0; k < N; k++)
                {
                    mas[div(m[k])].add(m[k]);
                }
                k1 = countColisia(mas);
                clearTable(mas);

                for (int k = 0; k < N; k++)
                {
                    mas[midSquare(m[k])].add(m[k]);
                }
                k2 = countColisia(mas);
                clearTable(mas);

                for (int k = 0; k < N; k++)
                {
                    mas[fold(m[k])].add(m[k]);
                }
                k3 = countColisia(mas);
                clearTable(mas);

                for (int k = 0; k < N; k++)
                {
                    mas[mult(m[k])].add(m[k]);
                }
                k4 = countColisia(mas);
                clearTable(mas);

                if (k1 <= k2 && k1 <= k3 && k1 <= k4)
                {
                    t1++;
                }
                if (k2 <= k1 && k2 <= k3 && k2 <= k4)
                {
                    t2++;
                }
                if (k3 <= k2 && k1 >= k3 && k3 <= k4)
                {
                    t3++;
                }
                if (k4 <= k2 && k4 <= k3 && k1 >= k4)
                {
                    t4++;
                }
            }
            method_1.Text = t1.ToString();
            method_2.Text = t2.ToString();
            method_3.Text = t3.ToString();
            method_4.Text = t4.ToString();
        }
        //Подсчет коллизий
        private int countColisia(HashTable[] table)
        {
            int count = 0;
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i].size() > 1)
                {
                    count += table[i].size() - 1;
                }
            }
            return count;
        }

        //Очистить список
        private void clearTable(HashTable[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i].clear();
            }
        }
        

        //Выход
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compare_Click(object sender, EventArgs e)
        {
            int[] m1 = new int[n];
            int[] m2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                m1[i] = random.Next(0, n);
                m2[i] = random.Next(0, value);
            }
            //метод открытой адресации
            int[] moa = new int[n];
            for (int i = 0; i < n; i++)
            {
                moa[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                int hash = fold(m1[i]);
                while (moa[hash] != -1)
                {
                    hash = (hash + 1) % n;
                }
                moa[hash] = m1[i];
            }

            int compr = 0;
            int c = 0;
            int startTime = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                int hash = fold(m2[i]);
                compr++;
                if (moa[hash] == m2[i])
                {
                    c++;
                    continue;
                }
                int pos = (hash + 1) % n;
                while (pos != hash)
                {
                    compr++;
                    if (moa[pos] == m2[i])
                    {
                        c++;
                        break;
                    }
                    pos = (pos + 1) % n;
                }

            }
            time_1.Text = (Environment.TickCount - startTime).ToString();
            compar_1.Text = (compr / n).ToString();
            find_1.Text = c.ToString();
            //метод цепочек
            HashTable[] mas = new HashTable[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new HashTable();
            }
            for (int i = 0; i< n; i++)
            {
                int hash = fold(m1[i]);
                mas[hash].add(m1[i]);
            }
            c = 0;
            compr = 0;
            startTime = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                int hash = fold(m2[i]);
                compr++;
                if (mas[hash].size() == 0)
                    continue;
                foreach (int value in mas[hash].getlist())
                {
                    compr++;
                    if(value == m2[i])
                    {
                        c++;
                        break;
                    }
                }
            }
            time_2.Text = (Environment.TickCount - startTime).ToString();
            compar_2.Text = (compr / (double)n).ToString();
            find_2.Text = c.ToString();
        }
    }


    class HashTable
    {
        private List<int> list;

        public HashTable()
        {
            list = new List<int>();
        }
        public void add(int key)
        {
            list.Add(key);
        }
        public int size()
        {
            return list.Count;
        }

        public void clear()
        {
            list.Clear();
        }

        public int[] getlist()
        {
            return list.ToArray();
        }

    }
}
