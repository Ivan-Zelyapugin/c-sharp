using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0 || numericUpDown2.Value == 0 || numericUpDown3.Value == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля перед расчетом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = (2 * (numericUpDown1.Value * numericUpDown2.Value + numericUpDown2.Value * numericUpDown3.Value + numericUpDown1.Value * numericUpDown3.Value)).ToString();
                textBox2.Text = (numericUpDown1.Value * numericUpDown2.Value * numericUpDown3.Value).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
