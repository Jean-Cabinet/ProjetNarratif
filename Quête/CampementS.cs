﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class CampementS : Quest
    {
        internal override string CreateDescription() =>
     @"Après c'etre fait expulsé de l'auberge, Edvars cherchait un coin paisible pour dormir à la belle étoile.
       Au bord du feu de camp, Edvars regarda les flammes du feu, repensait à son action, il entendit des voix émanée de son épée, on aurait dit  les plaintes du leshen....
       . Un bruit de coeur qui bat s'intensifia dans l'esprit d'edvars, en regardant son épée. Il décida de la prendre en main.
       La flamberge etait devenu d'un acier noir sinistre refletant un rouge sanguinolant.Edvars prenna son arme et sentit une puissance envahir son bras droit,
     celui - ci se mit à muter légére, une sorte de peau d'un noir sombre parcouru de veines d'un rouge sanguinolant recouvrit l'avant bras d'Edvars.
      Edvars cria, il sentit l'ame du monstre qu'il avait sacrifier lui parourir le bras.
      Edavrs de Ragn - *soupir avec un souflle coupé*, qu'est ce que ?.......
      Edvars vit son bras et le regarda avec attention, il sentit son coeur battre dans son avant-bras.
      Edvars ne ferma pas les yeux du soir, obnubiler par son avant-bras et les battements de coeur dans son bras qui le lançait.
      A l'aube du matin, edvars sentit une groupe de personne se rappocher de lui, il faisa semblant de dormir. [combat]";

        internal override void ReceiveChoice(string choice, Edvars e)
        {
           switch(choice)
           {

                case "combat":

                    e.levelSacrifice = e.levelSacrifice + 1;
                    Console.WriteLine($"vous avez atteint le niveau {e.levelSacrifice} en sacrifice");
                    e.Attaqueignis = e.Attaqueignis + 5;
                    e.Attaquefrostis = e.Attaquefrostis + 5;
                    Console.WriteLine($"Vos sortilèges offensif sont plus puissant : Ignis est passé de 5 à {e.Attaqueignis} et frostis est passé de 5 à {e.Attaquefrostis}");
                    e.compétences = new CompétenceSacrifice("Mort destinée", @"Edvars à l'aide de sa flamberge libère le pouvoir des ames emprisonner dans son arme,
                    en plongeant l'épée dans le sol pour invoquer une myriade de lames. En plus d'infliger des dégâts immédiats, cette attaque réduit la défense de la cible pendant un instant.", 20);
                    Console.WriteLine($"Vous apprenez une nouvelle compétence Mort destinée : {e.compétences} ");







                    break;



           }



        }





    }
}
