using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Inventairemarchand
    {

        public List<Item> inventairemarchand = new();

        public Inventairemarchand()
        {

        }

        public void Add(Item item)
        {
            inventairemarchand.Add(item);
        }

        public void SubA(Item item,Alcahest A, Marchand M)
        {

            inventairemarchand.Remove(item);
            M.bourse = M.bourse + A.prix;
            Console.WriteLine($"Le marchand possède {M.bourse}");
        }

        public void SubM(Item item, Mandragore U, Marchand M)
        {

            inventairemarchand.Remove(item);
            M.bourse = M.bourse + U.prix;
            Console.WriteLine($"Le marchand possède {M.bourse}");
        }
        public void SubD(Item item, Alcahest A, Mandragore U ,Marchand M)
        {

            inventairemarchand.Remove(item);
            M.bourse = M.bourse + A.prix + U.prix;
            Console.WriteLine($"Le marchand possède {M.bourse}");
        }
        public void See(Item item)
        {
            inventairemarchand.ForEach(i => Console.WriteLine("Le marchand possède "+ i.nombre +" "+ i.name +" au prix de "+ i.prix)); 
        }




    }
}
