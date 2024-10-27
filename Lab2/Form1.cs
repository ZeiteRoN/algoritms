using aloritms;
using System;

namespace Lab2
{
    public partial class Form1 : algoritms.Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        public override void setSortType(string sortType, MyArray array, string action)
        {
            MyArray1 array1 = new MyArray1(array, array.arrayType);
            if (sortType == "merge")
            {
                if(action == "draw") sort_method = array1.MergeSort;
                else
                {
                    sort_method = array1.MergeSort;
                    for (int i = 0; i < array1.count; i++)
                    {
                        richTextBox1.Text += $"{array1.numbers[i]}\n";
                    }
                    sort_method();
                    for (int i = 0; i < array1.count; i++)
                    {
                        richTextBox2.Text += $"{array1.numbers[i]}\n";
                    }
                }
            }
            else if (sortType == "insertion") sort_method = array1.insertionSort;
        }
    }
}
