using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane(); //making airplane class into myplane to call 
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine();
            Console.WriteLine("Journey by car:");
            Car myCar = new Car(); //making car class into mycar to call
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine();
            Console.WriteLine("Journey by motorcycle");
            Motorcycle R6 = new Motorcycle();
            R6.StartEngine(" RROOOM ROOOOM");
            R6.GOFAST();
            R6.Drive();
            R6.SKID();
            R6.StopEngine("CLANK CLUNK CLANK");

            Console.WriteLine();
            Console.WriteLine("Journey by Cigarette Boat");
            Boat Cigarette = new Boat();
            Cigarette.StartEngine(" CHUG CHUG");
            Cigarette.Swoosh();
            Cigarette.Drive();
            Cigarette.Whip();
            Cigarette.StopEngine("It doesnt matter - tony");

            Console.WriteLine();
            Console.WriteLine("Journey by Vehicle");
            Vehicle V = new Vehicle();
            V.StartEngine("Start Engine");
            V.Drive(); //virtual method, desginged to be overriden 
            V.StopEngine("Stop ENgine");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
