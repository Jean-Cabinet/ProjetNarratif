using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class VillageS : Quest
    {
        internal override string CreateDescription() =>
       @"Sur la route pour le prochain village acommpagné de son fièle destrier,Edvars fut troubler par ce qui lui était arriver, il avait sentit une puissance destructice s'emparer de lui. 
         Tout en regardant son arme,il vit que celle-ci avait pris une teinte noiratre avec des reflets rouges. Edvars savait que son arme etait un artefact magique parmis tant d'autres
         qu'il fournissait à l'école des croiseleurs et que lui avait décidé de prendre une flamberge.
         Edvars de Ragn - Tuer et ne pas succomber......hmm ça prends du sens maintenant
         Edvars de Ragn - Je devrais me reposer ce combat m'a épuisé, allons à l'[auberge] dans ce village.";
        internal override void ReceiveChoice(string choice, Edvars e)
        {

            switch (choice)
            {
                case "auberge":

                    Console.WriteLine(@"Edvars ouvra la porte de l'auberge, tout le monde dans l'auberge le dévisagea, comprenant qui il était.
                     Edvars se posa au bar, et demanda de lui servir une bière");
                    Console.WriteLine("tavernier - On sert aps les gens comme vous ici, dégager !!!");
                    Console.WriteLine("Edvars de Ragn - Écouter, je ne veux pas d'ennuis, je veux juste une chambre et une bière, j'ai de quoi vous payez");
                    Thread.Sleep(2000);
                    Console.WriteLine("bandit - eh... tu as pas compris quoi dans, on va pas de toi ici");
                    Console.WriteLine("Edvars n'avait pas envie de se battre, mais il sentit qu'il n'eu pas le choix");
                    Console.WriteLine("Edvars de Ragn- très bien allons [dehors] messieur, je vous pris.[Flamberge]");

                    switch (choice)
                    {
                        case "dehors":
                            Console.WriteLine("Une fois dehors, Edvars est encerclé par 3 brigants ");
                            Console.WriteLine("Edvars de Ragn - par qui je commence....");
                            Console.WriteLine("Un brigand avança pour mettre une droite à edvars, Edvars equiva et lui retrouna un uppercut dans le menton");
                            Console.WriteLine("le brigand tomba et ses camarades prire peur et coururent pour s'enfuir");
                            Console.WriteLine("Edavrs rentra de nouveux dans la taverne seul cette fois-ci");
                            Thread.Sleep(2500);
                            Console.WriteLine("Tavernier - Désolé... mais vous ne pouvez pas rester ici, cela risque d'effrayer mes clients");
                            Thread.Sleep(2000);
                            Console.WriteLine("Edvars de Ragn - très bien, bon vent");


                            break;

                        case "Flamberge":
                            Console.WriteLine("Edvars de Ragn sortit sa flamberge et se dirigea vers la sortie");
                            Thread.Sleep(2000);
                            Console.WriteLine("Bandit - OH...doucement l'ami, on ne veut pas d'embrouille. C'était juste une petite boutade.");
                            Thread.Sleep(2000);
                            Console.WriteLine("Edvars rangea sa flamberge et dit : humm...puis - je avoir cette bière et une chambre tavernier ? en lui lançant un regard menaçant");
                            Thread.Sleep(1000);
                            Console.WriteLine("Tavernier - Oui de suite....mais ne créer pas d'embouille dans mon auberge par pitié");
                            e.Bourse = e.Bourse - 15;
                            Console.WriteLine($"Il vous reste {e.Bourse}");
                            Game.Transition<AubergeS>();

                            break;


                    }

                    break;

            }



        }




    }
}
