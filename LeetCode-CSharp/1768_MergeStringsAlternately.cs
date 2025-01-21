using System.Text;

namespace LeetCode_CSharp
{
    public class _1768_MergeStringsAlternately
    {
        public static string StringMerge(string word1, string word2)
        {
            StringBuilder builder = new StringBuilder();
            int longestWordLength;

            if (word1.Length >= word2.Length)
            {
                longestWordLength = word1.Length;
            }
            else
            {
                longestWordLength = word2.Length;
            }


            for (int i = 0; i < longestWordLength; i++)
            {
                if (i > word1.Length - 1)
                {
                    builder.Append(word2[i]);
                }
                else if (i > word2.Length -1)
                {
                    builder.Append(word1[i]);
                }
                else
                {
                    builder.Append(word1[i]);
                    builder.Append(word2[i]);
                }
            }

            return builder.ToString();
        }

        public static string MergeString2(string word1, string word2)
        {
            // I'm being given two strings, word1 and word 2
            // I need to merge them together alternatively. If one ends before the other, just keep adding the rest of the longer word to the new string. I need to start with word1

            // Are my strings ever going to be null?
            // Are my strings ever going to be empty?
            // Are my strings ever going to be 1x letter long

            // Create a stringbuilder to make the new string
            StringBuilder builder = new StringBuilder();
            string longestWord = "";
            string shortestWord = "";

            // Find longest and shortest word
            if (word1.Length >= word2.Length)
            {
                longestWord = word1;
                shortestWord = word2;
            }

            else
            {
                longestWord = word2;
                shortestWord = word1;
            }

            // for loop that iterates through the longest string length
            for (int i = 0; i <= longestWord.Length - 1; i++)
            {
                if (i <= shortestWord.Length -1)
                {
                    builder.Append(word1[i]);
                    builder.Append(word2[i]);
                }

                else
                {
                    builder.Append(longestWord[i]);
                }
            }

            return builder.ToString();

            // conditional to append both strings alternatively as long as both strings have letters remaining
            // stringbuilder append word1[i], then append word2[i]
            // else, only append longest stringbuilder
        }

        public string Merge3(string word1, string word2)
        {
            // R: Take in two strings and merge strings by adding letters in alternating order starting with word 1. If one word is longer than the other, append the rest of the letters onto the end of the merged string.
            // E: abc, pqr =? apbqcr // ab, pqrs => apbqrs
            // A: find shortWord and shortWordLength, find longWord and longWordLength, initialize ans
            // loop through for longWordLength with conditional of only appending from shortWord while less than shortWordLength, else append longWord
            // ab pqrs --> 4x loop from 0 to length of longWord, adding 1x letter from each word during each iteration
            // C:

            string shortWord = "";
            string longWord = "";
            
            if (word1.Length <= word2.Length)
            {
                shortWord = word1;
                longWord = word2;
            }

            else
            {
                shortWord = word2;
                longWord = word1;
            }

            StringBuilder answer = new StringBuilder();
            
            for (int i = 0; i < longWord.Length; i++)
            {
                
                if (i < shortWord.Length)
                {
                    answer.Append(word1[i]);
                    answer.Append(word2[i]);
                }
                else
                {
                    answer.Append(longWord[i]);
                }
            }

            return answer.ToString();

        }
    }
}
