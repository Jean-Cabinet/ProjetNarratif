using ProjetNarratif.Quête;

namespace ProjetNarratif.Quests
{
    internal class Pnj : Quest
    {
        

        internal override string CreateDescription() =>
@"Après avoir, négocier une prime ou devoir détendre l'atmosphere, Edvard posa des questions sur la nature de [l'attaque].
";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l, Nécrophages n)
        {
            switch (choice)
            {
                case "l'attaque":
                    Console.WriteLine("Régisse chèvre - On était avec les gars, on coupait du bois non loin dans la foret de Borneval, et Fabriste est allé pisser, quand tout à cas, j'ai entendu crier.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Régisse chèvre - Après ça on a juste vu des yeux rouges dans la pénombre du bois, alors on s'est mis à courir, mais j'en suis le seul [rescapé]");
                    
                    break;
                case "rescapé":
                    Console.WriteLine("Edvard de Ragn - Vous n'avez rien vu d'autre, ne serait ce que en vous retournant durant votre course");
                    Thread.Sleep(1000);
                    Console.WriteLine("Régisse chèvre - Je n'allais tout de meme pas me retourner alors qu'un monstre me pourchassait, tout en entendant mes camarades hurler à la mort ");
                    Thread.Sleep(2000);
                    Console.WriteLine("Edvard de Ragn - C'est tout pour moi, vous n'avez vraisemblablement pu rien voir d'intéréssant, je vais me rendre sur le lieu. Bon vent");
                    Thread.Sleep(1000);
                    Console.WriteLine("le paysan fit signe à Edvard");
                    Game.Transition<Riddle>();

                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
