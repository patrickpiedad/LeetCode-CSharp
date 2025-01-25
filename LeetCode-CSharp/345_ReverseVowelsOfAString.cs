using System.Text;

namespace LeetCode_CSharp;

public static class ReverseVowelsOfAStringSolution {

    public static string ReverseVowels(string s)
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
    
    public static string ReverseVowels2(string s) {
        //R: Take in string, reverse only the vowels in the string, keeping the normal order of the consonants, return string
        //E: s = IceCreAm => AceCreIm // s = leetcode => leotcede
        //A: loop through string, conditionals to find vowels in upper and lower case, push into stack
        // loop through string again, same conditionals but when finding a vowel, replace with the stack
        //C:

        Stack<char> vowelStack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (
                s[i] == 'a' ||
                s[i] == 'A' ||
                s[i] == 'e' ||
                s[i] == 'E' ||
                s[i] == 'i' ||
                s[i] == 'I' ||
                s[i] == 'o' ||
                s[i] == 'O' ||
                s[i] == 'u' ||
                s[i] == 'U')
            {
                vowelStack.Push(s[i]);
            }
        }

        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (
                s[i] == 'a' ||
                s[i] == 'A' ||
                s[i] == 'e' ||
                s[i] == 'E' ||
                s[i] == 'i' ||
                s[i] == 'I' ||
                s[i] == 'o' ||
                s[i] == 'O' ||
                s[i] == 'u' ||
                s[i] == 'U')
            {
                answer.Append(vowelStack.Pop());
            }

            else
            {
                answer.Append(s[i]);
            }
        }

        return answer.ToString();


        //T: Test cases passed
        //O: Currently O(n) with two separate loops, optimize by using two pointer solution and swapping vowels when found
    }
}