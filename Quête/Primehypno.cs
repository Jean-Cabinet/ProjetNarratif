using ProjetNarratif.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Primehypno : Quest
    {
        internal override string CreateDescription() =>
  @"////////////////////////////PRIMEhypno///////////////////////////////////////////////
Tout bon Croiseleur se doit de évoquer la question de la prime, peut importe les moyens employé.
 Edvard de Ragn - Disons [150 écu] payé d'avance, pour le manque d'acceuil";




        internal override void ReceiveChoice(string choice, Edvars e)
        {
            switch (choice)
            {
                case "150 écu":

                    Console.WriteLine("Régisse chèvre - très bien, les voici");
                    Thread.Sleep(1000);
                    Console.WriteLine(" Edvard de Ragn - Merci bien.");
                    Game.Transition<Riddle>();
                    

                    break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }







    }
}
