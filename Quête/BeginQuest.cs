using ProjetNarratif.Quête;

namespace ProjetNarratif.Quests
{
    internal class BeginQuest : Quest
    {
        //ajout mécanique RPG niveaux sacrifice et épargnement + iventaire + bourse + etc
        internal override string CreateDescription() =>
@"////////////////////////////////////////PROLOGUE///////////////////////////////////////////////////////////////////
Jadis, notre monde se mêla à un autre, lors d'un cataclysme que les érudits
 appellent la Conjonction des Sphères.Ceci permirent à des forces impies de se déverser notre monde.
Le résultat de cataclysme fut cette force abjecte appelée magie, que l'on préférer étudier pour en tirer profit plutôt que bannir.
Quant au monstres à nos porte, nous avons préférer laisser se fardeaux à d'autres.
Ces fameux Avalonien...,  des guildes qui  s'occupe de prendre des enfants perdus qu'ils corrompent par une ignoble magie, leurs corps déformés par des rituels impies,
Alors qu'ils ne distinguent même pas le bien du mal.
Vous...Vous faites partie de la guilde d'Avalon, l'une des pires..............votre mission est juste d'éradiquer les monstres de votre espèce.
Vous etes un tout nouveaux croiseleurs, vous etes affecté à votre toutes premiers mission. un seul mode d'ordre aucun monstre ne doit survivre.
////////////////////////////////////////////////////////FIN DU PROLOGUE/////////////////////////////////////////////
///////////////////////////////////////////////////////DÉBUT QUETE/////////////////////////////////////////////////
 Edvard de Ragn- Bonjour, je viens pour le contrat, c'est vous Régisse chèvre ?
 Régisse Chèvre - Casse-toi le monstre !!
 Edvard de Ragn - [menace], [sort], [lui dire bon vent]";


        internal override void ReceiveChoice(string choice,Edvars e, Leshen l)
        {
            switch (choice)
            {
                case "menace":
                    Console.WriteLine(" Edvard de Ragn - Si je serais vous, je parlerais sur un autre ton, si vous ne voulez pas que votre tete me serve de récompense en plus de ma prime.");
                    Console.WriteLine(" Régisse Chèvre - oh doucement, c'était une petit blague de rien du tout, et oui c'est moi qui est déposé de contrat, vous allez nous en débarrasser n'est-ce pas ?");
                    Thread.Sleep(1000);
                    Console.WriteLine(" Edvard de Ragn - très bien, dites moi ce que vous savez sur cette attaque (je me suis laisser un peu emporté, évitons de mentionner la prime maintenant, j'ai besoin de se travail).");
                    Thread.Sleep(2000);
                    Game.Transition<Pnj>();

                    break;

                case "sort":

                    Console.WriteLine("Edvard de Ragn - Vos paupières sont lourdes, maintenant dites-moi ce que vous savez sur l'attaque");
                    Thread.Sleep(2000);
                    Console.WriteLine("Régisse chèvre - On était avec les gars, on coupait du bois non loin dans la foret de Borneval, et Fabriste est allé pisser, quand tout à cas, j'ai entendu crier.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Régisse chèvre - Après ça on a juste vu des yeux rouges dans la pénombre du bois, alors on s'est mis à courir, mais j'en suis le seul rescapé");
                    Game.Transition<Primehypno>();
                    break;

                case "lui dire bon vent":

                    Console.WriteLine("Edvard de Ragn - Très bien, alors, bon vent");
                    Thread.Sleep(2000);
                    Console.WriteLine("Régisse chèvre - Non revenez, c'était qu'une petite boutade d'acueil, on voit pas tous les jours des gens de votre genre");
                    Thread.Sleep(3000);
                    Console.WriteLine("En voilà une façon d'accuellir, à mon tour maintenant, et si nous parlions de ma prime");
                    Thread.Sleep(2000);
                    Game.Transition<Prime>();


                    break;


                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
