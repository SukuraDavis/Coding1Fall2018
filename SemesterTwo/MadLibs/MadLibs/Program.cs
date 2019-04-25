using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string adjective3 = Console.ReadLine();

            Console.WriteLine("Enter a body part: ");
            string body1 = Console.ReadLine();

            Console.WriteLine("Enter a living thing, but it must be plural: ");
            string plural1 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter an emotion: ");
            string emotion1 = Console.ReadLine();

            Console.WriteLine("Enter an object: ");
            string object1 = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string adjective4 = Console.ReadLine();

            Console.WriteLine("Enter a verb that ends in -ed: ");
            string verbED1 = Console.ReadLine();

            Console.WriteLine("Enter a place: ");
            string place1 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb1 = Console.ReadLine();

            Console.WriteLine("Enter an emotion: ");
            string emotion2 = Console.ReadLine();

            Console.WriteLine("Enter a body part: ");
            string body2 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb2 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb3 = Console.ReadLine();

            Console.WriteLine("Enter a quote: ");
            string quote = Console.ReadLine();

            Console.WriteLine("Enter a place: ");
            string place2 = Console.ReadLine();

            Console.WriteLine("Enter an object: ");
            string object2 = Console.ReadLine();

            Console.WriteLine("Enter an action ending in -ing: ");
            string action = Console.ReadLine();

            Console.WriteLine("Enter a profession: ");
            string profession = Console.ReadLine();

            Console.WriteLine("Enter an emotion: ");
            string emotion3 = Console.ReadLine();

            Console.WriteLine("Enter a name: ");
            string name2 = Console.ReadLine();

            Console.WriteLine("Enter a place: ");
            string place3 = Console.ReadLine();

            Console.WriteLine("Enter an object: ");
            string object4 = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb4 = Console.ReadLine();

            Console.WriteLine("Enter a verb that end in -ed: ");
            string verbED2 = Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a name: ");
            string name3 = Console.ReadLine();

            Console.WriteLine("Enter a relationship status: ");
            string relation = Console.ReadLine();

            Console.WriteLine("Enter a crime: ");
            string crime = Console.ReadLine();

            Console.WriteLine("Enter a verb that ends in -ed: ");
            string verbED3 = Console.ReadLine();

            Console.WriteLine("Enter an object. Must be plural: ");
            string object3 = Console.ReadLine();

            Console.WriteLine("Enter an emotion: ");
            string emotion4 = Console.ReadLine();

            //   string[] messages = new string[] { "How are you gentlemen !!", "All your base are belong to us.", "You are on the way to destruction." };

            string[] messages = new string[] { "When we first met " + name1 + " you looked " + adjective2 + " and " + adjective3, "I couldn't believe my " + body1 + "!", "You smelled like " + plural1 + " and walked as graceful as a " + noun1 + ".",
            "When I " + emotion1 + " asked you if I could have your " + object1 + ", I could see a look of " + adjective4 + " in your eyes.", "You hesitated for a moment, then you " + verbED1 + "!", "I finally got to take you to " + place1 + ".",
            "I loved spending time with you.", "You could make me " + verb1 + " so easily, like no one had before.", "When you touched me, I felt " + emotion2 + " up my " + body2 + ".", "When it was over, I was so " + verb2 + " to bring you home, I longed to " + verb3 + " you again.",
            "When you looked at me and said '" + quote + "', I just knew.", "I went to my " + place2 + " and sat in front of my " + object2 + " after that.", "I can picture you " + action + " with me.", "The next day, you told me that you are a " + profession + ".", "You were feeling " + emotion3 + " towards " + name2 +
            " and wanted pay back.", "We went to " + name2 + "'s " + place2 + " and saw him at his " + object3 + ".", "You pulled out a " + noun2 + ", and we " + verb4 + "!", "The police caught us though, and they sent us to " + place3 + ".", "We " + verbED2 + " them and received " + num + " years at " + place3 + "!",
            "The very next day there was an article that read: 'Breaking news! " + name3 + " and " + name1 + " who are " + relation + " got arrested for " + crime + "!", "They " + verbED3 + " many " + object4 + ", but no need to feel " + emotion4 + " citizens!", "All is fine now."};
            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = 0; j < messages[i].Length; j++)
                {
                    Console.Write(messages[i][j]);
                    System.Threading.Thread.Sleep(50);
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
