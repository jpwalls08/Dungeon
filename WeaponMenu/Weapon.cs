﻿namespace WeaponMenu
{
    public enum WeaponType
    {
        Sword,
        Knife,
        Mace,
        Spear,
    }

    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        public bool IsTwoHanded;
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public WeaponType Type{ get; set; }

        public Weapon(string name, int maxdamage, int minDamage, int bonusHitChance, bool TwoHanded, WeaponType type)
        {
            Name = name;
            MaxDamage = maxdamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = TwoHanded;
            Type = type;            
        }
        public override string ToString()
        {
            return string.Format("******** {0} ********\n" +
                "Health: {1} of {2},\n" +
                "Damage: {3}%\n" +
                "Block: {4}" +
                "Weapon Type: {5}",
                Name,
                MaxDamage,
                MinDamage,
                BonusHitChance,
                IsTwoHanded ? "yes" : "no",
                Type);
        }

    }

}