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
        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {





        }




    }
}
