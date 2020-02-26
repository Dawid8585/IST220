using System;

namespace EX_1_20200116
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
 
            Console.WriteLine("The Wizard NEEDS your help. He has been trapped in a prison of magic.");
            Console.ReadLine();
            Console.WriteLine("The only way to get him out is to input the correct values.");
            Console.ReadLine();
            Console.WriteLine("QUICKLY find the correct values and input them into the locks!");
            Console.ReadLine();
            Console.WriteLine("SAVE THE WIZARD");
            Console.ReadLine();
            Console.WriteLine("Travler the world is in your hands!");
            Console.ReadLine();
            Console.WriteLine("Lock 1 AREA OF THE CIRCLE CIRCUMFRENCE\n");
            Console.WriteLine("Did you get the correct values to get the Area and circumfrence of the prison? LETS FIND OUT!");
            string str_var = Console.ReadLine();
            int int_var = int.Parse(str_var);
            double radius = int_var;
            double pi = Math.PI;
            double circumference;
            double area;
            circumference = 2 * pi * radius;
            area = pi * (radius * radius);
            Console.WriteLine("Circumference of Circle : {0}", circumference);
            Console.WriteLine("Area of a Circle : {0}", area);

            Console.WriteLine("You passed the first lock\n");
            Console.WriteLine("Press ENTER to continue to lock 2");
            Console.ReadLine();
            Console.WriteLine("Lock 2 HEMISHPERE OF TIME\n");
            Console.WriteLine("Enter a radius to calculate the Hemisphere of Time");
            str_var = Console.ReadLine();
            int_var = int.Parse(str_var);
            double volume;
            volume = (1.333333333) * pi * (radius * radius * radius) / 2;
            Console.WriteLine("volume of a Circle : {0}", volume);


            Console.WriteLine("You passed the second lock travler!\n");
            Console.WriteLine("Press ENTER to continue to lock 3");
            Console.ReadLine();
            Console.WriteLine("Lock 3 ARENA, THE TRIANGLE OF DOOM!\n");
            Console.WriteLine("Heron needs your help in finding the three sides of the triangle\n");
            Console.WriteLine("Enter side A");
            string strsidea = Console.ReadLine();
            double intsidea = int.Parse(strsidea);
            Console.WriteLine("Enter side B");
            string strsideb = Console.ReadLine();
            double intsideb = int.Parse(strsideb);
            Console.WriteLine("Enter side C");
            string strsidec = Console.ReadLine();
            double intsidec = int.Parse(strsidec);
            double intp = (intsidea + intsideb + intsidec) / 2;
            double introot = (intp - intsidea) * (intp - intsideb) * (intp - intsidec);
            double intarea = Math.Sqrt(intp * introot);
            Console.WriteLine(intarea);
            Console.WriteLine("You passed the third lock travler!\n");
            Console.WriteLine("Press ENTER to continue to Lock 4");
            Console.ReadLine();
            Console.WriteLine("PART 4 THE QUADTRATIC NECROMANCER\n");
            Console.WriteLine("WATCH OUT");
            Console.ReadLine();
            Console.WriteLine("Henry the Necromancer is sending lighting bolts at you! ");
            Console.ReadLine();
            Console.WriteLine("HURRY UP and unlock the last lock so The Wizard can defeat Henry!");
            Console.ReadLine();

            Console.WriteLine("Enter value A");
            string strvaluea = Console.ReadLine();
            double valuea = int.Parse(strvaluea);
            Console.WriteLine("Enter value B");
            string strvalueb = Console.ReadLine();
            double valueb = int.Parse(strvalueb);
            Console.WriteLine("Enter value C");
            string strvaluec = Console.ReadLine();
            double valuec = int.Parse(strvaluec);

            double ac = 4 * (valuea * valuec);
            double bsquared = valueb * valueb;
            double abc = bsquared - ac;
            if (abc < 0)
            {

                Console.WriteLine("You try your best but the lock isn't opening");
                Console.ReadLine();
                Console.WriteLine("A huge bolt of lighting hurles toward you");
                Console.ReadLine();
                Console.WriteLine("You fail to dodge it..... killing you and... The Wizard");
                Console.ReadLine();
                Console.WriteLine("No Real Solution\n");
                Console.WriteLine("GAME OVER\n");
                Console.WriteLine("Press ENTER to restart");
            }
            else
            {
                double bottom = 2 * valuea;
                double abcsquare = Math.Sqrt(abc);
                double right = abcsquare / bottom;
                double left = (-valueb) / bottom;
                double Xpos = left + right;
                double Xneg = left - right;


                Console.ReadLine();
                Console.WriteLine("A huge bolt of lighting hurles toward you");
                Console.ReadLine();
                Console.WriteLine("CLICK");
                Console.ReadLine();
                Console.WriteLine("CLACK");
                Console.ReadLine();
                Console.WriteLine("CLUNK!");
                Console.ReadLine();
                Console.WriteLine("The final lock drops");
                Console.ReadLine();
                Console.WriteLine("THE WIZARD lunges forward grabbing the lighting bolt in his hands\n");
                Console.WriteLine("With a smile on his face he redirects it back to Henry\n");
                Console.WriteLine("Vaporizing Henry in thin air");
                Console.ReadLine();
                Console.WriteLine(Xpos);
                Console.WriteLine(Xneg);
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.WriteLine("CONGRATULATIONS YOU WON\n");
                Console.WriteLine("You have unlocked a new Character\n");
                Console.WriteLine("THE WIZARD Charles Xavier Carter");
                Console.WriteLine("Press ENTER to restart");

            }

            Console.ReadKey();
            goto start;


        }




    }

}

