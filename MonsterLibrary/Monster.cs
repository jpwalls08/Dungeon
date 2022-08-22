using CharacterLibrary;

namespace MonsterLibrary
{
    public class Monster : Character
    {
       
                
        public int MaxDamage { get; set; }

        public Monster(string name, int damage, int block, int maxHealth, int minHealth) : base(name, damage, block, maxHealth, minHealth)
        {
            
        }
        public Monster()
        {
            Name = "Dragon";
            Damage = 5; 

        }
    }
}