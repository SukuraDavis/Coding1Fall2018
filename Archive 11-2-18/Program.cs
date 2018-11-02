using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRomansCompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Juliet Romans

            //You will create a do -while loop that will allow the user to unlimitedly run the menu options until they enter the exit code - 1.
            //The menu will contain the following sub - items:
            //1.Conditionals
            //2.For Loops
            //3.While Loops
            //4.Arrays
            //5.Lists
            //- 1.Exit

            //Conditionals
            //The user will be prompted for user input for their grade, and their reading grade level.Upon input, the program will tell the user if they are in high school and read proficiently, 
            // if they are in middle school and read proficiently, 
            // if they are in elementary school and read proficiently, 
            // or if they do not read proficiently.
            //  Reading proficiency is calculated by gradeLevel <= readingProficiencyLevel.

            //For Loops
            //Prompt the user for a number to countBy, and a number to countTo.
            //Then, using a for loop, count to countTo by countBy.
            //Example output is as follows: countBy = 3, countTo = 15… 0, 3, 6, 9, 12, 15.


            //While Loops
            //Create an int variable that stores the sum of the user input.
            //Then allow the user to input integer values to add to the sum.
            //When the user enters 0, it will get out of the loop and tell the user their final total.


            //Arrays
            //Create an array of ints, size 10.Add user input to a for loop that iterates through the array and puts the input in that index.
            //If the user enters 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 then that will be the values in the array.
            //After they have entered all 10 values, print the values to the user.


            //Lists
            //Create a list of strings, and continuously allow the user to add new strings to the list until they enter “end”. 
            //Upon the ending string, print out the elements of the list to the user.

            int input = 0;
            do
            {
                Console.WriteLine("Enter the number cooresponding to the action you want to make.");
                Console.WriteLine("1. Conditionals");
                Console.WriteLine("2. For Loops");
                Console.WriteLine("3. While Loops");
                Console.WriteLine("4. Arrays");
                Console.WriteLine("5. Lists");
                Console.WriteLine("-1. Exit");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    int grade = 0;
                    Console.WriteLine("Enter your grade: ");
                    grade = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    int level = 0;
                    Console.WriteLine("Enter your reading grade level: ");
                    level = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    if (grade <= 5 && grade <= level)
                    {
                        Console.WriteLine("You are in elementary school and you read at an appropriate level.");
                        Console.WriteLine(" ");
                    }
                    else if (grade == 6 && grade <= level)
                    {
                        Console.WriteLine("You are in middle school and read at an appropriate level");
                        Console.WriteLine(" ");
                    }
                    else if (grade == 7 && grade <= level)
                    {
                        Console.WriteLine("You are in middle school and read at an appropriate level");
                        Console.WriteLine(" ");
                    }
                    else if (grade == 8 && grade <= level)
                    {
                        Console.WriteLine("You are in middle school and read at an appropriate level");
                        Console.WriteLine(" ");
                    }
                    else if (grade >= 9 && grade <= level)
                    {
                        Console.WriteLine("You are in high school and read an an appropriate level");
                        Console.WriteLine(" ");
                    }
                    else if (grade > level)
                    {
                        Console.WriteLine("You don't read at an appropriate level. Go study.");
                        Console.WriteLine(" ");
                    }
                    
                }
               
                if (input == 2)
                {
                    int countBy = 0;
                    Console.WriteLine("Enter a number to count by: ");
                    countBy = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    int countTo = 0;
                    Console.WriteLine("Enter a number to count up to by " + countBy + ":");
                    countTo = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    for ( int i = 0; i <= countTo; i+= countBy)
                    {
                        Console.WriteLine(i);
                        
                    }
                    Console.WriteLine(" ");


                }
                
                if (input == 3)
                {
                    Console.WriteLine("Our sum starts at 0. Enter integer values to add to, and print the sum. Enter 0 to stop adding.");
                    int value = 0;
                    Console.WriteLine("Enter a value: ");
                 
                    value = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");


                    int sum = 0;

                    while (value != 0)
                    {
                     
                        if (value >= 1)
                        {
                            sum = value + sum;
                            Console.WriteLine("New sum = " + sum);
                            Console.WriteLine(" ");
                            Console.WriteLine("Enter a value: ");
                            value = int.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                        }
                        
                    }
                    Console.WriteLine("New sum = " + sum);
                    Console.WriteLine(" ");
                    Console.WriteLine("Exiting loop, your final sum = " + sum);
                    Console.WriteLine(" ");


                }
                
                if (input == 4)
                {
                    Console.WriteLine("You have an array of size 10 and of type int. Enter values to populate the array.");
                    int[] IntArray = new int[10];
                    for (int i = 0; i < IntArray.Length; i++)
                    {
                        int UserArray1 = 0;
                        UserArray1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray1 + " successfully added");
                        int UserArray2 = 0;
                        UserArray2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray2 + " successfully added");
                        int UserArray3 = 0;
                        UserArray3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray3 + " successfully added");
                        int UserArray4 = 0;
                        UserArray4 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray4 + " successfully added");
                        int UserArray5 = 0;
                        UserArray5 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray5 + " successfully added");
                        int UserArray6 = 0;
                        UserArray6 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray6 + " successfully added");
                        int UserArray7 = 0;
                        UserArray7 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray7 + " successfully added");
                        int UserArray8 = 0;
                        UserArray8 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray8 + " successfully added");
                        int UserArray9 = 0;
                        UserArray9 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray9 + " successfully added");
                        int UserArray10 = 0;
                        UserArray10 = int.Parse(Console.ReadLine());
                        Console.WriteLine(UserArray10 + " successfully added");

                        Console.WriteLine("All array values added. Here they are!");
                        IntArray[0] = UserArray1;
                        Console.WriteLine("index 0 = " + UserArray1);
                        IntArray[1] = UserArray2;
                        Console.WriteLine("index 1 = " + UserArray2);
                        IntArray[2] = UserArray3;
                        Console.WriteLine("index 2 = " + UserArray3);
                        IntArray[3] = UserArray4;
                        Console.WriteLine("index 3 = " + UserArray4);
                        IntArray[4] = UserArray5;
                        Console.WriteLine("index 4 = " + UserArray5);
                        IntArray[5] = UserArray6;
                        Console.WriteLine("index 5 = " + UserArray6);
                        IntArray[6] = UserArray7;
                        Console.WriteLine("index 6 = " + UserArray7);
                        IntArray[7] = UserArray8;
                        Console.WriteLine("index 7 = " + UserArray8);
                        IntArray[8] = UserArray9;
                        Console.WriteLine("index 8 = " + UserArray9);
                        IntArray[9] = UserArray10;
                        Console.WriteLine("index 9 = " + UserArray10);
                        

                    }
                    

                    if (input == 5)
                    {
                        Console.WriteLine("Enter a string: ");
                        string add = "";
                        add = Console.ReadLine();
             
                        
                        
                        List<string> myStringList = new List<string>();

                        for (int i = 0; i < myStringList.Count; i++)
                        {
                            myStringList.Add(add);
                            Console.WriteLine("Enter a string: ");
                            add = Console.ReadLine();
                            myStringList.Add(add);
                        }
                        if (add == "end")
                        {
                            Console.WriteLine(myStringList);
                        }
                                


                            
                        }


                    }
                if (input == -1)
                {
                    Console.WriteLine("Exit.");
                }
                    






                




            } while (input != -1); 

        }
    }
}
