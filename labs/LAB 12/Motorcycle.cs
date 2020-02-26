using System;

namespace Vehicles
{
    internal class Motorcycle : Vehicle // uses/goes through vehicle class. Vehivle is the base class.
    {
        internal void GOFAST()
        {
            Console.WriteLine("BRRROOOM");
        }
        internal void SKID()
        {
            Console.WriteLine("SKKKRT");

        }
        public override void Drive() //virtual method, desginged to be overriden 
        {
            Console.WriteLine("biking");
        }
    }
}