using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProveedor
    {
        private readonly string filename = "Proveedor.bin";
        FileStream archivo;
        public void Add(Proveedor proveedor)
        {
            List<Proveedor> proveedores= Leer();
            proveedores.Add(proveedor);
            Guardar(proveedores);
        }
        public void Guardar(List<Proveedor> proveedores)
        {
            archivo = new FileStream(filename, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(archivo, proveedores);
            archivo.Close();
        }
        public List<Proveedor> Leer()
        {
            if (!File.Exists(filename))
            {
                return new List<Proveedor>();
            }
            using (FileStream archivo = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<Proveedor> proveedores = (List<Proveedor>)formatter.Deserialize(archivo);
                return proveedores;
            }
        }
        public Proveedor Buscar(int id)
        {
            List<Proveedor> proveedores = Leer();
            foreach (var item in proveedores)
            {
                if (item.id == id)
                {
                    return item;
                }

            }
            return null;
        }

        public void Actualizar(Proveedor proveedorNuevo)
        {
            List<Proveedor> proveedores = Leer();
            foreach (var item in proveedores)
            {
                if (item.id == proveedorNuevo.id)
                {
                    proveedores.Remove(item);
                    proveedores.Add(proveedorNuevo);
                    break;
                }
            }
            Guardar(proveedores);
        }
        public void Eliminar(int id)
        {
            List<Proveedor> proveedores = Leer();
            foreach (var item in proveedores)
            {
                if (item.id == id)
                {
                    proveedores.Remove(item);
                    break;
                }
            }
            Guardar(proveedores);
        }
    }
}
