namespace LeetCode_CSharp;

public static class ContainerWithMostWater {
    public static int MaxArea(int[] height) {
        // Input: height = [1,8,6,2,5,4,8,3,7]
        // Output: 49
        // Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
        // In this case, the max area of water (blue section) the container can contain is 49.
        
        // Looking for optimal point where x distance is maximized while y is maximized
        // Greedy, make the best known decision at each point
        
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            // area calculation
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxArea;
    }
    
    public static int MaxArea2(int[] height) {
        // Input: height = [1,8,6,2,5,4,8,3,7]
        // Output: 49
        // Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
        // In this case, the max area of water (blue section) the container can contain is 49.

        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxArea;

    }
    
    public static int MaxArea3(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(currentArea, maxArea);

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxArea;
    }
    
    public static int MaxArea4(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int currentArea = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(currentArea, maxArea);

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxArea;
    }
}