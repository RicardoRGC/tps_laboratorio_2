using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EntidadesExcepciones;

namespace EntidadesArchivos
{
    public class ClaseSerializadora<T>
    {
        static string ruta;

        static ClaseSerializadora()
        {
             ruta = AppDomain.CurrentDomain.BaseDirectory;
                      
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pj"></param>
        /// <exception cref="Exception"></exception>
        public static void EscribirT(T datos, string archivo)
        {
            
            string completo = ruta + @"\Serializadora" + archivo + ".xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(completo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    xmlSerializer.Serialize(sw, datos);
                }

            }
            catch (Exception)
            {
                throw new ArchivoInvalidoException($"Error en el archivo{completo}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pjs"></param>
        /// <exception cref="Exception"></exception>
        public static T LeerListaT(string nombre)
        {
            string archivo = string.Empty;
            T datos = default;
            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivosRuta = Directory.GetFiles(ruta);


                    foreach (string archivoRuta in archivosRuta)
                    {
                        if (archivoRuta.Contains(nombre))
                        {
                            archivo = archivoRuta;
                        }
                    }
                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(archivo))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                            datos = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }
                return datos;

            }
            catch (Exception)
            {
                throw new ArchivoInvalidoException($"Error en el archivo{archivo}");
            }
        }
    }
}
