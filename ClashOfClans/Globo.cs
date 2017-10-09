using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Globo:Tropa_Normal
    {
        public Globo(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Globo";
            this.daño = 25;
            this.velocidad = 10;
            this.tipo = "Aéreo";
            this.vida = 150;
            this.costo = 2000;
            this.nivel = 1;
            this.espacioOcupado = 15;

        }
    }
}
