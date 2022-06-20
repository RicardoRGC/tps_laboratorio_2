using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTp3
{
    public static class ClaseDeExtension
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static int BuscarIdEquipoPorNombre(this String nombre)
        {
            try
            {
                Equipo equipo = EquipoDao.Leer().Find(x => x.NombreEquipo == nombre);

                return equipo.Id;

            }
            catch (NullReferenceException ex)
            {
                throw;
            }
     
        }               
        public static string BuscarNombreEquipoPorId(this int idEquipo)
        {
            try
            {
                Equipo equipo = EquipoDao.Leer().Find(x => x.Id == idEquipo);

                return equipo.NombreEquipo;

            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("NO se encuentra el equipo del usuario",ex);
            }
     
        }
    }
}
