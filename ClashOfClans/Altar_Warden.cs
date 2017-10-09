using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Altar_Warden:Edificio
    {
        public bool warden_existente;

        public Altar_Warden(string moneda, int vida, int costo, int nivel, string nombre) : base(moneda, vida, nombre, costo, nivel)
        {
            this.warden_existente = false;

        }

        public String Crear_Warden()
        {
            if (this.warden_existente == false)
            {
                Entidad warden = new Warden("Rayos", 150, 25, "Aereo", "Elixir Oscuro", "Warden", 2500, 10000, 1);
                this.warden_existente = true;
                return "Se a ha creado un warden";
            }

            else
            {
                return "Ya hay un warden creado";
            }
        }
    }
}
