using System.Text;

namespace LeetCode_CSharp
{
    public static class ReverseWordsInAString
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

        public static string ReverseWords2(string s)
        {
            //R: input is a string, output is string with words reversed where input may have multiple leading or trailing spaces and output should be concatd with one space between words
            //E: s = "the sky is blue" => "blue is sky the"
            //A:

            //If empty string, return s
            if (s == "") return s;

            //If null, return s 
            if (s == null) return s;
            
            //only need to check for uppercase, lowercase, digits, and spaces
            //stack allows for easy reversal upon traverse, stringbuilder used to build new string
            //start at beginning of string, if space && stringbuilder length is 0 break, else if space (stringbuilder length is not 0) push to stack and stringbuilder reset, else stringbuilder append
            StringBuilder word = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && word.Length == 0) continue;
                
                else if (s[i] == ' ')
                {
                    stack.Push(word.ToString());
                    word.Clear();
                }

                else if (i == s.Length - 1)
                {
                    word.Append(s[i]);
                    stack.Push(word.ToString());
                    word.Clear();
                }
                
                else
                {
                    word.Append(s[i]);
                }
            }

            //once at end of string, build new string by popping stack
            StringBuilder answer = new StringBuilder();
            int loopLength = stack.Count();
            
            for (int i = 0; i < loopLength; i++)
            {
                if (i < loopLength - 1)
                {
                    answer.Append(stack.Pop());
                    answer.Append(' ');
                }

                else
                {
                    answer.Append(stack.Pop());
                }
            }
            //return string
            return answer.ToString();
        }
    }
}
