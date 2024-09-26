using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    internal class IncreasingTripletSubsequence
    {

        public static bool IncreasingTriplet(int[] nums)
        {

            int first = int.MaxValue;
            int second = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= first)
                {
                    first = nums[i];
                }

                else if (nums[i] <= second)
                {
                    second = nums[i];
                }

                else
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IncreasingTriplet2(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < first) first = nums[i];
                else if (nums[i] < second) second = nums[i];
                else return true;
            }
            return false;
        }

        public bool IncreasingTriplet3(int[] nums)
        {
            // check each number and compare to first and second
            // first and second start at max value
            // first iterations will set first number to first value
            // next iterations will compare with first number, if less than, it will reassign first number to that value
            // if not less than, it will reassign to second value
            // once first and second values are reassigned and a larger number is compared, it will pass those checks and return true
            // if you get through the entire array without return true, return false

            int first = int.MaxValue;
            int second = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= first) first = nums[i];
                else if (nums[i] <= second) second = nums[i];
                else return true;
            }

            return false;
        }
    }
}
