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

    }
}
