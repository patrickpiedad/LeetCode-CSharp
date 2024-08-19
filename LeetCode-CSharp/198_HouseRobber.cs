using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class HouseRobber
    {
        public static int MaxMoney(int[] houseMonies, int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int val1 = houseMonies[0];

            if (n == 1)
            {
                return val1;
            }

            int val2 = Math.Max(houseMonies[0], houseMonies[1]);
            if (n == 2)
            {
                return val2;
            }

            int maxVal = 0;

            for (int i = 2; i < n; i++)
            {
                maxVal = Math.Max(houseMonies[i] + val1, val2);
                val1 = val2;
                val2 = maxVal;
            }

            return maxVal;
        }
    }
}
