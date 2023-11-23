using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Huileleshi : Item
    {
        public int huileleshi = 5;
       

        public Huileleshi(string name, string type, int huileleshi)
        {
            this.name = name;
            this.type = type;
            this.huileleshi = huileleshi;
           

        }

    }
}
