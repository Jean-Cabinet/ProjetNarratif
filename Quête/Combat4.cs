using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Combat4 : Quest
    {
        


        public static Random random = new Random();
        internal override string CreateDescription() =>
@"Edvars de ragn - Bon......les indices prete à croire que c'est une Ent qui n'est pas très content que l'on exploite sa forêt.
  Edvars de ragn - Je finir de me préparer pour le combattre, et je vais essayer de répéter la scène d'attaque des bûcherons en tapant avec cette hache sur un arbre.
   Après avoir finir d'huilé l'arme et fait la méditation pour le renforcement des sorts, edvars agrippa la hache laisser par un bûcheron et commença à couper le tronc d'un arbre.
 Guère de temps après, il entendu le bruit du monstre, ce n'était pas un Ulfhedinn mais un leshen. Impossible de faire marche arrière. Edvars aggrippa son arme et se lanca à son rencontre pour le tuer."
  ;

        internal override void ReceiveChoice(string choice, Edvars e)
        {
            Leshen l = new Leshen();
            do
            {
                e.UseHuilelycan();
                e.RenforcementFrostis();
                bool brûlure = false;
                string AttaqueEdvars = "";
                Console.WriteLine("Que voulez-vous faire ?[Attaque],[Sort Bouclier],[Riposte]");
                if (choice == "Attaque")
                {
                    Console.WriteLine("Que voulez-vous faire ?[Coupépée],[Ignis]");
                    AttaqueEdvars = Convert.ToString(Console.ReadLine());
                }


                int choiceLeshen = new Random().Next(2, 5);//changer
                //2 = défense
                //3 = attaque griffe/nuée corbeau
                //4 = riposte


                if (choice == "Attaque" && choiceLeshen == 2)
                {
                    if (brûlure == false)
                    {

                        if (AttaqueEdvars == "Coupépée")
                        {
                            Console.WriteLine("Edvars bondit sur le leshen pour lui asséner un coup de flamberge...");
                            Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                            Console.WriteLine("Le leshen para l'attaque en la deviant avec son bras");
                        }
                        if (AttaqueEdvars == "Ignis")
                        {
                            Console.WriteLine("Edvars élança son bras et l'avant est lança le sort ignis");
                            Console.WriteLine("Edvars de Ragn - Ignis");
                            Console.WriteLine("Le leshen se dématérialisé en corbeau pour esquiver le sort et téléporta à un autre endroit");

                        }
                    }
                    if (brûlure == true)
                    {
                        if (AttaqueEdvars == "Coupépée")
                        {
                            Console.WriteLine("Edvars bondit sur le leshen pour lui asséner un coup de flamberge...");
                            Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                            Console.WriteLine("Le leshen para l'attaque en la deviant avec son bras");
                            l.PV = l.PV - e.brulureIgnis;
                        }
                        if (AttaqueEdvars == "Ignis")
                        {
                            Console.WriteLine("Edvars élança son bras et l'avant est lança le sort ignis");
                            Console.WriteLine("Edvars de Ragn - Ignis");
                            Console.WriteLine("Le leshen se dématérialisé en corbeau pour esquiver le sort et téléporta à un autre endroit");
                            l.PV = l.PV - e.brulureIgnis;

                        }
                    }


                }
                if (choice == "Attaque" && choiceLeshen == 3)
                {
                    if (AttaqueEdvars == "Coupépée")
                    {
                        Console.WriteLine("Edvars bondit sur le leshen pour lui asséner un coup de flamberge...");
                        Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                        Console.WriteLine("Le leshen répliqua avec un coup de griffe");
                        Console.WriteLine("les deux protagonistes s'en resortent avec des blessures");
                        e.PVEdvars = e.PVEdvars - (l.attaque - e.défenseEdvars);
                        l.PV = l.PV - (e.AttaqueGwynbleidd - l.défense);
                        Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");
                    }
                    if (AttaqueEdvars == "Ignis")
                    {

                        Console.WriteLine("Edvars élança son bras et l'avant est lança le sort ignis");
                        Console.WriteLine("Edvars de Ragn - Ignis");
                        Console.WriteLine("Le leshen prit de plein fouet le sort de edvars mais eu le temps de lancée une volée de corbeaux qui entailla notre héros ");
                        Console.WriteLine("Le leshen étant très sensible au feu souffre de dégats de brûlure");
                        e.PVEdvars = e.PVEdvars - (l.nuéecorbeaux - e.défenseEdvars);
                        l.PV = l.PV - (e.Attaqueignis - l.défense);
                        Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");
                        brûlure = true;

                    }
                }
                if (choice == "Attaque" && choiceLeshen == 4)
                {
                    if (brûlure == false)
                    {
                        if (AttaqueEdvars == "Coupépée")
                        {
                            Console.WriteLine("Edvars bondit sur le leshen pour lui asséner un coup de flamberge...");
                            Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                            Console.WriteLine("Le leshen esquiva l'attaque d'edvars, puis avec un coup de griffe répliqua");
                            Console.WriteLine("Edvars fut projeter avec puissance sur un arbre, il cracha du sang puis se releva");
                            e.PVEdvars = e.PVEdvars - l.riposte;
                            Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");
                        }
                        if (AttaqueEdvars == "Ignis")
                        {

                            Console.WriteLine("Edvars élança son bras et l'avant est lança le sort ignis");
                            Console.WriteLine("Edvars de Ragn - Ignis");
                            Console.WriteLine("Le leshen se dématérialisé en corbeau pour esquiver le sort et téléporta derrière edvars puis lui lança une nuée de corbeaux");
                            Console.WriteLine("ceci destabilisa edvars et le blessa ");
                            e.PVEdvars = e.PVEdvars - l.riposte;
                            Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");



                        }
                    }
                    if (brûlure == true)
                    {
                        if (AttaqueEdvars == "Coupépée")
                        {
                            Console.WriteLine("Edvars bondit sur le leshen pour lui asséner un coup de flamberge...");
                            Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                            Console.WriteLine("Le leshen esquiva l'attaque d'edvars, puis avec un coup de griffe répliqua");
                            Console.WriteLine("Edvars fut projeter avec puissance sur un arbre, il cracha du sang puis se releva");
                            e.PVEdvars = e.PVEdvars - l.riposte;
                            l.PV = l.PV - e.brulureIgnis;
                            Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");
                        }
                        if (AttaqueEdvars == "Ignis")
                        {

                            Console.WriteLine("Edvars élança son bras et l'avant est lança le sort ignis");
                            Console.WriteLine("Edvars de Ragn - Ignis");
                            Console.WriteLine("Le leshen se dématérialisé en corbeau pour esquiver le sort et téléporta derrière edvars puis lui lança une nuée de corbeaux");
                            Console.WriteLine("ceci destabilisa edvars et le blessa ");
                            e.PVEdvars = e.PVEdvars - l.riposte;
                            l.PV = l.PV - e.brulureIgnis;
                            Console.WriteLine($"Edvars possède {e.PVEdvars} point de vie");



                        }

                    }
                }
                if (choice == "Sort Bouclier" && choiceLeshen == 2)
                {
                    if (brûlure == false)
                    {
                        Console.WriteLine("Edvars et le Leshen se regarda dans le blanc des yeux attendant que l'un face le premier pas");
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("Edvars et le Leshen se regarda dans le blanc des yeux attendant que l'un face le premier pas");
                        l.PV = l.PV - e.brulureIgnis;
                    }

                }
                if (choice == "Sort Bouclier" && choiceLeshen == 3)
                {

                    if (brûlure == false)
                    {
                        Console.WriteLine("Le bouclier d'edvars absorba les attaques du leshen, sans aucun problème");
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("Le bouclier d'edvars absorba les attaques du leshen, sans aucun problème");
                        l.PV = l.PV - e.brulureIgnis;
                    }
                }
                if (choice == "Sort Bouclier" && choiceLeshen == 4)
                {

                    if (brûlure == false)
                    {
                        Console.WriteLine("Le leshen resta sur ses gardes pret à riposter toutes éevntualité d'attaque de la prt d'edvars.");
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("Le leshen resta sur ses gardes pret à riposter toutes éevntualité d'attaque de la prt d'edvars.");
                        l.PV = l.PV - e.brulureIgnis;
                    }
                }

                if (choice == "Riposte" && choiceLeshen == 2)
                {
                    if (brûlure == false)
                    {
                        Console.WriteLine("Edvars observa chaque recoin, chaque mouvement pour espérer enterevoir une opportunité de riposté, mais le leshen resta sur la défensive");
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("Edvars observa chaque recoin, chaque mouvement pour espérer enterevoir une opportunité de riposté, mais le leshen resta sur la défensive");
                        l.PV = l.PV - e.brulureIgnis;
                    }


                }
                if (choice == "Riposte" && choiceLeshen == 3)
                {

                    if (brûlure == false)
                    {
                        Console.WriteLine("Edvars vit avec rapidité l'attaque du leshen, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans le flan du monstre");
                        l.PV = l.PV - e.riposteEdvars;
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("Edvars vit avec rapidité l'attaque du leshen, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans le flan du monstre");
                        l.PV = l.PV - e.riposteEdvars;
                        l.PV = l.PV - e.brulureIgnis;
                    }
                }
                if (choice == "Riposte" && choiceLeshen == 4)
                {
                    if (brûlure == false)
                    {
                        Console.WriteLine("tout deux restèrent sur ses gardes pret à riposter toutes éventualité d'attaque.");
                    }
                    if (brûlure == true)
                    {
                        Console.WriteLine("tout deux restèrent sur ses gardes pret à riposter toutes éventualité d'attaque.");
                        l.PV = l.PV - e.brulureIgnis;
                    }
                }



            } while (e.PVEdvars != 0 || l.PV != 0);

            Game.Transition<Fin_alternatif>();


        }




    }
}
