using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;

namespace DeckOfCards
{
    class Deck
    {
        List<Card> deckie = new List<Card>();

        List<Card> discardie = new List<Card>();

        

        public void Shuffle()
        {
            Random Rand = new Random();
            
            
            //might need to go backwards
            foreach(var v in discardie)
            {
                deckie.Add(v);
                discardie.Remove(v);
            }

          deckie = deckie.OrderBy(item => Rand.Next()).ToList();

        }

        public Card Draw()
        {
            Card first;
            first = deckie[deckie.Count - 1];

            Console.WriteLine(" ");
            Console.WriteLine(" Ooooooo!");
            first.Print();
            Console.Write(" ");
            
            Console.WriteLine("Has been drawn!");
            Console.WriteLine(" ");
            deckie.Remove(first);

            return first;
            
        }

        public void Discard(Card c)
        {
            
            discardie.Add(c);
            Console.WriteLine(" ");
            c.Print();
            Console.WriteLine(" ");
            Console.WriteLine("Has been discarded!");
            Console.WriteLine(" ");
            
           
            
            
            //  string user = "";
            //  Console.Write("What card would you like to discard?: ");

            //  foreach (var i in hand)
            //  {
            //      Console.WriteLine(i);

            //    user = Console.ReadLine();

            //     if (user == i)
            //     {
            //         discardie.Add(user);

            //          hand.Remove(user);
            //     }

            //     else
            //     {
            // Console.WriteLine("There is no such card in your hand!");
            //     }
            // }




        }

        public void PrintDeck()
        {
            for (int i = 0; i < deckie.Count; i++)
            {

                Console.WriteLine(" ");
                deckie[i].Print();


            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        public void PrintDiscard()
        {
            for (int i = 0; i < discardie.Count; i++)
            {

                Console.WriteLine(" ");
                discardie[i].Print();


            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }

        public Deck()
        {
            foreach(var face in Enum.GetValues(typeof(Face)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deckie.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }
    }
}
