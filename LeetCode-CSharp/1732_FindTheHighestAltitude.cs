namespace LeetCode_CSharp;

public class FindTheHighestAltitudeSolution {
    public int LargestAltitude(int[] gain) {
        // [-5 1 5 0 -7]
        // [0 -5 -4 1 1 -6] because you start at [0], then net gain is -5 so you decrease -5 alt to [-5] then next gain is 1, so you increase alt by 1
    
        // take gain array, create new ans array of length gain.Length + 1
        int[] ans = new int[gain.Length + 1];

        // ans[0] = 0
        ans[0] = 0;

        // for loop, where i starts at 1, ans[i] = ans[i-1] + gain[i]
        for (int i = 1; i <= gain.Length; i++)
        {
            ans[i] = ans[i-1] + gain[i-1];
        }

        // i = 2
        // gain = [-5 1 5 0 -7]
        // ans = [0 -5 -4 - - -]

        // loop and find max value
        int max = 0;
        for (int i = 0; i <= ans.Length -1; i++)
        {
            if (ans[i] > max)
            {
                max = ans[i];
            }
        }

        return max;
    }


}