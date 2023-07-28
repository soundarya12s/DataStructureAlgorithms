using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class BubbleSort
    {
        public void bubbleSorting(int[] intArray)
        {
            int count = 0;
            for (int j = 0; j <= intArray.Length - 1; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i < intArray.Length-j - 1; i++)
                {
                    count = count + 1;
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("After Sorting Array :");
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
           
        }
    }
}
