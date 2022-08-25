using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomLibrary;
using CharacterLibrary;
using WeaponMenu;

namespace DungeonApplication
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {

            //Game game = new Game();
            //string name = game.GetUser();
            #region Old Loop
            //do
            //{


            //    Console.WriteLine($"Not sure if this is the place you are wanting to be {name}...");
            //    Console.WriteLine("Enter Y to keep moving forward");
            //    Console.WriteLine("Enter N to Exit");
            //    string option = Console.ReadLine().ToUpper();


            //    if (option == "N")

            //    {
            //        Console.WriteLine("I reckon you head out West, over yonder. There you will come across a body over water that is rid of any danger");
            //        return; //pulls and exits the method
            //    }


            //    if (option == "Y")
            //    {
            //        Console.WriteLine("You're a brave soul to embark on this journey");

            //        break;// pulls and breaks out of iterator
            //    }

            //} while (true);
            #endregion


            //Console.WriteLine("Dungeon Looping");
            //TODO Create a player

            Console.WriteLine("Welcome traveler, may I ask whom I'm speaking with?\n");

            string name;
            do
            {
                Console.WriteLine("\nEnter Your Character Name\n");
                name = Console.ReadLine();

                if (name.Length > 1)
                    break;

            } while (true);
            

            //TODO Create a player object - player customization?

            var races = Enum.GetValues(typeof(Race));
            foreach(var race in races)
            //{
            //    Console.WriteLine($"{index}) {race}");
            //    index++;
            //}
            {
                Console.WriteLine($"{(int)race + 1} : {race}");//+1 displays in console
            }
            string userInput = Console.ReadKey(true).KeyChar.ToString();
            
            int r = int.Parse(userInput) - 1;//key is reading a key and stores it in the propety
            Console.Clear();
            Race race1 = (Race)r;//casting from an int(r) to a variable(Race)



            //TODO Weapon Object - List of weapons?
            Weapon sword = new Weapon("sword", 8, 1, 5, true, WeaponType.Sword);
            Player player = new Player(name, 70, 5, 40, 40, sword, race1);
            Console.WriteLine(player.ToString());
            bool mainLoop = true;

            do
            {
                /*TODO generate a room
                * Implement GetRoom()
                */
                Random rand = new Random();

                Rooms r1 = Rooms.GetRoom();

                Console.WriteLine(r1);
                Console.WriteLine("");


                //TODO retrieve a random monster
                Monster monster = Monster.GetMonster();
                Console.WriteLine("You have stubbled upon..." + monster.Name);
                Console.WriteLine("");



                break;

            } while (mainLoop);//end do

            //bool reload = false;//boolean for inner loop. Reload new monster/room when true
            bool exit = true;//inner loop

            do
            {
                Console.WriteLine("\n\nHurry what will you do?:\n\n" +
                    "A) Attack\n" +
                    "B) Run Away\n" +
                    "C) Player Info\n" +
                    "D) Monster Info\n" +
                    "E) Exit");

                //ConsoleKey userAction = Console.ReadKey(true).Key;
                string userAction = Console.ReadKey(true).Key.ToString().ToUpper();
                Console.Clear();

                switch (userAction)
                {

                    case "A":
                        Console.WriteLine("Attack");
                        int win = new Random().Next(101);

                        if (win > 10)
                        {
                            Console.WriteLine("You Won!");

                            
                        }

                        else 
                        {

                            Console.WriteLine("You Lost.");

                            exit = false;
                        }
                        break;

                    case "B":
                        
                        Console.WriteLine("Run Away");
                        exit = true;//reload
                        break;

                    case "C":
                        Console.WriteLine("Player Info");//player
                        Console.WriteLine(player);
                        //1. TODO CountNumbers()
                        
                        break;

                    case "D":
                        Console.WriteLine("Monster Info");
                        //MonsterInfo();
                        Console.WriteLine(Monster.GetMonster().ToString());
                        break;

                    case "E":
                        Console.WriteLine("Thank you for playing!");
                        //Console.ReadLine();
                        exit = false;//

                        break;

                }//end switch

            } while (exit);//end do

            //Monster m = new Monster()
            //{
            //    Name = "Sauron",
            //    RoomLevel = "[0]",
            //    CalcDamage = new DateTime(2019, 1, 1)
            //};
            ////Namespace.CLassname
            //Console.WriteLine(m);

            ////Manually format or override the ToString()

            ////Inferring the datatype with object initialization
            //var s1 = new Monster() { Name = "John Smith", RoomLevel = "", StartDate = new DateTime(2022, 08, 25) };
            ////the new .NET 6 / C# 10 way of using constructors.
            //Monster s2 = new() { Name = "Jane Doe", RoomLevel = "Super Senior", StartDate = new DateTime(1999, 08, 01) };

            //Practical application
            //When we need a temporary collection of objects to manipulate and then discard,
            //you can combine Object and Collection Initialization Syntaxes.
            //NOTE: These objects will ONLY exist with the collection.

            List<Monster> monsters = new List<Monster>()
            {
                new Monster() { /*Property Assignment (Name = "whatever", etc)*/},
                
            };
            //perform some operation on the list (foreach, for example)
            int index = new Random().Next(monsters.Count);
            Monster s4 = monsters[index];
            monsters.RemoveAt(index);


        }//end Main()

    }//end DungeonRoom
}//end namespace
