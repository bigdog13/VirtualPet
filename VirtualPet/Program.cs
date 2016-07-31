using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {



            //create object //new inst of class //parameter 
            Pet MAXX = new Pet("\n\nHere are MAXX's current vitals\n", 50, 50, 50);
            string playAgain;
            do
            {
                Console.WriteLine("Hi--");


                MAXX.Tick();
                // MAXX.PrintStats();
                Console.WriteLine("\n\nWhat do you want to do with MAXX?");
                Console.WriteLine("enter 1 to feed.");
                Console.WriteLine("enter 2 to play.");
                Console.WriteLine("enter 3 to walk.");

                int number = int.Parse(Console.ReadLine());


                switch (number)
                {
                    case 1:

                        MAXX.action();
                        Console.WriteLine("\n\nMAXX says thanks");
                        break;

                    case 2:

                        MAXX.action();
                        Console.WriteLine("\n\nOUCH my leash is too tight");
                        break;

                    case 3:

                        MAXX.action();
                        Console.WriteLine("\n\nWHOA buddy my legs are too short to go that fast");
                        break;

                    default:

                        break;

                }//end of switch
                MAXX.Tick();
                MAXX.print();

                //ask op if they want to play again
                Console.WriteLine("Do you to to play agian yes / no?");
                playAgain = Console.ReadLine().ToLower();
                Console.Clear();

            } while (playAgain == "yes");

                     
            






















































        }
    }
}
