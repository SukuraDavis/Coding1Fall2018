using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program 
    {
        static void Main(string[] args)
        {
            int input = 4;
            while (input != 9)
            {
                Console.WriteLine("Enter the integer value for the action you want to perform, and then press enter to have the shape appear.");
                Console.WriteLine("1. Square 1");
                Console.WriteLine("2. Square 2");
                Console.WriteLine("3. Square 3");
                Console.WriteLine("4. Triangle 1");
                Console.WriteLine("5. Triangle 2");
                Console.WriteLine("6. Triangle 3");
                Console.WriteLine("7. Special 1");
                Console.WriteLine("8. Special 2");
                Console.WriteLine("9. Exit the program.");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            if (i == 1 || j == 1)
                            { Console.Write("X"); }

                            else
                            { Console.Write(" "); }
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }

                else if (input == 2)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (i == 0 || i == 4 || j == 0 || j == 4)
                            {
                                Console.Write("X");
                            }

                            else
                            {
                                Console.Write("X");
                            }
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }

                else if (input == 3)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == 0 || i == 4 || j == 0 || j == 4)
                            {
                                Console.Write("X");
                            }

                            else
                            {
                                Console.Write("X");
                            }
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }
                else if (input == 4)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {

                            Console.Write("X");
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }
                else if (input == 5)
                {
                    Console.WriteLine(input);

                    int i, j, k = (2 * 5) - 2;

                    for (i = 0; i < 5; i++)
                    {
                        for (j = 0; j < k; j++)
                        {
                            Console.Write(" ");
                        }

                        k = k - 1;

                        for (j = 0; j <= i; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }
                else if (input == 6)
                {
                    Console.WriteLine(input);

                    for (int i = 1; i < 6; i += 2)
                    {
                        for (int k = 0; k < (4 - i / 2); k++)
                        {
                            Console.Write(" ");

                        }
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("X");
                        }
                        Console.Write(" ");
                        Console.WriteLine();
                        Console.ReadKey();
                    }

                }
                else if (input == 7)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (j == i || 4 - (j - 5) == i)
                            {
                                Console.Write(" X");

                            }

                            else
                            {
                                Console.Write("X");

                            }
                        }
                        Console.WriteLine();
                        Console.ReadKey();


                    }

                }
                else if (input == 8)
                {
                    Console.WriteLine(input);

                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (j == 5 || 4 - j == i)
                            {
                                Console.Write(" X");

                            }

                            else
                            {
                                Console.Write("X");

                            }
                        }
                        Console.WriteLine();
                        Console.ReadKey();


                    }

                }
                else if (input == 9)
                {
                    Console.WriteLine(input);

                    Console.WriteLine("Exit the program.");
                }
            }

        }

    }
}
