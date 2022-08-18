namespace CharacterLibrary
{
    public class Character
    {
        private string _name;
        private int _damage;
        private int _block;
        private int _maxHealth;
        private int _minHealth;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }//end Damage
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//end Block
        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }//end MaxHealth
        
        public int MinHealth
        {
            get { return _minHealth; }
            set
            {
                _minHealth = value <= MaxHealth ? value : MaxHealth;
            }
        }//end minHeath     

       public Character(string name, int damage, int block, int maxHealth, int minHealth)
        {
            Name = name;
            Damage = damage;
            Block = block;
            MaxHealth = maxHealth;
            MinHealth = minHealth;

        } //end Character

        //TODO Methods
        
    }
}