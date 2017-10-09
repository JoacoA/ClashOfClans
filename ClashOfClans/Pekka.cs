using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Pekka: Tropa_Normal
    {
        public Pekka(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel,espacioOcupado)
        {
            this.nombre = "Pekka";
            this.daño = 240;
            this.velocidad = 16;
            this.tipo = "Terrestre";
            this.vida = 2800;
            this.costo = 28000;
            this.nivel = 1;
            this.espacioOcupado = 28;
        }
    }
}
