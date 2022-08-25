namespace RoomLibrary
{
    public class Rooms
    {
        private static int CurrentLevel = 0;
        private string _room;
        private string _description;
        private int _level = 1;


        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }//close 

        public Rooms(string room, string description, int level)
        {
            _room = room;
            _description = description;
            _level = level;
        }



        public override string ToString()
        {
            return $"Room: {Room}";
             //$"Description: {description}";
        }
        public static Rooms GetRoom()
        {
            Rooms r1 = new Rooms("Theirs a ", "Layer", 1);
             
            
            Rooms r2 = new Rooms("This is hot and stinky", "Layer", 2);
            
            
            Rooms r3 = new Rooms("This is cold and stinky", "Layer", 3);


            //List<Rooms> rooms = new List<Rooms>();

            //rooms.Add(r1);
            //rooms.Add(r2);
            //rooms.Add(r3);

            //rooms.Sort();

            Rooms[] buildings =
            {
                r1, r2, r3
            };

            return buildings[new Random().Next(buildings.Length)];
            
        }
        //public override string ToString()
        //{
        //    return $"Room: {Room}";
        //     //$"Description: {description}";
        //}
        //public static Rooms GetRoom()
        //{
        //    Rooms r1 = new Rooms("This is dark and stinky", "Layer");
        //    return r1;
        //}
        
    }
}