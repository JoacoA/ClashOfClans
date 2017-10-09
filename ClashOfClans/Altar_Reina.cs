using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Altar_Reina:Edificio
    {
        public bool reina_existente;

        public Altar_Reina(string moneda, int vida, int costo, int nivel, string nombre) : base(moneda, vida, nombre, costo, nivel)
        {
            this.reina_existente = false;

        }

        public String Crear_Reina()
        {
            if (this.reina_existente == false)
            {
                Entidad reina = new Reina("Flecha de fuego", 100, 15, "Terrestre", "Elixir Oscuro", "Reina Arquera",1400,10000,1):
                this.reina_existente = true;
                return "Se a ha creado una reina";
            }

            else
            {
                return "Ya hay una reina creado";
            }
        }
    }
}
