using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRomansHangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] WordList = new string[20];
            WordList[0] = "stars";
            WordList[1] = "zenith";
            WordList[2] = "orion";
            WordList[3] = "space";
            WordList[4] = "solar";
            WordList[5] = "lunar";
            WordList[6] = "mars";
            WordList[7] = "earth";
            WordList[8] = "pluto";
            WordList[9] = "moon";
            WordList[10] = "sun";
            WordList[11] = "apollo";
            WordList[12] = "eclipse";
            WordList[13] = "tilt";
            WordList[14] = "antares";
            WordList[15] = "regulus";
            WordList[16] = "polar";
            WordList[17] = "deneb";
            WordList[18] = "capella";
            WordList[19] = "draco";

            Console.WriteLine("Ready to have some Hangman fun???");
            Console.WriteLine("Topic: Astronomy");

            int count1 = 0;

            Random rand = new Random();
            int k = rand.Next(0, 20);
            string RandomWord = WordList[k];
            char[] guess = new char[RandomWord.Length];
            //Console.WriteLine("Enter guess: ");
            List<char> guesses = new List<char>();




            for (int i = 0; i < RandomWord.Length; i++)
                guess[i] = '_';

            while (true && count1 != 6)
            {
                count1++;
                Console.WriteLine(" ");
                Console.WriteLine("Enter guess: ");
                char UserGuess = char.Parse(Console.ReadLine());
                guesses.Add(UserGuess);
                Console.WriteLine("Your guessed guesses so far are: ");
                foreach (var input in guesses)
                {
                    Console.WriteLine(input);
                }

                if (count1 == 6)
                {
                    for (int i = 0; i < RandomWord.Length; i++)
                    {

                        if (UserGuess == RandomWord[i])
                            guess[i] = UserGuess;
                        Console.Write(guess[i]);

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("The word is " + RandomWord + "!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Thanks for playing! :)");
                    Console.ReadKey();
                }

                    for (int i = 0; i < RandomWord.Length; i++)
                    {

                        if (UserGuess == RandomWord[i])
                            guess[i] = UserGuess;
                        Console.Write(guess[i]);

                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("You have " + (6 - count1) + " guess(es) left.");





                
            }



        }
    }
}
    

    


