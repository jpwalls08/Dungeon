using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RoomLibrary;
using CharacterLibrary;
using MonsterLibrary;
using WeaponMenu;
using System.Media;

namespace DungeonApplication
{
    internal class DungeonApp
    {
        static void Main(string[] args)
        {

            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Gollums_Song.wav";
            musicPlayer.PlayLooping();//will repeat when finished. .Play() plays once and stops.
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


            //    if (option == "1 : 4")
            //    {
            //        Console.WriteLine("There is no denying that there is evil in this world but the light will always conquer the darkness.");

            //        break;// pulls and breaks out of iterator
            //    }

            //} while (true);
            #endregion



            #region Player Creator
            //TODO Create a player

            Console.WriteLine("Welcome traveler, may I ask whom I'm speaking with?\n");

            int score = 0;

            string name;
            do
            {
                Console.WriteLine("\nEnter Your Character Name\n");
                name = Console.ReadLine();
                Console.Clear();

                //if (name.Length > 1)
                if (name.Length > 1)
                    break;

            } while (true);
            #endregion


            #region Player Race & Weapon

            //TODO Create a player object - player customization?

            var races = Enum.GetValues(typeof(Race));
            Console.WriteLine("\nSelect your kin, choose wisely.\n");

            foreach (var race in races)
            //{
            //    Console.WriteLine($"{index}) {race}");
            //    index++;
            //}
            {
                Console.WriteLine($"{(int)race + 1} : {race}");//+1 displays in console
            }
            string userInput = Console.ReadKey(true).KeyChar.ToString();
            Console.Clear();

            int r = int.Parse(userInput) - 1;//key is reading a key and stores it in the property
            Race race1 = (Race)r;//casting from an int(r) to a variable(Race)
            Console.WriteLine($"\nAh, the {race1} is an excellent choice.\n\n");
            //Console.WriteLine("");
            var weapons = Enum.GetValues(typeof(WeaponType));

            Console.WriteLine("\nWhat will you wield?\n");
            foreach (var item in weapons)
            {
                Console.WriteLine($"{(int)item + 1} : {item}");
            }
            userInput = Console.ReadKey(true).KeyChar.ToString();

            int w = int.Parse(userInput) - 1;
            WeaponType type = (WeaponType)w;

            Weapon weapon = Weapon.CreateWeapon(type);

            Player player = new Player(name, 30, 3, 30, 30, weapon, race1);

            Console.WriteLine(player.ToString());
            Console.Clear();
            bool exit = false;
            #endregion


            #region Generate Room & Monsters

            do
            {
                //1. TODO retrieve a random monster

                //generate a room
                //TODO Implement GetRoom()

                string room = GetRoom();
                Console.WriteLine(room);

                //Monster monster = new Monster(); //selects specific monster
                Monster monster = Monster.GetMonster(); //Random Monster

                Console.WriteLine("You have stubbled upon..." + monster.Name);

                bool reload = false;//boolean for inner loop. Reload new monster/room when true

                //bool exit = true;//inner loop
                //bool exit = false;//inner loop
                #endregion


                #region Player Options

                do
                {
                    Console.WriteLine("\n\nHurry what will you do?:\n\n" +
                        "A) Attack\n" +
                        "B) Run Away\n" +
                        "C) Player Info\n" +
                        "D) Monster Info\n" +
                        "E) EXIT");

                    //ConsoleKey userAction = Console.ReadKey(true).Key;
                    string userAction = Console.ReadKey(true).Key.ToString().ToUpper();
                    Console.Clear();


                    //Random rand = new Random();

                    //Rooms r1 = Rooms.GetRoom();

                    //Monster m1 = monster.GetMonster();



                    switch (userAction)
                    {

                        case "A":
                            Console.WriteLine("Attack\n");
                            int win = new Random().Next(101);
                            //My.Computer.Audio(ConsoleKey);


                            Combat.DoBattle(player, monster);
                            if (monster.MinHealth <= 0)
                            {
                                //IT's DEAD!
                                //Could put logic here to have the player get items, life or something similar due to beating the monster
                                score++;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.WriteLine("You Won!");
                                Console.Beep(500, 800);//if we win
                                Console.ResetColor();
                                Console.Clear();
                                reload = true;//get a new room, and a new monster
                            }//end if monster died

                            //else
                            //{

                            //    Console.WriteLine("You Lost.");

                            //    exit = false;
                            //}
                            //break;

                            if (player.MinHealth <= 0)
                            {

                                Console.WriteLine($"\nYou were no match for {monster.Name}!\n", Console.ForegroundColor = ConsoleColor.Red);
                                exit = true;//leave the ENTIRE game!
                            }//end if player died
                            

                            else if (player.MinHealth <= 5)
                            {
                                Console.WriteLine("\nI suggest you runaway for you are near death!", Console.ForegroundColor = ConsoleColor.DarkYellow);
                                Console.ResetColor();
                            }
                            break;

                        case "B":

                            Console.WriteLine("Run Away");
                            reload = true;//reload
                            break;

                        case "C":
                            Console.WriteLine("Player Info:\n");//player
                            Console.WriteLine(player);

                            Console.WriteLine("Enemies Defeated: " + score, Console.ForegroundColor = ConsoleColor.Red);
                            Console.ResetColor();
                            //1. TODO CountNumbers()
                            break;

                        case "D":
                            Console.WriteLine("Monster Info");
                            //MonsterInfo();
                            //Console.WriteLine(monster.GetMonster().ToString());
                            Console.WriteLine(monster);
                            break;

                        case "E":
                        case "Esc":
                        case "End":
                            Console.WriteLine("We live to fight another day!\n\n", Console.ForegroundColor = ConsoleColor.Yellow);
                            Console.ResetColor();
                            //Console.ReadLine();
                            exit = true;//

                            break;

                    }//end switch
                } while (!exit && !reload);
                Console.ResetColor();

            } while (!exit);
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."), Console.BackgroundColor = ConsoleColor.Red, Console.ForegroundColor = ConsoleColor.Black);
            Console.ResetColor();
            Console.WriteLine("Your courage and bravery will live on! Press any key to exit...");
            Console.ReadKey();
        }//end Main()
        #endregion


        private static string GetRoom()
        {
            string[] rooms =
            {


                "Cold and darkness is bestowed upon you here.\n\n",
                "This mountain was the home of the great Dwarves.\n\n",
                "You have crossed over into Mordor\n\n",
                "This room possesses an unwelcoming since of hope...\n\n",
                "You have just looked into the Eye of Sauron... Turn back before it is too late!\n\n",
                "Oh my.... this is the stench of orcs!\n\n",
                "This forest was once a breeding ground for all the magnificent creatures that came upon it before, it was infested with evil and dark souls.\n\n",
                "The Dead Marshes is a vast swamp on the northern border of Mordor. During the Second Age it was the site of a great battle during the War of the Last Alliance. Three thousand years later it is haunted by the spirits of those who perished in battle.\n\n",
                "Isengard, an extremely defensible fortress in Rohan built by the Númenoreans ages before the War\n\n",

            };

            string room;

            Random rand = new Random();
            int index = rand.Next(rooms.Length);
            room = rooms[index];
            return room;


            //return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom

        #region Assigning a Monster to a Room

        //if (reload == true)
        //{
        //    /*
        //     * remove rooms and generate a new one
        //     * New Monster is assigned to new Room so no need to redifine it
        //     * reassign weapon
        //     */

        //    reload = false;
        //}

        //} while (exit);//end do

        //Monster m = new Monster()
        //{
        //    Name = "Sauron",
        //    RoomLevel = new (),
        //    CalcDamage = new 
        //};
        //Namespace.CLassname
        //Console.WriteLine(m);

        ////Manually format or override the ToString()

        ////Inferring the datatype with object initialization
        //var s1 = new Monster() { Name = "John Smith", RoomLevel = "", StartDate = new DateTime(2022, 08, 25) };
        ////the new .NET 6 / C# 10 way of using constructors.
        //Monster s2 = new() { Name = "Jane Doe", RoomLevel = "Super Senior", StartDate = new DateTime(1999, 08, 01) };


        //List<Monster> monsters = new List<Monster>()
        //{
        //    new Monster() { /*Property Assignment (Name = "whatever", etc)*/},

        //};
        ////perform some operation on the list (foreach, for example)
        //int index = new Random().Next(monsters.Count);
        //Monster s4 = monsters[index];
        //monsters.RemoveAt(index);

        #endregion

    }//end Main()


}//end namespace
