using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class AubergeS : Quest
    {

        internal override string CreateDescription() =>
 @"";
        
        internal override void ReceiveChoice(string choice, Edvars e)
        {
            e.compétences = new CompétenceSacrifice("Mort destinée","oui",20);
            switch (choice)
            {
                case "Pr":

                    

                    break;





            }



        }
    }






}
}
