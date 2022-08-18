using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon // MAKE IT PUBLIC!
    {
        //Fields
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        //Added 8/17, Block 3 Lab
        private WeaponType _type;


        //Props
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//end MaxDamage

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//end BonusHitChance

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//end IsTwoHanded

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }//end MinDamage

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        //CTORS
        public Weapon(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            //If you have ANY properties that have business rules
            //that are based off of any OTHER properties... 
            //set the other properties first!!
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }//end FQ CTOR

        //METHODS
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\n{4}\t\t{5}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                Type,
                IsTwoHanded ? "Two-Handed" : "One-Handed");
        }//end ToString()
    }//end class
}//end namespace
