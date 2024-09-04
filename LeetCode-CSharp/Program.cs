namespace LeetCode_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KidsWithCandies([2, 3, 5, 1, 3], 3);
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
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
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] >= currentMax)
                {
                    currentMax = candies[i];
                }
            }

            Console.WriteLine(currentMax);

            // Loop through array, adding extraCandies to each element and compare to currentMax, Compare means if currentKid >= currentMax, add bool value of true to list, else add false
            for (int i = 0; i < candies.Length; i++)
            {
                int currentCandies = candies[i] + extraCandies;
                if ((currentCandies) >= currentMax)
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
}