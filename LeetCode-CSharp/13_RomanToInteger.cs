using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    internal class RomanToInt
    {
        public static int RomanToIntMethod(string s)
        {
            int value = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (i + 1 < s.Length && s[i + 1] == 'V')
                    {
                        value += 4;
                        i += 1;
                    }
                    else if (i + 1 < s.Length && s[i + 1] == 'X')
                    {
                        value += 9;
                        i += 1;
                    }
                    else
                    {
                        value += 1;
                    }
                }
                else if (s[i] == 'V')
                {
                    value += 5;
                }
                else if (s[i] == 'X')
                {
                    if (i + 1 < s.Length && s[i + 1] == 'L')
                    {
                        value += 40;
                        i += 1;
                    }
                    else if (i + 1 < s.Length && s[i + 1] == 'C')
                    {
                        value += 90;
                        i += 1;
                    }
                    else
                    {
                        value += 10;
                    }
                }
                else if (s[i] == 'L')
                {
                    value += 50;
                }
                else if (s[i] == 'C')
                {
                    if (i + 1 < s.Length && s[i + 1] == 'D')
                    {
                        value += 400;
                        i += 1;
                    }
                    else if (i + 1 < s.Length && s[i + 1] == 'M')
                    {
                        value += 900;
                        i += 1;
                    }
                    else
                    {
                        value += 100;
                    }
                }
                else if (s[i] == 'D')
                {
                    value += 500;
                }
                else if (s[i] == 'M')
                {
                    value += 1000;
                }
            }
            return value;
        }
    }
}
