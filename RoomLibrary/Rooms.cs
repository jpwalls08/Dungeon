//using CharacterLibrary;
//using MonsterLibrary;


//namespace RoomLibrary
//{
//    public class Rooms 
//    {
//        private static int CurrentLevel = 0;
//        private string _room;
//        private string _description;
//        private int _level = 1;

//        //public Monster RoomMonster { get; set; }
//        public string Room
//        {
//            get { return _room; }
//            set { _room = value; }
//        }
//        public string Description
//        {
//            get { return _description; }
//            set { _description = value; }
//        }
//        public int Level
//        {
//            get { return _level; }
//            set { _level = value; }
//        }//close 

//        public Rooms(string room, string description, int level)//, Monster roommonster)
//        {
//            _room = room;
//            _description = description;
//            _level = level;
//            //RoomMonster = roommonster;
//        }



//        //public override string ToString()
//        //{
//        //    return $"Room: {Room}";
//        //     $"Description: {description}";
//        //}
//        //public static string GetRoom()
//        //{
//        //    rooms r1 = new rooms("theirs a dark cave", "dark cave", 1, new smaug("smaug", 7, 5, 20, 5, 10, 5, "a fiery gust of flames emerges from the ashes, where the dragon resides..."));

//        //    //Rooms r2 = new Rooms("Theirs a dark cave", "Dark Cave", 1, new Smaug("Balrog", 7, 5, 20, 5, 10, 5, "A fiery gust of flames emerges from the ashes, where the Dragon resides..."));

//        //    //Rooms r3 = new Rooms("Theirs a dark cave", "Dark Cave", 1, new Smaug("Gollum", 7, 5, 20, 5, 10, 5, "A fiery gust of flames emerges from the ashes, where the Dragon resides..."));

//        //    //Rooms r4 = new Rooms("Theirs a dark cave", "Dark Cave", 1, new Smaug("Sauron", 7, 5, 20, 5, 10, 5, "A fiery gust of flames emerges from the ashes, where the Dragon resides..."));



//        //    //    //List<Rooms> rooms = new List<Rooms>();

//        //    //    //rooms.Add(r1);
//        //    //    //rooms.Add(r2);
//        //    //    //rooms.Add(r3);

//        //    //    //rooms.Sort();

//        //    //    //Rooms[] buildings =
//        //    //    //{
//        //    //    //        r1, r2, r3
//        //    //    //    };

//        //    return Rooms[new Random().Next(Rooms.Length)];


//        //    //public override string ToString()
//        //    //{
//        //    //    return $"Room: {Room}";
//        //    //    //$"Description: {description}";
//        //    //}
//        //    //public static Rooms GetRoom()
//        //    //{
//        //    //    Rooms r1 = new Rooms("This is dark and stinky", "Layer");
//        //    //    return r1;
//        //}

//        private static string GetRoom()
//        {
//            string[] rooms =
//            {


//                "The room is dark and musty with the smell of lost souls.",
//                "You enter a pretty pink powder room and instantly get glitter on you.",
//                "You arrive in a room filled with chairs and a ticket stub machine...DMV",
//                "You enter a quiet library... silence... nothing but silence....",
//                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
//                "Oh my.... what is that smell? You appear to be standing in a compost pile",
//                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
//                "Oh no.... the worst of them all... Oprah's bedroom....",
//                "The room looks just like the room you are sitting in right now... or does it?",

//            };

//            string room;

//            Random rand = new Random();
//            int index = rand.Next(rooms.Length);
//            room = rooms[index];
//            return room;


//            //return rooms[new Random().Next(rooms.Length)];
//        }//end GetRoom
//    }
//}