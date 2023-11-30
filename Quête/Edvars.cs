using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Edvars
    {
        public int absorptionquen {  get; set; }
        public Compétences compétences {  get; set; }
        public Flamberge Gwynbleidd { get; set; }
        public int PVEdvars { get; set; }
        public int Bourse { get; set; }
        public int PointexperienceSacrifice { get; set; }
        public int PointexperienceEpargner { get; set; }
        public int levelSacrifice { get; set; }
        public int levelEpargner { get; set; }
        public int AttaqueGwynbleidd { get; set; }
        public int Attaqueignis { get; set; }
        public int Attaquefrostis { get; set; }
        public int Attaqueyrden { get; set; }
        public int méditation { get; set; }
        public int défenseEdvars { get; set; }
        public int riposteEdvars { get; set; }
        public int brulureIgnis { get; set; }
        public int bonusmedi { get; set; }
        public Inventaire inventaire { get; set; }
        public Edvars()
        {
            this.absorptionquen = 50;
            this.PVEdvars = 50;
            this.Bourse = 10;
            this.levelEpargner = 1;
            this.levelSacrifice = 1;
            this.PointexperienceSacrifice = 0;
            this.PointexperienceEpargner = 0;
            this.AttaqueGwynbleidd = 10;
            this.Attaqueignis = 5;
            this.Attaquefrostis = 5;
            this.Attaqueyrden = 2;
            this.méditation = 10;
            this.défenseEdvars = 10;
            this.riposteEdvars = 10;
            this.brulureIgnis = 2;
            this.bonusmedi = 2;
            this.inventaire = new Inventaire();
            this.inventaire.Add(new Flamberge("Gwynbleidd", "flamberge", 12));
            this.inventaire.Add(new Hirondelle("Hironedlle", "Soin", 12));
            this.inventaire.Add(new Huileleshi("huileleshi", "combat", 3));
            this.inventaire.Add(new Huilezoruna("huilezoruna", "combat", 1));
            this.inventaire.Add(new Huilealfi("huilealfi", "combat", -5));
            this.inventaire.Add(new Huileent("huileent", "combat", 1));
            this.inventaire.Add(new Huilelycan("huilelycan", "combat", -5));
            this.inventaire.Add(new Florinprime(150, 0, 0, "primehypno", "florin"));
            this.inventaire.Add(new Florinprime(0, 50, 0, "prime", "florin"));
            this.inventaire.Add(new Florinprime(0, 0, 80, "primequete", "florin"));

        }

        /*public bool equip()
        {
           foreach (Item item in inventaire.inventaire)
           {
               if (item is Flamberge)
               {
                   Flamberge oui;
                   Gwynbleidd = ((Flamberge)item);
                   oui = Gwynbleidd;
                   inventaire.Sub(item);

                   return true;
               }



           }
           Console.WriteLine("Vous ne possédez pas d'hirondelle");
           return false;


        }*/






        public bool UseHirondelle()
        {
            foreach (Item item in inventaire.inventaire)
            {
                if (item is Hirondelle)
                {

                    PVEdvars = PVEdvars + ((Hirondelle)item).HealingAmount;
                    inventaire.Sub(item);
                    Console.WriteLine($"Edvars possède {PVEdvars} point de vie ");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'hirondelle");
            return false;

        }


        public bool UseHuileleshi(Leshen l)
        {
            foreach (Item item in inventaire.inventaire)
            {
                
                l.défense = l.défense - 5;
                if (item is Huileleshi)
                {

                    AttaqueGwynbleidd = AttaqueGwynbleidd + ((Huileleshi)item).huileleshi;
                    inventaire.Sub(item);
                    Console.WriteLine($"Gwynbleidd a mainteant un montant d'attaque de {AttaqueGwynbleidd}");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'huile de leshi");
            return false;

        }
        public bool UseHuileent()
        {
            foreach (Item item in inventaire.inventaire)
            {
                if (item is Huileent)
                {

                    AttaqueGwynbleidd = AttaqueGwynbleidd + ((Huileent)item).huileent;
                    inventaire.Sub(item);
                    Console.WriteLine($"Gwynbleidd a un montant d'attaque de {AttaqueGwynbleidd}");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'huile d'ent");
            return false;

        }

        public bool UseHuilezoruna()
        {
            foreach (Item item in inventaire.inventaire)
            {
                if (item is Huilezoruna)
                {

                    AttaqueGwynbleidd = AttaqueGwynbleidd + ((Huilezoruna)item).huilezoruna;
                    inventaire.Sub(item);
                    Console.WriteLine($"Gwynbleidd a un montant d'attaque de {AttaqueGwynbleidd}");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'huile de zoruna");
            return false;

        }

        public bool UseHuilelycan(Leshen l)
        {
            foreach (Item item in inventaire.inventaire)
            {
                
                l.défense = l.défense + 15;
                if (item is Huilelycan)
                {

                    AttaqueGwynbleidd = AttaqueGwynbleidd - ((Huilelycan)item).huilelycan;
                    inventaire.Sub(item);
                    Console.WriteLine("Gwynbleidd a un montant d'attaque de ????");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'huile de lycan");
            return false;

        }

        public bool UseHuilealfi(Leshen l)
        {
            foreach (Item item in inventaire.inventaire)
            {
                
                l.défense = l.défense + 15;
                if (item is Huilealfi)
                {

                    AttaqueGwynbleidd = AttaqueGwynbleidd - ((Huilealfi)item).huilealfi;
                    inventaire.Sub(item);
                    Console.WriteLine("Gwynbleidd a un montant d'attaque de ????");
                    return true;
                }

            }
            Console.WriteLine("Vous ne possédez pas d'huile d'alfi");
            return false;

        }


        public bool Primesort()
        {

            foreach (Item item in inventaire.inventaire)
            {
                if (item is Florinprime)
                {

                    Bourse = Bourse + ((Florinprime)item).primehypno;
                    inventaire.Sub(item);
                    Console.WriteLine($" Vous possédez maintenant {Bourse} florins");
                    return true;
                }

            }
            Console.WriteLine("Vous n'avez choisir l'option sort lors de la prime");
            return false;



        }

        public bool Prime()
        {

            foreach (Item item in inventaire.inventaire)
            {
                if (item is Florinprime)
                {

                    Bourse = Bourse + ((Florinprime)item).prime;
                    inventaire.Sub(item);
                    Console.WriteLine($" Vous possédez maintenant {Bourse} florins");
                    return true;
                }

            }
            Console.WriteLine("Vous n'avez choisir l'option prime lors de la négotiation");
            return false;



        }

        public bool Primequete()
        {

            foreach (Item item in inventaire.inventaire)
            {
                if (item is Florinprime)
                {

                    Bourse = Bourse + ((Florinprime)item).primequete;
                    inventaire.Sub(item);
                    Console.WriteLine($" Vous possédez maintenant {Bourse} florins");
                    return true;
                }

            }
            Console.WriteLine("Vous n'avez choisir l'option prime lors de la négotiation");
            return false;

        }


        public int RenforcementIgnis()
        {

            Attaqueignis = Attaqueignis + méditation;
            brulureIgnis = brulureIgnis + bonusmedi;
            Console.WriteLine($"La puissance de votre signe est augmenter {Attaqueignis}");


            return Attaqueignis;

        }

        public int RenforcementFrostis()
        {
            Attaquefrostis = Attaquefrostis + méditation;
            Console.WriteLine($"La puissance de votre signe est augmenter {Attaquefrostis}");

            return Attaquefrostis;

        }

        public int RenforcementYrden()
        {
            Attaqueyrden = Attaqueyrden + méditation;
            Console.WriteLine($"La puissance de votre signe est augmenter {Attaqueyrden}");

            return Attaqueyrden;

        }

        public void Afficherstat()
        {
            


        }

        public void niveauxsacrifice(Ennemis E,Edvars C,Leshen L)
        {
            
          if (E.PV == 0)
          {
                C.PointexperienceSacrifice = C.PointexperienceSacrifice + 10;
            }
          if(L.PV == 0)
          {
                C.PointexperienceSacrifice = C.PointexperienceSacrifice + 100;
                C.levelSacrifice = C.levelSacrifice + 1;
                Console.WriteLine($"Vous etes monté niveau {C.levelSacrifice}");

          }


        }

        public void niveauxepargner(Ennemis E, Edvars C, Leshen L)
        {

            if (E.PV == 0)
            {
                C.PointexperienceEpargner = C.PointexperienceEpargner + E.expérience;
                Console.WriteLine($"Vous avez gagner {E.expérience}");
            }
            if (L.PV == 0)
            {
                C.PointexperienceEpargner = C.PointexperienceEpargner + 100;
                C.levelEpargner = C.levelEpargner + 1;
                Console.WriteLine($"Vous etes monté niveau {C.levelEpargner}");

            }


        }











    }





}
