using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_like
{
    internal class Selection
    {
        public static List<MonPersonnage> SelectionHero()
        {

            foreach (var hero in NPC.heroes())
            {
                hero.Afficher();
            }

            Console.WriteLine("choisi ton personnage\n " +
                "Appuye 1 pour le chevalier\n" +
                "Appuye 2 pour le sorcier\n" +
                "Appuye 3 pour le mort vivant ");

            var monPersonnage = new List<MonPersonnage>();

            while (true)
            {
                try
                {
                    int choix = int.Parse(Console.ReadLine());
                    if (choix == 1)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                             new MonPersonnage("Artas", 60, 7, 8, "Chevalier",15)

                        };
                        break;
                    }
                    if (choix == 2)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                            new MonPersonnage("Dumbledor", 45, 10, 3,"Sorcier",15)
                        };
                        break;
                    }
                    if (choix == 3)
                    {
                        monPersonnage = new List<MonPersonnage>
                        {
                            new MonPersonnage("Liche", 100, 5, 1,"MortViant",15)
                        };
                        break;
                    }
                    else
                    {
                        Console.WriteLine("tu n'as pas mis un bon chiffre");
                    }
                }
                catch
                {
                    Console.WriteLine("on a dit un chiffre");
                }
            }


            foreach (var perso in monPersonnage)
            {
                Console.Clear();
                Console.WriteLine("le hero que tu as choisi est : ");
                Console.WriteLine();
                perso.Afficher();

            }

            return monPersonnage;
        }

    }
}
