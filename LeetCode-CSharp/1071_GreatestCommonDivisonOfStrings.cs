using System.Text;

namespace LeetCode_CSharp;

public class GreatestCommonDivisionOfStrings {
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) return "";
        int gcdLength = Gcd(str1.Length, str2.Length);

        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < gcdLength; i++)
        {
            answer.Append(str1[i]);
        }

        return answer.ToString();

    }

    private static int Gcd(int length1, int length2)
    {
        while (length2 != 0)
        {
            int temp = length1 % length2;
            length1 = length2;
            length2 = temp;
        }

        return length1;
    }
}