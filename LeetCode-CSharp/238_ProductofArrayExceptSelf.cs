namespace LeetCode_CSharp
{
    internal static class ProductofArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] ansArr = new int[nums.Length];
            int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];

            left[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }

            right[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                ansArr[i] = left[i] * right[i];
            }

            return ansArr;
        }
        
        public static int[] ProductExceptSelf2(int[] nums) {
            //R: take in nums array, return ans array where ans array[i] is prod of all numbers in nums array except self
            //E: nums = [1,2,3,4] => ans = [24,12,8,6]
            //A: create pre array doing all prod starting from left of array, create post array doing all prod starting from right of array, ans array is prod of both arrays
            //C:

            int[] pre = new int[nums.Length];
            int[] post = new int[nums.Length];
            int[] ans = new int[nums.Length];

            pre[0] = 1;
            post[post.Length - 1] = 1;

            for (int i = 1; i < pre.Length; i++)
            {
                pre[i] = pre[i - 1] * nums[i - 1];
            }

            for (int i = post.Length - 2; i >= 0; i--)
            {
                post[i] = post[i + 1] * nums[i + 1];
            }

            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = pre[i] * post[i];
            }

            return ans;
        }


        public static int[] ProductExceptSelf3(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = 1;
            }

            int prefix = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = prefix;
                prefix *= nums[i];
            }

            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                res[i] *= postfix;
                postfix *= nums[i];
            }

            return res;
        }
    }
}
