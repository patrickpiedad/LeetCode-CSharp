using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    class _1189_MaximumNumberOfBalloons
    {

        public int MaxNumberOfBalloons(string text)
        {
            // I get a string text and have to use the characters in the string to form "balloon" as mny times as possible
            // I can only use each character once

            // only need to see if characters exist, does not need to be in order
            // need to ensure not to use characters again

            // use dictionary (hash map)

            Dictionary<char, int> bhm = new();


            // add all chars to dict
            bhm.Add('b', 0);
            bhm.Add('a', 0);
            bhm.Add('l', 0);
            bhm.Add('o', 0);
            bhm.Add('n', 0);

            // loop through string, add values to dict kvp if present
            for (int i = 0; i < text.Length; i++)
            {
                {
                    if (bhm.ContainsKey(text[i]))
                    {
                        bhm[text[i]]++;
                    }
                }
            }

            // divide l and o values by 2 since they appear in balloon twice
            bhm['l'] /= 2;
            bhm['o'] /= 2;

            // return the amount of times you can spell balloon as the min value in the dict
            return bhm.Values.Min();

        }

    }
}
