using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPday16and17Problems
{
    class InsertionSort
    {
        public void Insertion_Sort()
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = k;
            }
            BubbleSort.PrintArray(array);
        }
        public void PrintArray(int[] array)
        {
            Console.WriteLine("The Sorted array is : ");
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
