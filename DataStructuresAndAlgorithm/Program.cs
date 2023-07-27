﻿using System;
namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static string FilePath = @"D:\gittestrep\DataStructuresAndAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to execute:\n 1.Binary search\n 2.Anagram \n 3.Replace String\n 4.Insertion Sort \n 5.Exit");
           
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
                        int[]  arr= new int[size];
                        for(int i = 0; i < size;i++)
                        {
                            arr[i]= Convert.ToInt32(Console.ReadLine());
                        }
                        sort.InsertionSorting(arr,size);
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