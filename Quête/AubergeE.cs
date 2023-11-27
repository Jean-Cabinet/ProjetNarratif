using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class AubergeE : Quest
    {
        internal override string CreateDescription() =>
     @"Une fois dans sa chambre, edvars déposa son matériel au sol. Il repensa à cette quête, tout en regardant son arme
     qui avait changer de teinte....Edvars se leva et prenna son épée. Il sentit une puissance envahir son bras droit
     celui - ci se mit à muter légére comme une sorte d'écaille d'un pureté rayonnate recouvrit l'avant bras d'Edvars
      Edavrs de Ragn - Hmm... intéressant, il semblerait que cette épée soit que ce que je le pensais. 
      Je me demande si je continuais à épargner ce monstre si mon arme et mon bras vont continuer de changer.
      Edavrs de Ragn - Sortons, je n'arriverais à dormir de toutes évidence.[dehors]";

        internal override void ReceiveChoice(string choice, Edvars e)
        {
            e.levelEpargner = e.levelEpargner + 1;
            Console.WriteLine($"vous avez atteint le niveau {e.levelEpargner} en épargnement");
            e.PVEdvars = e.PVEdvars + 5;
            e.absorptionquen = e.absorptionquen + 5;
            Console.WriteLine($"Votre sortilège de bouclier absorbe plus dé dégats : {e.absorptionquen}");
            Console.WriteLine($"Vos nombres de point de vie, on augmenter de 5 est passe à {e.PVEdvars}");
            e.compétences = new CompétenceSacrifice("Jugement destinée", @"libère  le pouvoir des purificateur dans son arme, en plongeant l'épée dans le sol pour invoquer une myriade de lames. 
             En plus d'infliger des dégâts immédiats, cette attaque augmente la défense du personnage pendant un long moment.", 20);
            Console.WriteLine($"Vous apprenez uen nouvelle Jugement destinée : {e.compétences} ");
            switch (choice)
            {
                case "dehors":

                    Console.WriteLine("Sans un bruit edvars sortit de l'auberge et prena son cheval en direction de la prochaine ville, Berg.");


                    break;





            }



        }
    }
}
