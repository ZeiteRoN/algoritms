using aloritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class QuickSortArray : MyArray
    {
        public QuickSortArray(ArrayType arrayType, int count) : base(arrayType, count) { }

        public void QuickSort()
        {
            QuickSortLogic(numbers, 0, numbers.Length - 1);
        }

        private void QuickSortLogic(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortLogic(array, low, pivotIndex - 1);
                QuickSortLogic(array, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }

        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public void RandomQuickSort()
        {
            RandomQuickSortLogic(numbers, 0, numbers.Length - 1);
        }

        private void RandomQuickSortLogic(int[] array, int low, int high)
        {
            if (low < high)
            {
                Random random = new Random();
                int pivotIndex = random.Next(low, high + 1);
                Swap(array, pivotIndex, high);
                int partitionIndex = Partition(array, low, high);
                RandomQuickSortLogic(array, low, partitionIndex - 1);
                RandomQuickSortLogic(array, partitionIndex + 1, high);
            }
        }
    }

}
