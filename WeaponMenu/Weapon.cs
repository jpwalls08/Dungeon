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
        private WeaponType _type;


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
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Weapon (string weaponDescription)
        {
            _weaponDescription = weaponDescription;
        }


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
                "\nWeapon Description: {5}\n\n" +
                "Weapon Stats:\n" +
                "Damage: {2} to {1}\n" +
                //"Damage: {3}\n" +
                "Bonus Hit Chance: {3}%\n" +
                "Weapon Type: {6}\n\n",
                Name, // {0}
                MaxDamage, // (1}
                MinDamage, // {2}
                BonusHitChance, // {3}
                IsTwoHanded ? "yes" : "no", // {4}
                WeaponDescription, // {5}
                Type // {6}
                );

        //    string description = "";
        //    switch (Type)
        //    {
        //        case WeaponType.Bow:
        //            description = "Bow of Bregor";
        //            break;

        //        case WeaponType.Spear:
        //            description = "Spear";
        //            break;

        //        case WeaponType.Sword:
        //            description = "Sword";
        //            break;

        //        case WeaponType.Axe:
        //            description = "Axe";
        //            break;

        //        case WeaponType.Sting:
        //            description = "Sting";
        //            break;


        //    }
        //    return base.ToString() +
        //"\nWeapon : " +
        //Name +
        //"\nWeapon : " + WeaponDescription +
        //"\nName : " + description;
        }

        public static Weapon CreateWeapon(WeaponType type)
        {
            Weapon weapon = null;

            switch (type)
            {
                case WeaponType.Bow:
                    weapon = new Weapon("Bow of Bregor", 9, 5, 20, true, "Owned by Barahir and Beren, the bow is very accurate and precise if you have the skill set for it.", WeaponType.Bow);
                    break;

                case WeaponType.Spear:
                    weapon = new Weapon("Aeglos", 8, 2, 12, true, "Was the spear of the Elven king Gil-galad. It was said that none could withstand the spear of Gil-galad but takes an elf to shed light on it's true strength and capabilites.", WeaponType.Spear);
                    break;

                case WeaponType.Sword:
                    weapon = new Weapon("Aranrúth", 13, 4, 5, true, "Was a sword that belonged to Elu Thingol, King of Doriath, and is known for inflicting severe damage but at a cost of efficiency if in the wrong hands.", WeaponType.Sword);
                    break;

                case WeaponType.Axe:
                    weapon = new Weapon("Durin's Axe", 13, 1, 3, true, "Was a great heirloom of the Dwarves of Durin's Folk. It's known for it's powerful striking damage but can be difficult for the user to be consistent due to it's weight.", WeaponType.Axe);
                    break;

                case WeaponType.Sting:
                    weapon = new Weapon("Sting", 14, 12, 9, false, "Was an Elvish knife made in Gondolin in the First Age. Although it was just the size of a dagger by the standards of Men or Elves, it made an excellent sword for a Hobbit.", WeaponType.Sting);
                    break;
            }
            return weapon;
        }



    }

}