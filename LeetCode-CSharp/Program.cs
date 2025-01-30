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
            Console.WriteLine(IncreasingTripletSubsequence.IncreasingTriplet4([1,2,3,4,5]));
            Console.WriteLine(IncreasingTripletSubsequence.IncreasingTriplet4([20,100,10,12,5,13]));
            Console.ReadLine();

        }
        

    }
}