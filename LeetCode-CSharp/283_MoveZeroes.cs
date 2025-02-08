namespace LeetCode_CSharp;

public static class MoveZeroes
{
    public static int[] MoveZeroes1(int[] nums)
    {
        // I will get an integer array called nums that has various integers in it, to include 0's
        // I need to move all 0's to the end of the array while keeping the rest of the elements in order
        // I cannot make a copy of the array

        // Will the array ever be empty? => No
        // Will the array ever be null? => No
        // Will there be any negative numbers? => No

        // nums = [0, 1, 0, 0, 3, 12] => [1, 3, 12, 0, 0, 0]

        // Create var called insertPos to hold last insert position
        int insertPos = 0;

        // for loop, iterate through all array elements
        // if nums[i] != 0, nums[firstZero] = nums[i], [1 3 12 0 3 12], insertPos++
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                nums[insertPos] = nums[i];
                insertPos++;
            }
        }

        // while (insertPos <= nums.Length - 1), nums[insertPos] = 0, then insertPos++
        while (insertPos < nums.Length)
        {
            nums[insertPos] = 0;
            insertPos++;
        }

        return nums;
    }

    public static void MoveZeroes2(int[] nums)
    {
        // R: get integer array nums and move all 0s to end in place, keep order of other elements 
        // E: Input: nums = [0,1,0,3,12]
        // Output: [1,3,12,0,0]
        // A: two pointers, counter for zeroes, p1/p2 at start, if zero, move p2 until non zero, then swap p2 and p1 and make p1 = p2 again
        // continue til p2 is at end, then make p1 iterate zeroes until end
        // C:

        int pointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[i];
                nums[i] = nums[pointer];
                nums[pointer] = temp;
                pointer++;
            }
        }
    }
}