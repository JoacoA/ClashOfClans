using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Lava : Tropa_Oscura
    {
        public Lava(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacio)
        {
            this.nombre = "Lava";
            this.daño = 10;
            this.velocidad = 24;
            this.tipo = "Terrestre";
            this.vida = 5700;
            this.costo = 390;
            this.nivel = 1;
            this.espacio = 24;

        }
    }
}
