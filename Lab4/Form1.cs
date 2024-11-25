using aloritms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab4
{
    public partial class Form1 : algoritms.Form1
    {
        public QuickSortArray NutsAndBolts { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        public override void setSortType(string sortType, MyArray array)
        {
            QuickSortArray quickSortArray = new QuickSortArray(array.arrayType, array.count);

            if (sortType == "quicksort")
            {
                sort_method = quickSortArray.QuickSort;
            }
            else if (sortType == "randomquicksort")
            {
                sort_method = quickSortArray.RandomQuickSort;
            }

            base.array = quickSortArray;
        }

        public override void printArray()
        {
            if (base.array is QuickSortArray quickSortArray)
            {
                quickSortArray.QuickSort();
                printToTextBox(quickSortArray.numbers, richTextBox1);

                quickSortArray = new QuickSortArray(base.array.arrayType, base.array.count);
                quickSortArray.RandomQuickSort();
                printToTextBox(quickSortArray.numbers, richTextBox2);
            }
        }

        public override void drawSeries(string method, Series series)
        {
            for (int i = 10; i <= 5000; i += 500)
            {
                var array = new QuickSortArray(ArrayType.Random, i);
                Stopwatch sw = new Stopwatch();

                if (method == "quicksort")
                {
                    sw.Start();
                    array.QuickSort();
                    sw.Stop();
                }
                else if (method == "randomquicksort")
                {
                    sw.Start();
                    array.RandomQuickSort();
                    sw.Stop();
                }

                series.Points.AddXY(i, sw.Elapsed.TotalMilliseconds);
            }
        }
    }
}
