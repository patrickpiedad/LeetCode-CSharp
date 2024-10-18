using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    internal class SortingColors
    {
        public void SortColors(int[] nums)
        {
            // nums array, n objects, various colors of 0-red, 1-white, 2-blue
            // need to sort in place (no libraries), in red, white, blue order (0, 1, 2)
            // [2, 0, 2, 1, 1, 0] => [0, 0, 1, 1, 2, 2]

            QuickSort(nums, 0, nums.Length -1);
        }

        public static int[] QuickSort(int[] nums, int low, int high)
        {

            if (low < high)
            {
                int pivotIndex = Partition(nums, low, high);
                QuickSort(nums, low, pivotIndex-1);
                QuickSort(nums, pivotIndex +1, high);
            }

            return nums;
        }

        public static int Partition(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = low - 1;

            for (int j = low; j < nums.Length; j++)
            {
                if (nums[j] < pivot)
                {
                    i++;
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }

            i++;
            int temp2 = nums[high];
            nums[high] = nums[i];
            nums[i] = temp2;

            return i;
        }
    }
}




