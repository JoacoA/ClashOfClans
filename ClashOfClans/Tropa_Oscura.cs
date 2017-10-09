using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Tropa_Oscura:Tropa
    {
        public Tropa_Oscura(int espacioOcupado,string nombre, int daño, int velocidad, string tipo, string moneda, int vida, int costo, int nivel):base(espacioOcupado,daño, velocidad, tipo, moneda, nombre, vida, costo, nivel)
        {
            this.moneda = "Elixir Oscuro";
        }        
    }
}
