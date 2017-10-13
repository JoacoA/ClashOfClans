using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Almacenamiento: IAlmacenamiento
    {
        public int capacidadTotal;
        public int espacioUsado;
        public int espacioLibre;

        public int Almacenar(int e) //Devuelve la cantidad de "elemento" que no pudo ser almacenado, en el caso de que devuelva 0, es porque toda la cantidad
                                    //de elemento que se deseó almacenar, efectivamente fue almacenado
        {
            espacioLibre = capacidadTotal - espacioUsado;
            if(e <= espacioLibre)
            {
                espacioUsado += e;
                espacioLibre -= e;                                          // MÉTODOS GENERALES, NO SIRVEN EN CASOS ESPECÍFICOS YA QUE VARÍA EL TIPO DE RECURSO 
                return 0;                                                   // POR LO TANTO EL NOMBRE DEL ATRIBUTO
            }
            else
            {
                espacioUsado = capacidadTotal;
                int sobrante = e - espacioLibre;  // cantidad de elemento que no pudo ser almacenado
                espacioLibre = 0;
                return sobrante;
            }
        }

        public int Quitar(int e) // Método utilizado en todos los casos que requiera usar un recurso (construcción de edificios, entrenamiento de tropas, etc)
        {                        // Devuelve la cantidad de Recurso que pudo ser quitado (siendo e el máximo)
            if (e <= espacioUsado)
            {
                espacioUsado -= e;
                espacioLibre += e;
                return e;
            }
            else
            {
                int sobrante = e - espacioUsado;
                espacioUsado = 0;
                espacioLibre = capacidadTotal;
                return sobrante;
            }
        }      
    }
}
