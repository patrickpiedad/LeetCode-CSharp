namespace LeetCode_CSharp;

public class ReverseVowelsOfAStringSolution {

    public string ReverseVowels(string s)
    {
        // I will receive a string 's' and I need to reverse all of the vowels in the string, then return that string
        // Are there any constraints on time or space complexity?
        // Will I ever receive a null string?
        // Will I ever receive an empty string?
        // What is the max length of the string?
        // Can I be or do I have to be destructive to the original string?

        // Examples
        // s = 'hello' => 'holle'
        // s = 'leetcode' => 'leotcede'

        // create stack
        Stack<char> stack = new Stack<char>();
        char[] ans = new char[s.Length];

        // Loop through string once, if vowel then push onto stack (ie. stack = [e o] and will pop out 'o' then 'e' because LIFO)
        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' ||
                s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
            {
                stack.Push(s[i]);
            }
        }

        // Loop through string again, if vowel, then replace with stack pop
        for (int i = 0; i <= s.Length - 1; i++)
        {
            if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' ||
                s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
            {
                ans[i] = stack.Pop();
            }
            else
            {
                ans[i] = s[i];
            }
        }

        return String.Join("", ans);
    }
}