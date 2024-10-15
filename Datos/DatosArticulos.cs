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
    public class DatosArticulos
    {

            private readonly string filename = "Articulo.bin";
            FileStream archivo;
            public void Add(Articulo articulo)
            {
                List<Articulo> articulos = Leer();
                articulos.Add(articulo);
                Guardar(articulos);
            }
            public void Guardar(List<Articulo> articulos)
            {
                archivo = new FileStream(filename, FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(archivo, articulos);
                archivo.Close();
            }
            public List<Articulo> Leer()
            {
                if (!File.Exists(filename))
                {
                    return new List<Articulo>();
                }
                using (FileStream archivo = new FileStream(filename, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    List<Articulo> articulos = (List<Articulo>)formatter.Deserialize(archivo);
                    return articulos;
                }
            }
            public Articulo Buscar(int id)
            {
                List<Articulo> articulos = Leer();
                foreach (var item in articulos)
                {
                    if (item.id == id)
                    {
                        return item;
                    }

                }
                return null;
            }

            public void Actualizar(Articulo articuloNuevo)
            {
                List<Articulo> articulos = Leer();
                foreach (var item in articulos)
                {
                    if (item.id == articuloNuevo.id)
                    {
                        articulos.Remove(item);
                        articulos.Add(articuloNuevo);
                        break;
                    }
                }
                Guardar(articulos);
            }
            public void Eliminar(int id)
            {
                List<Articulo> articulos = Leer();
                foreach (var item in articulos)
                {
                    if (item.id == id)
                    {
                        articulos.Remove(item);
                        break;
                    }
                }
                Guardar(articulos);
            }





        }
    }

