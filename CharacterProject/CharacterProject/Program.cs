using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CharacterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Character current = new Character("", 0, "", "", 0, 0, 0);

            while (input != 6)
            {
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Modify a character");
                Console.WriteLine("3. Delete a character");
                Console.WriteLine("4. Load Existing character");
                Console.WriteLine("5. Print character");
                Console.WriteLine("6. Exit the program");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                   current = CreateCharacter();
                }

                if (input == 2)
                {
                    ModifyCharacter(current);
                }

                if (input == 3)
                {
                    Console.WriteLine("Which character do you want to delete?");
                    string characterName;
                    characterName = Console.ReadLine();

                    DeleteCharacter(characterName);
                }

                if (input == 4)
                {
                    Console.WriteLine("Which character do you want to load?");
                    string characterName;
                    characterName = Console.ReadLine();

                    LoadCharacter(characterName);
                    
                }

                if (input == 5)
                {
                    PrintCharacter(current);
                }
                        
                        
            }
        }


        public static Character CreateCharacter()
        {
            string name;
            Console.Write("What is the Character's name?: ");
            name = Console.ReadLine();
            int age;
            Console.Write("How old is your Character?: ");
            age = int.Parse(Console.ReadLine());
            string eye_color;
            Console.Write("What is your Character's eye color?: ");
            eye_color = Console.ReadLine();
            string hair_color;
            Console.Write("What is your Character's hair color?: ");
            hair_color = Console.ReadLine();
            int intelligence;
            Console.Write("What is your Character's intelligence?: ");
            intelligence = int.Parse(Console.ReadLine());
            int agility;
            Console.Write("What is your Character's agility?: ");
            agility = int.Parse(Console.ReadLine());
            int strength;
            Console.Write("What is your Character's strength?: ");
            strength = int.Parse(Console.ReadLine());
            Character character = new Character(name, age, eye_color, hair_color, intelligence, agility, strength);

            SaveCharacter(character);

            return character;

        }
 
        public static void ModifyCharacter(Character character)
        {
            int inp = 0;

            while (inp != 7)
            {
                Console.WriteLine("Is there anything about your character that you would like to change?");
                Console.WriteLine("1. Age");
                Console.WriteLine("2. Eye Color");
                Console.WriteLine("3. Hair Color");
                Console.WriteLine("4. Intelligence");
                Console.WriteLine("5. Agility");
                Console.WriteLine("6. Strength");
                Console.WriteLine("7. Nope! I'm good. :D");

                inp = int.Parse(Console.ReadLine());

                if (inp == 1)
                {
                    Console.WriteLine("The current age is " + character.age + " what would you like to change it to?: ");
                    int Newage = int.Parse(Console.ReadLine());
                    character.age = Newage;

                    SaveCharacter(character);
                }

                if (inp == 2)
                {
                    Console.WriteLine("The current eye color is " + character.eye_color + " what would you like to change it to?: ");
                    string Neweyecolor = Console.ReadLine();
                    character.eye_color = Neweyecolor;

                    SaveCharacter(character);
                }

                if (inp == 3)
                {
                    Console.WriteLine("The currect hair color is " + character.hair_color + " what would you like to change it to?: ");
                    string Newhaircolor = Console.ReadLine();
                    character.hair_color = Newhaircolor;

                    SaveCharacter(character);
                }

                if (inp == 4)
                {
                    Console.WriteLine("The current intelligence is " + character.intelligence + " what would you like to change it to?: ");
                    int Newintell = int.Parse(Console.ReadLine());
                    character.intelligence = Newintell;

                    SaveCharacter(character);
                }

                if (inp == 5)
                {
                    Console.WriteLine("The currect agility is " + character.agility + " what would you like to change it to?: ");
                    int Newagility = int.Parse(Console.ReadLine());
                    character.agility = Newagility;

                    SaveCharacter(character);
                }

                if (inp == 6)
                {
                    Console.WriteLine("The current strength is " + character.strength + " what would you like to change it to?: ");
                    int Newstrength = int.Parse(Console.ReadLine());
                    character.strength = Newstrength;

                    SaveCharacter(character);
                }
            }
        }

        public static void SaveCharacter(Character character)
        {   //string path = @"C:\Users\138692\OneDrive - Academy District 20\Coding\CharacterProject\CharacterName1.txt";
            // string path = @"C:\Users\138692\Documents\Coding1Fall2018\CharacterName.txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("The file already exists. Do you want to overwrite? y or n");

                if (Console.ReadLine()[0] == 'y')
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.name);
                        sw.WriteLine(character.age);
                        sw.WriteLine(character.eye_color);
                        sw.WriteLine(character.hair_color);
                        sw.WriteLine(character.intelligence);
                        sw.WriteLine(character.agility);
                        sw.WriteLine(character.strength);
                    }
                    Console.WriteLine("File overwritten");
                }
                else
                {
                    Console.WriteLine("Nothing overwritten");
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.name);
                    sw.WriteLine(character.age);
                    sw.WriteLine(character.eye_color);
                    sw.WriteLine(character.hair_color);
                    sw.WriteLine(character.intelligence);
                    sw.WriteLine(character.agility);
                    sw.WriteLine(character.strength);
                }

                Console.WriteLine("File created");
            }
        }

        public static bool DeleteCharacter(string characterName)
        {
            

            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";
            if (File.Exists(path))
            { 
                Console.WriteLine("The file exists. You sure you want to delete? y or n");
                if (Console.ReadLine()[0] == 'y')
                {
                    File.Delete(path);

                    Console.WriteLine(characterName + " has been removed.");
                    return true;
                }

                else
                {
                    Console.WriteLine(characterName + " is not removed.");

                    return false;
                }
            }

            else
            {
                Console.WriteLine(characterName + " doesn't exist, therefore was not removed.");

                return false;
            }

           

        }

       public static Character LoadCharacter(string characterName)
       {
           string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";
            if (File.Exists(path))

            {
                List<string> file = new List<string>();
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        file.Add(line);
                        
                    }
                }
                Console.WriteLine(characterName + " has been loaded.");
                return new Character(file[0], int.Parse(file[1]), file[2], file[3], int.Parse(file[4]), int.Parse(file[5]), int.Parse(file[6]));
            }

            else
            {
                Console.WriteLine("File doesn't exist...");
                return null;
            }
              
          
       }

        public static void PrintCharacter(Character character)
        {
            
            string path = AppDomain.CurrentDomain.BaseDirectory + character.name + ".txt";
         
            

            if (File.Exists(path))
            {
                List<string> file = new List<string>();
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        file.Add(line);


                    }

                    Console.WriteLine(character.name);
                    Console.WriteLine(character.age);
                    Console.WriteLine(character.eye_color);
                    Console.WriteLine(character.hair_color);
                    Console.WriteLine(character.intelligence);
                    Console.WriteLine(character.agility);
                    Console.WriteLine(character.strength);
                }
            }

            else
            {
                Console.WriteLine("File doesn't exist...");
            }
           
        }
      //  public static List<Character> LoadCharacters()
     //   {
            //new.Character(sw.ReadLine(), sw.ReadLine(), se.ReadLine(), sw.ReadLine() {etc. depending on the # of lines} );
      //  }

     //   public static void ListCharacters(List<Character> characters)
      //  {

      //  }

    }
}
