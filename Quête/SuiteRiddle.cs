using ProjetNarratif.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class SuiteRiddle : Quest
    {
        
        internal override string CreateDescription() =>
@"Edvars de Ragn - **bruit de respiration** bruit lame qui rentre dans son fourreau**, Bon passons aux indices.
 Devant Edvars se dresse un camp de bûcheron abandonné. Le camp se compose  d'un feu camp entourée de trois tentes avec une charette remplie de bois derrière la deuxième tentes.
 Sur le sol, on remarque plusieurs flaques de sang qui mènent vers un [cadavre].
 On peut remarquer sur les arbres des [entailles]";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {
            switch (choice)
            {
                case "cadavre":

                   Game.Transition<Cadavre>();
                    

                    break;

                case "entailles":

                    Console.WriteLine("Edvars de Ragn - l'entaille est profonde mais irrégulières, un nécrophage n'aurait pas pu faire ça, c'est surement notre monstre. Examinons cela de plus près ");
                    Thread.Sleep(1000);
                    Console.WriteLine("Edvars de Ragn - Tiens une touffe de poils, elle doit probablement venir d'une meute de loup des alentours ou bien d'un loup-garou");
                    Console.WriteLine("Edvars de Ragn se rélève et dit - Je me rapelle qu'il avait mentionné un de leur collègue qui était parti uriner et qui a délanché cette pagaille." +
                        "explorons les alentours voir si je ne trouve pas ce cadavre.");
                    Game.Transition<Riddlecadavre>();

                    break;



            }
        }




    }
}
