﻿using System.Threading.Channels;

namespace LeetCode_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program will run your desired LeetCode solution");
            Console.WriteLine("Output from your LeetCode solution begins below:");
            Console.WriteLine("----------------------------------------------------------------");
            string answer = ReverseVowelsOfAStringSolution.ReverseVowels2("IceCreAm");
            Console.WriteLine(answer); 
            Console.ReadLine();

        }
        

    }
}