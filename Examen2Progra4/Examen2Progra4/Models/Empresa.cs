using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2Progra4.Models
{
    public class Empresa
    {
        public string titulo { get; set; }
        public int costo { get; set; }
        public int baseDomiciliar { get; set; }
        public int baseEmpresarial { get; set; }
        public int fechaCobro { get; set; }
        public int fechaCorte { get; set; }
        public int multa { get; set; }

        public Empresa(string titulo, int costo, int baseDomiciliar, int baseEmpresarial, int fechaCobro, int fechaCorte, int multa)
        {
            this.titulo = titulo;
            this.costo = costo;
            this.baseDomiciliar = baseDomiciliar;
            this.baseEmpresarial = baseEmpresarial;
            this.fechaCobro = fechaCobro;
            this.fechaCorte = fechaCorte;
            this.multa = multa;
        }

        public Empresa()
        {
        }
    }
}
