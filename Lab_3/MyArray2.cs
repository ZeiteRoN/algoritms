using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algoritms;
using aloritms;

namespace Lab_3
{
    public class MyArray2: MyArray
    {
        public int inversions;
        public MyArray2(MyArray array, ArrayType arrayType) : base(arrayType, array.count)
        {
            count = array.count;
            numbers = array.numbers;
        }
        public void MergeSort() => numbers = GetMergedArray(numbers);

        private int[] GetMergedArray(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }
            int middleIndex = array.Length / 2;
            int[] firstHalf = array.Take(middleIndex).ToArray();
            int[] secondHalf = array.Skip(middleIndex).Take(array.Length - middleIndex).ToArray();
            firstHalf = GetMergedArray(firstHalf);
            secondHalf = GetMergedArray(secondHalf);
            return MergeArrays(firstHalf, secondHalf);
        }

        private int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                    inversions += array1.Length - i;
                }
            }
            while (i < array1.Length)
            {
                mergedArray[k++] = array1[i++];
            }
            while (j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }
            return mergedArray;
        }

        public void bruteForce()
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                        inversions++;
                    }
                }
            }
        }
    }
}
