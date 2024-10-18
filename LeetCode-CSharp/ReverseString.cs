namespace LeetCode_CSharp;

public class ReverseString
{
    public static string ReverseStringMethod(string str)
    {
        char[] strArr = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            strArr[i] = str[str.Length - 1 - i];
        }

        return new string(strArr);
    }
}