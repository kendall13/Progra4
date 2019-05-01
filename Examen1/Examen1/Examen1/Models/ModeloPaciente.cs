using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ModeloPaciente
    {
        public string nombre { get; set; }
        public string cedula { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string ocupacion { get; set; }
        public int edad { get; set; }
    }
}
