using System;

namespace FighterGameGoneWildGoneSexual
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = new Fighter(); // Erna Goodwin AKA Hot-Girl
            Fighter f2 = new Fighter(); //Hot-Boy

            //f2.weapon.name = "";

            Console.WriteLine("Erna Goodwin AKA Hot-Girl\nWeapon equipped:" + f1.weapon.weaponName);
            Console.WriteLine("\nHot-Boy\nWeapon equipped: " + f2.weapon.weaponName);



            while (f1.getAlive() == true && f2.getAlive() == true)
            {
                f1.Hp -= f2.weapon.Damage();
                f2.Hp -= f1.weapon.Damage();

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Hp left:\n\nErna Goodwin AKA Hot-Girl: " + f1.Hp);
                Console.WriteLine("\nHot-Boy: " + f2.Hp);



                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------");

            if (f1.getAlive() == false)
            {
                Console.WriteLine("Erna Goodwin AKA Hot-Girl Died ;-;");
            }

            else if (f2.getAlive() == false)
            {
                Console.WriteLine("Hot-Boy Died :3");
            }

            else if (f1.Hp == f2.Hp)
            {
                Console.WriteLine("It's a TIE!");
            }

            else if (f1.Hp < 0 && f2.Hp < 0)            //for some reason this command don't wanna work, i tried w putting f1.getAlive() == false && f2.getAlive() == false but no work
            {                                           // i also have to write in ingles because the spelling plug in do not like swedish :(
                Console.WriteLine("They both Died.");
            }




            Console.ReadLine();

        }
    }
}

