using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesExcepciones;
using EntidadesArchivos;

namespace EntidadesTp3
{

    public class Equipo : IPagoMensual
    {
        private int id;
        private static int lasId;
        private string nombreEquipo;
        DateTime fechaDePgo;
        double montoPagado;
        private string historialDePago;
   

        static Equipo()
        {
            lasId = 1;

        }
        public Equipo()
        {
            fechaDePgo = new DateTime();
        }
        public Equipo(int id, string nombreEquipo)
        {
            this.id = id;
            this.nombreEquipo = nombreEquipo;
            
        } 
        public Equipo( string nombreEquipo)
        {           
            this.nombreEquipo = nombreEquipo;            
        }
        public Equipo(int id, string nombreEquipo,double montoPagado,DateTime fechaDePago,string historialPago)
            {
            this.id = id;
            this.nombreEquipo = nombreEquipo;
            this.montoPagado = montoPagado;
            this.fechaDePgo = fechaDePago;
            this.historialDePago += historialPago;
            }

        public int Id { get => id; set => id = value; }
        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public static int LasId { get => lasId; set => lasId = value; }
        public double MontoPagado { get => montoPagado; set => montoPagado = value; }
        public DateTime FechaDePgo1 { get => fechaDePgo;set =>fechaDePgo = value; }
        public string HistorialDePago { get => historialDePago; set => historialDePago = value; }

        public void PagoMensual(string monto)
        {
            this.montoPagado = double.Parse(monto);
            this.fechaDePgo = DateTime.Now;
            this.historialDePago += this.Mostrar();

            EquipoDao.CargarBaseDatoPagoEquipo(this);
        }
        public string MostrarHistorialPago()
        {
            
            if(this.historialDePago == "")
            {
                return "No hay historial";
            }

            return this.historialDePago;
        }


   
        public string Mostrar()
        {
            return (string)this;
        }
        public static explicit operator string(Equipo usuario)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {usuario.NombreEquipo}");

            stringBuilder.AppendLine($"Apellido: {usuario.MontoPagado}");
            stringBuilder.AppendLine($"Apellido: {usuario.fechaDePgo}");

            stringBuilder.AppendLine($"-----------");

            return stringBuilder.ToString();
        }
        /// <summary>
        /// Devuelve el id del Equipo ,Busca por nombre de equipo
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="DatoInvalidoExeptionEquipo"></exception>
        public static int BuscarEquipo(string nombre)
        {
            try
            {
                Equipo equipo = EquipoDao.Leer().Find(x => x.nombreEquipo == nombre);

                return equipo.id;

            }
            catch(NullReferenceException )
            {
                throw;
            }
            catch (DatoInvalidoExeptionEquipo )
            {

                throw new DatoInvalidoExeptionEquipo("Error al buscar equipo");
            }
            return 0;
        }  
      
       
        /// <summary>
        /// Agrega instancia un Equipo y lo Agrega a la lista de la liga, Guarda el ultimo id y lo agrega al registro de pagos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Retorna true si la Operacion fue exitisa </returns>
        public static bool AgregarEquipo(string nombre)
        {
             Equipo equipo = new Equipo(nombre);

            if (equipo is not null)
            {
               if(EquipoDao.Guardar(equipo))
                {
                    return true;
                }
            }
            return false;
        }
      

    }
}
