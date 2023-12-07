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
@" [enigme]";


        internal override void ReceiveChoice(string choice, Edvars e)
        {
            switch(choice)
            {
                case "enigme":


                    int essais = 0;
                    string réponse;
                    do
                    {
                        Console.WriteLine("Que dit une noix qui éternue ?");
                        réponse = Console.ReadLine();
                        if (essais == 1)
                        {
                            Console.WriteLine(" 1 ère indice : originaire d'amerique tropicale");

                        }
                        if (essais == 2)
                        {
                            Console.WriteLine(" 2 ème indice : son deuxième nom est anacarde");

                        }
                        if (réponse =="cajou")
                        {
                            Console.WriteLine("Bravo vous trouvé la réponse");

                        }



                    } while (essais != 2);

                    Console.WriteLine("Vous n'avez pas trouvé la bonne réponse");






                break;





            }



        }
    }
}
