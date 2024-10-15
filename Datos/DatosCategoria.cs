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
    public class DatosCategoria
    {
                private readonly string filename = "Categoria.bin";
                FileStream archivo;
                public void Add(Categoria categoria)
                {
                    List<Categoria> categorias = Leer();
                    categorias.Add(categoria);
                    Guardar(categorias);
                }
                public void Guardar(List<Categoria> categorias)
                {
                    archivo = new FileStream(filename, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(archivo, categorias);
                    archivo.Close();
                }
                public List<Categoria> Leer()
                {
                    if (!File.Exists(filename))
                    {
                        return new List<Categoria>();
                    }
                    using (FileStream archivo = new FileStream(filename, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        List<Categoria> categorias = (List<Categoria>)formatter.Deserialize(archivo);
                        return categorias;
                    }
                }
                public Categoria Buscar(int id)
                {
                    List<Categoria> categorias = Leer();
                    foreach (var item in categorias)
                    {
                        if (item.id == id)
                        {
                            return item;
                        }

                    }
                    return null;
                }

                public void Actualizar(Categoria categoriaNuevo)
                {
                    List<Categoria> categorias = Leer();
                    foreach (var item in categorias)
                    {
                        if (item.id == categoriaNuevo.id)
                        {
                            categorias.Remove(item);
                            categorias.Add(categoriaNuevo);
                            break;
                        }
                    }
                    Guardar(categorias);
                }
                public void Eliminar(int id)
                {
                    List<Categoria> categorias = Leer();
                    foreach (var item in categorias)
                    {
                        if (item.id == id)
                        {
                            categorias.Remove(item);
                            break;
                        }
                    }
                    Guardar(categorias);
                }
            }
        }
  

