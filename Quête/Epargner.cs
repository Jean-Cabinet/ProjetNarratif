using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Epargner:Quest
    {
        internal override string CreateDescription() =>
  @"Edvars se rendit au village pour récupérer sa prime.
 Régisse chèvre - Alors, vous avez abattu le monstre ?  
 Edvars de Ragn -  Oui, elle ne vous embêtera plus.
 Régisse chèvre - ahah, finalement vous etes plutot sympathique vous autres
 Régisse chèvre - Tenez, voici votre prime.[Pr]
 ";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {
            switch (choice)
            {
                case "Pr":
                    
                    Console.WriteLine("Edvars pris la prime, et s'en alla, s'en dire un mot");
                    e.Primequete();
                    Console.WriteLine("Il savait très bien que épargner un monstre, faisait de lui un renégat qui sera poursuit par des membres de sa propre guilde pour toucher la mise à prix");
                    Console.WriteLine("Edvars monta à dos de son cheval pour atteindre le prochain village pour résoudre une nouvellle contrat, en tant que rénégat et non Croiseleurs");
                    
                    break;





            }



        }
    }
}
