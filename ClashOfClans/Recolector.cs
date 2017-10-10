using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Recolector: Produccion
    {
        public int capacidadTotal;

        public Recolector(int capacidadTotal, int velocidad, string moneda, int vida, string nombre, int costo, int nivel):base(velocidad,moneda,vida,nombre,costo,nivel)
        {
            this.capacidadTotal = capacidadTotal;
        }        

    }
}
