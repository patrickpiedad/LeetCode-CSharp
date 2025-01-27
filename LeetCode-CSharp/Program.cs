using System.Threading.Channels;

namespace LeetCode_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will run your desired LeetCode solution");
            Console.WriteLine("Output from your LeetCode solution begins below:");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine(ReverseWordsInAString.ReverseWords2("the sky is blue"));
            Console.WriteLine(ReverseWordsInAString.ReverseWords2("  hello world  "));
            Console.WriteLine(ReverseWordsInAString.ReverseWords2("a good  example"));
            Console.ReadLine();

        }
        

    }
}