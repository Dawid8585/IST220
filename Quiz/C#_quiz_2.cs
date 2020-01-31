using System;
using System.Numerics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            sum = GetSums(start, end, sum);
            Console.WriteLine($"the sum is { sum}");

        }

        private static int GetSums(int start, int end, int sum)
        {
            Console.WriteLine("The sum is " +start +" and " + end + " is " +sum);
            start = start + 1;
            sum = sum + start;
            if (start == end)
                return (sum);
            else 
                return (GetSums(start,end,sum));
        }
    }
}