using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class VillageÉ : Quest
    {
        internal override string CreateDescription() =>
        @"Sur la route pour le prochain village acommpagné de son fièle destrier,Edvars repensa à son choix d'épargner cette femme qui autre fois comme lui était une croiseleuses.
         On lui avait appris dans son entrainement intense à ne pas céder à la pitié, en lui bourrant dans le crâne : 
         aucun monstre ne doit survivre. La personne qui se transforme ne conserve pas ses pleins pouvoirs, et est obligé de vivre dans un monde qui ne veut pas d'elle,
         soit parmis les hommes ou la guilde d'avalon. Conservant les marques sur son corps de son échec et de son passé. Ces personnes là finissent par devenir des ronin,
         qui essaye après leur échec se voir faire accepter pour faire un contrat, n'étant plus affilié à aucune guilde. Il peuvent se retransformer en monstre si cette de ronin
         les pousse ans leur derniers retranchement.
         Edvars de Ragn -  Gwynbleidd.....elle a pris une teinte blanchâtre, rayonne avec un légère intensité.
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
                            Console.WriteLine("Tavernier - Oui de suite....mais ne créer pas d'embrouille dans mon auberge par pitié");
                            e.Bourse = e.Bourse - 15;
                            Console.WriteLine($"Il vous reste {e.Bourse}");
                            Game.Transition<AubergeE>();


                            break;


                    }




                    break;

            }





        }



    }
}
