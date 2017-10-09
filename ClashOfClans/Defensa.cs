using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Defensa:Edificio
    {
        public int daño;
        public string target; //Objetivos aéreos o terrestres

        public Defensa(int daño,string target, string moneda, int vida, string nombre, int costo, int nivel) : base(moneda, vida, nombre, costo, nivel)
        {
            this.daño = daño;
            this.target = target;
        }
        public void Atacar() { }

    }
}
