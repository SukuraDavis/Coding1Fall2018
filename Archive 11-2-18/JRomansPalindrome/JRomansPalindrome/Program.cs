using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRomansPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string reverse = "";
            Console.WriteLine("Enter a word that you want to check is a palindrome.");
            s = Console.ReadLine();
            string lower = s.ToLower();
            lower.Replace(" ", string.Empty);
            for (int i = lower.Length - 1; i >= 0; i--)
            {
                reverse += lower[i].ToString();
            }
            if (reverse == lower)
            {
                Console.WriteLine("The string you entered is a Palindrome!");
            }
            else
            {
                Console.WriteLine("The string you entered isn't a Palindrome.... :(");
            }
            Console.ReadKey();

        }
    }
}
