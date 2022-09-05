namespace CharacterLibrary
{
    public class Character
    {
        private string _name;
        private int _hitchance;//hitChance
        private int _block;
        private int _maxHealth;//maxLife
        private int _minHealth;//life

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitchance; }
            set { _hitchance = value; }
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

        public Character()
        {

        }
       public Character(string name, int hitchance, int block, int maxHealth, int minHealth)
        {
            Name = name;
            HitChance = hitchance;
            Block = block;
            MaxHealth = maxHealth;
            MinHealth = minHealth;

        } //end Character


        public override string ToString()
        {
            return string.Format("******** {0} ********\n" +
                "Health: {1} of {2},\n" +
                "HitChance: {3}%\n" +
                "Block: {4}",
                Name,
                MinHealth,
                MaxHealth,//rename to life
                HitChance,
                CalcBlock());//overwritten
        }
        
        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
     


        //TODO Methods

    }
}