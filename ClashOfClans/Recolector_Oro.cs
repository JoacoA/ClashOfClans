using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Recolector_Oro 
    {
        public int capacidadTotal;

        public  Recolector_Oro(int capacidadTotal)
        {
            this.capacidadTotal = 5000;
        }

        public string Recolectar(Almacen_Oro O)
        {
            if (O.espacioUsado <= espacioLibre)
            {
                espacioLibre -= O.espacioUsado;
                return "Oro recolectado.";
            }
            else
            {
                return "No queda suficiente espacio!";
            }
        }
    }
}
