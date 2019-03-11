using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_Practice_Assignment
{
    class Program
    {
        
        static char[] decodie = new char[26];
        static char[] alphabetta = new char[26];
        static void Main(string[] args)
        {
            int input = 0;


            while (input != 6)
            {

                Console.WriteLine("1. Little Johnny and his money!~");
                Console.WriteLine("2. Is it ascending, decending, or in random order?");
                Console.WriteLine("3. The decoded message...");
                Console.WriteLine("4. An integer multiplied by all lesser integers.");


                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int loop = 0;
                    List<float> money = new List<float>();

                    do
                    {
                        Console.WriteLine("1. Add a coin");
                        Console.WriteLine("2. The total of the coins");
                        Console.WriteLine("3. Return to the main menu.");

                        //  List<float> money = new List<float>();

                        float value = 0;
                        string kind = "";


                        loop = int.Parse(Console.ReadLine());

                        if (loop == 1)
                        {
                            Console.WriteLine("What are you adding? Type in caps.");
                            kind = Console.ReadLine();

                            if (kind == "QUARTER")
                            {
                                float quart = 0;

                                Console.WriteLine("How many quarters are there?");
                                value = int.Parse(Console.ReadLine());

                                quart = value * .25f;

                                money.Add(quart);


                            }

                            if (kind == "DIME")
                            {
                                float dime = 0;

                                Console.WriteLine("How many dimes are there?");
                                value = int.Parse(Console.ReadLine());

                                dime = value * .10f;

                                money.Add(dime);



                            }

                            if (kind == "NICKEL")
                            {
                                float nickel = 0;

                                Console.WriteLine("How many nickels are there?");
                                value = int.Parse(Console.ReadLine());

                                nickel = value * .05f;

                                money.Add(nickel);


                            }

                            if (kind == "HALFDOLLAR")
                            {
                                float half = 0;

                                Console.WriteLine("How many halfdollars are there?");
                                value = int.Parse(Console.ReadLine());

                                half = value * .50f;

                                money.Add(half);



                            }

                            if (kind == "PENNY")
                            {
                                float penny = 0;

                                Console.WriteLine("How many pennies are there?");
                                value = int.Parse(Console.ReadLine());

                                penny = value * .01f;

                                money.Add(penny);


                            }

                            if (kind != "PENNY" && kind != "DIME" && kind != "QUARTER" && kind != "NICKEL" && kind != "HALFDOLLAR")
                            {
                                Console.WriteLine("How much of " + kind + " are there?");
                                value = int.Parse(Console.ReadLine());

                                Console.WriteLine("You suddenly set the " + kind + " aside noticing that it cannot be added to the total amount.");
                            }


                        }

                        if (loop == 2)
                        {
                            float total = money.Sum(num => num);

                            Console.WriteLine("$" + total.ToString("0.00"));



                            //Console.WriteLine("$" + money.Sum(num => num));

                        }

                    } while (loop != 3);
                }

                if (input == 2)
                {
                    // int N = 0;

                    List<int> a = new List<int>();



                    int loop = 0;



                    do
                    {


                        Console.WriteLine("1. Add numbers.");
                        Console.WriteLine("2. Check if it is ascending, decending, invalid, etc.");
                        Console.WriteLine("3. Return to the main menu.");

                        loop = int.Parse(Console.ReadLine());

                        if (loop == 1)
                        {
                            //List<int> o = new List<int>();

                            Console.WriteLine("What number are you adding? ");

                            string p = "";

                            p = Console.ReadLine();

                            // p = int.Parse(Console.ReadLine());

                            if (p.ToLower().Contains('%'))

                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else if (p.ToLower().Contains('='))
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else if (p.ToLower().Contains('('))
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else if (p.ToLower().Contains('_'))
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else if (p.ToLower().Contains('^'))
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else if (p.Contains("- "))
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }

                            else
                            {
                                int r = 0;

                                bool res = int.TryParse(p, out r);


                                a.Add(r);



                            }
                        }

                        if (loop == 2)
                        {
                            string b = checklol(a);

                            Console.WriteLine(b);

                        }

                    } while (loop != 3);





                }

                if (input == 3)
                {
                    decrypt2();

                }

                if (input == 4)
                {
                    int i = 0;
                    int fact = 1;
                    int number = 0;

                    Console.Write("Enter a Number: ");
                    number = int.Parse(Console.ReadLine());
                    for (i = 1; i <= number; i++)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("Factorial of " + number + " is: " + fact);
                }


            }
        }

        static bool isSorted(int[] a)
        {
            int i = a.Length - 1;
            if (i <= 0) return true;
            if ((i & 1) > 0) { if (a[i] < a[i - 1]) return false; i--; }
            for (int ai = a[i]; i > 0; i -= 1)
                if (ai < (ai = a[i - 1]) || ai < (ai = a[i - 1]))
                {

                    return false;
                }

            return a[0] <= a[1];


        }

        static void decrypt()
        {


            string letter;
            Console.WriteLine("Enter a string (or char) to decrypt: ");
            letter = Console.ReadLine();

            List<string> chaR = new List<string>();


            chaR.Add(letter);

            for (int i = 0; i < chaR.Count; i++)
            {
                string value = chaR[i];
            }

            char[] ToStore = letter.ToCharArray();

            foreach (var x in ToStore)
            {
                char y = x;

                if (y == '-')
                {
                    string letter2 = new string(ToStore);

                    int index = letter2.IndexOf('-');

                    letter2 = letter2.Remove(index, 1);

                    ToStore = letter2.ToCharArray();
                }

            }

            //  letter.Replace("-", string.Empty);










            int shift;
            Console.WriteLine("Enter the original shift value: ");
            Console.WriteLine("(Enter 10 if you want to use the regular alphabet.)");
            shift = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            foreach (var other in ToStore)
            {
                char shifted;

                if (other == ' ')
                {
                    // shifted = (char)(other - shift);


                    //   shifted = (char)(other - shift);

                    string letter2 = new string(ToStore);

                    int index = letter2.IndexOf(' ');

                    letter2 = letter2.Remove(index, 1);

                    Console.WriteLine(' ');

                    ToStore = letter2.ToCharArray();




                }

                else
                {
                    shifted = (char)(other - shift);

                    if (shifted < 97)
                    {
                        shifted = (char)(other - shift + 26);

                    }



                    Console.WriteLine(shifted);
                }

            }
            Console.WriteLine(" ");
            Console.WriteLine("This is your decrypted message! :)");
            Console.WriteLine(" ");
        }

        static string checklol(List<int> a)
        {
            string state = "unknown";
            int old = 0;
            bool check = false;

            foreach (int y in a)
            {

                if (check == false)
                {
                    check = true;
                    old = y;
                    continue;
                }

                if (y > old)
                {
                    if (state == "descending") return "random";
                    state = "ascending";


                }
                else if (y < old)
                {
                    if (state == "ascending") return "random";
                    state = "descending";

                }



                old = y;



            }

            return state;
        }

        static void alphabet()
        {
            alphabetta[0] = 'a';
            alphabetta[1] = 'b';
            alphabetta[2] = 'c';
            alphabetta[3] = 'd';
            alphabetta[4] = 'e';
            alphabetta[5] = 'f';
            alphabetta[6] = 'g';
            alphabetta[7] = 'h';
            alphabetta[8] = 'i';
            alphabetta[9] = 'j';
            alphabetta[10] = 'k';
            alphabetta[11] = 'l';
            alphabetta[12] = 'm';
            alphabetta[13] = 'n';
            alphabetta[14] = 'o';
            alphabetta[15] = 'p';
            alphabetta[16] = 'q';
            alphabetta[17] = 'r';
            alphabetta[18] = 's';
            alphabetta[19] = 't';
            alphabetta[20] = 'u';
            alphabetta[21] = 'v';
            alphabetta[22] = 'w';
            alphabetta[23] = 'x';
            alphabetta[24] = 'y';
            alphabetta[25] = 'z';
        }

        static void decrypt2()
        {
            alphabet();
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob03.in_.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            int count = 0;
            while ((line = file.ReadLine()) != null)
            {
                count++;
                if (count == 1)
                {
                    int o = 0;
                    foreach (char c in line)
                    {
                        decodie[o] = c;
                        o++;
                    }
                }
                if (count > 1)
                {
                    string[] data = line.Split(null);
                    List<string> yee = new List<string>();
                    List<string> decoded = new List<string>();
                    foreach (string s in data)
                    {
                        string letter = "";
                        int letternum;
                        foreach (char c in s)
                        {
                            if (c != '-')
                            {
                                letter = letter + c;
                            }
                            if (c == '-')
                            {
                                letternum = Convert.ToInt32(letter);
                                Console.Write(decodie[letternum - 1]);
                                letter = "";
                            }
                        }
                        letternum = Convert.ToInt32(letter);
                        Console.Write(decodie[letternum - 1] + " ");
                    }
                    Console.WriteLine();
                }
            }


        }

        
    }
}
