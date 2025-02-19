namespace LeetCode_CSharp;

public static class IsSubsequenceSolution {
    public static bool IsSubsequence(string s, string t) {
        // Im going to receive a string s and t. S is the "to be tested" subsequence of t. If s IS a subsequence of t, return true, else false
        // abc is a subsequence of ahbgdc because you can delete hgd to create your new string s without any disruption

        // Take first element of s, loop through t. First element of s must be seen, and must been seen BEFORE any other subsequent letters of s
        // Only execute one loop, so that if the checked element exists later in the string, it could pass the test but the subsequent letters wouldnt
        // abc ==> ahbgdc
        // axc ==> ahbgdc

        if (s.Length == 0)
        {
            return true;
        }

        int currentSIndex = 0;


        for (int i = 0; i <= t.Length - 1; i++)
        {

            if (s[currentSIndex] == t[i] && currentSIndex == s.Length -1)
            {
                return true;
            }

            if (s[currentSIndex] == t[i])
            {
                currentSIndex++;
            }
        }

        return false;
    }
    
    public static bool IsSubsequence2(string s, string t)
    {

        if (s.Length == 0) return true;

        int sPointer = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (s[sPointer] == t[i] && sPointer == s.Length - 1) return true;

            else if (s[sPointer] == t[i])
            {
                sPointer++;
            }
        }

        return false;
    }
}