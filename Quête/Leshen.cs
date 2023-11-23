using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Leshen : Edvars
    {

        public int PVLeshen { get; set; }
        public int griffures { get; set; }
        public int nuéecorbeaux { get; set; }
        public int défenseLeshen {  get; set; }

        public int riposteLeshen {  get; set; }   

        public Leshen()
        {
            this.PVLeshen = 50;
            this.griffures = 15;
            this.nuéecorbeaux = 17;
            this.défenseLeshen = 10;
            this.riposteLeshen = 10;

        }


   



    }
}
