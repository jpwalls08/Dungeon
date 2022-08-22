using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomLibrary;
using CharacterLibrary;


namespace DungeonApplication
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            string name = game.GetUser();

            do
            {


                Console.WriteLine($"Not sure if this is the place you are wanting to be {name}...");
                Console.WriteLine("Enter Y to keep moving forward");
                Console.WriteLine("Enter N to Exit");
                string option = Console.ReadLine().ToUpper();


                if (option == "N")

                {
                    Console.WriteLine("I reckon you head out West, over yonder. There you will come across a body over water that is rid of any enemies");
                    return; //pulls and exits the method
                }


                if (option == "Y")
                {
                    Console.WriteLine("You're a brave soul to embark on this journey");

                    break;// pulls and breaks out of iterator
                }

            } while (true);



            bool mainLoop = true;

            do
            {
                Random rand = new Random();

                Rooms r1 = Rooms.GetRoom();

                //TODO retrieve a random monster
                Console.WriteLine("You have stubbled upon (Insert Monster Here)\n");
                Console.WriteLine("");
                /*TODO generate a room
                * Implement GetRoom()
                */

                Console.WriteLine(r1);
                Console.WriteLine("");

                break;

            } while (mainLoop);//end do


            bool exit = true;

            do
            {
                Console.WriteLine("Hurry what will you do?:\n" +
                    "A) Attack\n" +
                    "B) Run Away\n" +
                    "C) Character Info\n" +
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
                        RunAway();
                        break;

                    case "C":
                        Console.WriteLine("Character Info");
                        //1. TODO CountNumbers()
                        CharacterInfo();
                        break;

                    case "D":
                        Console.WriteLine("Monster Info");
                        MonsterInfo();
                        break;

                    case "E":
                        Console.WriteLine("Thank you for playing!");
                        exit = false;

                        break;

                }//end switch

            } while (exit);//end do


        }//end Main()

    }//end DungeonRoom
}//end namespace
