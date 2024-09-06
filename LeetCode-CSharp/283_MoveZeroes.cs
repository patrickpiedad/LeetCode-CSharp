namespace LeetCode_CSharp;

public class Solution {
    public void MoveZeroes(int[] nums) {
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
        for (int i = 0; i <= nums.Length - 1; i++){
            if (nums[i] != 0){
                nums[insertPos] = nums[i];
                insertPos++;
            }

        }
        
        // while (insertPos <= nums.Length - 1), nums[insertPos] = 0, then insertPos++
        while (insertPos < nums.Length){
            nums[insertPos] = 0;
            insertPos++;

        }

    }
}