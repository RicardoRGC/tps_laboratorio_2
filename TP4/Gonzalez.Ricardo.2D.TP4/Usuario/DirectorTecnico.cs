using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTp3
{
    public class DirectorTecnico :Usuario
    {
        private int idEquipo;

        public DirectorTecnico()
        {

        }
        public DirectorTecnico(string apellido, string nombre, int dni, int edad, int idEquipo) : base(apellido, nombre, dni, edad)
        {
            this.idEquipo = idEquipo;
        }

        public override int IdEquipo { get => idEquipo; set => idEquipo = value; }
    }
}
