using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Herboriste : Marchand
    {

        public Herboriste() 
        {
            this.inventairemarchand.Add(new Mandragore("Mandragore","plante",3,10));
            this.inventairemarchand.Add(new Alcahest("Alcahest", "alccol", 3,5));
        
        
        
        }




    }
}
