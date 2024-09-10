using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // I will get two arrays, nums1 and nums 2.
            // nums1 has the length of nums1.Length + nums2.Length
            // m is the length of nums1, n is the length of nums2
            // I need to merge the arrays, sorted in non-decreasing order, and store the final merged array in the nums1 array

            // [1 2 3 0 0 0], m =3 / [2 5 6] n =3


            // check if one of the arrays are empty
            if (m == 0)
            {
                for (int i = 0; i <= n-1; i++)
                {
                    nums1[i] = nums2[i];
                }
            }

            else if (n == 0)
            {
                nums1 = nums1;
            }


            else
            {
                // add nums2 elements to the end of nums1
                for (int i = m; i <= m + n - 1; i++)
                {
                    nums1[i] = nums2[i-m];
                }

                //sort in non-descending order
                Array.Sort(nums1);
            }

            static void QuickSort(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int index = Partition(array, low, high);
                    QuickSort(array, low, index -1);
                    QuickSort(array, index + 1, high);
                }
            }

            static void Swap(int[] array, int i, int j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            static int Partition(int[] array, int low, int high)
            {
                int pivot = array[low];
                int i = low;
                int j = high;

                do
                {
                    while (i <= j && array[i] <= pivot)
                    {
                        i++;
                    }
                    while (i <= j && array[j] > pivot)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        Swap(array, i, j);
                    }
                }

                while (i < j);
                Swap(array, low, j);
                return j;
            }
        }
    }
}
