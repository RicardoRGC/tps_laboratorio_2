using System;
using System.IO;
using EntidadesExcepciones;
namespace EntidadesArchivos
{
    public static class Archivo
    {
        static string ruta;
        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            ruta += @"\source\repos\Gonzalez.Ricardo.2D.TP3";

        }
        public static void GuardarLastIdUsuario(string id)
        {
            
            string nombrerchivo = @"\LastId" +  ".txt";

            string completa = ruta + nombrerchivo;
    
            try
            {
                if (!Directory.Exists(ruta)) //valida si existe
                {
                    Directory.CreateDirectory(ruta); //crea una carpeta, si esta no existe
                }
                //using (StreamWriter sw = new StreamWriter(completa,true)) //agrega datos al archivo existente
                using (StreamWriter sw = new StreamWriter(completa)) //crea y sobrescribe archivo.
                {
                    sw.WriteLine(id);
                }

            }
            catch (Exception)
            {
                throw new ArchivoInvalidoIdException($"Error en el archivo");
            }

        }
        public static void GuardarLastIdEquipo(string id)
        {
            
            string nombrerchivo = @"\LastIdEquipo" +  ".txt";

            string completa = ruta + nombrerchivo;
    
            try
            {
                if (!Directory.Exists(ruta)) //valida si existe
                {
                    Directory.CreateDirectory(ruta); //crea una carpeta, si esta no existe
                }
                //using (StreamWriter sw = new StreamWriter(completa,true)) //agrega datos al archivo existente
                using (StreamWriter sw = new StreamWriter(completa)) //crea y sobrescribe archivo.
                {
                    sw.WriteLine(id);
                }

            }
            catch (ArchivoInvalidoIdException ex)
            {
                throw new ArchivoInvalidoIdException($"Error en el archivo");
            }

        }
        public static string LeerLastId(string archivo)
        {

            try
            {
                string datos = string.Empty;

                if (Directory.Exists(ruta))
                {
                    string completa = ruta + $@"\{archivo}" + ".txt";

                    using (StreamReader sr = new StreamReader(completa))
                    {
                        string linea;

                        datos = sr.ReadToEnd();// lee todo de una.

                        //while ((linea = sr.ReadLine()) != null)// lee linea por linea.
                        //{
                        //    datos += "\n" + linea;
                        //}
                    }
                }
                return datos;

            }
            catch (Exception)
            {
                throw new ArchivoInvalidoIdException($"Error al cargar el archivo");
            }

        }
    }
}
