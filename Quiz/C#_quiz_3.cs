using System;

namespace quiz4
{
    class Program
    {
        static void Main(string[] args)
        {

            bool validInput = true;
            do
            {
                string userinput;
                int input;
                int num;
                Console.WriteLine("To calculate the reciprocal of an integer, enter a positive integer:");
                try
                {

                    validInput = true;
                    userinput = Console.ReadLine();
                    input = int.Parse(userinput);
                    num = 1;
                    double total = (num / input);


                    if (input < 0)
                    {
                        Console.Write("Your number must be a positive number ");
                        continue;
                    }
                    Console.WriteLine("the answer is " + (double)num / (double)input);
                    validInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Attempted to divide by zero.");
                }

            } while (validInput);

        }

    }

}

