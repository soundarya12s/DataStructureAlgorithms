using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class BinarySearch
    {
        public void ReadTextFileAndSearch(string filePath)
        {
            string readAllText= File.ReadAllText(filePath);
            string[] words = readAllText.Split(",");
            string key = Console.ReadLine();
            bool isFind = false;
            foreach(var data in words)
            {
                if(data.Equals(key))
                {
                    isFind = true;
                }
               
            }
            if (isFind)
            {
                Console.WriteLine("Search element {0}  is found", key);
            }
            else
            {
                Console.WriteLine("Search element not found");
            }
        }
    }
}
