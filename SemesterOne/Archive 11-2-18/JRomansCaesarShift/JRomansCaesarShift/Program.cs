using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRomansCaesarShift
{
    class Program
    {
        static void Main(string[] args)
        {
            //char e = 'e';
            //int shift = -3;
            //char shifted = (char)(e + shift);
            //Console.WriteLine(shifted);
            //Will print e = b

            int input = 0;

            while (input != 3)
            {
                Console.WriteLine("Choose an option that you want to do: ");
                Console.WriteLine("1. Encryption");
                Console.WriteLine("2. Decryption");
                Console.WriteLine("3. Exit the program.");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    encrypt();
                }
                else if (input == 2)
                {
                    do
                    {
                        BruteForce();
                    } while (input != 26);

                    //decrypt();
                }



            }
        }

        static void encrypt()
        {
            //char shifted;

            string letter;
            Console.WriteLine("Enter a string (or char) to encrypt: ");
            letter = Console.ReadLine();

            letter.Replace(" ", string.Empty);

            char[] ToStore = letter.ToCharArray();



            int shift;
            Console.WriteLine("Enter a shift value: ");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            foreach (var other in ToStore)
            {
                char shifted = (char)(other + shift);



                if (shifted > 122)
                {
                    shifted = (char)(other + shift - 26);
                }


                Console.WriteLine(shifted);






            }
            Console.WriteLine(" ");
            Console.WriteLine("This is your encrypted word! (Or letter) :)");
            Console.WriteLine(" ");
        }

        static void decrypt()
        {


            string letter;
            Console.WriteLine("Enter a string (or char) to decrypt: ");
            letter = Console.ReadLine();

            letter.Replace(" ", string.Empty);

            char[] ToStore = letter.ToCharArray();



            int shift;
            Console.WriteLine("Enter the original shift value: ");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            foreach (var other in ToStore)
            {
                char shifted = (char)(other - shift);

                if (shifted < 97)
                {
                   shifted = (char)(other - shift + 26);
                }


                Console.WriteLine(shifted);
                    
                
            }
            Console.WriteLine(" ");
            Console.WriteLine("This is your decrypted word! (Or letter) :)");
            Console.WriteLine(" ");
        }

        static void BruteForce()
        {
            string letter;
            Console.WriteLine("Enter a string (or char) to decrypt: ");
            letter = Console.ReadLine();

            letter.Replace(" ", string.Empty);

            char[] ToStore = letter.ToCharArray();



            int shift;
            Console.WriteLine("Enter the original shift value: ");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            foreach (var other in ToStore)
            {
                char shifted = (char)(other - shift);

                if (shifted < 97)
                {
                    shifted = (char)(other - shift + 26);
                }


                Console.WriteLine(shifted);


            }
            
        }
    }
}
