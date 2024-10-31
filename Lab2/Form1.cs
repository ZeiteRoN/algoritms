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
        public override void setSortType(string sortType, MyArray array)
        {
            MyArray1 array1 = new MyArray1(array, array.arrayType);
            if (sortType == "merge") sort_method = array1.MergeSort;
            else if (sortType == "insertion") sort_method = array1.insertionSort;
            base.array = array1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
