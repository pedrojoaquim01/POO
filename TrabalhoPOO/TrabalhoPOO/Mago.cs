using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO
{
    class Mago : Character
    {
        private int LvlLimitToChange;


        public override void Update()
        {
            Move();
        }

        public Mago(string NomeInicial)
        {
            LvlLimitToChange = 50;
            name = NomeInicial;
            level = Nivel;
        }

        public string Nome
        {
            get { return name; }
            set { if (level >= LvlLimitToChange) name = value; }
        }

        public int Nivel
        {
            get { return level; }
            set { level = value; }
        }


    }
}
