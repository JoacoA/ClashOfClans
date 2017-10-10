using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Almacen_Oro: Almacenamiento,IAlmacenamiento
    {
                
        public Almacen_Oro(int capacidadTotal, int espacioUsado, int espacioLibre): base(capacidadTotal, espacioUsado, espacioLibre)
        {
            this.capacidadTotal = 4;
            
        }

        public int Almacenar_Oro(int e) //Devuelve la cantidad de "elemento" que no pudo ser almacenado, en el caso de que devuelva 0, es porque toda la cantidad
                                       //de elemento que se deseó almacenar, efectivamente fue almacenado
        {
            espacioLibre = capacidadTotal - espacioUsado;
            if (e <= espacioLibre)
            {
                espacioUsado += e;
                espacioLibre -= e;
                return 0;
            }
            else
            {
                espacioUsado = capacidadTotal;
                int sobrante = e - espacioLibre;  // cantidad de elemento que no pudo ser almacenado
                espacioLibre = 0;
                return sobrante;
            }
        }
    }
}
