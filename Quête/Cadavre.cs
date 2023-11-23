using ProjetNarratif.Quête;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quests
{
    internal class Cadavre : Quest
    {
        internal static bool cadavre;
        internal override string CreateDescription() =>
@" Vous vous approchez pour [examiner le cadavre]

";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {
            switch (choice)
            {      
                   
                case "examiner le cadavre":
                    if(cadavre == false)
                    {
                        Console.WriteLine("Edvars de Ragn - hmmm, visiblement mort d'un crise cardiaque et dévorer par les nécrophages au vu des entailles fines et irrégulières.");
                        Console.WriteLine("Edvars de Ragn - ça ne vas pas beaucoup m'aider pour identifier le monstre à l'origine de l'attaque de ce [camp].");
                        Game.Transition<SuiteRiddle>();
                    }
                    if(cadavre == true)
                    {
                        Console.WriteLine("Edvars de Ragn - Je redevrais retourner au camp, l'examen de ce cadavre ne m'a rien apporté");
                        Game.Transition<SuiteRiddle>();
                        
                    }

                    Game.Transition<SuiteRiddle>();
                    break;
                
                    
         
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }





    }
}
