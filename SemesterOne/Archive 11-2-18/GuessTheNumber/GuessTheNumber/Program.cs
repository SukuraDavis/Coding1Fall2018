using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code prompts user to guess a number between 0-1000 and program prints wether it is too high, too low, or correct.

            // create Int for user input
            int input = 0;
            // create Random rand = new Random
            Random rand = new Random();
            // create Int for the one random number
            int num = rand.Next(0, 1000);
            // create Int that will keep track of each attempt (guesses)
            int count = 0;
            // create a do while loop where user has to re-guess for the random number if user input is too high or too low
            do
            {
                //Prompt user input
                Console.WriteLine("Guess a number from 0-1000");
                //Store user input
                input = int.Parse(Console.ReadLine());
                //Adds 1 to each attempt (guesses)
                count++;
                //If statement for if user input is too high or too low
                if (num > input)
                {
                    Console.WriteLine("Your guessed number is low.");
                }
                else if (num < input)
                {
                    Console.WriteLine("Your guessed number is high."); 
                }
                
                //End do-while loop
            } while (num != input);

            //Tells user how many tries it took
            Console.WriteLine("You guessed the right number! It took you " + count + " tries.");
            Console.ReadLine(); 
           

   
               
            
        }
    }
}
