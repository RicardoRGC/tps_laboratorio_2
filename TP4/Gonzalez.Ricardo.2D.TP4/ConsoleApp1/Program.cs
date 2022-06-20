using System;
using System.Collections.Generic;
using EntidadesTp3;
using EntidadesArchivos;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {





            // Equipo equipo = new Equipo("River");

            // EquipoDao.Guardar(equipo);
            List<Equipo> equipos = ClaseSerializadora<List<Equipo>>.LeerListaT("ListaEquipo");
            EquipoDao.GuardarListaEquipos(equipos);

            //for (int i = 0; i < 26; i++)
            //{
            //    EquipoDao.Eliminar(i);
            //}

            Console.WriteLine("riky");
        }
    }
}
