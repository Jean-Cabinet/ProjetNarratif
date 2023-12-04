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
            Chasseur ch = new Chasseur();


            switch (choice)
            {

                case "combat":

                    e.levelEpargner = e.levelEpargner + 1;
                    Console.WriteLine($"vous avez atteint le niveau {e.levelEpargner} en épargnement");
                    e.PVEdvars = e.PVEdvars + 5;
                    e.absorptionquen = e.absorptionquen + 5;
                    Console.WriteLine($"Votre sortilège de bouclier absorbe plus dé dégats : {e.absorptionquen}");
                    Console.WriteLine($"Vos nombres de point de vie, on augmenter de 5 est passe à {e.PVEdvars}");
                    e.compétences = new CompétenceEpargner("Jugement destinée", @"libère  le pouvoir des purificateur dans son arme, en plongeant l'épée dans le sol pour invoquer une myriade de lames. 
                     En plus d'infliger des dégâts immédiats, cette attaque augmente la défense du personnage pendant un long moment.", 20);
                    Console.WriteLine($"Vous apprenez une nouvelle Jugement destinée : {e.compétences} ");
                    Thread.Sleep(2000);

                    do
                    {

                        bool brulure = false;
                        bool bouclier = false;
                        bool compétence = false;
                        string AttaqueEdvars = "";
                        string DéfenseEdvars = "";
                        Console.WriteLine("Que voulez-vous faire ?[Attaque],[Défense],[Riposte],[Hirondelle]");
                        if (choice == "Attaque")
                        {
                            Console.WriteLine("Que voulez-vous faire ?[Coupépée],[Jugement destinée]");
                            AttaqueEdvars = Convert.ToString(Console.ReadLine());
                        }
                        if (choice == "défense")
                        {
                            Console.WriteLine("Que voulez-vous faire ?[sort Bouclier],[Roulade]");
                            DéfenseEdvars = Convert.ToString(Console.ReadLine());
                        }

                        int choiceChasseur = new Random().Next(2, 6);//changer
                                                                     //2 = défense
                                                                     //3 = Attaque
                                                                     //4 = sort
                                                                     //5 = riposte

                        if (choice == "Attaque" && choiceChasseur == 2)
                        {

                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança l'épée dans les deux mains pour attaquer le chasseur");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Le chasseur esquiva son coup avec facilité.");




                            }
                            if (choice == "Jugement destinée")
                            {
                                Console.WriteLine(@"L'épée d'edvars s'illumina, à deux mains, il fit un premier un coup de haut en bas pour trancher le chasseur, puis dans une rapidité déconsertante
                                 planta son arme dans le sol, une myraide de lames tournoyait tout autour de lui");
                                Console.WriteLine(" le chasseur esquiva l'attaque de justesse.");
                                Console.WriteLine("Votre défense augmente significativement");
                                e.défenseEdvars = e.défenseEdvars + 20;


                            }


                        }
                        if (choice == "Attaque" && choiceChasseur == 3)
                        {

                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer le renégat");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Le chasseur armé de son arc, tira une flèche qui se divisa en trois flèches ");
                                Console.WriteLine("Edvars se prit 2 fléches lors de son assaut mais déterminé à asséner son coup, il ignora la douleur. Surprenant le chasseur, il réussi à asséner son coup");
                                e.PVEdvars = e.PVEdvars - (ch.attaque - e.défenseEdvars);
                                ch.PV = ch.PV - (e.AttaqueGwynbleidd - ch.défense);


                            }



                            if (choice == "Jugement destinée")
                            {

                                Console.WriteLine("Gwynbleiff s'illumina, edvars coura avec un rapidité sans précéedente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Le chasseur armé de son arc, tira une flèche qui se divisa en trois flèches ");
                                Console.WriteLine("Edvars se prit 2 fléches lors de son assaut mais déterminé à asséner son coup, il ignora la douleur.");
                                Console.WriteLine(@"Edvars toucha une premier fois le chasseur avec le bout de sa lame, il profita par la suite pour planter son épée dans le sol
                                pour faire apparaitre le la myriade de lame. Le chasseur se prit la compétences d'edvars de plein fouet, il fut populser dans les airs.");
                                e.PVEdvars = e.PVEdvars - (ch.attaque - e.défenseEdvars);
                                e.compétences.Éxecuter(ch, e);


                            }

                        }
                        if (choice == "Attaque" && choiceChasseur == 4)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer le renégat");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Le chasseur armé de son arc, tira une flèche imprégné de flamme noir qui se divisa en quatre flèche ");
                                Console.WriteLine("Edvars se prit 3 fléches lors de son assaut mais déterminé à asséner son coup, il ignora la douleur. Surprenant le chasseur, il réussi à asséner son coup");
                                Console.WriteLine("Edavrs subit les brulures de ces flammes qui malgré la flèche retirer des plaies, le feu ccontinuai de bruler sa chair.");
                                e.PVEdvars = e.PVEdvars - (ch.flèchesifrit - e.défenseEdvars);
                                ch.PV = ch.PV - (e.AttaqueGwynbleidd - ch.défense);
                                e.PVEdvars = e.PVEdvars - ch.brulureifrit;
                            }
                            if (choice == "Jugement destinée")
                            {
                                Console.WriteLine("Gwynbleiff s'illumina, edvars coura avec un rapidité sans précéedente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Le chasseur armé de son arc, tira une flèche imprégné de flamme noir qui se divisa en quatre flèche ");
                                Console.WriteLine("Edvars se prit 3 fléches lors de son assaut mais déterminé à asséner son coup, il ignora la douleur.");
                                Console.WriteLine(@"Edvars toucha une premier fois le chasseur avec le bout de sa lame, il profita par la suite pour planter son épée dans le sol
                                pour faire apparaitre le la myriade de lame. Le chasseur se prit la compétences d'edvars de plein fouet, il fut populser dans les airs.");
                                Console.WriteLine("Edavrs subit les brulures de ces flammes qui malgré la flèche retirer des plaies, le feu ccontinuai de bruler sa chair.");
                                e.PVEdvars = e.PVEdvars - ch.flèchesifrit;
                                e.PVEdvars = e.PVEdvars - ch.brulureifrit;
                                e.compétences.Éxecuter(ch, e);
                            }


                        }
                        if (choice == "Attaque" && choiceChasseur == 5)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer le renégat");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Edvars arriva à portée pour asséner son coup");
                                Console.WriteLine("le chasseur esquiva avec rapidité et répliqua avec un flèche dans le flanc");
                                e.PVEdvars = e.PVEdvars - ch.riposte;


                            }
                            if (choice == "Jugement destinée")
                            {
                                Console.WriteLine("Gwynbleiff s'illumina, edvars coura avec un rapidité sans précéedente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Edvars arriva à portée pour asséner son coup, le chasseur esquiva se premier coup");
                                Console.WriteLine("Edvars continua l'assaut en sautant dans sa direction pour planter sa flmaberge dans le sol");
                                Console.WriteLine("le chasseur esquiva en sautant et répliqua une flèches dans chaque épaules.");
                                e.PVEdvars = e.PVEdvars - ch.riposte;

                            }


                        }

                        if (choice == "Defense" && choiceChasseur == 2)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Edvars et le Chasseur se regarda dans le blanc des yeux attendant que l'un face le premier pas");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade en pensant que le chasseur allait attaquer");
                            }


                        }
                        if (choice == "Defense" && choiceChasseur == 3)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Le bouclier d'edvars absorba les attaques du chasseur, sans aucun problème");
                                e.absorptionquen = e.absorptionquen - ch.attaque;
                                Console.WriteLine($"Votre bouclier peut absorber {e.absorptionquen}");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade pour esquiver la volée de flèche du chasseur");
                            }


                        }
                        if (choice == "Defense" && choiceChasseur == 4)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Le bouclier d'edvars absorba les attaques du chasseur, sans aucun problème");
                                e.absorptionquen = e.absorptionquen - ch.attaque;
                                Console.WriteLine($"Votre bouclier peut absorber {e.absorptionquen}");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade pour esquiver la volée de flèche du chasseur");

                            }


                        }
                        if (choice == "Defense" && choiceChasseur == 5)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Le chasseur resta sur ses gardes pret à riposter toutes éventualité d'attaque de la part d'edvars.");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Le chasseur resta sur ses gardes pret à riposter toutes éventualité d'attaque de la part d'edvars.Edvars fit une roulade de peur d'une représaille");
                            }


                        }

                        if (choice == "Riposte" && choiceChasseur == 2)
                        {

                            Console.WriteLine("Edvars observa chaque recoin, chaque mouvement pour espérer enterevoir une opportunité de riposté, mais le chasseur resta sur la défensive");

                        }
                        if (choice == "Riposte" && choiceChasseur == 3)
                        {
                            Console.WriteLine("Edvars vit avec rapidité l'attaque du chasseur, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans le flan du monstre");
                            ch.PV = ch.PV - e.riposteEdvars;


                        }
                        if (choice == "Riposte" && choiceChasseur == 4)
                        {
                            Console.WriteLine("Edvars vit avec rapidité l'attaque du chasseur, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans le flan du monstre");
                            ch.PV = ch.PV - e.riposteEdvars;
                        }
                        if (choice == "Riposte" && choiceChasseur == 5)
                        {
                            Console.WriteLine("tout deux restèrent sur ses gardes pret à riposter toutes éventualité d'attaque.");

                        }
                        if (choice == "Hirondelle" && choiceChasseur == 2)
                        {
                            Console.WriteLine("Edavrs saisit l'occasion pour boire une hirondelle afin de régénéré ses points et vie te augmenter son nombre maximun");
                            e.UseHirondelle();
                        }
                        if (choice == "Hirondelle" && choiceChasseur == 3)
                        {
                            Console.WriteLine("Edvars commença à boire son hirondelle mais le chasseur se mit à l'attaque en lui tirant une volé de flèches");
                            Console.WriteLine("Edvars esquiva de justesse  les flèches, malgré une  qui lui entailla légèrement le bras");
                            Console.WriteLine("Edvars buva rapidement sa potion pour poursuivre l'attque");
                            e.UseHirondelle();

                        }
                        if (choice == "Hirondelle" && choiceChasseur == 4)
                        {
                            Console.WriteLine("Edvars commença à boire son hirondelle mais le chasseur se mit à l'attaque en lui tirant une volé de flèches enflammé");
                            Console.WriteLine("Edvars esquiva de justesse  les flèches, malgré une  qui lui entailla légèrement le bras");
                            Console.WriteLine("Edvars buva rapidement sa potion pour poursuivre l'attaque");
                            e.UseHirondelle();

                        }
                        if (choice == "Hirondelle" && choiceChasseur == 5)
                        {
                            Console.WriteLine("Edavrs saisit l'occasion pour boire une hirondelle afin de régénéré ses points et vie te augmenter son nombre maximun");
                            e.UseHirondelle();

                        }


                    } while (e.PVEdvars != 0 || ch.PV != 0);


                    break;


            }



        }







    }
}
