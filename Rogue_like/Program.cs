using System;
using Rogue_like;

namespace jeu_de_role
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NPC.heroes();
            //Selection.SelectionHero();

            //foreach (var monstre in NPC.HordeMonstre())
            //{
            //    monstre.Afficher();
            //}

            var personnage = new List<MonPersonnage>();
            personnage.AddRange((IEnumerable<MonPersonnage>)Selection.SelectionHero().Cast<Hero>());

            var monstre = new List<Monstre>();
            monstre.AddRange((IEnumerable<Monstre>)NPC.leMonstre().Cast<Monstre>());


           
            Console.WriteLine("t'es au bout");

            //Figth.combat(personnage,monstre);
        }

    }
}
