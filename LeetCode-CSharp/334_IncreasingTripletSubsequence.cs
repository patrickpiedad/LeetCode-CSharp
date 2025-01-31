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
        
        public static bool IncreasingTriplet4(int[] nums) {
        
            //R: input array nums, return true if there are three values in a row that increase in value, else return false
            //E: [1,2,3,4,5] => true, [5,4,3,2,1] => false, [2,1,5,0,4,6] => true because [...0,4,6]
            //[20,100,10,12,5,13]
            //A/C: 
            
            // init min1 value to track first minimum value requirement
            int min1 = Int32.MaxValue;

            // init min2 value to track second minimum value requirement
            int min2 = Int32.MaxValue;
            
            // loop through array
            for (int i = 0; i < nums.Length; i++)
            {
                // min1 is set if found
                if (nums[i] <= min1) min1 = nums[i];
                
                // min2 is set if found
                else if (nums[i] <= min2) min2 = nums[i];
                
                // if nums[i] is not <= min1 or min2, then that means it is larger than min1 or min2, and we have found our third increasing number in the triplet
                else return true;
            }

            // if loop completes, no triplet is found, return false
            return false;
        }
        
        public static bool IncreasingTriplet5(int[] nums) {
        
            //R: check if given array nums has increasing triplet subsequence, where subsequence does not need to be consecutive numbers or indices
            //E: [1,2,3,4,5] => true; [2,5,1,0,6] => true
            //A: keep track of min numbers by have two min number variables tracked, update when hitting those numbers, if something larger than second min number exists, return true, else false
            //C:

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
        
    }
}
