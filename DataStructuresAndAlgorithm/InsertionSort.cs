using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class InsertionSort
    {
        public string[] InsertionSorting(string[] array, int length)
        {
            for (int i = 1; i < length; i++)
            {
                var key = array[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (string.Compare(key, array[j])<0)
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("Sorted:");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
            return array;
        }
    }
}
