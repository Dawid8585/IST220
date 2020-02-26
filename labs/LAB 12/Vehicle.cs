
using System;

namespace Vehicles
{
    class Vehicle // BASE CLASS
    {
        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
        }
        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Generic DrIving");
        }

    }
}
