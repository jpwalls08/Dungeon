using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomLibrary;
using CharacterLibrary;


namespace DungeonLibrary
{
    internal class DungeonRoom
    {
        static void Main(string[] args)
        {



            Random rand = new Random();

            Console.WriteLine("Dungeon Looping");
            //TODO Create a player
            Console.WriteLine("Welcome traveler, may I ask whom am I speaking to?\n");
            Console.WriteLine("\nEnter Your Character Name\n");




            bool mainLoop = true;
            do
            {
                Rooms r1 = Rooms.GetRoom();

                //TODO retrieve a random monster
                Console.WriteLine("You have stubbled upon (Insert Monster Here)\n");
                Console.WriteLine("");
                /*TODO generate a room
                    * Implement GetRoom()
                    */

                Console.WriteLine(r1);
                Console.WriteLine("");




                bool innerLoop = true;
                do
                {
                    //Action Menu
                    Console.ReadLine();
                    innerLoop = false;

                } while (innerLoop);

            } while (mainLoop);//end do




        }//end Main()

    }//end DungeonRoom
}//end namespace
