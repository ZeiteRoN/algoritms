using algoritms;
using aloritms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static algoritms.Form1;

namespace Lab_3
{
    public partial class Form1 : algoritms.Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        public override void setSortType(string sortType, MyArray array)
        {
            MyArray2 array2 =  new MyArray2(array, array.arrayType);
            if (sortType == "merge") sort_method = array2.MergeSort;
            else if (sortType == "insertion") sort_method = array2.bruteForce;
            base.array = array2;
        }

        public override void printArray()
        {
            MyArray2 inversionArray = (MyArray2)base.array;
            printToTextBox(inversionArray.numbers, richTextBox1);
            sort_method();
            printToTextBox(new int[] { inversionArray.inversions }, richTextBox2);
        }
    }
}
