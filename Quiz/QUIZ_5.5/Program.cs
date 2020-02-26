using System;
using System.Collections.Generic;
using System.Linq;

namespace QUIZ_5._5
{
    class Program // this is your class
    {
        static void Main(string[] args) // this is your method
        {
            string words = "I think, therefore I am"; //declaring "words" as a string and having it equal "I think, therefore I am" 

            char[] spaces = { ' ', ' ', ' ', ' ' }; // setting array of spaces to split words
            // you dont need char spaces. you can use 'string[] value = words.Split(" "); ' instead.

            string[] value = words.Split(" "); // this is your array of words
                                                   // words is split between spaces and then layerd one on top of the other in a 1x4 grid

            for (int i = 4; i < value.Length; i--) // this is your for loop 
                                                   //i starts from 4th array and goes down every time it loops therefore reversing it.
            {
                Console.WriteLine(value[i]);    // writes your result
            }


        }
    }
}
