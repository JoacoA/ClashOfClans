using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Heroe:Tropa
    {
        String poder;
        public Heroe(string poder,int daño,int velocidad,string tipo,string moneda,string nombre,int vida,int costo, int nivel) : base(daño, velocidad, tipo, moneda, nombre, vida, costo, nivel)
        {
            this.poder = poder;
        }

       

    }
}
