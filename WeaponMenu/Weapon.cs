namespace WeaponMenu
{
    public enum WeaponType
    {
        Sword,
        Bow,
        Axe,
        Spear,
        Sting
    }

    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        public bool IsTwoHanded;
        private string _weaponDescription;
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
        public string WeaponDescription
        {
            get { return _weaponDescription; }
            set { _weaponDescription = value; }
        }
        public WeaponType Type { get; set; }


        public Weapon(string name, int maxdamage, int minDamage, int bonusHitChance, bool TwoHanded, string weaponDescription, WeaponType type)
        {
            Name = name;
            MaxDamage = maxdamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = TwoHanded;
            WeaponDescription = weaponDescription;
            Type = type;
        }
        public override string ToString()
        {
            return string.Format("******** {0} ********\n" +
                "Health: {1} of {2},\n" +
                "Damage: {3}%\n" +
                "Block: {4}" +
                "Weapon Type: {6}" +
                "Weapon Description: {5}" +
                Name,
                MaxDamage,
                MinDamage,
                BonusHitChance,
                IsTwoHanded ? "yes" : "no",
                WeaponDescription,
                Type);
        }

        public static Weapon CreateWeapon(WeaponType type)
        {
            Weapon weapon = null;

            switch (type)
            {
                case WeaponType.Bow:
                    weapon  = new Weapon("Bow of Bregor", 9, 5, 20, true, " owned by Barahir and Beren, the bow is very accurate and precise if you have the skill set for it.", WeaponType.Bow);
                    break;

                case WeaponType.Spear:
                    weapon = new Weapon("Aeglos", 8, 2, 12, true, " was the spear of the Elven king Gil-galad. It was said that none could withstand the spear of Gil-galad but takes an elf to shed light on it's true strength and capabilites.", WeaponType.Spear);
                    break;

                case WeaponType.Sword: 
                    weapon = new Weapon("Aranrúth", 13, 4, 5, true, " was a sword that belonged to Elu Thingol, King of Doriath, and is known for inflicting severe damage but at a cost of efficiency if in the wrong hands.", WeaponType.Sword);
                    break;

                case WeaponType.Axe:
                    weapon = new Weapon("Durin's Axe", 13, 1, 3, true, " Durin's Axe was a great heirloom of the Dwarves of Durin's Folk. It's known for it's powerful striking damage but can be difficult for the user to be consistent due to it's weight.", WeaponType.Axe);
                    break;

                case WeaponType.Sting:
                    weapon = new Weapon("Sting", 14, 12, 9, false, " was an Elvish knife made in Gondolin in the First Age. Although it was just the size of a dagger by the standards of Men or Elves, it made an excellent sword for a Hobbit.", WeaponType.Sting);
                    break;
            }
            return weapon;
        }

    }

}