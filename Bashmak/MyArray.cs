﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aloritms
{
    public enum ArrayType
    {
        Rising,
        Descending,
        Random
    }
    public class MyArray
    {
        public int[] numbers;
        public int count;
        public MyArray(ArrayType arrayType, int count)
        {
            numbers = new int[count];
            this.count = count;
            int temp = count;

            if (arrayType == ArrayType.Descending)
            {

                for (int i = 0; i < count; i++)
                {

                    numbers[i] = temp;
                    temp--;
                }
            }
            else if (arrayType == ArrayType.Random)
            {
                numbers = GenerateUniqueRandomArray();
            }
            else if (arrayType == ArrayType.Rising)
            {
                for (int i = 0; i < count; i++) numbers[i] = i;
            }
        }
        public void bubleSort()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j]; numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
        public void insertionSort()
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
                    }
                }
            }
        }
        public int[] GenerateUniqueRandomArray()
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random random = new Random();

            while (uniqueNumbers.Count < count)
            {
                uniqueNumbers.Add(random.Next(0, count + 1));
            }

            return uniqueNumbers.ToArray();
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
    }
}