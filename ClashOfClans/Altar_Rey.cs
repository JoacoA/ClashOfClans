using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Altar_Rey: Edificio
    {
        public bool rey_existente;

        public Altar_Rey(string moneda, int vida, int costo, int nivel, string nombre) : base(moneda, vida, nombre, costo, nivel)
        {
            this.rey_existente = false;

        }

        public String Crear_Rey()
        {
            if (this.rey_existente == false)
            {
                Entidad rey = new Rey("Puño de Hierro", 144, 16, "Terrestre", "Elixir Oscuro", "Rey Bárbaro", 1700, 10000, 1);
                this.rey_existente = true;
                return "Se a ha creado un rey";
            }

            else
            {
                return "Ya hay un rey creado";
            }
        }
      
    }
}
