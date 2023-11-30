using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class CampementE : Quest
    {
        internal override string CreateDescription() =>
     @"Après c'etre fait expulsé de l'auberge, Edvars cherchait un coin paisible pour dormir à la belle étoile.
       Au bord du feu de camp, Edvars regarda les flammes du feu, repensait à son action et ce que cela impliquait d'etre un renégat. 
       Il serait pourchassé par un groupe chevronnée de croiseleurs envoyé par la guilde d'Avalon. Edvars reporta son regard sur son épée.
       La flamberge etait devenu d'un acier blanc éclatant presque lumineux après avoir sauvé leshen.Edvars prenna son arme et sentit une puissance envahir son bras droit
     celui - ci se mit à muter légére, une sorte d'écaille d'une pureté rayonnate recouvrit l'avant bras d'Edvars
      Edavrs de Ragn - Hmm... intéressant, il semblerait que cette épée soit plus que ce que je ne pensais. 
      Je me demande si je continuais à épargner ce monstre si mon arme et mon bras vont continuer de changer.
      Edavrs de Ragn - Il faut que je dorme, le voyage sera long demain.
      A l'aube du matin, edvars sentint une groupe de personne se rappocher de lui, il continua de faire semblant de dormir. [combat]";

        internal override void ReceiveChoice(string choice, Edvars e)
        {
            switch (choice)
            {
                case "combat":

                    e.levelEpargner = e.levelEpargner + 1;
                    Console.WriteLine($"vous avez atteint le niveau {e.levelEpargner} en épargnement");
                    e.PVEdvars = e.PVEdvars + 5;
                    e.absorptionquen = e.absorptionquen + 5;
                    Console.WriteLine($"Votre sortilège de bouclier absorbe plus dé dégats : {e.absorptionquen}");
                    Console.WriteLine($"Vos nombres de point de vie, on augmenter de 5 est passe à {e.PVEdvars}");
                    e.compétences = new CompétenceSacrifice("Jugement destinée", @"libère  le pouvoir des purificateur dans son arme, en plongeant l'épée dans le sol pour invoquer une myriade de lames. 
                     En plus d'infliger des dégâts immédiats, cette attaque augmente la défense du personnage pendant un long moment.", 20);
                    Console.WriteLine($"Vous apprenez une nouvelle Jugement destinée : {e.compétences} ");
                    Thread.Sleep(2000); 









                    break;


            }



        }







    }
}
