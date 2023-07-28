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
            static bool IsPrime(int num)
            {
                if (num <= 1)
                    return false;
                if (num == 2)
                    return true;
                if (num % 2 == 0)
                    return false;

                for (int i = 3; i <= Math.Sqrt(num); i += 2)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }

            static bool IsAnagram(int num1, int num2)
            {
                char[] num1Array = num1.ToString().ToCharArray();
                char[] num2Array = num2.ToString().ToCharArray();
                Array.Sort(num1Array);
                Array.Sort(num2Array);

                return new string(num1Array) == new string(num2Array);
            }

            static bool IsPalindrome(int num)
            {
                string numStr = num.ToString();
                int left = 0;
                int right = numStr.Length - 1;

                while (left < right)
                {
                    if (numStr[left] != numStr[right])
                        return false;
                    left++;
                    right--;
                }
                return true;
            }
            int lowerRange = 0;
            int upperRange = 1000;

            List<int> primeNumbers = new List<int>();
            for (int num = lowerRange; num <= upperRange; num++)
            {
                if (IsPrime(num))
                    primeNumbers.Add(num);
            }

            Console.WriteLine("Prime numbers in the range of 0 to 1000:");
            foreach (int prime in primeNumbers)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();

            List<int> anagramPalindromePrimes = new List<int>();
            for (int i = 0; i < primeNumbers.Count; i++)
            {
                for (int j = i + 1; j < primeNumbers.Count; j++)
                {
                    if (IsAnagram(primeNumbers[i], primeNumbers[j]) && IsPalindrome(primeNumbers[i]))
                    {
                        anagramPalindromePrimes.Add(primeNumbers[i]);
                    }
                }
            }

            Console.WriteLine("Prime numbers that are Anagram and Palindrome:");
            foreach (int prime in anagramPalindromePrimes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }
}
