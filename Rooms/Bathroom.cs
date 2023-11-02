namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
       internal static bool vapeur;
        internal override string CreateDescription() =>
@"Dans la toilette, le [bain] est rempli d'eau chaude.
Le [miroir] devant toi affiche ton visage déprimé.
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    
                    Console.WriteLine("Tu te laisses relaxer dans le bain. La vapeur monte");
                    vapeur = true;
                    
                    break;
                case "miroir":
                    if (vapeur)
                    {
                        Console.WriteLine("Tu aperçois les chiffres 9632 écrits sur la brume sur le miroir.");
                    }
                    else
                    {
                        Console.WriteLine("tu devrais te raser");
                    }
                    
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
