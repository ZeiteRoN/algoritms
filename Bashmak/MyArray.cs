using System;
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
        public ArrayType arrayType;
        public MyArray(ArrayType arrayType, int count)
        {
            numbers = new int[count];
            this.count = count;
            int temp = count;
            this.arrayType = arrayType;

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
    }
}
