using System;

namespace EX_2
{
    class Program
    {

        public static void Main()
        {

            Part1();
            Part2();
            Part3();
            
        }

        public static void Part1()
        {

            int i, sum1, sum = 0;
            double num10 = 10;
            double avg;

            Console.WriteLine("Part 1");
            Console.WriteLine("Students grades are");
            for (i = 1; i <= num10; i++)
            {
                Console.WriteLine("Test grade {0}:", i);

                sum1 = Convert.ToInt32(Console.ReadLine());
                sum += sum1;
                continue;
            }
            avg = sum / num10;
            Console.WriteLine($"The student got a {avg}\n");
            Console.WriteLine("----------------------------------------\n");

        }

        public static void Part2()
        {

            int i, sum1, sum = 0;
            double avg;

            Console.WriteLine("Part 2");
            Console.WriteLine("Enter number of grades");
            int numG = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Students grades are");
            for (i = 1; i <= numG; i++)
            {
                Console.WriteLine("Test grade {0}:", i);

                sum1 = Convert.ToInt32(Console.ReadLine());
                sum += sum1;
                continue;
            }
            avg = sum / numG;
            // return avg;

            if (avg >= 90)
            {
                Console.WriteLine($"The student got a A {avg}");
                //return "A";
            }

            if (avg >= 80 && avg <= 89)
            {
                Console.WriteLine($"The student got a B {avg}");
                //return "B";
            }

            if (avg >= 70 && avg <= 79)
            {
                Console.WriteLine($"The student got a C {avg}");
                //  return "C";
            }
            if (avg >= 60 && avg <= 69)
            {
                Console.WriteLine($"The student got a D {avg}");
                //return "D";
            }
            if (avg >= 0 && avg <= 59)
            {
                Console.WriteLine($"The student got a F {avg}");
                // return "F";
            }
            Console.WriteLine($"---------------------------------------\n");

        }

        public static void Part3()
        {
            double input = -1;
            double currValue = -1;
            double sum = 0;
            double average;
            while (currValue != 0)
            {
                Console.WriteLine($"Enter a test score: ");
                Console.WriteLine($"Press enter to input another test score.  Input 0 to show results and exit.");
                string str = Console.ReadLine();
                currValue = double.Parse(str);
                sum = currValue + sum;
                input++;
                if (currValue == 0)
                {
                    average = sum / input;
                    Console.WriteLine($"Your average test score is {average}");
                }
            }
    
        }
    }
}









