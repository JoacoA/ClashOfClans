using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Gigante:Tropa_Normal
    {
        public Gigante(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Gigante";
            this.daño = 11;
            this.velocidad = 12;
            this.tipo = "Terrestre";
            this.vida = 300;
            this.costo = 250;
            this.nivel = 1;
            this.espacioOcupado = 29;

        }
    }
}
