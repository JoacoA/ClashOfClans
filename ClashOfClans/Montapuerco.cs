using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Montapuerco:Tropa_Oscura
    {
        public Montapuerco(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacio)
        {
            this.nombre = "Montapuerco";
            this.daño = 60;
            this.velocidad = 24;
            this.tipo = "Terrestre";
            this.vida = 270;
            this.costo = 40;
            this.nivel = 1;
            this.espacio = 25;

        }
    }
}
