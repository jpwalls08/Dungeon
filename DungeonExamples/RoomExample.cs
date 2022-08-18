using dungeonlibrary;
using system.media;//added for play music

namespace dungeon
{
    internal class program
    {
        static void main(string[] args)
        {
            console.writeline("dungeon looping!");
            #region play music - windows only

            //install nuget package - system.windows.extensions
            //add using system.media above
            //add a music file of your choice (.wav only) to the "root" of the main project.
            //right click on .wav file > properties
            //set "copy to output directory" to "copy always"

            soundplayer musicplayer = new soundplayer();
            musicplayer.soundlocation = appdomain.currentdomain.basedirectory + "the_bards_tale.wav";
            musicplayer.playlooping();//will repeat when finished. .play() plays once and stops.



            #endregion


            //create a player
            //character below will be replaced with player at a later date. using this for testing.
            character player = new character("test character", 10, 10, 100, 100);

            bool exit = false; //boolean for outer loop. exit game when true.

            do
            {
                //todo retrieve a random monster
                console.writeline("this is a monster...");
                //generate a room
                //todo implement getroom()
                string room = getroom();
                console.writeline(room);

                bool reload = false;//boolean for inner loop. reload new monster/room when true

                do
                {
                    console.write("\nplease choose an action:\n" +
                        "a) attack\n" +
                        "r) run away\n" +
                        "p) player info\n" +
                        "m) monster info\n" +
                        "x) exit\n");
                    string userchoice = console.readkey(true).key.tostring();
                    console.clear();

                    switch (userchoice)
                    {
                        case "a":
                            console.writeline("attack!");
                            //handle winning (reload) and losing (exit)
                            break;
                        case "r":
                            console.writeline("run away!");
                            //reload room
                            reload = true;
                            break;
                        case "p":
                            console.writeline("player info");
                            console.writeline(player);
                            break;

                        case "m":
                            console.writeline("monster info");
                            break;

                        case "x":
                        case "e":
                        case "escape":
                            console.writeline("no one likes a quitter...");
                            //exit the game
                            exit = true;
                            break;

                        default:
                            console.writeline("please try again...");
                            break;
                    }

                } while (!exit && !reload);

            } while (!exit);
            console.writeline("\n\nthanks for playing! press any key to exit...");
            console.readkey();
        }//end main()
        //todo getroom()
        private static string getroom()
        {
            string[] rooms =
            {


                "the room is dark and musty with the smell of lost souls.",
                "you enter a pretty pink powder room and instantly get glitter on you.",
                "you arrive in a room filled with chairs and a ticket stub machine...dmv",
                "you enter a quiet library... silence... nothing but silence....",
                "as you enter the room, you realize you are standing on a platform surrounded by sharks",
                "oh my.... what is that smell? you appear to be standing in a compost pile",
                "you enter a dark room and all you can hear is hair band music blaring.... this is going to be bad!",
                "oh no.... the worst of them all... oprah's bedroom....",
                "the room looks just like the room you are sitting in right now... or does it?",

            };
            return rooms[new random().next(rooms.length)];
        }//end getroom
    }//end class
}//end namespace