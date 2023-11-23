using ProjetNarratif.Quête;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quests
{
    internal class Prime : Quest
    {
        internal override string CreateDescription() =>
@"////////////////////////////PRIME/////////////////////////////////////////////////
Tout bon Croiseleur se doit de évoquer la question de la prime, et oui les temps sont dur.
///////////////////////////////////////////////////////////////////////////////////

 Edvard de Ragn - Disons [100 écu] de plus, pour le manque d'acceuil";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l, Nécrophages n)
        {
            switch (choice)
            {
                case "100 écu":

                    Console.WriteLine("Régisse chèvre - Vous rigolez, c'est toutes mes économies, je préfère appeler quelqu'un d'autre que vous si vous ne baissez pas");
                    Thread.Sleep(1000);
                    Console.WriteLine(" Edvard de Ragn - Très bien passons, je ne veux plus me fatigué avec vous, va pour [50 écu]");


                    break;
                case "50 écu":

                    Console.WriteLine("Régisse chèvre - Marché conclu, ma foie");
                    e.Prime();
                    Game.Transition<Pnj>();

                    break;
               
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }



    }
}
