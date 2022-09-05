using CharacterLibrary;

namespace MonsterLibrary
{
    public class Monster : Character
    {
        public int MaxDamage { get; set; }

        public string Description { get; set; }

        private int _minDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            //can't be more than maxdamage, can't be less than 1
            set
            {
                if (value > MaxDamage || value < 1)
                {
                    _minDamage = 1;
                }
                //else if (value < 1)
                //{
                //    _minDamage = 1;
                //}
                else
                {
                    _minDamage = value;
                }//end else
                //_minDamage = value > MaxDamage || value < 1 ? 1 : value;

            }//end set
        }//end MinDamage

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            //Property = parameter
        }//end FQ CTOR
         //default constructor for a default monster


        public override int CalcDamage()
        {
            //return base.CalcDamage();//returns 0, not what we want.
            return new Random().Next(MinDamage, MaxDamage + 1);// +1 because it's exclusive
        }//end CalcDamage()

        public Monster()
        {
            Name = "Smaug";
            HitChance = 30;
            Block = 45;
            MaxHealth = 22;
            MinHealth = 22;
            MaxDamage = 15;
            MinDamage = 8;
            Description = @"A fiery gust of flames emerges from the ashes, where the infamous Smaug resides...




                                                                                                                              ▒▒                  ░░            
                                                                                                                                                                
                                                                                                                                      ▒▒▒▒▒▒          ▒▒        
                                                                                                                ░░░░░░              ░░▒▒▒▒                      
                                                                                                              ░░▒▒▒▒              ░░▒▒                        ░░
                                                                                                            ░░▒▒▒▒                          ░░░░            ░░▒▒
                                                                                                            ▒▒▒▒          ░░            ░░░░▒▒            ▒▒▒▒  
                                                                                                  ▒▒                                    ▒▒▒▒▒▒          ▒▒▒▒▒▒  
                                                                                                                                      ▒▒▒▒▒▒▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒  
                                                                                  ▒▒        ▒▒          ░░    ▒▒▒▒▒▒▒▒▒▒░░          ▒▒▒▒░░▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒  
                                                                ▒▒▒▒▒▒                          ░░        ▒▒▒▒░░░░░░░░░░▒▒░░      ▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒
                                                            ▒▒▓▓▓▓▓▓▓▓▓▓                              ▒▒▒▒░░░░░░        ░░▒▒░░    ▒▒▒▒░░░░░░▒▒▒▒░░░░░░░░░░░░▒▒▒▒
                                                          ▒▒▓▓▓▓▓▓▓▓▓▓▓▓░░                            ▒▒░░░░              ░░░░    ▒▒▒▒░░░░░░░░░░          ░░▒▒▒▒
                                                        ▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░                        ░░░░░░░░░░            ░░▒▒▒▒  ▒▒░░░░░░░░              ░░▒▒▒▒
                                                      ░░▓▓▓▓▓▓▓▓▓▓██████▓▓▒▒                    ░░  ░░░░░░░░▒▒░░            ░░▒▒  ▒▒░░░░                  ░░▒▒▒▒
                                                    ▒▒▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓                  ▒▒░░          ▒▒░░            ░░▒▒▒▒▒▒░░                    ░░▒▒▒▒
                                                  ▓▓▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██▓▓          ▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░              ░░▒▒▒▒░░░░                  ░░░░▒▒▒▒
                                                ▒▒▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓██▓▓        ░░      ░░▒▒░░▒▒░░░░░░░░░░                ░░▒▒░░░░                  ░░░░░░▒▒  
                                              ▒▒▓▓▓▓▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓                ░░▒▒▒▒░░░░░░░░░░                    ░░░░░░                  ░░░░▒▒▒▒▒▒  
                                            ▒▒▓▓▓▓▓▓▓▓▓▓████▓▓▒▒▓▓▒▒██                ░░▒▒░░░░░░░░                                                ░░░░▒▒▒▒▒▒    
                                          ▒▒▓▓▓▓▓▓▓▓▓▓████▓▓▒▒▒▒▒▒▓▓▓▓      ░░        ▒▒░░░░                                                    ░░░░▒▒▒▒▒▒      
                                        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▒▒▒▒▒▒▒▒▒▒██            ▒▒▒▒░░░░                                                      ░░░░▒▒▒▒        
                                      ▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓██▓▓▒▒▒▒▒▒▒▒██              ▒▒░░░░░░                                                    ░░░░▒▒░░          
                                  ░░▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓██▓▓▒▒▒▒▒▒▒▒▒▒▒▒            ▒▒░░░░                                                        ░░▒▒▒▒            
                          ░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓██▓▓▒▒░░░░░░▓▓██          ▒▒▒▒                                                          ░░░░▒▒▒▒            
                        ░░░░░░░░██▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓██▓▓░░░░  ░░██          ▒▒▒▒▒▒░░░░                                                  ░░░░░░▒▒░░              
                              ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░        ░░          ▒▒▒▒░░░░░░                                              ░░░░░░▒▒▒▒                  
                            ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░        ░░          ▒▒░░░░░░░░░░                                          ░░░░░░░░▒▒▒▒                  
                        ░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░▓▓▓▓          ░░▓▓          ▒▒░░░░                    ░░░░░░░░░░  ░░    ░░░░░░░░░░░░░░░░░░▒▒        ░░        
                      ░░░░░░  ░░▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░██▓▓      ░░░░▓▓▓▓          ▒▒▒▒░░          ░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░                
                      ░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░  ██    ░░░░░░░░▒▒▓▓          ▒▒░░              ░░░░░░░░░░░░░░▒▒░░░░              ▒▒▒▒▒▒▒▒▒▒░░              
                    ░░░░  ░░░░░░▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░██▓▓▒▒░░░░░░░░░░▓▓▓▓          ▒▒                        ░░░░▒▒▒▒▒▒░░                ▒▒▒▒▒▒░░              
                  ░░░░  ░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░  ████▓▓▒▒▒▒▒▒░░░░██▓▓          ▒▒░░                  ░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒                                
                ░░░░  ░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░  ██▒▒▓▓▓▓▒▒▒▒░░░░▓▓▓▓        ▒▒▒▒░░                    ░░░░▒▒░░            ▒▒                          
              ░░░░  ░░░░  ▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▒▒░░░░░░░░░░░░  ████▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓        ▒▒▒▒            ░░░░░░░░░░░░░░▒▒                ░░        ░░            
            ░░░░  ░░    ▓▓▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░░░░░  ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓            ▒▒▒▒░░░░░░░░░░░░▒▒▒▒░░░░░░░░░░                                      
          ░░░░  ░░      ▓▓▓▓▓▓▒▒░░▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░▒▒░░░░░░░░  ██████▓▓▓▓▓▓██▓▓                ▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░                                      
        ░░░░  ░░          ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░▒▒▒▒░░░░░░    ████████▓▓                        ▒▒▒▒░░░░▒▒    ▒▒▒▒▒▒▒▒░░                ▒▒░░              
      ░░░░  ░░                ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░▒▒▒▒          ██████                              ▒▒▒▒▒▒░░        ▒▒░░  ▒▒      ▒▒▒▒▒▒▒▒▒▒▒▒            
    ░░░░  ░░                ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒░░░░▒▒                        ░░            ▒▒▒▒                        ▒▒▒▒  ▒▒▒▒            
    ░░░░░░                  ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░  ▒▒                                                ▒▒▒▒                                            
  ░░░░░░                  ░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░  ▒▒                                                    ░░                                          
  ░░░░                    ░░  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░  ▒▒                                        ░░                                                      
  ░░                      ░░    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░  ▒▒▒▒                                                                                              
                              ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒░░░░░░░░░░    ▒▒                                                                                              
                            ░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░    ▒▒                                                                                            
                            ░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░    ▒▒                                                                                          
                              ░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░    ░░                                                                                        
                              ░░    ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░  ▒▒░░                                                                                      
                                  ░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒░░░░░░░░░░░░░░  ▒▒▒▒                                                                                    
                                                                      
";

        }

        public override string ToString()
        {
            return $@"
        ******* MONSTER *******
        {Name}
        Life: {MinHealth} of {MaxHealth}
        Damage: {MinDamage} to {MaxDamage}
        Block: {Block}
        Description: {Description}";
        }
        



        public static Monster GetMonster()
        {
            
            Monster smaug = new Monster();
            Monster sauron = new Monster("Sauron", 35, 35, 65, 8, 14, 23, "In all my lifetime I have never layed eye's upon such a cruel and sinful being..." +
                                         "The ruler of Mordor, Sauron!\n");
            Monster orc = new Monster("Orc", 15, 20, 75, 10, 4, 7, "Orcs are a brutish, aggressive, ugly, and malevolent race of monsters\n");
            Monster gollum = new Monster("Smeagle", 20, 20, 45, 20, 8, 15, "Gollum is a slimy, skinny creature living in the middle of an underground lake " +
                                         "underneath the Misty Mountains.\n");
            Monster saruman = new Monster("Saruman", 25, 25, 50, 40, 12, 20, "Saruman was not born evil; rather, he has become corrupt out of arrogance and ambition\n");

            List<Monster> monsters = new List<Monster>()
            {
                smaug, smaug,
                sauron, sauron,
                orc, orc, orc,
                gollum, gollum, gollum,
                saruman, saruman
            };

            
            return monsters[new Random().Next(monsters.Count)];
        }//end GetMonster()

    }

}

