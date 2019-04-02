using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 0;
           

            while (user != 9)
            {
                Console.WriteLine("Please enter an integer for the menu option you want to choose: ");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2.Add two integers from user input together");
                Console.WriteLine("3.Calulcate the area of a circle given just the radius from user input");
                Console.WriteLine("4.Calculate the area of a triangle given the length of all three sides from user input");
                Console.WriteLine("5.Given an integer n from user input, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6.Given an integer n from user input, draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7.Given two integer variables from user input, swap their values");
                Console.WriteLine("8.Reverse a string from user input using a for loop");
                Console.WriteLine("9.End the program");

                Console.Write("Input: ");
                user = int.Parse(Console.ReadLine());

                if (user == 1)
                {
                    Console.WriteLine("Hello World!");
                    Console.WriteLine(" ");
                }

                if (user == 2)
                {
                    int num1 = 0;
                    int num2 = 0;

                    Console.Write("Please enter the first integer value you want to add: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the second integer value you want to add: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    Console.WriteLine(" ");
                }

                if (user == 3)
                {
                    int r = 0;

                    Console.Write("Please enter the radius of a circle to calculate area: ");
                    r = int.Parse(Console.ReadLine());

                    double x = Math.PI * Math.Pow(r, 2);

                    Console.WriteLine("The area of a circle with a radius of " + r + " is " + x);
                    Console.WriteLine(" ");
                }

                if (user == 4)
                {
                    int A = 0;
                    int B = 0;
                    int C = 0;
                    double P = 0;
                    double area = 0;

                    Console.Write("Input length of side A of triangle: ");
                    A = int.Parse(Console.ReadLine());

                    Console.Write("Intput of side B of triangle: ");
                    B = int.Parse(Console.ReadLine());

                    Console.Write("Input of side C of triangle: ");
                    C = int.Parse(Console.ReadLine());

                    P = (A + B + C) / 2;

                    area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

                    Console.WriteLine(area);
                    Console.WriteLine(" ");

                }

                if (user == 5)
                {
                    int size = 0;

                    Console.Write("What size square do you want to draw?: ");
                    size = int.Parse(Console.ReadLine());

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if (i == 0 || i == size || j == 0 || j == size)
                            {
                                Console.Write("X");
                            }

                            else
                            {
                                Console.Write("X");
                            }
                        }
                        Console.WriteLine();
                        
                    }

                    Console.WriteLine(" ");
                }

                if (user == 6)
                {
                    int size = 0;

                    Console.Write("What size square do you want to draw?: ");
                    size = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= size; i++)
                    {
                        for (int j = 1; j <= size; j++)
                        {
                            if (i == 1 || i == size || j == 1 || j == size)
                            {
                                Console.Write("X");
                            }

                            else
                            {
                                Console.Write(" ");
                            }

                        }
                        Console.WriteLine();

                    }

                    Console.WriteLine(" ");

                   
                }

                if (user == 7)
                {
                    int one = 0;
                    int two = 0;
                    int three = 0;

                    Console.Write("Please enter the first integer value you want to swap: ");
                    one = int.Parse(Console.ReadLine());

                    Console.Write("Please enter the second integer value you want to swap: ");
                    two = int.Parse(Console.ReadLine());

                    Console.WriteLine("Swapping " + one + " and " + two);

                    three = one;
                    one = two;
                    two = three;
                   
                    Console.WriteLine("After swap values are " + one + " and " + two);
                    Console.WriteLine(" ");
                }

                if (user == 8)
                {
                    string s = "";
                    string k = "";
                    
                    Console.Write("Enter a string to reverse: ");
                    s = Console.ReadLine();

                    string l = s;
                    Console.WriteLine("Original string = " + s);

                    Console.Write("Reversed string = ");
                  
                    for (int i = l.Length - 1; i >= 0; i--)
                    {
                        Console.Write(l[i]);
                       
                    }

                    
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }

            }


        }
    }
}
