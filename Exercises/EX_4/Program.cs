using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("This is my Pokemon Day Care\n");
            Pokemon1 Charizards = new Pokemon1.Charizard("Charizard", "Fire, Flying", "Rock, Electric, Water", "3 of 3", "#006");
            Console.ReadKey();
            Console.WriteLine("This is my Pokemon Day Care\n");
            Pokemon2 Grengar = new Pokemon2.Grengar("Charizard", "Fire, Flying", "Rock, Electric, Water", "3 of 3", "#006");
        }
        
    }
}



