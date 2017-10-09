using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Duende:Tropa_Normal
    {
        public Duende(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Duende";
            this.daño = 11;
            this.velocidad = 32;
            this.tipo = "Terrestre";
            this.vida = 25;
            this.costo = 25;
            this.nivel = 1;
            this.espacioOcupado = 48;

        }
    }
}
