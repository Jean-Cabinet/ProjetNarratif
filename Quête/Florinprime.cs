using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Florinprime : Item
    {
        public int primehypno { get; set; }
        public int prime { get; set; }

        public int primequete{get; set; }


        public Florinprime(int primehypno, int prime, int primequete, string name, string type)
        {
            this.primehypno = primehypno;
            this.prime = prime;
            this.primequete = primequete;
            this.name = name;
            this.type = type;


        }
    }
}
