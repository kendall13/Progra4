using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2Progra4.Models
{
    public class Consumo
    {
        public int mesU { get; set; }
        public int anoU { get; set; }
        public int consumoU { get; set; }
        public int cedulaU { get; set; }
        public int pagoU { get; set; } = 0;
        public Boolean pagadoU = false;
        public Boolean multaU = false;
        

        public Consumo(int mes, int ano, int consumo, int cedula)
        {
            this.mesU = mes;
            this.anoU = ano;
            this.consumoU = consumo;
            this.cedulaU = cedula;
        }

        public Consumo()
        {
        }
    }
}
