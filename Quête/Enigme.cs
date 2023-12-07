using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Enigme : Quest
    {

        internal override string CreateDescription() =>
@"[enigme]";


        internal override void ReceiveChoice(string choice, Edvars e)
        {
            switch(choice)
            {
                case "enigme":


                    int essais = 0;
                    string réponse = "";
                    bool bonneréponse = false;
                    
                    do
                    {
                        if (bonneréponse == false)
                        {
                            Console.WriteLine("Que dit une noix qui éternue ?");
                            réponse = Console.ReadLine();
                            if (réponse != "cajou")
                            {
                                essais++;
                            }
                        }
                        if (essais == 1 && bonneréponse == false)
                        {
                            Console.WriteLine(" 1 ère indice : originaire d'amerique tropicale");
                            
                        }
                        if (essais == 2 && bonneréponse == false)
                        {
                            Console.WriteLine(" 2 ème indice : son deuxième nom est anacarde");
                            
                        }
                        if (réponse =="cajou" && bonneréponse == false)
                        {
                            bonneréponse = true;
                            Console.WriteLine("Bravo vous trouvé la réponse");

                        }
                        if(essais == 3 && bonneréponse == false)
                        {
                            Console.WriteLine("Vous n'avez pas trouvé la bonne réponse");
                            
                        }



                    } while (essais != 3);

                    






                break;





            }



        }
    }
}
