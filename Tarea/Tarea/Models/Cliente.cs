using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int cedula, string nombre, string email, string direccion, int telefono1, int telefono2)
        {
            Cedula = cedula;
            Nombre = nombre;
            Email = email;
            Direccion = direccion;
            Telefono1 = telefono1;
            Telefono2 = telefono2;
        }

        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
    }
}
