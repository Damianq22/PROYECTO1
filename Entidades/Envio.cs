using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Envio
    {
        public int id { get; set; }
        public DateTime fechaHora { get; set; }
        public string receptor { get; set; }
        public string direccion { get; set; }
        public int cantidadViajes{ get; set; }
        public double precio { get; set; }
        public Transporte transporte { get; set; }

    }
}
