using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoGame
{
    public class Card
    {
        public ConsoleColor color;
        public int value;
        public bool effected = false;
        public Card(ConsoleColor color, int value)
        {
            this.color = color;
            this.value = value;
        }
        public bool isPlayable(ref List<Card> lastPlayed)
        {
            if (value > 12)
            {
                return true;
            }
            return (lastPlayed[lastPlayed.Count - 1].color == color || lastPlayed[lastPlayed.Count - 1].value == value);
        }
        public string toString()
        {
            string r = "";
            switch (color)
            {
                case ConsoleColor.Blue:
                    r += "B";
                    break;
                case ConsoleColor.Green:
                    r += "G";
                    break;
                case ConsoleColor.Red:
                    r += "R";
                    break;
                case ConsoleColor.Yellow:
                    r += "Y";
                    break;
                default:
                    break;
            }
            r += valueToString();
            return r;
        }
        public int getOrderValue()
        {
            int r = 0;
            switch (color)
            {
                case ConsoleColor.Blue:
                    r += 0;
                    break;
                case ConsoleColor.Green:
                    r += 100;
                    break;
                case ConsoleColor.Red:
                    r += 200;
                    break;
                case ConsoleColor.Yellow:
                    r += 300;
                    break;
                case ConsoleColor.Gray:
                    r += 400;
                    break;
                default:
                    break;
            }
            r += value;
            return r;
        }
        public string valueToString()
        {
            string r = "";
            switch (value)
            {
                case 10:
                    r += "X";
                    break;
                case 11:
                    r += "+2";
                    break;
                case 12:
                    r += "<>";
                    break;
                case 13:
                    r += "+4";
                    break;
                case 14:
                    r += "C";
                    break;
                default:
                    r += value.ToString();
                    break;
            }
            return r;
        }
        public void print()
        {
            Console.ForegroundColor = color;
            Console.Write(valueToString());
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
