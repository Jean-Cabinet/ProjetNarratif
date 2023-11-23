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
         soit parmis les hommes ou la guilde d'avalon. Conservant les marques sur son corps de son échec et de son passé. Ces personnes là finissent par devenir ronin,
         qui essaye après leur échec se voir faire accepter pour faire un contrat, n'étant plus affilié à aucune guilde. Il peuvent se retransformer en monstre si cette de ronin
         les pousse ans leur derniers retranchement.
         Edvars de Ragn -  Gwynbleidd.....elle a pris une teinte blanchâtre, rayonne avec un légère intensité
         Edvars de Ragn - Je devrais me reposer ce combat m'a épuisé, allons à l'auberge dans ce village.";
        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {





        }



    }
}
