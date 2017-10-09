using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Lanzarrocas:Tropa_Oscura
    {
        public Lanzarrocas(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacio)
        {
            this.nombre = "Lanzarocas";
            this.daño = 65;
            this.velocidad = 14;
            this.tipo = "Terrrestre";
            this.vida = 290;
            this.costo = 130;
            this.nivel = 1;
            this.espacio = 30;

        }
    }
}
