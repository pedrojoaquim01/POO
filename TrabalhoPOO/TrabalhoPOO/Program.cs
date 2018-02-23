using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new Mago("Harry");
            Mago mago2 = new Mago("Gandalf");

            Monge monge1 = new Monge("Buda");
            Monge monge2 = new Monge("Aang");

            Console.WriteLine(mago1.Nome);
            mago1.Nivel = 50;
            mago1.Nome = "Potter";
            Console.WriteLine(mago1.Nome);
        }

    }
}
