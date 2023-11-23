using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Dilemme : Quest
    {
        internal override string CreateDescription() =>
  @"Edvars, exténué du combat se laissa tomber au sol avant de sacrifier le corps du leshen, il rigola car pour une  première quête ce n'etait pas de tout repos et il l'avait réussit.
A peine, il eut le temps de levé la tête qu'il voit le cadavre du leshen  se décomposer, pour laisser place à un corps d'un homme.
Edvars se leva en sursaut et ne comprena pas ce qu'il se passa. Il entenda au loin les gémissments de l'Homme qui suppliait à l'aide. Edvars alla le voir:
Edvar de Ragn - Qui etes vous ? ou est passé le cadavre du leshen à sacrifier ?
???????- S'il vous plaît ne me sacrifier pas, épargner moi ayez pitié. L'homme répéta sans arret cette phrase sans jamais répondre au question d'edvars.
Edvars de Ragn - J'ai peur de comprendre ce que ça signifie.....
[S],[E]
";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {
            switch (choice)
            {
                case "S":

                    Console.WriteLine("Edvars planta son épée dans le corps de l'homme, celui-ci cria à l'agonie tout en suppliant edvars d'arrêter");
                    Thread.Sleep(2000);
                    Console.WriteLine("Edvars de Ragn - Tais-toi, et crève");
                    Console.WriteLine("??????-AHAAHAHAHAHAHAHAHHA");
                    Console.ReadKey();
                    Console.ReadKey();
                    Console.ReadKey();
                    Console.ReadKey();
                    Console.WriteLine("l'épée d'edvars aspira une énergie noir qui émana du corps de l'homme jusqu'à disparaisse");
                    Game.Transition<Sacrifier>();

                    break;

                case "E":

                    Console.WriteLine("Edvars se baissa au niveau de l'homme et à l'aide son épée, il lui influa une énergie blanche");
                    Thread.Sleep(2000);
                    Console.WriteLine("L'homme se releva et remercia edvars");
                    Console.WriteLine("??????- Merci, comme puis-je vous remerciez ?");
                    Console.WriteLine("Edvars ne répondit pas et se retourna pour aller chercher sa prime");
                    Game.Transition<Epargner>();

                    break;




            }



        }
    }
}
