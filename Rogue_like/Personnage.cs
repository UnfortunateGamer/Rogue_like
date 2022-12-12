using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue_like
{
    class MonPersonnage : Hero
    {

        public MonPersonnage(string nom, int pointDeVie, int pointAttaque, int pointDefence, string classe, int pointInitative) : base(nom, pointDeVie, pointAttaque, pointDefence, classe, pointInitative)
        {

        }
        public override void Afficher()
        {
            base.Afficher();
        }

    }
    class Hero : Personnage
    {
        public string classe;

        public Hero(string nom, int pointDeVie, int pointAttaque, int pointDefence, string classe, int pointInitative) : base(nom, pointDeVie, pointAttaque, pointDefence, pointInitative)
        {
            this.classe = classe;
        }
        public override void Afficher()
        {
            
            base.Afficher();
            Console.WriteLine("classe : " + classe);
            Console.WriteLine();
        }
    }

    class Monstre : Personnage
    {
        // monstre -> liste de 18 monstres ( Nom,pv,ini,point d'attaque,point de déffance)

        public Monstre(string nom, int pointDeVie, int pointAttaque, int pointDefence, int pointInitative) : base(nom, pointDeVie, pointAttaque, pointDefence, pointInitative)
        {

        }

    }
    class Personnage
    {

        public string nom;
        public int pointDeVie;
        public int pointAttaque;
        public int pointDefence;
        public int pointInitative;

        public Personnage(string nom, int pointDeVie, int pointAttaque, int pointDefence, int pointInitative)
        {
            this.nom = nom;
            this.pointDeVie = pointDeVie;
            this.pointAttaque = pointAttaque;
            this.pointDefence = pointDefence;
            this.pointInitative = pointInitative;
        }


        public virtual void Afficher()
        {
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Point de vie : " + pointDeVie);
            Console.WriteLine("Point d'attaque : " + pointAttaque);
            Console.WriteLine("Point de defence : " + pointDefence);
            Console.WriteLine("Point d'initiative " + pointInitative);
            
        }

    }
}