using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class PrimeNumber
    {
        public void IsPrimeNumber()
        {
            int count;
            int num = 1000; 
            for (int i = 0; i <= num; i++)
            {
                count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
