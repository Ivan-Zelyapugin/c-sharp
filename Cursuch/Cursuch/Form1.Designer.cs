namespace Cursuch
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.list_lenght = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.persent_sort = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_lenght)).BeginInit();
            this.panel11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persent_sort)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.Interval = 500D;
            chartArea1.CursorY.Interval = 200D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Шаг";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(206, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Деление пополам";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Кнут";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Вирт";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(750, 319);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this._1,
            this._2,
            this._3,
            this._4,
            this._5,
            this._6,
            this._7,
            this._8,
            this._9,
            this._10});
            this.dataGridView1.Location = new System.Drawing.Point(204, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 52;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 170);
            this.dataGridView1.TabIndex = 10;
            // 
            // Step
            // 
            this.Step.HeaderText = "Шаг";
            this.Step.MinimumWidth = 6;
            this.Step.Name = "Step";
            this.Step.Width = 70;
            // 
            // _1
            // 
            this._1.HeaderText = "";
            this._1.MinimumWidth = 6;
            this._1.Name = "_1";
            this._1.Width = 70;
            // 
            // _2
            // 
            this._2.HeaderText = "";
            this._2.MinimumWidth = 6;
            this._2.Name = "_2";
            this._2.Width = 70;
            // 
            // _3
            // 
            this._3.HeaderText = "";
            this._3.MinimumWidth = 6;
            this._3.Name = "_3";
            this._3.Width = 70;
            // 
            // _4
            // 
            this._4.HeaderText = "";
            this._4.MinimumWidth = 6;
            this._4.Name = "_4";
            this._4.Width = 70;
            // 
            // _5
            // 
            this._5.HeaderText = "";
            this._5.MinimumWidth = 6;
            this._5.Name = "_5";
            this._5.Width = 70;
            // 
            // _6
            // 
            this._6.HeaderText = "";
            this._6.MinimumWidth = 6;
            this._6.Name = "_6";
            this._6.Width = 70;
            // 
            // _7
            // 
            this._7.HeaderText = "";
            this._7.MinimumWidth = 6;
            this._7.Name = "_7";
            this._7.Width = 70;
            // 
            // _8
            // 
            this._8.HeaderText = "";
            this._8.MinimumWidth = 6;
            this._8.Name = "_8";
            this._8.Width = 70;
            // 
            // _9
            // 
            this._9.HeaderText = "";
            this._9.MinimumWidth = 6;
            this._9.Name = "_9";
            this._9.Width = 70;
            // 
            // _10
            // 
            this._10.HeaderText = "";
            this._10.MinimumWidth = 6;
            this._10.Name = "_10";
            this._10.Width = 70;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.list_lenght);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(204, 191);
            this.panel10.TabIndex = 14;
            // 
            // list_lenght
            // 
            this.list_lenght.Location = new System.Drawing.Point(31, 104);
            this.list_lenght.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.list_lenght.Name = "list_lenght";
            this.list_lenght.Size = new System.Drawing.Size(120, 22);
            this.list_lenght.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.MaximumSize = new System.Drawing.Size(180, 40);
            this.label10.MinimumSize = new System.Drawing.Size(180, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "Размерность двусвязного списка";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.groupBox1);
            this.panel11.Controls.Add(this.persent_sort);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(0, 191);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(204, 298);
            this.panel11.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип упорядоченности";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(0, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Упорядоченная";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(0, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Неупорядоченная";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(0, 97);
            this.radioButton4.MaximumSize = new System.Drawing.Size(200, 0);
            this.radioButton4.MinimumSize = new System.Drawing.Size(0, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(200, 40);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Упорядоченная в обратном порядке";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(196, 20);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Частично упорядоченная";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // persent_sort
            // 
            this.persent_sort.Location = new System.Drawing.Point(31, 223);
            this.persent_sort.Name = "persent_sort";
            this.persent_sort.Size = new System.Drawing.Size(120, 22);
            this.persent_sort.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Процент упорядоченности";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.clear);
            this.panel12.Controls.Add(this.exit);
            this.panel12.Controls.Add(this.sort);
            this.panel12.Location = new System.Drawing.Point(0, 489);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(956, 71);
            this.panel12.TabIndex = 16;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(178, 27);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 30);
            this.clear.TabIndex = 9;
            this.clear.Text = "Очистить ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(649, 27);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 30);
            this.exit.TabIndex = 8;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(31, 27);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(141, 30);
            this.sort.TabIndex = 7;
            this.sort.Text = "Отсортировать";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 559);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Зеляпугин Иван 22ВП2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_lenght)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persent_sort)).EndInit();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown list_lenght;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown persent_sort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewTextBoxColumn _1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _6;
        private System.Windows.Forms.DataGridViewTextBoxColumn _7;
        private System.Windows.Forms.DataGridViewTextBoxColumn _8;
        private System.Windows.Forms.DataGridViewTextBoxColumn _9;
        private System.Windows.Forms.DataGridViewTextBoxColumn _10;
    }
}

