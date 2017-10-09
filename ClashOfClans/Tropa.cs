using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Tropa : Entidad, ITropa
    {
        public int daño;
        public int velocidad;
        public String tipo;
        public String moneda;
        public int espacioOcupado;
        public void Atacar_Aldea()
        {
            throw new NotImplementedException();
        }
        public Tropa(int espacioOcupado,int daño, int velocidad, string tipo, string moneda, string nombre, int vida, int costo, int nivel) : base(nombre, vida, costo, nivel)
        {
            this.daño = daño;
            this.velocidad = velocidad;
            this.tipo = tipo;
            this.moneda = moneda;
        }

        public string Atacar_Aldea(Aldea a)
        {
            return "Atacando a: " + a.nombre;
        }



    }
}
