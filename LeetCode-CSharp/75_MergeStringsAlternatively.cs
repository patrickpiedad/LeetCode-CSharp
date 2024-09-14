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
        
        public string MergeAlternately(string word1, string word2) {
            // Need to take two strings and make into one.
            // Need to take into account that one maybe longer than other, avoid out of bounds error
            // Start with word 1, use stringbuilder
            // Use 1x for loop, use if conditional to stop adding shorter array
            // Need to know which word is shorter and actual length


            string longWord = "";
            string shortWord = "";

            if (word1.Length > word2.Length){
                longWord = word1;
                shortWord = word2;
            }

            else{
                longWord = word2;
                shortWord = word1;
            }

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < longWord.Length; i++){
                if (i < shortWord.Length){
                    answer.Append(word1[i]);
                    answer.Append(word2[i]);
                }

                else{
                    answer.Append(longWord[i]);
                }

            }

            return answer.ToString();    
        }

    }
}
