using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Golem : Tropa_Oscura
    {
        public Golem(string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel, int espacio):base(nombre,daño,velocidad,tipo,moneda,vida,costo, nivel, espacio)
        {
            this.nombre = "Golem";
            this.daño = 38;
            this.velocidad = 12;
            this.tipo = "Terrestre";
            this.vida = 4500;
            this.costo = 450;
            this.nivel = 1;
            this.espacio = 40;


        }
    }
}
