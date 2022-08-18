using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomLibrary;

namespace DungeonLibrary
{
    internal class DungeonRoom
    {
        static void Main(string[] args)
        {

            {
                bool mainLoop = true;
                bool innerLoop = true;
                Random rand = new Random();

                Console.WriteLine("Dungeon Looping");
                //TODO Create a player
                Console.WriteLine("Welcome traveler, may I ask whom am I speaking to?\n");
                Console.WriteLine("\nEnter Your Character Name\n"); ;

                bool MainLoop = true;//boolean for outer loop. Exit game when true

            }while (true)


                do
                {
                    Rooms r1 = Rooms.GetRoom(); 
                    Rooms r2 = Rooms.GetRoom(); 
                    Rooms r3 = Rooms.GetRoom(); 




                    Random rand = new Random();
                    //TODO retrieve a random monster
                    Console.WriteLine("You have stubbled upon (Insert Monster Here)\n");
                    Console.WriteLine("");
                    /*TODO generate a room
                        * Implement GetRoom()
                        */

                    Console.WriteLine(r1);
                    Console.WriteLine("");

                    Console.WriteLine(r2);
                    Console.WriteLine(""); 

                    Console.WriteLine(r3);
                    Console.WriteLine("");

                    bool InnerLoop = true;

                } while (true);//end do


        }//end Main()

    }//end DungeonRoom
}//end namespace
