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
 @"Une fois dans sa chambre, edvars déposa son matériel au sol. Il repensa à cette quête, tout en regardant son arme
     qui avait changer de teinte....Edvars se leva et prenna son épée. Il sentit une puissance envahir son bras droit
     celui - ci se mit à muter légérement comme une sorte de peau d'un noir sombre parcouru de veines d'un rouge sanguinolant recouvrit l'avant bras d'Edvars.
     Edvars cria, il sentit l'ame du monstre qu'il avait sacrifier lui parourir le bras.
      Edavrs de Ragn - *soupir avec un souflle coupé*, qu'est ce que ?.......
      Edvars vit son bras et le regarda avec attention, il sentit son coeur battre dans son avant-bras. Edvars entendit plusieurs pas de diriger vers sa chambre.
      Il prena ses affaires et quitta l'auberge par le fenêtre et partit avec son [cheval]. ";
        
        internal override void ReceiveChoice(string choice, Edvars e)
        {
           
            switch (choice)
            {
                case "cheval":
                    e.levelSacrifice = e.levelSacrifice + 1;
                    Console.WriteLine($"vous avez atteint le niveau {e.levelSacrifice} en sacrifice");
                    e.Attaqueignis = e.Attaqueignis + 5;
                    e.Attaquefrostis = e.Attaquefrostis + 5;
                    Console.WriteLine($"Vos sortilèges offensif sont plus puissant : Ignis est passé de 5 à {e.Attaqueignis} et frostis est passé de 5 à {e.Attaquefrostis}");
                    e.compétences = new CompétenceSacrifice("Mort destinée", @"Edvars à l'aide de sa flamberge libère le pouvoir des ames emprisonner dans son arme,
                    en plongeant l'épée dans le sol pour invoquer une myriade de lames. En plus d'infliger des dégâts immédiats, cette attaque réduit la défense de la cible pendant un instant.", 20);
                    Console.WriteLine($"Vous apprenez une nouvelle compétence Mort destinée : {e.compétences} ");

                    Console.WriteLine("Edvars de Ragn - Direction la capitale de berg. Ya au galop");


                    break;





            }



        }
    }






}

