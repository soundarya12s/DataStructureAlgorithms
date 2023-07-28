using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    public class MergeSort
    {
        public void Mergesorting(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[middle + 1 + j];

            int p = 0, q = 0;
            int k = left;

            while (p < n1 && q < n2)
            {
                if (leftArr[p] <= rightArr[q])
                {
                    arr[k] = leftArr[p];
                    p++;
                }
                else
                {
                    arr[k] = rightArr[q];
                    q++;
                }
                k++;
            }

            while (p < n1)
            {
                arr[k] = leftArr[p];
                p++;
                k++;
            }

            while (q < n2)
            {
                arr[k] = rightArr[q];
                q++;
                k++;
            }
        }

        public void mergeSortAlgorithm(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                mergeSortAlgorithm(arr, left, middle);
                mergeSortAlgorithm(arr, middle + 1, right);

                Mergesorting(arr, left, middle, right);
            }
        }

        public void mergeSort(int[] arr)
        {
            mergeSortAlgorithm(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}
