using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class FindPivotIndexSolution1
    {
        public int PivotIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int pivotIndex = 0;

            for (int i = 0; i <= nums.Length -1; i++)
            {
                pivotIndex = i;
                leftSum = 0;
                rightSum = 0;

                for (int j = 0; j <= nums.Length -1; j++)
                {

                    if (pivotIndex == 0)
                    {
                        leftSum = 0;
                        if (j > pivotIndex)
                        {
                            rightSum += nums[j];
                        }
                    }

                    else if (pivotIndex == nums.Length -1)
                    {
                        rightSum = 0;
                        if (j < pivotIndex)
                        {
                            leftSum += nums[j];
                        }
                    }


                    // [1 7 3 /6/ 5 6] => pivot index is index 3 (value of 4) because 1 + 7 + 3 = 5 + 6

                    else
                    {
                        if (j < pivotIndex)
                        {
                            leftSum += nums[j];
                        }

                        else if (j > pivotIndex)
                        {
                            rightSum += nums[j];
                        }
                    }

                }

                if (leftSum == rightSum)
                {
                    return pivotIndex;
                }

            }

            return -1;
        }
    }

    public class FindPivotIndexSolution2
    {
        public int PivotIndex(int[] nums)
        {
            // Find total sum using for loop
            // Execute another for loop, find left sum by adding until pivot index, then right sum by doing totalsum - pivot index - left sum

            int pivotIndex = 0;
            int totalSum = 0;
            int leftSum = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                totalSum += nums[i];
            }

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                pivotIndex = i;
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }
                leftSum += nums[i];
            }
            return -1;
        }
    }
}
