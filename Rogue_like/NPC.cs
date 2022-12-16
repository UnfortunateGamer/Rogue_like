using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rogue_like;

namespace Rogue_like
{
    internal class NPC
    {
        public static List<Hero> heroes()
        {
            var classeDePersonnage = new List<Hero>
            {
                new Hero("Artas",60,7,8,"Chevalier",15),
                new Hero("Dumbledor", 45, 10, 3,"Sorcier",15),
                new Hero("Liche", 100, 5, 1,"MortViant",15)
            };

            return classeDePersonnage;
        }


        public static List<Monstre> HordeMonstre()
        {
            var hordeMonstre = new List<Monstre>
            {
                new Monstre("Guldan", 70, 6, 0,15),
                new Monstre("Ilidan", 70, 6, 0,15),
                new Monstre("Goblin Infamelique", 70, 6, 0,15),
                new Monstre("Kouro Gaki", 70, 6, 0,15),
                new Monstre("Yuumi", 10, 15, 9,20),
                new Monstre("Ifrit", 150, 11, 1,40),
                new Monstre("Bahometh", 70, 6, 0,15),
                new Monstre("Lilith", 70, 6, 0,15),
                new Monstre("Loki", 70, 6, 0,15),
            };

            return hordeMonstre;
        }

        public static List<Monstre> leMonstre()
        {
            var crapules = HordeMonstre();
            var random = new Random();
            var valeurAleatoire = random.Next(0, 8);
            var crapule = crapules[valeurAleatoire];
            
            crapule.Afficher();
            return new List<Monstre> { crapule };
        }


    }
}
