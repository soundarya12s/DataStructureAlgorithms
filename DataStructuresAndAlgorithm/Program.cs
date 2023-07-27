using System;
namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static string FilePath = @"D:\gittestrep\DataStructuresAndAlgorithm\Files\Search.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the option to execute:\n 1.Binary search\n 2.Anagram \n 3.Exit");
           
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
                       flag=false;
                        break;
                  
                    default:
                       Console.WriteLine("Please enter a valid option");
                       flag= false;
                       break;
                }
            }
        }
    }
}
