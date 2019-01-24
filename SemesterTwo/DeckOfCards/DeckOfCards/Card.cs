using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;




namespace DeckOfCards
{
    public enum Suit { Clubs, Spades, Hearts, Diamonds }
    public enum Face { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

    class Card
    {
        //List<string> cards = new List<string>();

        

        public static Dictionary<Face, int> Value = new Dictionary<Face, int>()
        {
           { Face.Ace, 15 },
           { Face.Two, 2 },
           { Face.Three, 3 },
           { Face.Four, 4 },
           { Face.Five, 5 },
           { Face.Six, 6 },
           { Face.Seven, 7 },
           { Face.Eight, 8 },
           { Face.Nine, 9 },
           { Face.Ten, 10 },
           { Face.Jack, 10 },
           { Face.Queen, 10 },
           { Face.King, 10 },
        };

        public static Dictionary<Suit, string> type = new Dictionary<Suit, string>()
        {
            {Suit.Clubs, "of Clubs" },
            {Suit.Spades, "of Spades" },
            {Suit.Hearts, "of Hearts" },
            {Suit.Diamonds, "of Diamonds" },

                
        };
        public Face face;

        public Suit suit;

        public Card(Face face, Suit suit)
        {
            this.face = face;
            this.suit = suit;
        }

        public void Print()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("|" + " " + face + " " + "of " + suit + " " + "|");
            Console.WriteLine("------------------");
                
        }
    }
}
