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
            Console.WriteLine(StringCompression.Compress(['a','a','b','b','c','c','c']));
            Console.WriteLine(StringCompression.Compress(['a']));
            Console.WriteLine(StringCompression.Compress(['a','b','b','b','b','b','b','b','b','b','b','b','b']));
            Console.ReadLine();

        }
        

    }
}