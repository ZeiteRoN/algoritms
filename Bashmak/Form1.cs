﻿using aloritms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace algoritms
{
    public partial class Form1 : Form
    {
        public delegate void SortMethod();
        protected SortMethod sort_method;


        public Form1()
        {
            InitializeComponent();
        }

        public void sortButton_Click(object sender, EventArgs e)
        {
            int count = Int32.Parse(textBox1.Text);
            richTextBox1.Clear();
            richTextBox2.Clear();

            MyArray numbers = choosenRange(count);
            printSortedNums(numbers, count);
        }

        public void rising_CheckedChanged(object sender, EventArgs e)
        {

        }
        public MyArray choosenRange(int count)
        {
            if (rising.Checked)
            {
                return new MyArray(ArrayType.Rising, count);
            }
            else if (descending.Checked)
            {
                return new MyArray(ArrayType.Descending, count);
            }
            else
            {
                return new MyArray(ArrayType.Random, count);
            }
        }

        public void research_Click(object sender, EventArgs e)
        {

        }

        public void printSortedNums(MyArray numbers, int count)
        {
            foreach (Control control in sortType.Controls)
            {
                if (control is System.Windows.Forms.RadioButton radioButton && radioButton.Checked)
                {
                    setSortType(radioButton.Tag.ToString(), numbers);
                }
            }
            
                for (int i = 0; i < count; i++)
                {
                    richTextBox1.Text += $"{numbers.numbers[i]}\n";
                }
                sort_method();
                for (int i = 0; i < count; i++)
                {
                    richTextBox2.Text += $"{numbers.numbers[i]}\n";
                }
        }

        public long MeasureSortTime(MyArray array)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            array.bubleSort();
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        public virtual void research_Click_1(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            MyArray array = new MyArray(ArrayType.Descending, 10);
            drawSeries(bubbleSort.Tag.ToString(), chart1.Series[0]);

            drawSeries(insertionSort.Tag.ToString(), chart1.Series[1]);
        }

        public void drawSeries(string method, Series series)
        {
            for (int i = 10; i <= 5000; i += 500)
            {
                var array = new MyArray(ArrayType.Descending, i);
                Stopwatch sw = new Stopwatch();
                setSortType(method, array);
                sw.Start();
                sort_method();
                sw.Stop();
                series.Points.AddXY(i, sw.Elapsed.TotalMilliseconds);
            }
        }
        public virtual void setSortType(string sortType, MyArray array)
        {
            if (sortType == "bubble") sort_method = array.bubleSort;
            else if (sortType == "insertion") sort_method = array.insertionSort;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}