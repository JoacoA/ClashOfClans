using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Dragon:Tropa_Normal
    {
        public Dragon(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Dragón";
            this.daño = 140;
            this.velocidad = 16;
            this.tipo = "Aéreo";
            this.vida = 1900;
            this.costo = 25000;
            this.nivel = 1;
            this.espacioOcupado = 48;

        }
    }
}
