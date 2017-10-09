using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Dragon_Bebe:Tropa_Normal
    {
        public Dragon_Bebe(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Dragón bebé";
            this.daño = 8;
            this.velocidad = 16;
            this.tipo = "Terrestre/ Aéreo";
            this.vida = 1200;
            this.costo = 15000;
            this.nivel = 1;
            this.espacioOcupado = 33;

        }
    }
}
