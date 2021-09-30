using System;

namespace FighterGameGoneWildGoneSexual
{
    class Fighter
    {
        public int Hp = 100;

        public Weapon weapon = new Weapon();

        public bool getAlive()
        {
            if (Hp <= 0)
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }

    }
}