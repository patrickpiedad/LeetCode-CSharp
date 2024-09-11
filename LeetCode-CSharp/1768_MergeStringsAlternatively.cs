using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    internal class _75_MergeStringsAlternatively
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

        public string MergeAlternately(string word1, string word2)
        {
            // Using two pointer approach with while loop
            // We will continue while loop as long as we are within the length of one of the strings
            // If conditionals to determine if we're appending from two strings or just one

            int pointer1 = 0;
            int pointer2 = 0;

            StringBuilder ans = new StringBuilder();

            while (pointer1 <= word1.Length -1 || pointer2 <= word2.Length -1)
            {
                if (pointer1 <= word1.Length -1)
                {
                    ans.Append(word1[pointer1]);
                    pointer1++;
                }

                if (pointer2 <= word2.Length -1)
                {
                    ans.Append(word2[pointer2]);
                    pointer2++;
                }
            }

            return ans.ToString();
        }

    }
}
