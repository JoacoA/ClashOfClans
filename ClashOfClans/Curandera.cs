using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Curandera:Tropa_Normal
    {
        public Curandera(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel,int espacioOcupado) : base(nombre, daño, velocidad, tipo, moneda, vida, costo, nivel, espacioOcupado)
        {
            this.nombre = "Curandera";
            this.daño = 8;
            this.velocidad = 16;
            this.tipo = "Aéreo";
            this.vida = 500;
            this.costo = 5000;
            this.nivel = 1;
            this.espacioOcupado = 24;

        }
    }
}
