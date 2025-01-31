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
    }
}
