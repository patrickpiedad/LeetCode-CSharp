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
            bool answer = CanPlaceFlowers.CanPlaceFlowers2([1, 0, 0, 0, 1, 0, 0], 2);
            Console.WriteLine(answer); 
            Console.ReadLine();

        }
        

    }
}