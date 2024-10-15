using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaArticulo
    {
        public DatosArticulos datosArticulos = new DatosArticulos();   
        public void Add(Articulo articulo)
        {
            datosArticulos.Add(articulo);
        }

        public List<Articulo> leer()
        {
            return datosArticulos.Leer();
        }
    }
}
