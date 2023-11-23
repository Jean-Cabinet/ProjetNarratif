using System.Timers;
using System;
using ProjetNarratif.Quête;
using System.Diagnostics;
using System.Threading;

namespace ProjetNarratif.Quests
{


    internal class Riddle : Quest
    {
        public static Random random = new Random();
        internal static Stopwatch timer = new Stopwatch();





        internal static bool griffure;

        internal override string CreateDescription() =>
@"Edvard chevauchant son cheval se mit en route vers le lieu de l'attaque,
éspérant trouver plus d'indices qui pourrait l'aider dans sa quête.
Edvars de Ragn - Il ne m'a guère appris ce maraud.
Une fois arrivé à [forêt],Edvars décendit de son cheval, l'odeur de vielle charogne décomposé, enivra les narives de notre Croiseleur.
De plus, le vent s'était levé, brouillant la posibilité de suivre un piste par l'odorat";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l)
        {
            string choix = "";
            switch (choice)
            {
                case "forêt":
                    Console.WriteLine("Edvars de Ragn - L'odeur des cadavres ne m'avait pas manqué, espèrons que ça n'a pas attiré de nécrophages. humm...difficile de se fier à mes sens d'odorats pour trouver la piste du camp");
                    Thread.Sleep(1000);
                    Console.WriteLine("Edvars de Ragn - J'apperçois des traces de [sang] au loin et des [griffures] sur les tronc");
                    if (griffure)
                    {
                        Console.WriteLine("Edvars de Ragn - Suivons les traces de [sang]");
                    }

                    break;
                case "Sang":
                    Console.WriteLine("Edvars de Ragn - nous y voilà,mais je ne suis pas seul visiblement , voy....");
                    Thread.Sleep(500);
                    Console.WriteLine("A peine, il eut le temps de se pencher sur une preuve, qu'il se fit attaquer par deux nécrophage.Il esquiva avec une roulade parfaitement executé pour avoir les deux [goules] dans son champ de vision");




                    break;
                case "griffures":
                    Console.WriteLine("Edvars de Ragn - Ces griffures semble mené à rien, en les regardant de plus près, c'est une meute de 2 ou 3 loups, et ce n'est surement pas eux qui ont cosé se raffut");
                    Thread.Sleep(500);
                    Console.WriteLine("Edvars de Ragn - je ferais mieux de rebrousser chemin jusqu'à l'entrée de la [forêt]");
                    griffure = true;
                    break;

                case "goules":

                    Console.WriteLine("Edvars de Ragn - Ce sont des goules, j'aurais du m'en douter que les cadavres les attiraient.");
                    Thread.Sleep(1500);
                    Console.WriteLine("Les goules décidairent d'attaquer en coordonnant leur coups de griffes.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Choisissez une action dans le temps imparti : [roulade],[ sort fous],[esquiver]");
                    Console.ReadKey();
                    Console.WriteLine("1");
                    Thread.Sleep(1000);
                    Console.WriteLine("2");
                    Thread.Sleep(1000);
                    Console.WriteLine("3");
                    Thread.Sleep(1000);
                    Console.WriteLine("4");
                    Thread.Sleep(1000);
                    Console.WriteLine("5");
                    timer.Start();
                    choix = Convert.ToString(Console.ReadLine());
                    timer.Stop();
                    TimeSpan res = timer.Elapsed;
                    double resu = res.TotalSeconds;
                    if (resu < 5)
                    {
                        switch (choix)
                        {
                            
                            case "roulade":
                                
                                string attaque = "";
                                Console.WriteLine("Edvars fit une roulade sur le coté afin d'esquiver mais il était trop exentré pour porter un coup de flamberge");
                                Thread.Sleep(1000);
                                Console.WriteLine("Choisissez une action dans le temps imparti : [ignis],[se rapprocher/coup d'épee]");
                                Console.ReadKey();
                                Console.WriteLine("1");
                                Thread.Sleep(1000);
                                Console.WriteLine("2");
                                Thread.Sleep(1000);
                                Console.WriteLine("3");
                                Thread.Sleep(1000);
                                Console.WriteLine("4");
                                Thread.Sleep(1000);
                                Console.WriteLine("5");
                                timer.Start();
                                attaque = Convert.ToString(Console.ReadLine());
                                timer.Stop();
                                TimeSpan re = timer.Elapsed;
                                double ret = re.TotalSeconds;
                                if(ret < 5)
                                {
                                    
                                    switch (attaque) 
                                    {

                                        case "ignis":

                                            Console.WriteLine("Edvars de Ragn - Ignis !!!!!.");
                                            Console.WriteLine("Edvars de Ragn - une vague de flamme surgit de la main ce qui permit de repousser et brû^ler les goules et de créer une distraction " +
                                                " pour  Edvars puisse se glisser derrire eux  pour asséner le coup mortel.");



                                            break;
                                        case "[se rapprocher/coup d'épee]":
                                            
                                            string boubou = "";

                                            Console.WriteLine("les deux goules esquiva l'attaque avec faciliter");
                                            Console.WriteLine("Edvars de Ragn - Fait chier, je vais essayer un sort de [bouclier] et foncer dans le tas");
                                            Console.ReadKey();
                                            Console.WriteLine("1");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("2");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("3");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("4");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("5");
                                            timer.Start();
                                            boubou = Convert.ToString(Console.ReadLine());
                                            timer.Stop();
                                            TimeSpan sum = timer.Elapsed;
                                            double summ = sum.TotalSeconds;
                                            {
                                                switch (boubou)
                                                {
                                                    case "bouclier":
                                                        Console.WriteLine(" Les goules fut surpris pas sa rapidité à peine elle eue le temps de réagir, que leur tête furent tranché");
                                                        Game.Transition<SuiteRiddle>();
                                                        break;
                                                        
                                                }
                                                
                                            }
                                            if(summ > 5)
                                            {
                                                int randomAttaque = random.Next(1,1);
                                                if (randomAttaque == 1)
                                                {
                                                    Console.WriteLine("Edvars eu un moment d'hésitation, lorsque qu'il asséna son coup d'épée. La deuxième goule eu le temps de riposter avec un coup de griffe.");
                                                    Console.WriteLine("Heuresement, Edvars avait activé son sort de bouclier et pu coninuer d'asséner son coup d'épée");
                                                }
                                               
                                            }
                                                  



                                            break;
                                    }


                                }
                                if(ret > 5)
                                {
                                    int randomAttaque = random.Next(1, 3);
                                    if (randomAttaque == 1)
                                    {

                                        Console.WriteLine("Edvars de Ragn - Ignis !!!!!.");
                                        Console.WriteLine("Edvars de Ragn - une vague de flamme surgit de la main ce qui permit de repousser les goules et de créer une distraction " +
                                            " pour  Edvars puisse se glisser derrire eux  pour asséner le coup mortel.");
                                        Game.Transition<SuiteRiddle>();
                                    }
                                    if (randomAttaque == 2)
                                    {
                                        string boubou = "";

                                        Console.WriteLine("les deux goules esquiva l'attaque avec faciliter");
                                        Console.WriteLine("Edvars de Ragn - Fait chier, je vais essayer un sort de [bouclier] et foncer dans le tas");
                                        Console.ReadKey();
                                        Console.WriteLine("1");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("2");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("3");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("4");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("5");
                                        timer.Start();
                                        boubou = Convert.ToString(Console.ReadLine());
                                        timer.Stop();
                                        TimeSpan sum = timer.Elapsed;
                                        double summ = sum.TotalSeconds;
                                        if (summ < 5)
                                        {
                                            switch (boubou)
                                            {
                                                case "bouclier":
                                                    Console.WriteLine(" Les goules fut surpris pas sa rapidité à peine elle eue le temps de réagir, que leur tête furent tranché");
                                                    Game.Transition<SuiteRiddle>();
                                                    break;

                                            }

                                        }
                                        if (summ > 5)
                                        {
                                            int randomDef = random.Next(1, 1);
                                            if (randomDef == 1)
                                            {
                                                Console.WriteLine("Edvars eu un moment d'hésitation, lorsque qu'il asséna son coup d'épée. La deuxième goule eu le temps de riposter avec un coup de griffe.");
                                                Console.WriteLine("Heuresement, Edvars avait activé son sort de bouclier et pu coninuer d'asséner son coup d'épée");
                                                Game.Transition<SuiteRiddle>();
                                            }

                                        }

                                    }
                                    
                                }

                                break;
                            case "sort fous":

                                Console.WriteLine("Edvars de Ragn - Fous !!!!!.");
                                Console.WriteLine("Edvars de Ragn - un déferlement d'un puissance projeta les goules sur un énorme rocher situé derrière eux " +
                                    " Edvars profita de que les goules soit étourdit pour leur asséner le dernier coup.");
                                Game.Transition<SuiteRiddle>();

                                break;

                            case "esquiver":

                                Console.WriteLine("Edvars de Ragn - D'un simple pas de coté d'une agilité et d'une vitesse digne d'un félin, il se metta en position pour asséner une riposte qui coupa la tete des deux goules en l'air.");
                                Game.Transition<SuiteRiddle>();
                                break;

                        }
                    }
                    if (resu > 5)
                    {
                        int randomAttaque = random.Next(1, 4);
                        if (randomAttaque == 1)
                        {
                            string boubou = "";

                            Console.WriteLine("les deux goules esquiva l'attaque avec faciliter");
                            Console.WriteLine("Edvars de Ragn - Fait chier, je vais essayer un sort de [bouclier] et foncer dans le tas");
                            Console.ReadKey();
                            Console.WriteLine("1");
                            Thread.Sleep(1000);
                            Console.WriteLine("2");
                            Thread.Sleep(1000);
                            Console.WriteLine("3");
                            Thread.Sleep(1000);
                            Console.WriteLine("4");
                            Thread.Sleep(1000);
                            Console.WriteLine("5");
                            timer.Start();
                            boubou = Convert.ToString(Console.ReadLine());
                            timer.Stop();
                            TimeSpan sum = timer.Elapsed;
                            double summ = sum.TotalSeconds;
                            if (summ < 5)
                            {
                                switch (boubou)
                                {
                                    case "bouclier":
                                        Console.WriteLine(" Les goules fut surpris pas sa rapidité à peine elle eue le temps de réagir, que leur tête furent tranché");
                                        Game.Transition<SuiteRiddle>();
                                        break;

                                }

                            }
                            if (summ > 5)
                            {
                                int randomDef = random.Next(1, 1);
                                if (randomDef == 1)
                                {
                                    Console.WriteLine("Edvars eu un moment d'hésitation, lorsque qu'il asséna son coup d'épée. La deuxième goule eu le temps de riposter avec un coup de griffe.");
                                    Console.WriteLine("Heuresement, Edvars avait activé son sort de bouclier et pu coninuer d'asséner son coup d'épée");
                                    Game.Transition<SuiteRiddle>(); 

                                }

                            }
                        }
                        if (randomAttaque == 2)
                        {
                            Console.WriteLine("Edvars de Ragn - Fous !!!!!.");
                            Console.WriteLine("Edvars de Ragn - un déferlement d'un puissance projeta les goules sur un énorme rocher situé derrière eux " +
                                " Edvars profita de que les goules soit étourdit pour leur asséner le dernier coup.");
                            Game.Transition<SuiteRiddle>();
                        }
                        if (randomAttaque == 3)
                        {
                            Console.WriteLine("Edvars de Ragn - D'un simple pas de coté d'une agilité et d'une vitesse digne d'un félin, il se metta en position pour asséner une riposte qui coupa la tete des deux goules en l'air.");
                            Game.Transition<SuiteRiddle>();
                        }
                    }


                    break;



                default:
                    Console.WriteLine("Commande invalide.");
                    break;





            }
        }
    }
}
