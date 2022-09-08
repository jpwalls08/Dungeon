using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponMenu;

namespace CharacterLibrary
{
    public sealed class Player : Character
    {
        private Weapon _equippedWeapon;

        private Race _playerRace;
        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }

        public Race PlayerRace
        {
            get { return _playerRace; }
            set { _playerRace = value; }
        }

        public Player(string name, int hitchance, int block, int maxHealth, int minHealth, Weapon equippedWeapon, Race race) : base(name, hitchance, block, maxHealth, minHealth)
        {
            EquippedWeapon = equippedWeapon;
            PlayerRace = race;


            switch (PlayerRace)
            {
                case Race.Human:
                    MaxHealth -= 10;
                    MinHealth += 5;
                    break;
                case Race.Elf:
                    HitChance += (HitChance / 20); //hitchance * 1.05
                    MaxHealth += 5;
                    break;
                case Race.Hobbit:
                    Block += 15;
                    HitChance += 5;
                    MinHealth -= 15;
                    break;
                case Race.Dwarf:
                    MaxHealth += 5;
                    MinHealth += 5;
                    Block += 5;
                    break;
                case Race.Ent:
                    MaxHealth += 5;
                    MinHealth -= 5;
                    Block -= 5;
                    break;
            }//end switch
        }





        public override string ToString()
        {
            string description = "";
            switch (PlayerRace)
            {
                case Race.Human:
                    description = "Human";
                    break;

                case Race.Elf:
                    description = "Elf";
                    break;

                case Race.Hobbit:
                    description = "Hobbit";
                    break;

                case Race.Dwarf:
                    description = "Dwarf";
                    break;

                case Race.Ent:
                    description = "Ent";
                    break;
            }
            return base.ToString() +
                "\nRace: " + PlayerRace +
            "\nWeapon: " +
                EquippedWeapon.ToString();
                
        }



        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();//0, we don't want it!
            //Random Object
            Random rand = new Random();

            //Weapon has max and min damage
            return rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            //int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return damage;
            //long version

        }

    }
}
