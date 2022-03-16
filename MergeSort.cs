using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPday16and17Problems
{
    class MergeSort
    {
        public void DoMergeSort()
        {
            Console.WriteLine("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter  elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array, 0, size - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        public static int Sort(int[] array, int first, int last)
        {
            if (last > first)
            {
                int mid = (first + last) / 2;

                Sort(array, first, mid);
                Sort(array, mid + 1, last);

                Merge(array, first, mid, last);
            }
            return -1;
        }
        public static void Merge(int[] array, int first, int mid, int last)
        {
            int size1 = mid - first + 1;
            int size2 = last - mid;

            int[] firstArray = new int[size1];
            int[] secondArray = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                firstArray[i] = array[first + i];
            }
            for (int i = 0; i < size1; i++)
            {
                secondArray[i] = array[mid + i + 1];
            }

            int x = 0, y = 0;
            int k = first;
            while (x < size1 && y < size2)
            {
                if (firstArray[x] > secondArray[y])
                {
                    array[k] = secondArray[y];
                    y++;
                }
                else
                {
                    array[k] = firstArray[x];
                    x++;
                }
                k++;
            }
            while (x < size1)
            {
                array[k] = firstArray[x];
                x++;
                k++;
            }
            while (y < size2)
            {
                array[k] = secondArray[y];
                y++;
                k++;
            }
        }
    }
}
