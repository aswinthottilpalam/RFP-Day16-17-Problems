using System;
using System.Collections.Generic;
using System.IO;

namespace RFPday16and17Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Welcome to Algorithm and Data Structures Programs**********  ");
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("\n1.Bubble Sort \n2.Insertion Sort \n3.Check Anagram \n4.Check Primenumber \n5.Merge Sort \n6.Exit");
                Console.WriteLine("Enter your Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        BubbleSort sort = new BubbleSort();
                        sort.Bubble_Sort();
                        break;
                    case 2:
                        InsertionSort insertion = new InsertionSort();
                        insertion.Insertion_Sort();
                        break;
                    case 3:
                        Anagram anagram = new Anagram();
                        anagram.Anagram_Check();
                        break;
                    case 4:
                        PrimeNumber primenumber = new PrimeNumber();
                        primenumber.PrimeNumberCheck();
                        break;
                    case 5:
                        MergeSort sortMerge = new MergeSort();
                        sortMerge.DoMergeSort();
                        break;
                    case 6:
                        string txtpath = File.ReadAllText(@"C:\Users\HP\Desktop\Class\RFPday16and17Problems\RFPday16and17Problems\words.txt");
                        List<string> words = new List<string>(txtpath.Split(" "));
                        words.Sort();
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.BinarySearchWord(word);
                        break;
                    case 7:
                        Console.WriteLine("Exited");
                        return;
                    default:
                        Console.WriteLine("You have entered a Wrong option! please try again.");
                        break;
                }
            }
        }
    }
}
