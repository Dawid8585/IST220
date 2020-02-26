using System;
using System.Collections.Generic;
using System.Text;

namespace EX_4
{
    class Pokemon1
    {

        string Name;
        string Type;
        string Weaknesses;
        string Evolutions;
        string Pokedex;

        internal class Charizard : Pokemon1
        {
            public Charizard(string Name, string Type, string Weaknesses, string Evolutions, string Pokedex)
            {
                this.Name = Name;
                this.Type = Type;
                this.Weaknesses = Weaknesses;
                this.Evolutions = Evolutions;
                this.Pokedex = Pokedex;
                base.Name = "Charizard";
                base.Type = "Fire, Flying";
                base.Weaknesses = "Rock, Electric, Water";
                base.Evolutions = "3 of 3";
                base.Pokedex = "#006";
                Console.WriteLine($"My name is {base.Name}");
                Console.WriteLine($"I am a {base.Type} type");
                Console.WriteLine($"my weakness is {base.Weaknesses}");
                Console.WriteLine($" my evolution is {base.Evolutions}");
                Console.WriteLine($"I am number {base.Pokedex} in the Pokedex\n");
            }
        }
    }
}
