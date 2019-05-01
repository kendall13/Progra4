using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TareaLavanderia.Models
{
    public class Prenda
    {
        public Prenda()
        {
        }

        public Prenda(int id_Prenda, int cedulaPropietario, string tipoPrenda, string tipoTela, string descLavado)
        {
            this.id_Prenda = id_Prenda;
            CedulaPropietario = cedulaPropietario;
            TipoPrenda = tipoPrenda;
            TipoTela = tipoTela;
            DescLavado = descLavado;
        }

        public int id_Prenda { get; set; }
        public int CedulaPropietario { get; set; }
        public string TipoPrenda { get; set; }
        public string TipoTela { get; set; }
        public string DescLavado { get; set; }
    }
}