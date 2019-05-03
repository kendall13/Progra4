using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2Progra4.Models
{
    public class Cliente
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int medidor { get; set; }
        public Boolean tipoDomi { get; set; }

        public Cliente(int cedula, string nombre, int telefono, string direccion, int medidor, bool tipoDomi)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.medidor = medidor;
            this.tipoDomi = tipoDomi;
        }

        public Cliente()
        {
        }
    }
}
