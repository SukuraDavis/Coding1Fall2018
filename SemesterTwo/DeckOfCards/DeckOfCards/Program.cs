using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Deck myDeck = new Deck();
            Card myCard = new Card(Face.Ace, Suit.Clubs);

            while (input != 6)
            {
                Console.WriteLine("1. Shuffles the deck");
                Console.WriteLine("2. Draws a card from the deck");
                Console.WriteLine("3. Discards a card to the discard pile");
                Console.WriteLine("4. Prints the deck");
                Console.WriteLine("5. Prints the discard");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    myDeck.Shuffle();
                    Console.WriteLine(" ");
                    Console.WriteLine("The deck has been shuffled!");
                    Console.WriteLine(" ");
                }

                if (input == 2)
                {
                    
                    myCard = myDeck.Draw();
                }

                if (input == 3)
                {
                    
                  myDeck.Discard(myCard);
                    myCard = null;
                    

                }

                if (input == 4)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("This is the deck so far: ");
                    myDeck.PrintDeck();
                    
                }

                if (input == 5)
                {
                    Console.WriteLine(" ");

                    Console.WriteLine("This is the current discard pile: ");
                    
                    myDeck.PrintDiscard();
                    
                    
                }

            }

          
            
        }
    }
}
