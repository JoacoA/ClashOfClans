using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    public abstract class Entidad
    {
        public string nombre;
        public int vida;
        public int costo;
        public int nivel;

        public Entidad(string nombre, int vida, int costo, int nivel)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.costo = costo;
            this.nivel = nivel;
        }
    }
}
