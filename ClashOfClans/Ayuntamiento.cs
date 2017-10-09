using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Ayuntamiento
    {
        public int capacidadTotalOro;
        public int espacioUsadoOro;
        public int espacioLibreOro;
        public int capacidadTotalElixir;
        public int espacioUsadoElixir;
        public int espacioLibreElixir;

        public int AlmacenarOro(int e) //Devuelve la cantidad de "elemento" que no pudo ser almacenado, en el caso de que devuelva 0, es porque toda la cantidad
                                       //de elemento que se deseó almacenar, efectivamente fue almacenado
        {
            espacioLibreOro = capacidadTotalOro - espacioUsadoOro;
            if (e <= espacioLibreOro)
            {
                espacioUsadoOro += e;
                espacioLibreOro -= e;
                return 0;
            }
            else
            {
                espacioUsadoOro = capacidadTotalOro;
                int sobrante = e - espacioLibreOro;  // cantidad de elemento que no pudo ser almacenado
                espacioLibreOro = 0;
                return sobrante;
            }
        }

        public int AlmacenarElixir(int e) //Devuelve la cantidad de "elemento" que no pudo ser almacenado, en el caso de que devuelva 0, es porque toda la cantidad
                                          //de elemento que se deseó almacenar, efectivamente fue almacenado
        {
            espacioLibreElixir = capacidadTotalElixir - espacioUsadoElixir;
            if (e <= espacioLibreElixir)
            {
                espacioUsadoElixir += e;
                espacioLibreElixir -= e;
                return 0;
            }
            else
            {
                espacioUsadoElixir = capacidadTotalElixir;
                int sobrante = e - espacioLibreElixir;  // cantidad de elemento que no pudo ser almacenado
                espacioLibreElixir = 0;
                return sobrante;
            }
        }

        public int QuitarOro(int e) // Método utilizado en todos los casos que requiera usar un recurso (construcción de edificios, entrenamiento de tropas, etc)
        {                        // Devuelve la cantidad de Recurso que pudo ser quitado (siendo e el máximo)
            if (e <= espacioUsadoOro)
            {
                espacioUsadoOro -= e;
                espacioLibreOro += e;
                return e;
            }
            else
            {
                int sobrante = e - espacioUsadoOro;
                espacioUsadoOro = 0;
                espacioLibreOro = capacidadTotalOro;
                return sobrante;
            }
        }

        public int QuitarElixir(int e) // Método utilizado en todos los casos que requiera usar un recurso (construcción de edificios, entrenamiento de tropas, etc)
        {                        // Devuelve la cantidad de Recurso que pudo ser quitado (siendo e el máximo)
            if (e <= espacioUsadoOro)
            {
                espacioUsadoElixir -= e;
                espacioLibreElixir += e;
                return e;
            }
            else
            {
                int sobrante = e - espacioUsadoElixir;
                espacioUsadoElixir = 0;
                espacioLibreElixir = capacidadTotalElixir;
                return sobrante;
            }
        }
    }
}
