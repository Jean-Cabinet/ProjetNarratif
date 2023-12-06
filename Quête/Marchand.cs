using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Marchand
    {
        public int bourse {  get; set; }

        public Inventairemarchand inventairemarchand { get; set; }  
        public Marchand() 
        { 
            this.bourse = 150;
            this.inventairemarchand = new Inventairemarchand();
            this.inventairemarchand.Add(new Mandragore("Mandragore","plante",2,10));
            this.inventairemarchand.Add(new Alcahest("Alcahest", "alcool", 2,5));

        }   


        




    }
}
