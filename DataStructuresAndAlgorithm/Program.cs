﻿using System;
namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static string FilePath = @"D:\gittestrep\DataStructuresAndAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to execute:\n 1.Binary search\n 2.Anagram \n 3.Replace String\n 4.Insertion Sort \n 5.Bubble Sort \n 6.PrimeNumber\n 7.Merge Sort\n 8.Exit");
           
            bool flag = true;
            while (flag)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        Console.WriteLine("Enter the element to search:");
                        search.ReadTextFileAndSearch(FilePath);
                        break;
                    case 2:
                        Anagram anagram= new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 3:
                        ReplaceString replaceString = new ReplaceString();
                        replaceString.StringReplace();
                        break;
                    case 4:
                        InsertionSort sort = new InsertionSort();
                        Console.WriteLine("Enter the size of the array:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the array elements:");
                        string[]  arr= new string[size];
                        for(int i = 0; i < size;i++)
                        {
                            arr[i]= Console.ReadLine();
                        }
                        sort.InsertionSorting(arr,size);
                        break;
                    case 5:
                        BubbleSort bubblesort = new BubbleSort();
                        Console.WriteLine("Enter the size of the array:");
                        int size1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the array elements:");
                        int[] array = new int[size1];
                        for (int i = 0; i < size1; i++)
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        bubblesort.bubbleSorting(array);
                        break;
                    case 6:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.IsPrimeNumber();
                        break;
                    case 7:
                        MergeSort mergeSort = new MergeSort();
                        Console.WriteLine("Enter the size of the array:");
                        int size2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the array elements:");
                        int[] ar = new int[size2];
                        for (int i = 0; i < size2; i++)
                        {
                            ar[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        mergeSort.mergeSort(ar);
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        flag = false;
                        break;
                }
            }
        }
    }
}