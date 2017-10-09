using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Aldea
    {
        public string nombre;
        public int cant_oro;
        public int cant_ElixirR;
        public int cant_ElixirO;
        public List<IAlmacenamiento> 

        public Aldea(string nombre, int oro, int rojo, int oscuro)
        {
            this.nombre = nombre;
            this.cant_oro = oro;
            this.cant_ElixirR = rojo;
            this.cant_ElixirO = oscuro;

        }

        public void AgregarEntidad (Entidad e)
        {

        }

        // TEST
        //holaaa


        
        

    }
}
