using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Edificio: Entidad, IEdificio
    {
        
        public String moneda;
        

        public Edificio(string moneda, int vida, string nombre, int costo, int nivel) : base(nombre,vida,costo,nivel)
        {
            this.moneda = moneda;
            
        }
        public void Subir_Nivel()
        {
            this.nivel += 1;
        }
    }
}
