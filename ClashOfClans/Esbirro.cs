using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Esbirro:Tropa_Oscura
    {
        public Esbirro(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacio)
        {
            this.nombre = "Esbirro";
            this.daño = 35;
            this.velocidad = 32;
            this.tipo = "Aéreo";
            this.vida = 55;
            this.costo = 6;
            this.nivel = 1;
            this.espacio = 3;


        }
    }
}
