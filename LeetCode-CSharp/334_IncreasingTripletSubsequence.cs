namespace LeetCode_CSharp
{
    public static class IncreasingTripletSubsequence
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

        public static bool IncreasingTriplet3(int[] nums)
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

        public static bool IncreasingTriplet4(int[] nums)
        {
            // Input: nums = [1,2,3,4,5]
            // Output: true
            // Explanation: Any triplet where i < j < k is valid.
            
            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= min1) min1 = nums[i];
                else if (nums[i] <= min2) min2 = nums[i];
                else if (nums[i] > min2) return true;
            }

            return false;
        }

        public static bool IncreasingTriplet5(int[] nums)
        {
            // Input: nums = [1,2,3,4,5]
            // Output: true
            // Explanation: Any triplet where i < j < k is valid.
            
            int min1 = Int32.MaxValue;
            int min2 = Int32.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min1) min1 = nums[i];
                if (nums[i] < min2) min2 = nums[i];
                if (nums[i] > min2) return true;
            }

            return false;

        }
        
        public static bool IncreasingTriplet6(int[] nums) {
            int num1 = Int32.MaxValue;
            int num2 = Int32.MaxValue;
            
            // [2,1,5,0,4,6]
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= num1) num1 = nums[i];
                else if (nums[i] <= num2) num2 = nums[i];
                else if (nums[i] > num2) return true;
            }

            return false;
        }
    }
}