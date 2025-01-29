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
        
        public static int[] ProductExceptSelf4(int[] nums) {
        //[1,2,3,4]           [1,2,3,4]                =>          [24,12,8,6]
        //[1,1,2,6] prefix , [24,12,4,1]
        //O(N)/O(N) time/space complexity
        //Make prefix array, postfix array, then multiply together to create answer
        //Prefix => first pass from left to right to calculate prefix of each position where the prefix for each position is in the space directly before it
        //prefix[0] is nothing because there is are no values "pre" the 0th position, so place 1 there to stay neutral in products
        //postfix[postfix.Length-1] is nothing because there is are no values "post" the last position, so place 1 there to stay neutral in products

        int[] prefix = new int[nums.Length];
        prefix[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i-1] * nums[i-1];
        }

        int[] postfix = new int[nums.Length];
        postfix[postfix.Length - 1] = 1;

        for (int i = postfix.Length - 2; i >= 0; i--)
        {
            postfix[i] = postfix[i + 1] * nums[i + 1];
        }

        int[] answer = new int[nums.Length];

        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = prefix[i] * postfix[i];
        }

        return answer;

        }
        
        public static int[] ProductExceptSelf5(int[] nums) {
            //[1,2,3,4] => [24,12,8,6]
            //[24,12,8,6], current = 24
            //O(N)/O(1) time/space complexity
            //create answer array and fill with 1s to stay neutral
            //initiate curr integer value to track what needs to be multiplied
            //calculate prefix in answer array with each prefix value being to the right of the index value
            //calculate postfix in answer array and place in proper index value

            int[] answer = new int[nums.Length];
            int current = 1;

            Array.Fill(answer, 1);

            for (int i = 1; i < answer.Length; i++)
            {
                answer[i] *= current;
                current = answer[i] * nums[i];
            }

            current = 1;

            for (int i = answer.Length - 1; i >= 0; i--)
            {
                answer[i] *= current;
                current *= nums[i];
            }

            return answer;

        }
    }
}
