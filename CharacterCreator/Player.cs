using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponMenu;

namespace CharacterLibrary
{
    public class Player : Character
    {
        public Weapon EquippedWeapon { get; set; }

        public Race PlayerRace { get; set; }
        public Player(string name, int hitchance, int block, int maxHealth, int minHealth, Weapon equippedWeapon, Race race) : base(name, hitchance, block, maxHealth, minHealth)
        {
            EquippedWeapon = equippedWeapon;
            PlayerRace = race;
        }
        public override string ToString()
        {
            return base.ToString() + "\nWeapon : " + 
                EquippedWeapon.Name +
                "\nRace : " + PlayerRace;
        }
    }
}
