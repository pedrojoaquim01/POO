using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    class Monge : Character
    {
        private int LvlLimitToChange;


        public override void Update()
        {
            Move();
        }

        private string Nome
        {
            get { return name; }
            set { if (level >= LvlLimitToChange) name = value; }
        }

        public int Nivel
        {
            get { return level; }
            set { level = value; }
        }


        public Monge(string NomeInicial)
        {
            LvlLimitToChange = 80;
            Nome = NomeInicial;
            level = Nivel;
        }



    }
}
