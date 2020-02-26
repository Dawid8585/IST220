using System;

namespace quiz_5
{
    class sum_the_roots_from_1_to_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add roots of numbers from 0 to 10");
            double k = 1;
            double sumSquare = 0;

            sumSquare = MultiplySquares(sumSquare, k);
            Console.WriteLine($"sum is {sumSquare}, hit any key");
            Console.ReadKey();

            


        }

        private static double MultiplySquares(double sumSquare, double k)
        {
            if (k > 10)
                return sumSquare;
            else
                return MultiplySquares(sumSquare + Math.Sqrt(k) , k + 1);
        }
    }

}
