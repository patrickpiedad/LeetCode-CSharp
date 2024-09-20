using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    internal class ReverseWordsInAString
    {
        public static string ReverseWords(string s)
        {
            // Need to reverse words in a string, but not the characters in the words
            // Use space to determine when a word has ended
            // Need to account for strings starting with spaces, ending with spaces, and having multiple spaces in around words

            // Use stack to provide the reverse behavior (first in, last out), so iterate and add in the first words, letting them become the last words

            Stack<string> words = new();
            string answer = "";
            string builder = "";

            for (int i = 0; i < s.Length; i++)
            {
                // if the current elem is a letter and not a space, add it to builder
                if (s[i] != ' ')
                {
                    builder += s[i];
                }

                else
                {
                    // builder has letters in it, meaning the last inputs into builder were not just spaces and passed over, add builder to stack, reset builder
                    if (builder.Length > 0)
                    {
                        words.Push(builder);
                        builder = "";
                    }
                }
            }
            // add final word to builder
            if (builder.Length > 0)
            {
                words.Push(builder);
            }

            // now in while loop, pop from stack and add to answer, add space in between words, then return answer
            while (words.Count > 0)
            {
                answer += words.Pop();

                if (words.Count > 0)
                {
                    answer += ' ';
                }
            }

            return answer;
        }

        public string ReverseWords2(string s)
        {
            Stack<string> stack = new();
            StringBuilder builder = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    builder.Append(s[i]);
                }

                else
                {
                    if (builder.Length > 0)
                    {
                        stack.Push(builder.ToString());
                        builder.Clear();
                    }
                }

            }
            if (builder.Length > 0)
            {
                stack.Push(builder.ToString());
                builder.Clear();
            }

            StringBuilder answer = new();

            while (stack.Count > 0)
            {
                if (stack.Count > 1)
                {
                    answer.Append(stack.Pop());
                    answer.Append(' ');
                }
                else
                {
                    answer.Append(stack.Pop());
                }
            }

            return answer.ToString();
        }
    }
}
