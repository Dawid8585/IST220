using System;

namespace Quiz_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is C Sharp quiz 7.");
            Shotgun shotty = new Shotgun();
          
            Rifle R = new Rifle();
            Pistol P = new Pistol();
            
            shotty.noises();
            R.nice();
            P.noisez();



        }

    }
}
