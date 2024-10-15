using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo
    {
        public int id {  get; set; }
        public string descripcion { get; set; }
        public double precioAlquiler { get; set; }

        public double precioProveedor { get; set; }
        public string estado { get; set; }
        public int cantidad { get; set; }
        public string imagen { get; set; }
        public Proveedor proveedor { get; set; }
        public Categoria categoria { get; set; }
        


    }
}
