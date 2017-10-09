using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Campamento
    {
        public int capacidadMaxima;
        public int espacioLibre;
        public List<Tropa> tropas;

        public Campamento(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
            tropas = new List<Tropa>();
        }

        public string AgregarTropa(Tropa T)
        {
            if(T.espacioOcupado <= espacioLibre)
            {
                espacioLibre -= T.espacioOcupado;
                return "Tropa agregada satisfactoriamente";
            }
            else
            {
                return "No quedan suficientes espacios!";
            }
        }

        public string BorrarTropas()
        {
            tropas.Clear();
            return "Las tropas del Campamento se han borrado!";
        }


    }
}
