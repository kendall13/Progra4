using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ModeloDoctor
    {
        public int id_doctor { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public int edad { get; set; }
    }
}
