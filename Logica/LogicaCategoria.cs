using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaCategoria
    {
        public DatosCategoria datosCategorias = new DatosCategoria();
        public void Add(Categoria categoria)
        {
            datosCategorias.Add(categoria);
        }

        public List<Categoria> leer()
        {
            return datosCategorias.Leer();
        }
    }
}
