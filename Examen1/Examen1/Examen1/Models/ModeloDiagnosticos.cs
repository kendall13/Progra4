using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1.Models
{
    public class ModeloDiagnosticos
    {
        public string nombre_paciente { get; set; }
        public int numero_consulta { get; set; }
        public string telefono_paciente { get; set; }
        public string doctor_encargado { get; set; }
        public string tipo_lente { get; set; }
        public DateTime fecha_examen { get; set; }
        public DateTime fecha_proximo_examen { get; set; }
        public string estado_receta { get; set; }

        public float oi_SPH { get; set; }
        public float oi_CYL { get; set; }
        public float oi_EJE { get; set; }
        public float oi_DP { get; set; }
        public float oi_ADD { get; set; }
        public float oi_PRISMA { get; set; }
        public float oi_BASE { get; set; }
        public float od_SPH { get; set; }
        public float od_CYL { get; set; }
        public float od_EJE { get; set; }
        public float od_DP { get; set; }
        public float od_ADD { get; set; }
        public float od_PRISMA { get; set; }
        public float od_BASE { get; set; }

        public float altura_od { get; set; }
        public float altura_oi { get; set; }
        public string diagnostico { get; set; }
         
    }
}
