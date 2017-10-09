using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Barbaro : Tropa_Normal
    {
        public Barbaro(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel)
        {
            this.nombre = "Barbaro";
            this.daño = 8;
            this.velocidad = 20;
            this.tipo = "Terrestre";
            this.vida = 54;
            this.costo = 5000;
            this.nivel = 1;

        }
        
    }
}
