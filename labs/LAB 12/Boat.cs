using System;

namespace Vehicles
{
    internal class Boat : Vehicle // uses/goes through vehicle class. Vehivle is the base class.
    {
        public Boat()
        {
        }

        internal void Swoosh()
        {
            Console.WriteLine("swoooooosh");
        }

        internal void Whip()
        {
            Console.WriteLine("yeeeeet");
        }
    }
}