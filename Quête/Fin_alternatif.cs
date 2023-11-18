using ProjetNarratif.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Fin_alternatif : Quest
    {
        internal override string CreateDescription() =>
  @"                                         VOUS ETES MORT
Edvars avait le présentiment que son erreur dans l'identification du monstre, pourrais lui coter la vie.........
 Je pensais que vous auriez été meilleure.......Ce n'est pas comme ça que vous allez tuer Aldagusar voyons.......
  reprenons à la page Glossaire et tâchez de bien choisir le Leshen";

        internal override void ReceiveChoice(string choice)
        {
            Game.Transition<Glossaire>();

        }
    }
}
