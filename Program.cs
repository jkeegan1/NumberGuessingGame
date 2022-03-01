using System;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;

namespace guessingGame
{
class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int correctNum = rng.Next(0,100);
        bool win = false;
        do 
        {
           Console.Write("Guess a number betweenn 0 and 100:");
           string s = Console.ReadLine();
           int i = int.Parse(s);
           if (i > correctNum)
           {
             Console.WriteLine("The number you guessed was too high, try again!"); 
           }
           else if(i < correctNum)
           {
               Console.WriteLine("The number you guessed was too low, try again");
           }
            else if ( i == correctNum )
            {
                Console.WriteLine("You guessed corretly!");
                win = true;
            }
                            
            }while(win == false);
        }
    }

}
