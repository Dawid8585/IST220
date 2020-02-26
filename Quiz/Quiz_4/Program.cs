using System;
using System.Collections.Generic;
using System.Text;


namespace Quiz_4
{
    class Program
    {
        static void doWork()
        {
            start:
            int i = 0;

            Console.WriteLine("This is Test 04");
            Firearm.Shotgun(i);
            Firearm.Rifle(i);   
            Firearm.Pistol(i);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
            goto start;
        }
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
