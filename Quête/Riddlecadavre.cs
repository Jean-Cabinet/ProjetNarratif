using ProjetNarratif.Quests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Riddlecadavre : Quest
    {
        internal static bool tête;
        internal static bool torse;
        internal static bool membres;
        internal override string CreateDescription() =>
@"Au alentour du camp, edvars vit le cadavre de leur collègue, celui-ci était dans un état déplorable.
 Examiner le [corps]
 Regarder [autour] du corps";

        internal override void ReceiveChoice(string choice, Edvars e, Leshen l, Nécrophages n)
        {
            switch (choice)
            {
                case "corps":
                    string partie = "";
                    tete:
                    ventre:
                    bras:
                    Console.WriteLine("[tête]");
                    Console.WriteLine("[torse]");
                    Console.WriteLine("[membres]");
                    Console.WriteLine("[conclusion]");
                    switch (partie)
                    {
                       
                        case "tête":
                            Console.WriteLine(" Edvars de Ragn - Contusion importante au niveau la partie droite du visage comme s'il reçut un coup de masse");
                            Thread.Sleep(2000);
                            Console.WriteLine("Edvars de Ragn - de multiples entailles fines mais peu profondes sont présentes dans le cou comme un rasoir, et elle s'étende jusqu'au torse. ");
                            goto tete;
                        break;

                        case "torse":
                            Console.WriteLine(" Edvars de Ragn - les entailles du cou continue sur le torse....un coup griffe lui arracha les l'adomen pour laisser sortir les boyaux, au vu de la coupe de la chair, on pensé que le monstres avait des griffes recourbés et très peu aguisée");
                            Thread.Sleep(2000);
                            Console.WriteLine("Edvars de Ragn - on peut exclure la piste d'une brouxe ou d'un vampires inférieurs");
                            goto ventre;
                            break;

                        case "membres":
                            Console.WriteLine(" Edvars de Ragn - il possède aussi entailles que sur le cou et le torse au niveaux des membres");
                            Thread.Sleep(2000);
                            Console.WriteLine("Edvars de Ragn - Tiens.. il a une racine planté dans la cuisse..........bizarre");
                            goto bras;


                            break;

                        case "conclusion":
                            
                            if(tête == true || torse == true || membres == true)
                            {
                                Console.WriteLine("Edvars de Ragn - Récapitulons **tout en relevant**... Nous avons de multiples entailles fines mais peu profondes sur tout le corps, Un coup de griffes déchiqueter l'abdomen, nous mentionnant que son des griffes recourbés et très peu aguisée et pour finir cette fameuse racine planté dans la jambe droite.");
                                Console.WriteLine("Edvars de Ragn - Je devrais consulter mon glossiare pour savoir qu'est ce qui va m'attendre");
                                Game.Transition<Glossaire>();
                            }
                            else
                            {
                                Console.WriteLine("Je ne peux tirer de conclusion avant d'avoir examiner l'entiéreté du corps");
                            }

                            break;



                    }



                    break;
                   
                   
                case "autour":

                    Console.WriteLine("Edvar de Ragn - les arbres sifflent comme si essayait d'entamer une musique hypnotique");
                   

                    break;


                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }




        }
    }
}
