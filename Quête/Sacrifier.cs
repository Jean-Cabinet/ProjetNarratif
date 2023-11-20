using ProjetNarratif.Quests;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Sacrifier : Quest
    {
        internal static Stopwatch timer = new Stopwatch();
        internal override string CreateDescription() =>
@"Edvars sentit une grande puissance envahir son épée, lorsqu'il empoigna son épée, il entendit les voix et les cris de l'homme, lui bourdonna dasn l'esprit.
Pris de peur Evars lacha son épée. 
Edvars de Ragn - qu'est ce que c'est que ce truc.....Je dois résiter et prendre mon arme.
Edavrs réussit à prendre son arme et la placer dans son dos et se dirigea vers le village pour récupérer sa prime
Régisse chèvre - Alors, vous avez abattu le monstre ?  
Edvars de Ragn -  Oui, elle ne vous embêtera plus.
Régisse chèvre - Vous avez une mine à détérer les morts
Régisse chèvre - Tenez voici votre prime.
LES VOIX DANS VOTRE TETE S'INTENSIFIE VOUS ENTENDEZ LES CRIS DE L'HOMME BOURDONNER DANS VOTRE CRANE.
Edvars tomba au sol en prenant la tete entre les se mains et cria. [repousser] les voix";


        internal override void ReceiveChoice(string choice, Edvars e)
        {
            switch (choice)
            {
                case "repousser":

                    Console.WriteLine("Régisse chèvre - Vous allez bien  ?");
                    Console.WriteLine("Edvars de Ragn - AAHAHAHAHAHAHAH, tout en se tenant la tete dans les mains");
                    Thread.Sleep(2000);
                    Console.WriteLine("Attention, vous allez devoir appuyer plusieurs fois sur votretouche entrée");
                    Console.ReadKey();
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("5");
                    timer.Start();
                   for( int i =0; i <5; i++)
                   {
                     Console.ReadKey();
                   }
                    timer.Stop();
                    TimeSpan res = timer.Elapsed;
                    double resu = res.TotalSeconds;
                    if(resu < 2)
                    {
                        Console.WriteLine("Edvars réussit à calmer les voix dans sa tête, dégoulinant de sueur froide le long de son corps");
                        Console.WriteLine("Régisse chèvre - Vous allez bien monsieur ?");
                        Thread.Sleep(2500);
                        Console.WriteLine("Edvars de Ragn - *soupir* *se releva*, merci, bon vent à vous");
                        Console.WriteLine(" le villageois fut déconensé par ce qu'il venait d'assister, il observa avec un air abasourdit edvars s'éloigner avec son cheval");

                    }
                    if(resu > 2)
                    {
                        Console.WriteLine("Edvars céssa tout gémissement, un aura noir et rouge s'évapora du corps de edvars");
                        Thread.Sleep(2000);
                        Console.WriteLine(" des griffes comment ça à sortir des mains d'edvars, puis il commença à grossir et grandir de façon fulgurante");
                        Console.WriteLine("Edvars de Ragn - AHAHAH.. qu'est ce qui m'arrive..je... GRAOU...");
                        Console.WriteLine("sa tete se transforma en museaux et des crocs sortie.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Edvars n'était plus le même, il n'a pu controler ses pouvoirs magiques du au manifestion de sacrifice.");
                        Console.WriteLine("Il s'était transformé en cerbères, détruisant le village au quel il avait accepté le contrat");
                        Console.WriteLine("Voilà ce qui arrive lorsque que l'on est faible, on se transforme en monstre");
                        Console.WriteLine(" et à son tour, il sera chasser et de nouveaux un chasseur tombera probablement dans la folie");

                        Game.Finish();
                    }


                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }

    }
}
