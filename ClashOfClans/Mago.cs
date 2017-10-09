using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Mago:Tropa_Normal
    {
        public Mago(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Mago";
            this.daño = 8;
            this.velocidad = 16;
            this.tipo = "Terrestre";
            this.vida = 75;
            this.costo = 150000;
            this.nivel = 1;
            this.espacioOcupado = 20;



        }
    }
}
