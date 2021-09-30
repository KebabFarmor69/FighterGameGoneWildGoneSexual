using System;

namespace FighterGameGoneWildGoneSexual
{
    public class Weapon
    {
        public Random generator = new Random();

        public string weaponName = "Roaring Silver Sniper";

        public int Damage()
        {
            return generator.Next(20, 50);
        }


    }
}