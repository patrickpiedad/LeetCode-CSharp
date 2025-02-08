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
            Console.WriteLine(MoveZeroes.MoveZeroes2([0, 1, 0, 3, 12]));
            
            Console.ReadLine();

        }
        

    }
}