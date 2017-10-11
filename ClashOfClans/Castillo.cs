using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Castillo
    {
        public int capacidadTotalOro;
        public int espacioUsadoOro;
        public int espacioLibreOro;
        public int capacidadTotalElixir;
        public int espacioUsadoElixir;
        public int espacioLibreElixir;
        public int capacidadTotalOscuro;
        public int espacioUsadoOscuro;
        public int espacioLibreOscuro;
        List<Tropa_Oscura> tropasOscuras;
        List<Tropa_Normal> tropasNormales;
        public int capacidadMaxTropasNormales;
        public int capacidadMaxTropasOscuras;
        public int espacioUsadoTropasNormales;
        public int espacioUsadoTropasOscuras;

        public Castillo()
        {
            this.capacidadTotalOro = 500;
            this.espacioUsadoOro = 0;         
            this.espacioLibreOro = 500;
            this.capacidadTotalElixir = 250;
            this.espacioUsadoElixir = 0;
            this.espacioLibreElixir = 250;
            this.capacidadTotalOscuro = 150;
            this.espacioUsadoOscuro = 0;
            this.espacioLibreOscuro = 150;
            this.tropasOscuras = new List<Tropa_Oscura>();
            this.tropasNormales = new List<Tropa_Normal>();
            this.capacidadMaxTropasNormales = 50;
            this.capacidadMaxTropasOscuras = 35;
            this.espacioUsadoTropasNormales = 0;
            this.espacioUsadoTropasOscuras = 0;

        }
        public string AgregarTropaNormal(Tropa_Normal T)
        {
            if(espacioUsadoTropasNormales + T.espacioOcupado <= this.capacidadMaxTropasNormales)
            {
                tropasNormales.Add(T);
                espacioUsadoTropasNormales += T.espacioOcupado;
                return "Tropa agregada con éxito!";
            }
            else
            {
                return "Espacio insuficiente :(";
            }
        }

        public string AgregarTropaOscura(Tropa_Oscura T)
        {
            if (espacioUsadoTropasOscuras + T.espacioOcupado <= this.capacidadMaxTropasOscuras)
            {
                tropasOscuras.Add(T);
                espacioUsadoTropasOscuras += T.espacioOcupado;
                return "Tropa Oscura agregada con éxito!";
            }
            else
            {
                return "Espacio insuficiente :(";
            }

        }

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

        public int AlmacenarOscuro(int e) //Devuelve la cantidad de "elemento" que no pudo ser almacenado, en el caso de que devuelva 0, es porque toda la cantidad
                                    //de elemento que se deseó almacenar, efectivamente fue almacenado
        {
            espacioLibreOscuro = capacidadTotalOscuro - espacioUsadoOscuro;
            if (e <= espacioLibreOscuro)
            {
                espacioUsadoOscuro += e;
                espacioLibreOscuro -= e;
                return 0;
            }
            else
            {
                espacioUsadoOscuro = capacidadTotalOscuro;
                int sobrante = e - espacioLibreOscuro;  // cantidad de elemento que no pudo ser almacenado
                espacioLibreOscuro = 0;
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

        public int QuitarOscuro(int e) // Método utilizado en todos los casos que requiera usar un recurso (construcción de edificios, entrenamiento de tropas, etc)
        {                        // Devuelve la cantidad de Recurso que pudo ser quitado (siendo e el máximo)
            if (e <= espacioUsadoOscuro)
            {
                espacioUsadoOscuro -= e;
                espacioLibreOscuro += e;
                return e;
            }
            else
            {
                int sobrante = e - espacioUsadoOscuro;
                espacioUsadoOscuro = 0;
                espacioLibreOscuro = capacidadTotalOscuro;
                return sobrante;
            }
        }


    }
}
