namespace RoomLibrary
{
    public class Rooms
    {
        private string _room;
        //private string _description;


        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
        //public string description
        //{
        //    get { return _description; } 
        //    set { _description = value; }
        //}

        public Rooms(string room, string description)
        {
            _room = room;
            //_description = description;
        }


        public override string ToString()
        {
            return $"Room: {Room}";
             //$"Description: {description}";
        }
        public static Rooms GetRoom()
        {
            Rooms r1 = new Rooms("This is dark and stinky", "Layer");
             
            
            Rooms r2 = new Rooms("This is hot and stinky", "Layer");
            
            
            Rooms r3 = new Rooms("This is cold and stinky", "Layer");

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