using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Bruja : Tropa_Oscura
    {
        public Bruja(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacio)
        {
            this.nombre = "Bruja";
            this.daño = 50;
            this.velocidad = 12;
            this.tipo = "Terrestre";
            this.vida = 270;
            this.costo = 250
            this.nivel = 1;
            this.espacio = 14;

        }
    }
}
