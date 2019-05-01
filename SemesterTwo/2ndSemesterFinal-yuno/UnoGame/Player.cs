using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGame
{
    public class Player
    {
        public bool active = true;
        public bool isAI = false;
        public string name;
        Random r = new Random();
        public List<Card> hand = new List<Card>();
        public Player(string name, bool isAI)
        {
            this.name = name;
            this.isAI = isAI;
        }
        public void Play(ref List<Card> deck, ref List<Card> playDeck, int turn, ref int plusBuffer)
        {
            OrderHand(ref hand);
            if (plusBuffer != 0)
            {
                Console.WriteLine("Draw " + plusBuffer + " cards");
            }
            if (!isAI)
            {
                for (int i = 0; i < hand.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("[");
                    hand[i].print();
                    Console.Write("] ");
                }
            }

            bool turnEnd = false;
            Console.Write("\n");
            while (!turnEnd)
            {
                string line;
                if (isAI)
                {
                    line = select(playDeck[playDeck.Count - 1], plusBuffer);
                }
                else
                {
                    line = Console.ReadLine();
                }
                if (line.ToLower() == "give up")
                {
                    for (int i = 0; i < hand.Count; i++)
                    {
                        deck.Add(hand[i]);
                    }
                    active = false;
                    turnEnd = true;
                }

                else if (line.ToLower().Equals("draw"))
                {
                    if (plusBuffer == 0)
                    {
                        drawCard(ref deck, ref playDeck);

                    }
                    else
                    {
                        playDeck[playDeck.Count - 1].effected = true;
                        for (int j = 0; j < plusBuffer; j++)
                        {
                            drawCard(ref deck, ref playDeck);
                        }
                        plusBuffer = 0;
                    }
                    turnEnd = true;
                }
                else
                {
                    string[] command = line.Split(' ');
                    bool found = false;
                    for (int i = 0; i < hand.Count && !found; i++)
                    {
                        if (hand[i].toString() == command[0].ToUpper())
                        {
                            found = true;
                            if (hand[i].isPlayable(ref playDeck))
                            {
                                if (hand[i].valueToString() == "C" || hand[i].valueToString() == "+4")
                                {
                                    string color = "X";
                                    while (hand[i].color == ConsoleColor.Gray)
                                    {
                                        switch (color)
                                        {
                                            case "R":
                                                hand[i].color = ConsoleColor.Red;
                                                break;
                                            case "G":
                                                hand[i].color = ConsoleColor.Green;
                                                break;
                                            case "B":
                                                hand[i].color = ConsoleColor.Blue;
                                                break;
                                            case "Y":
                                                hand[i].color = ConsoleColor.Yellow;
                                                break;
                                            default:
                                                Console.WriteLine("Please select a color R G B or Y");
                                                if (isAI)
                                                {
                                                    color = selectColor().ToUpper();
                                                }
                                                else
                                                {
                                                    color = Console.ReadLine().ToUpper();
                                                }
                                                break;
                                        }
                                    }
                                }
                                if (plusBuffer != 0)
                                {
                                    if (hand[i].valueToString() == "+4")
                                    {
                                        plusBuffer += 4;
                                        playCard(ref i, ref playDeck);
                                    }
                                    else if (hand[i].valueToString() == "+2")
                                    {
                                        plusBuffer += 2;
                                        playCard(ref i, ref playDeck);
                                    }
                                    else
                                    {
                                        playDeck[playDeck.Count - 1].effected = true;
                                        for (int j = 0; j < plusBuffer; j++)
                                        {
                                            drawCard(ref deck, ref playDeck);
                                        }
                                        plusBuffer = 0;
                                    }
                                }
                                else
                                {
                                    playCard(ref i, ref playDeck);
                                }
                                if (hand.Count == 1)
                                {
                                    bool said = false;
                                    if (command.Length > 1)
                                    {
                                        if (command[command.Length - 1].ToUpper() == "UNO")
                                        {
                                            said = true;
                                        }
                                    }
                                    if (!said)
                                    {
                                        Console.WriteLine("You didn\'t said UNO :/ 2 cards drawed");
                                        drawCard(ref deck, ref playDeck);
                                        drawCard(ref deck, ref playDeck);
                                        Console.WriteLine("Press any key to end turn");
                                        if (!isAI)
                                        {
                                            Console.ReadKey();
                                        }
                                    }

                                }
                                turnEnd = true;
                            }
                            else
                            {
                                Console.WriteLine("This card cant be played now\n");
                            }
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("You don't have this card");
                    }
                }
            }

        }
        public void drawCard(ref List<Card> deck, ref List<Card> playDeck)
        {

            if (deck.Count == 0)
            {
                int a = r.Next(playDeck.Count);
                if (playDeck[a].value > 12)
                {
                    playDeck[a].color = ConsoleColor.Gray;
                }
                playDeck[a].effected = false;
                hand.Add(playDeck[a]);
                playDeck.RemoveAt(a);
            }
            else
            {
                hand.Add(deck[deck.Count - 1]);
                deck.RemoveAt(deck.Count - 1);
            }
        }
        public void playCard(ref int cardIndex, ref List<Card> deck)
        {
            deck.Add(hand[cardIndex]);
            hand.RemoveAt(cardIndex);
        }
        public void OrderHand(ref List<Card> hand)
        {
            for (int i = 0; i < hand.Count; i++)
            {
                for (int j = i; j < hand.Count; j++)
                {
                    if (hand[i].getOrderValue() > hand[j].getOrderValue())
                    {
                        replace(i, j, ref hand);
                    }
                }
            }
        }
        public void replace(int a, int b, ref List<Card> hand)
        {
            Card temp = hand[a];
            hand[a] = hand[b];
            hand[b] = temp;
        }
        private string select(Card card, int plusBuffer)
        {
            string aiCommand = "";
            if (plusBuffer != 0)
            {
                bool found = false;
                for (int i = 0; i < hand.Count; i++)
                {
                    if (!found)
                    {
                        if (card.color == hand[i].color && hand[i].valueToString() == "+2")
                        {
                            aiCommand = hand[i].toString();
                            found = true;
                        }
                        else if (hand[i].valueToString() == "+4")
                        {
                            aiCommand = hand[i].toString();
                            found = true;
                        }
                        else
                        {
                            aiCommand = "";
                        }
                    }
                }
            }
            if (aiCommand == "")
            {
                bool found = false;
                for (int i = 0; i < hand.Count; i++)
                {
                    if (!found)
                    {
                        if (card.color == hand[i].color)
                        {
                            aiCommand = hand[i].toString();
                            found = true;
                        }
                        else if (card.value == hand[i].value)
                        {
                            aiCommand = hand[i].toString();
                            found = true;
                        }
                        else if (hand[i].value > 12)
                        {
                            aiCommand = hand[i].toString();
                            found = true;
                        }
                        else
                        {
                            aiCommand = "draw";
                        }
                    }
                }
            }
            if (aiCommand != "draw" && hand.Count == 2)
            {
                if (r.Next(100) > 10)
                {
                    aiCommand += " uno";
                }
            }
            Console.WriteLine(aiCommand);
            return aiCommand;
        }
        private string selectColor()
        {
            string selecedColor = "";
            int[] rgby = new int[4];
            for (int i = 0; i < hand.Count; i++)
            {
                switch (hand[i].color)
                {
                    case ConsoleColor.Blue:
                        rgby[2]++;
                        break;
                    case ConsoleColor.Green:
                        rgby[1]++;
                        break;
                    case ConsoleColor.Red:
                        rgby[0]++;
                        break;
                    case ConsoleColor.Yellow:
                        rgby[3]++;
                        break;
                    default:
                        break;
                }

            }
            int index = 0;
            for (int i = 0; i < rgby.Length; i++)
            {
                if (rgby[index] < rgby[i])
                {
                    index = i;
                }
            }
            if (rgby[index] == 0)
            {
                switch (r.Next(4))
                {
                    case 0:
                        selecedColor = "r";
                        break;
                    case 1:
                        selecedColor = "g";
                        break;
                    case 2:
                        selecedColor = "b";
                        break;
                    case 3:
                        selecedColor = "y";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    case 0:
                        selecedColor = "r";
                        break;
                    case 1:
                        selecedColor = "g";
                        break;
                    case 2:
                        selecedColor = "b";
                        break;
                    case 3:
                        selecedColor = "y";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(selecedColor);
            return selecedColor;
        }
    }
}
