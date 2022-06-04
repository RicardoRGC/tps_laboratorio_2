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
            
            ruta = AppDomain.CurrentDomain.BaseDirectory;


        }
        public static void GuardarLastIdUsuario(string id)
        {
            
            string nombrerchivo = @"\LastId" +  ".txt";

            string completa = ruta + nombrerchivo;
    
            try
            {
                if (!Directory.Exists(ruta)) 
                {
                    Directory.CreateDirectory(ruta); 
                }
            
                using (StreamWriter sw = new StreamWriter(completa)) 
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
                if (!Directory.Exists(ruta)) 
                {
                    Directory.CreateDirectory(ruta); 
                }

                using (StreamWriter sw = new StreamWriter(completa)) 
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
                        

                        datos = sr.ReadToEnd();
                                               
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
