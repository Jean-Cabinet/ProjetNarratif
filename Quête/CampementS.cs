using System;
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
           Nécrophages n = new Nécrophages();
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
                    Thread.Sleep(2000);

                    do
                    {

                        bool brulure = false;
                        bool bouclier = false;
                        bool compétence = false;
                        string AttaqueEdvars = "";
                        string DéfenseEdvars = "";
                        Console.WriteLine("Que voulez-vous faire ?[Attaque],[Defense],[Riposte],[Hirondelle]");
                        if (choice == "Attaque")
                        {
                            Console.WriteLine("Que voulez-vous faire ?[Coupépée],[Mort destinée]");
                            AttaqueEdvars = Convert.ToString(Console.ReadLine());
                        }
                        if (choice == "défense")
                        {
                            Console.WriteLine("Que voulez-vous faire ?[sort Bouclier],[Roulade]");
                            DéfenseEdvars = Convert.ToString(Console.ReadLine());
                        }

                        int choicenécrophages = new Random().Next(2, 6);
                                                                    //2 = défense
                                                                    //3 = Attaque
                                                                    //4 = sort
                                                                    //5 = riposte

                        if (choice == "Attaque" && choicenécrophages == 2)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança l'épée dans les deux mains pour attaquer les barguests");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Les barguests esquivèrent son coup avec facilité.");

                            }
                            if (choice == "Mort destinée")
                            {
                                Console.WriteLine(@"L'épée d'edvars s'illumina, à deux mains, il fit un premier un coup de haut en bas pour trancher les barguests, puis dans une rapidité déconsertante
                                 planta son arme dans le sol, une myraide de lames tournoyait tout autour de lui");
                                Console.WriteLine(" les barguests esquiva l'attaque de justesse.");
                                Console.WriteLine("Votre défense augmente significativement");
                                n.défense = n.défense  - 10;

                            }


                        }
                        if (choice == "Attaque" && choicenécrophages == 3)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer les barguests");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("les deux bargests s'élança à leur tour, pour mordre edvars");
                                Console.WriteLine("Edvars se fit mordre au molet droit lors de son assaut mais déterminé à asséner son coup, il ignora la douleur. Surprenant les barguests, il réussi à asséner son coup");
                                e.PVEdvars = e.PVEdvars - (n.attaque - e.défenseEdvars);
                                n.PV = n.PV - (e.AttaqueGwynbleidd - n.défense);




                            }
                            if (choice == "Mort destinée")
                            {
                                Console.WriteLine("Gwynbleiff s'illumina, edvars coura avec un rapidité sans précéedente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("les deux bargests s'élança à leur tour, pour mordre edvars");
                                Console.WriteLine("Edvars se fit mordre au molet droit lors de son assaut mais déterminé à asséner son coup, il ignora la douleur.");
                                Console.WriteLine(@"Edvars toucha une premier fois un des bargests avec le bout de sa lame, il en profita par la suite pour planter son épée dans le sol
                                pour faire apparaitre  la myriade de lame. Les deux bargest se prirent la compétences d'edvars de plein fouet, ils furent populser dans les airs.");
                                e.PVEdvars = e.PVEdvars - (n.attaque - e.défenseEdvars);
                                e.compétences.Éxecuter(n, e);

                            }

                        }
                        if (choice == "Attaque" && choicenécrophages == 4)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer le renégat");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Les bargests  se mirent en position pour cracher un souffle pestilentiel, pouvant provoquer une nécrose de l'intérieur");
                                Console.WriteLine("Edvars retenit son souffle malgré la douleur, il ignora la douleur. Surprenant le chasseur, il réussi à asséner son coup");
                                Console.WriteLine("Edavrs subit la nécrose de l'attaque");
                                e.PVEdvars = e.PVEdvars - (n.soufflepesti - e.défenseEdvars);
                                n.PV = n.PV - (e.AttaqueGwynbleidd - n.défense);
                                e.PVEdvars = e.PVEdvars - n.nécrose;

                            }
                            if (choice == "Mort destinée")
                            {
                                Console.WriteLine("Gwynbleiff se transforma en une lame sombre, edvars coura avec un rapidité sans précédente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Les bargests se mirent en position pour cracher un souffle pestilentiel, pouvant provoquer une nécrose de l'intérieur");
                                Console.WriteLine("Edvars retenit son souffle malgré la douleur, il ignora la douleur.");
                                Console.WriteLine(@"Edvars toucha une premier fois un des bargests avec le bout de sa lame, il en profita par la suite pour planter son épée dans le sol
                                pour faire apparaitre la myriade de lame. Les deux bargest se prirent la compétences d'edvars de plein fouet, ils furent populser dans les airs.");
                                Console.WriteLine("Edvars subit la nécrose de l'attaque");
                                e.PVEdvars = e.PVEdvars - n.soufflepesti;
                                e.PVEdvars = e.PVEdvars - n.nécrose;
                                e.compétences.Éxecuter(n, e);

                            }

                        }
                        if (choice == "Attaque" && choicenécrophages == 5)
                        {
                            if (choice == "Coupépée")
                            {
                                Console.WriteLine("Edvars s'élança la flamberge dans les deux mains pour attaquer les deux bargests");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Edvars arriva à portée pour asséner son coup");
                                Console.WriteLine("les bargests esquivèrent avec rapidité et répliquèrent avec une morsure purtéfiante dans le flanc");
                                e.PVEdvars = e.PVEdvars - n.riposte;
                            }
                            if (choice == "Mort destinée")
                            {
                                Console.WriteLine("Gwynbleiff se transforma en une lame sombre, edvars coura avec un rapidité sans précédente pour atteindre sa cible");
                                Console.WriteLine("Edvars de Ragn - AHHHHHHHHHH");
                                Console.WriteLine("Edvars arriva à portée pour asséner son coup, les bargests esquivèrent le premier coup");
                                Console.WriteLine("Edvars continua l'assaut en sautant dans sa direction pour planter sa flamberge dans le sol");
                                Console.WriteLine("les bargests esquivèrent en attaquant sur chacun des cotée d'edvars.");
                                e.PVEdvars = e.PVEdvars - n.riposte;
                            }
                        }

                        if (choice == "Defense" && choicenécrophages == 2)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Edvars et les bargest se regardèrent dans le blanc des yeux attendant que l'un face le premier pas");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade en pensant que les bargests allait attaquer");
                            }


                        }
                        if (choice == "Defense" && choicenécrophages == 3)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Le bouclier d'edvars absorba les attaques des bargests, sans aucun problème");
                                e.absorptionquen = e.absorptionquen - n.attaque;
                                Console.WriteLine($"Votre bouclier peut absorber {e.absorptionquen}");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade pour esquiver les attaques des bargests");
                            }

                        }
                        if (choice == "Defense" && choicenécrophages == 4)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Le bouclier d'edvars absorba les attaques des bargests, sans aucun problème");
                                e.absorptionquen = e.absorptionquen - n.attaque;
                                Console.WriteLine($"Votre bouclier peut absorber {e.absorptionquen}");

                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Edvars fit une roulade pour esquiver la volée de flèche du chasseur");
                            }


                        }
                        if (choice == "Defense" && choicenécrophages == 5)
                        {
                            if (choice == "sort Bouclier")
                            {
                                Console.WriteLine("Les bargests restèrent sur leur gardes pret à riposter toutes éventualité d'attaque de la part d'edvars.");
                            }
                            if (choice == "roulade")
                            {
                                Console.WriteLine("Les bargests resta sur ses gardes pret à riposter toutes éventualité d'attaque de la part d'edvars.Edvars fit une roulade de peur d'une représaille");
                            }


                        }

                        if (choice == "Riposte" && choicenécrophages == 2)
                        {
                            Console.WriteLine("Edvars observa chaque recoin, chaque mouvement pour espérer enterevoir une opportunité de riposté, mais les bargests restèrent sur la défensive");
                        }
                        if (choice == "Riposte" && choicenécrophages == 3)
                        {
                            Console.WriteLine("Edvars vit avec rapidité l'attaque des bargests, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans la gueule putréfié des bargests");
                            n.PV = n.PV - e.riposteEdvars;

                        }
                        if (choice == "Riposte" && choicenécrophages == 4)
                        {
                            Console.WriteLine("Edvars vit avec rapidité l'attaque des bargests, puis avec agilité, il esquiva pour se replacer et asséner un coup d'épée dans la gueule putréfié des bargests");
                            n.PV = n.PV - e.riposteEdvars;

                        }
                        if (choice == "Riposte" && choicenécrophages == 5)
                        {
                            Console.WriteLine("tout restèrent sur leur gardes pret à riposter toutes éventualité d'attaque.");

                        }
                        if (choice == "Hirondelle" && choicenécrophages == 2)
                        {
                            Console.WriteLine("Edvars saisit l'occasion pour boire une hirondelle afin de régénéré ses points et vie te augmenter son nombre maximun");
                            e.UseHirondelle();

                        }
                        if (choice == "Hirondelle" && choicenécrophages == 3)
                        {
                            Console.WriteLine("Edvars commença à boire son hirondelle mais les bargests se mirent à l'attaque en courant sur edvars pour le mordrent");
                            Console.WriteLine("Edvars esquiva de justesse  les bargests.");
                            Console.WriteLine("Edvars buva rapidement sa potion pour poursuivre l'attaque");
                            e.UseHirondelle();

                        }
                        if (choice == "Hirondelle" && choicenécrophages == 4)
                        {
                            Console.WriteLine("Edvars commença à boire son hirondelle mais les bargests se mirent à l'attaque en crachant un souffle péstilentiel");
                            Console.WriteLine("Edvars esquiva de justesse  les flèches, malgré une lègère respiration, il sentit des brulures à l'intérieur de son corps.");
                            Console.WriteLine("Edvars buva rapidement sa potion pour poursuivre l'attaque");
                            e.UseHirondelle();

                        }
                        if (choice == "Hirondelle" && choicenécrophages == 5)
                        {
                            Console.WriteLine("Edavrs saisit l'occasion pour boire une hirondelle afin de régénéré ses points et vie te augmenter son nombre maximun");
                            e.UseHirondelle();

                        }
                        

                    } while (e.PVEdvars != 0 || n.PV != 0);

                    break;



           }



        }





    }
}
