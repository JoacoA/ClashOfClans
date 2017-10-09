using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Minero:Tropa_Normal
    {
        public Minero(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Minero";
            this.daño = 80;
            this.velocidad = 24;
            this.tipo = "Terrestre";
            this.vida = 550;
            this.costo = 4200;
            this.nivel = 1;
            this.espacioOcupado = 25;

        }
    }
}
