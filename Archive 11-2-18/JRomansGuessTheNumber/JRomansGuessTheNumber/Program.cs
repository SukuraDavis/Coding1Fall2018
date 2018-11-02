using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRomansGuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Userinput = 0;
           
            Random rand = new Random();
           
            int number = rand.Next(0, 1000);
           
            int count = 0;
           
            do
            {
                
                Console.WriteLine("Guess a number from 0-1000");
               
                Userinput = int.Parse(Console.ReadLine());
               
                count++;
                
                if (number > Userinput)
                {
                    Console.WriteLine("The number you guessed is low. Try again!");
                }
                else if (number < Userinput)
                {
                    Console.WriteLine("The number you guessed is high. Try again!");
                }

               
            } while (number != Userinput);

           
            Console.WriteLine("Congratulations! You guessed the right number! It took you " + count + " tries.");
            Console.ReadLine();


        }
    }
}
