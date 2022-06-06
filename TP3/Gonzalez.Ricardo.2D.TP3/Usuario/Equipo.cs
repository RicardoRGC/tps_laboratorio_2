using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesExcepciones;
using EntidadesArchivos;

namespace EntidadesTp3
{

    public class Equipo:IPagoMensual
    {
        private int id;
        private static int lasId;
        private string nombreEquipo;
        DateTime fechaDePgo;
        double montoPagado;

        static Equipo()
        {
            lasId = 1;
            
        }
        public Equipo()
        {
            fechaDePgo = new DateTime();
        }
        public Equipo( string nombreEquipo)
        {
            id = lasId;
            this.nombreEquipo = nombreEquipo;
            lasId++;
        }

        public string NombreEquipo { get => nombreEquipo; set => nombreEquipo = value; }
        public int Id { get => id; set => id = value; }
        public static int LasId { get => lasId; set => lasId = value; }
        public double MontoPagado { get => montoPagado; set => montoPagado = value; }
        public DateTime FechaDePgo1 
            { get => fechaDePgo;
            set {
                fechaDePgo = value;
            }
        }

        public void PagoMensual(string monto)
        {
            this.montoPagado = double.Parse(monto);
            this.fechaDePgo = DateTime.Now;
           
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
                foreach (Equipo item in LigaFutbol<Equipo>.listaLigaStatica)
                {
                    if(item.nombreEquipo==nombre)
                    {
                        return item.id;
                    }
                }

            }
            catch (DatoInvalidoExeptionEquipo )
            {

                throw new DatoInvalidoExeptionEquipo("Error al buscar equipo");
            }
            return 0;
        } 
        /// <summary>
        /// busca el quipo por el nombre y retorna el objeto equipo.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="DatoInvalidoExeptionEquipo"></exception>
        public static Equipo RetornaEquipo(string nombre)
        {
            try
            {
                foreach (Equipo item in LigaFutbol<Equipo>.listaLigaStatica)
                {
                    if(item.nombreEquipo==nombre)
                    {
                        return item;
                    }
                }

            }
            catch (DatoInvalidoExeptionEquipo )
            {

                throw new DatoInvalidoExeptionEquipo("Error al buscar equipo");
            }
            return null;
        }
        /// <summary>
        /// busca el equipo por id 
        /// </summary>
        /// <param name="idEquipo"></param>
        /// <returns>Retorna el nombre del Equipo </returns>
        /// <exception cref="DatoInvalidoExeptionEquipo"></exception>
        public static string BuscarEquipo(int idEquipo)
        {
            try
            {
                foreach (Equipo item in LigaFutbol<Equipo>.listaLigaStatica)
                {
                    if(item.id==idEquipo)
                    {
                        return item.nombreEquipo;
                    }
                }

            }
            catch (DatoInvalidoExeptionEquipo )
            {

                throw new DatoInvalidoExeptionEquipo("Error al buscar equipo");
            }
            return "No Existe";
        }
        /// <summary>
        /// Agrega instancia un Equipo y lo Agrega a la lista de la liga, Guarda el ultimo id y lo agrega al registro de pagos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Retorna true si la Operacion fue exitisa </returns>
        public static bool AgregarEquipo(string nombre)
        {
            Equipo equipo = new Equipo(nombre);

            if(equipo is not null)
            {
                if(LigaFutbol<Equipo>.listaLigaStatica+equipo)
                {
                    Archivo.GuardarLastIdEquipo(Equipo.LasId.ToString());

                    RegistroDePagos.AgregarGestionarPago(equipo.id, equipo.nombreEquipo,equipo);

                    return true;

                }
            }
            return false;
        }
        public static bool operator ==(List<Equipo> listaEquipo, Equipo equipo)
        {

            foreach (Equipo item in listaEquipo)
            {
                if (item.NombreEquipo == equipo.nombreEquipo)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// si el producto esta en la lista devuelve false
        /// </summary>
        /// <param name="listProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(List<Equipo> listaEquipo, Equipo equipo)
        {
            return !(listaEquipo == equipo);
        }

        public static bool operator +(List<Equipo> listaEquipo, Equipo equipo)
        {
            if (equipo is null || listaEquipo is null)
            {
                throw new DatoInvalidoExeptionEquipo("dato nulo");
            }
            if (listaEquipo != equipo)
            {
                listaEquipo.Add(equipo);
                return true;
            }
            return false;
        }
        /// <summary>
        /// remueve un producto de la lista
        /// </summary>
        /// <param name="listProductos"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator -(List<Equipo> listaEquipo, Equipo equipo)
        {
            if (equipo is null || listaEquipo is null)
            {
                throw new DatoInvalidoExeptionEquipo("dato nulo");
            }
            if (listaEquipo == equipo)
            {
                listaEquipo.Remove(equipo);
                return true;
            }
            return false;
        }


    }
}
