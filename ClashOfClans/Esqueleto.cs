using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Esqueleto:Tropa_Normal
    {
        public Esqueleto(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Esqueleto";
            this.daño = 8;
            this.velocidad = 24;
            this.tipo = "Terrestre/ Aéreo";
            this.vida = 1200;
            this.costo = 15000;
            this.nivel = 1;
            this.espacioOcupado = 64;

        }
    }
}
