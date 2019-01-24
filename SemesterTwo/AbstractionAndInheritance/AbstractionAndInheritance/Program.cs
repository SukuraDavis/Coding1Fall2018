using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace AbstractionAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This tells you the items. Weight is in grams, " +
                "rarity is on a scale from 1 to 100, and cost is in gold.");

            List<Item> storage = new List<Item>();
           
            storage.Add(new Candy(1, 2, 10, "Yum! Why not have a treat? You restore 15 MP."));
            storage.Add(new Peppers(5, 2, 3, "WHAT ARE YOU THINKING??? I thought everyone knows that these peppers are-----, ahem. Excuse me. You restore 20 HP...."));
            storage.Add(new Water(10, 2, 2, "Ah, water. Refreshing. Restore 5 MP and 10 HP."));
            storage.Add(new Soda(12, 2, 5, "Here, have a coke! Don't drink more than 3 in one day though. You been warned. Restore 20 HP."));
            storage.Add(new Sword(450, 25, 65, "A sword that weilds dark magic... User beware. The weak will be consumed."));
            storage.Add(new Bow(300, 28, 70, "A bow that shoots arrows of darkness... User beware. The weak will be consumed."));
            storage.Add(new Harp(205, 40, 128, "An instrument that produces a calming melody. The harp is used along with magical attacks of light magic."));
            storage.Add(new Wand(20, 80, 300, "It looks like a stick. It must be a rip off... or is it? With the power of light, watch as you weild the greatest magic to protect you and your peers from enemies."));

            

            for (int i = 0; i < storage.Count; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(storage[i] + ":");
                Console.WriteLine(" ");
                Console.WriteLine(storage[i].description);
                Console.WriteLine("Cost: " + storage[i].cost);
                Console.WriteLine("Rarity: " + storage[i].rarity);
                Console.WriteLine("Weight: " + storage[i].weight);

                

            }
            Console.WriteLine(" ");
            Console.WriteLine("End of program.");
            Console.ReadKey();
            
        }
    }
}
