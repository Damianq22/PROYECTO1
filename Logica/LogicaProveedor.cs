using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaProveedor
    {
        public DatosProveedor datosProveedor = new DatosProveedor();
        public void Add(Proveedor proveedor)
        {
            datosProveedor.Add(proveedor);
        }

        public List<Proveedor> leer()
        {
            return datosProveedor.Leer();
        }
    }
}
