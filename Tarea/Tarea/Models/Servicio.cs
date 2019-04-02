using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea.Models
{
    public class Servicio
    {
        public Servicio()
        {
        }

        public Servicio(int id_Servicio, int cedulaPropietario, int id_Prenda, string descLavado, string comentarios, string estadoServicio, string fechaRecibido, string fechaDevolucion)
        {
            this.id_Servicio = id_Servicio;
            CedulaPropietario = cedulaPropietario;
            this.id_Prenda = id_Prenda;
            DescLavado = descLavado;
            Comentarios = comentarios;
            EstadoServicio = estadoServicio;
            FechaRecibido = fechaRecibido;
            FechaDevolucion = fechaDevolucion;
        }

        public int id_Servicio { get; set; }
        public int CedulaPropietario { get; set; }
        public int id_Prenda { get; set; }
        public string DescLavado { get; set; }
        public string Comentarios { get; set; }
        public string EstadoServicio { get; set; }
        public string FechaRecibido { get; set; }
        public string FechaDevolucion { get; set; }
    }
}
