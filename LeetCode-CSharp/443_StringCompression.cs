using System.Text;

namespace LeetCode_CSharp
{
    public static class StringCompression
    {
        public static int Compress(char[] chars)
        {

            int currIndex = 0;
            int i = 0;

            while (i < chars.Length)
            {
                int count = 0;
                char currChar = chars[i];

                while (i < chars.Length && chars[i] == currChar)
                {
                    i++;
                    count++;
                }

                chars[currIndex] = currChar;
                currIndex++;

                if (count > 1)
                {
                    foreach (char c in count.ToString())
                    {
                        chars[currIndex] = c;
                        currIndex++;
                    }
                }
            }
            return currIndex;
        }

        public static int Compress2(char[] chars)
        {
            
            // Track multiple values 

            int i = 0;
            int currIndex = 0;

            while (i < chars.Length)
            {
                char currChar = chars[i];
                int count = 0;
                
                // [a,b,b,c,c,c]

                while (i < chars.Length && currChar == chars[i])
                {
                    i++;
                    count++;
                }
                
                //[ , ]

                chars[currIndex] = currChar;
                currIndex++;

                if (count > 1)
                {
                    foreach (char c in count.ToString())
                    {
                        chars[currIndex] = c;
                        currIndex++;
                    }
                }

            }

            return currIndex;

        }
    }
}
