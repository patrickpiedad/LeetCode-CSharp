namespace LeetCode_CSharp;

public class KidsWithTheGreatestNumberOfCandies {
    IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
// I will receive an integer array called candies, where each element value in the array represents the number of candies its corresponding index (kid) has. I will also receive an integer called extraCandies.
// I need to take each element in the array and determine if that element plus the extraCandies (all of them) gives that kid the greatest number of candies => greatest number of candies means >= the greatest number in the array.

// Will the array ever be empty?
// Will the array ever be null?
// Will the extraCandies ever be empty?
// Will the extraCandides ever be null?
// Can we be destructive to the original array?
// Is time complexity a primary concern?
// Is space complexity a primary concern?
// Am I allowed to use a built in maximum function?
// Am I allowed to use a built in sorting function?
// Will I receive a sorted or unsorted array?

// Approach
// We do not need to compare every element to the "control element + extraCandies," only need to compare to the GREATEST number of candides in the array

//Code
// create IList<bool> to hold our answer List
        IList<bool> ansList = new List<bool>();

// Execute for loop to find max value in array
        int currentMax = 0;
        for (int i = 0; i < candies.Length - 1; i++)
        {
            if (candies[i] >= currentMax)
            {
                currentMax = candies[i];
            }
        }

        Console.WriteLine("currentMax");

// Loop through array, adding extraCandies to each element and compare to currentMax, Compare means if currentKid >= currentMax, add bool value of true to list, else add false
        for (int i = 0; i < candies.Length - 1; i++)
        {
            if ((candies[i] + extraCandies) >= currentMax)
            {
                ansList.Add(true);
            }
            else
            {
                ansList.Add(false);
            }
        }

// Return our list
        return ansList;
    }
}

public class KidWithGreatestNumberOfCandies2
{
    //R: Taking in array of candies and number of extra candies, calculate return array of bool values based on whether extra candies given to each array value will make that value the largest in the array
    //E: candies = [2, 3, 5, 1, 3], extraCandies = 3 => [true, true, true, false, true]
    //A: find max of array to set originalMaxCandies value
    // iterate through array and add to compare to originalMaxCandies and produce bool value, return bool array
    //C:
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int originalMaxCandies = candies[0];
        IList<bool> answer = new List<bool>();

        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > originalMaxCandies)
            {
                originalMaxCandies = candies[i];
            }
        }

        for (int i = 0; i < candies.Length; i++)
        {
            if ((candies[i] + extraCandies) >= originalMaxCandies)
            {
                answer.Add(true);
            }
            else
            {
                answer.Add(false);
            }
        }

        return answer;
    }
    //T: test cases passed in LC
    //O: currently O(N)
}