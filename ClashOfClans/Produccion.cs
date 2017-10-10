using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Produccion : Edificio
    {
        public int velocidad;
        public Produccion(int velocidad, string moneda, int vida, string nombre, int costo, int nivel) : base(moneda, vida, nombre, costo, nivel)
        {
            this.velocidad = velocidad;
        }
    }
}
