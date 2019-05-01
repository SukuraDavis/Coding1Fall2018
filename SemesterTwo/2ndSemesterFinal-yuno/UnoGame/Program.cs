using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGame
{
    class Program
    {
        static int turn;
        static List<Player> playerList = new List<Player>();
        static List<Card> deck = new List<Card>();
        static List<Card> playedCards = new List<Card>();
        static int numberOfCards = 15;
        static int numberOfStarterCards = 7;
        static bool irany = true;
        static int mode = 0;
        static int plusBuffer = 0;
        static List<string> winnerList = new List<string>();
        static string[] names = new string[] { "Lance", "Kat", "Guardia", "Jordan", "Victoria", "Desu", "Volt"};
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                switch (MainMenu())
                {
                    case 1:
                        localSingleInit();
                        break;
                    case 2:
                        localMultyInit();
                        break;
                    case 3:
                        Help();
                        break;
                    case 4:
                        Console.WriteLine("Game stopped");
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }

        static int MainMenu()
        {
            int a = 0;
            mode = 0;
            Console.Clear();
            Console.WriteLine("---UNO!---");
            string[] choice = new string[] { "Single Player", "Local Multi", "Help", "Exit" };
            for (int i = 0; i < choice.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + choice[i]);
            }
            while (a == 0)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        a = 1;
                        break;
                    case "2":
                        a = 2;
                        break;
                    case "3":
                        a = 3;
                        break;
                    case "4":
                        a = 4;
                        break;
                    //case "5":
                   //     a = 5;
                  //      break;
                    default:
                        a = 0;
                        break;
                }
            }
            return a;
        }
        static void clearGameData()
        {
            deck.Clear();
            winnerList.Clear();
            plusBuffer = 0;
            playedCards.Clear();
            playerList.Clear();
            irany = true;
        }
        static void localMultyInit()
        {
            initDeck();
            mode = 3;
            Console.WriteLine("Num of Players:");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " name:");
                playerList.Add(new Player(Console.ReadLine(), false));
                for (int j = 0; j < numberOfStarterCards; j++)
                {
                    playerList[i].drawCard(ref deck, ref playedCards);
                }
            }
            localPlay();


        }
        static void localSingleInit()
        {
            initDeck();
            Console.WriteLine("Num of Players:");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Player\'s  name:");
                    string name = Console.ReadLine();
                    if (name == "")
                    {
                        name = "You";
                    }
                    playerList.Add(new Player(name, false));
                }
                else
                {
                    Console.WriteLine(i + ". computer\'s name:");
                    string name = Console.ReadLine();
                    if (name == "")
                    {
                        name = names[i - 1];
                    }
                    playerList.Add(new Player(name, true));
                }
                for (int j = 0; j < numberOfStarterCards; j++)
                {
                    playerList[i].drawCard(ref deck, ref playedCards);
                }
            }
            localPlay();


        }
        static void initDeck()
        {
            Console.Clear();
            for (int i = 0; i < numberOfCards; i++)
            {
                if (i > 12)
                {
                    deck.Add(new Card(ConsoleColor.Gray, i));
                    deck.Add(new Card(ConsoleColor.Gray, i));
                    deck.Add(new Card(ConsoleColor.Gray, i));
                    deck.Add(new Card(ConsoleColor.Gray, i));
                }
                else
                {
                    deck.Add(new Card(ConsoleColor.Red, i));
                    deck.Add(new Card(ConsoleColor.Blue, i));
                    deck.Add(new Card(ConsoleColor.Green, i));
                    deck.Add(new Card(ConsoleColor.Yellow, i));
                }

            }
            Shuffle(ref deck);
        }
        static void localPlay()
        {

            turn = playerList.Count;
            int starter = 1;
            while (deck[deck.Count - starter].value > 9)
            {
                starter++;
            }
            playedCards.Add(deck[deck.Count - starter]);
            deck.RemoveAt(deck.Count - starter);

            while (NumOfActivePlayers() != 1)
            {

                //RefillDeck();

                int index = turn % playerList.Count;
                if (playerList[index].active)
                {
                    Console.Clear();
                    if (winnerList.Count != 0)
                    {
                        for (int i = 0; i < winnerList.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + winnerList[i]);
                        }
                    }
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        if (i != index && playerList[i].active)
                        {
                            Console.Write(playerList[i].name);
                            if (playerList[i].hand.Count == 1)
                            {
                                Console.Write(" UNO!");
                            }
                            Console.Write("\n");
                            for (int j = 0; j < playerList[i].hand.Count; j++)
                            {
                                Console.Write("[" + "] ");
                            }
                            Console.Write("\n");
                        }
                    }

                    Console.WriteLine("");
                    if (playedCards.Count != 0)
                    {
                        Console.Write("[");
                        playedCards[playedCards.Count - 1].print();
                        Console.Write("]");
                        Console.Write("\n\n");
                    }
                    int sumHand = 0;
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        if (playerList[i].active)
                        {
                            sumHand += playerList[i].hand.Count;
                        }
                    }
                    //Console.WriteLine(deck.Count);

                    Console.WriteLine(playerList[index].name + "\'s turn:");

                    if (playerList[index].isAI)
                    {
                        for (int i = 0; i < playerList[index].hand.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("[");
                            Console.Write("] ");
                        }
                    }
                    if (playerList[index].isAI && NumOfActiveRealPlayers() != 0)
                    {
                        Console.WriteLine("Thinking...");
                        System.Threading.Thread.Sleep(500);
                        //Console.ReadKey();
                    }
                    if (mode == 3)
                    {
                        Console.ReadKey();
                    }
                    playerList[index].Play(ref deck, ref playedCards, turn, ref plusBuffer);

                    if (playerList[index].hand.Count == 0)
                    {
                        winnerList.Add(playerList[index].name);
                        playerList[index].active = false;
                    }
                }
                if (!playedCards[playedCards.Count - 1].effected)
                {
                    if (playedCards[playedCards.Count - 1].valueToString() == "X")
                    {
                        playedCards[playedCards.Count - 1].effected = true;
                        nextTurn();
                    }
                    if (playedCards[playedCards.Count - 1].valueToString() == "<>")
                    {
                        playedCards[playedCards.Count - 1].effected = true;
                        irany = !irany;
                    }
                    if (plusBuffer == 0)
                    {
                        if (playedCards[playedCards.Count - 1].valueToString() == "+2")
                        {
                            plusBuffer += 2;
                            playedCards[playedCards.Count - 1].effected = true;
                        }
                        if (playedCards[playedCards.Count - 1].valueToString() == "+4")
                        {
                            plusBuffer += 4;
                            playedCards[playedCards.Count - 1].effected = true;
                        }
                    }
                }
                nextTurn();

            }

            GetWinner();
            Console.WriteLine("\nPress any key");
            clearGameData();
            Console.ReadKey();
        }
        static void nextTurn()
        {
            if (irany)
            {
                turn++;
            }
            else
            {
                turn--;
            }
            if (turn < playerList.Count)
            {
                turn = (playerList.Count * 2) - 1;
            }
            if (turn > playerList.Count * 2)
            {
                turn = playerList.Count + 1;
            }
        }
        static int NumOfActiveRealPlayers()
        {
            int activeNum = 0;
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].active && !playerList[i].isAI)
                {
                    activeNum++;
                }
            }

            return activeNum;
        }
        static int NumOfActivePlayers()
        {
            int activeNum = 0;
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].active)
                {
                    activeNum++;
                }
            }

            return activeNum;
        }
        static void GetWinner()
        {
            Console.Clear();
            for (int i = 0; i < winnerList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + winnerList[i]);
            }
            for (int i = 0; i < playerList.Count; i++)
            {
                if (playerList[i].active)
                {
                    Console.WriteLine("Last: " + playerList[i].name);
                }
            }
        }
        static void Shuffle(ref List<Card> deck)
        {

            Random r = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int a = r.Next(0, deck.Count);
                int b = r.Next(0, deck.Count);
                replace(ref a, ref b, ref deck);
            }
        }
        static void replace(ref int b, ref int a, ref List<Card> deck)
        {
            Card temp = deck[a];
            deck[a] = deck[b];
            deck[b] = temp;
        }
        
        static void Help()
        {
            Console.Clear();
            string word2 = "Symbol meanings: ";

            string word = "X = Skip\n<> = Reverse\nC = Change Color\n+2 = Draw 2\n+4 = Draw Four and Change Color";
            Console.WriteLine(word2);
            Console.WriteLine(word);
            Console.WriteLine(" ");

            string word3 = "Other: \nGive Up = If you wish to end the game or end your turn, type this command\nDraw = Use this when drawing cards";
            Console.WriteLine(word3);
            Console.WriteLine(" ");

            string text = "Rule: Symbol to Symbol, Color to Color\nIf your hand is empty you win! :) \n\nPlaying cards:\nIf a card has a color write the colors first letter before the cards symbol to play.\nFor example:";
            Console.WriteLine(text);
            Console.Write("\t-Play: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("6");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-->Write: r6\n");
            Console.Write("\t-Play: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("<>");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-->Write: b<>\n");
            Console.Write("\t-Play: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("+2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-->Write: y+2\n");
            Console.Write("\t-Play: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("X");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-->Write: gx\n");
            Console.WriteLine("\nUpper or lower letters doesn\'t matter.\nFor the last example: You can use gx, Gx, gX or GX. It\'s the same.");
            Console.WriteLine("\nWe have two special cards. C (Change Color) and +4. These cards don\'t have color, but it can be played to any card.");
            Console.WriteLine("\nYou can play these card like this:");
            Console.Write("\t-Play: C ");
            Console.Write("-->Write: c \n");
            Console.WriteLine("\t\t-Now it will ask you for a letter R, G, B or Y");
            Console.WriteLine("\t\tr or R --> Switch color to Red");
            Console.WriteLine("\t\tg or G --> Switch color to Green");
            Console.WriteLine("\t\tb or B --> Switch color to Blue");
            Console.WriteLine("\t\ty or Y --> Switch color to Yellow");
            Console.Write("\t-Play: +4 ");
            Console.Write("-->Write: +4 \n");
            Console.WriteLine("\t\t-Now it will ask you for a letter R, G, B or Y");
            Console.WriteLine("\t\tr or R --> Switch color to Red");
            Console.WriteLine("\t\tg or G --> Switch color to Green");
            Console.WriteLine("\t\tb or B --> Switch color to Blue");
            Console.WriteLine("\t\ty or Y --> Switch color to Yellow");
            Console.WriteLine("If you have only 2 cards in hand, and you play a card, you have to say UNO (uno/Uno is also fine).\n");
            Console.WriteLine("Example:");
            Console.WriteLine("You have these cards in your hand:");
            Console.Write("[");
            new Card(ConsoleColor.Red, 6).print();
            Console.Write("]");
            Console.Write("[");
            new Card(ConsoleColor.Gray, 13).print();
            Console.Write("]\n");
            Console.WriteLine("Now you can type r6 or +4. But you'll have 1 card in hand! So you have to say UNO. How? Just type \'uno\' after the played card.");
            Console.WriteLine("So you have to type like this:\n\t+4 uno\nIt will ask a color because it\'s +4 but you have to type it after the played card.");
            
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to return to the main menu.");
            Console.ReadKey();
        }
    }
}
