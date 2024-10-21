using aloritms;

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
            if (sortType == "merge") sort_method = array.MergeSort;  else if (sortType == "insertion") sort_method = array.insertionSort;
        }
    }
}
