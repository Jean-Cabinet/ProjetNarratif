using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class RencontreS : Quest
    {


        internal override string CreateDescription() =>
@"Une fois les nécrophages tué, Edvars repris la route en direction de la capitale de Berg. Sur la route, il croisa un marchand ambulant probablement un herboriste.
  Si tels était le cas, edvars devait s'arréter pour acheter des fournitures pour ses potions et ses huiles.[herboriste]"""
;

        internal override void ReceiveChoice(string choice, Edvars e)
        {
            Marchand mch = new Marchand();
            Item item = new Item();
            Alcahest A = new Alcahest("Alcahest", "alcool", 2, 5);
            Mandragore M = new Mandragore("Mandragore", "plante", 2, 10);
            switch (choice)
            {
                case "herboriste":

                    Console.WriteLine("Edvars de Ragn - Bonjour, seriez-vous un herboriste, si oui j'aimerais vous acheter quelque articles ?");
                    Console.WriteLine("Je vois que monsieur le croiseleur à l'oeil.., très bien, jettez y un coup d'oeil");

                    mch.inventairemarchand.See(item);
                    Console.WriteLine($"Le marchand possède une bourse de {mch.bourse} Florins");
                    Console.WriteLine($"Vous possédez {e.Bourse} florins dans votre bourse");
                    Console.WriteLine("Que vous-voulez vous acheter ?[alcahest],[mandragore],[les deux]");
                    string réponse = Convert.ToString(Console.ReadLine());
                    switch (réponse)
                    {
                        case "alcahest":
                            Console.WriteLine("Edvars de Ragn - très bien, je vais vous prendre vos deux alcahest ");
                            Console.WriteLine("Marchand - Pas de problème, ceci vous fera 10 florins");
                            e.AchatA(A, e);
                            mch.inventairemarchand.SubA(item, A, mch);
                            e.inventaire.Add(A);
                            e.inventaire.See(item);
                            Console.WriteLine("Edvars de Ragn - Bon vent, merci");
                            Console.WriteLine("Marchand - J'aimerais en dire autant pour vous, au revoir");

                            Console.WriteLine(@"Edvars regarda le marchand s'en aller après sa réponse plus que mystérieuse, celui comme un un claquement de doigts disparut comme par magie.");
                            Console.WriteLine(@"Edvars de Ragn - Hmmmm...... direction berg");
                            Game.Finish();

                            break;

                        case "mandragore":

                            Console.WriteLine("Edvars de Ragn - très bien, je vais vous prendre vos deux mandragores ");
                            Console.WriteLine("Marchand - Pas de problème, ceci vous fera 20 florins");
                            e.AchatM(M, e);
                            mch.inventairemarchand.SubM(item, M, mch);
                            e.inventaire.Add(M);
                            e.inventaire.See(item);
                            Console.WriteLine("Edvars de Ragn - Bon vent, merci");
                            Console.WriteLine("Marchand - J'aimerais en dire autant pour vous, au revoir");

                            Console.WriteLine(@"Edvars regarda le marchand s'en aller après sa réponse plus que mystérieuse, celui comme un un claquement de doigts disparut comme par magie.");
                            Console.WriteLine(@"Edvars de Ragn - Hmmmm...... direction berg");
                            Game.Finish();


                            break;

                        case "les deux":


                            Console.WriteLine("Edvars de Ragn - très bien, je vais vous prendre vos alcahests et vos mandragores ");
                            Console.WriteLine("Marchand - Pas de problème, ceci vous fera 30 florins");
                            e.AchatMA(M, e, A);
                            mch.inventairemarchand.SubD(item, A, M, mch);
                            e.inventaire.Add(A);
                            e.inventaire.Add(M);
                            e.inventaire.See(item);
                            Console.WriteLine("Edvars de Ragn - Bon vent, merci");
                            Console.WriteLine("Marchand - J'aimerais en dire autant pour vous, au revoir");

                            Console.WriteLine(@"Edvars regarda le marchand s'en aller après sa réponse plus que mystérieuse, celui comme un un claquement de doigts disparut comme par magie.");
                            Console.WriteLine(@"Edvars de Ragn - Hmmmm...... direction berg");
                            Game.Finish();

                            break;





                    }


                    break;





            }








        }
    }
}
