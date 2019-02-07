using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            
            while (input != 20)
            {
                Console.WriteLine("Code Quest! Which one would you like to access?");
                Console.WriteLine("1. Pass/Fail");
                Console.WriteLine("2. AEIOU");
                Console.WriteLine("3. SufFux");
                Console.WriteLine("4. Rock, Paper, Scissors");
                Console.WriteLine("5. Collatz Conjecture");
                Console.WriteLine("6. Space Station Repair Lights");
                Console.WriteLine("7. Palindrome Series");
                Console.WriteLine("8. Apollo 13");
                Console.WriteLine("9. Are Eucliding Me?");
                Console.WriteLine("10. Bishop's Move");
                Console.WriteLine("11. Chroma Key Effect");
                Console.WriteLine("12. Sieve of Erastosthenes");
                Console.WriteLine("13. Peoplebook");
                Console.WriteLine("14. ZIPPER text");
                Console.WriteLine("15. Piecewise Encrypter");
                Console.WriteLine("16. Twinkle Twinkle");
                Console.WriteLine("17. Tic Tac Toe Checker");
                Console.WriteLine("18. Dominating Disney");
                Console.WriteLine("19. It's an Enigma!");
                Console.WriteLine("20. Exit the program");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    List<int> Lgrade = new List<int>();

                    string innie = "";

                    Console.Write("Would you like to create a list of grades to see whether it was a pass or fail? (yes or no): ");

                    innie = Console.ReadLine();

                    int grade = 0;

                    int exit = 0;

                    if (innie == "yes")
                    {
                        do
                        {
                            Console.WriteLine("1. Add a grade");
                            Console.WriteLine("2. See the list");
                            Console.WriteLine("3. Return to the main menu");

                            exit = int.Parse(Console.ReadLine());

                            if (exit == 1)
                            {
                                Console.WriteLine("What is the grade you wish to add?");

                                grade = int.Parse(Console.ReadLine());

                                Lgrade.Add(grade);

                            }

                            if (exit == 2)
                            {
                                foreach (var x in Lgrade)
                                {
                                    if (x < 70)
                                    {
                                        Console.WriteLine("FAIL");
                                    }

                                    else
                                    {
                                        Console.WriteLine("PASS");
                                    }
                                }
                            }


                        } while (exit != 3);
                    }

                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Sending you back to the main menu.");
                        Console.WriteLine(" ");
                    }




                }

                if (input == 2)
                {
                    

                    string yesno = " ";

                    string word = " ";

                    Char[] WordList = word.ToCharArray();

                    int exit = 0;

                    int inn = 0;

                    Console.Write("Would you like to check a word or sentence to see how many consonants it contains? (yes or no): ");

                    if (yesno == "yes")
                    {
                        do
                        {
                            Console.WriteLine("1. Add a word");
                            Console.WriteLine("2. Check the list");
                            Console.WriteLine("3. Return to the main menu.");

                            exit = int.Parse(Console.ReadLine());

                            if (exit == 1)
                            {
                                Console.WriteLine("What word or sentence would you like to add?: ");
                                word = Console.ReadLine();
                               // WordList.Add(word);
                            }

                            if (exit == 2)
                            {
                                

                                foreach (var e in WordList)
                                {
                                    
                                   
                                }
                            }
                        } while (inn != 3);
                    }

                    else
                    {
                        Console.WriteLine("Returning you to the main menu.");
                    }
                }

                if (input == 17)
                {

                    

                }







                


            }
               
            

        }
    }
}
