using System;
using System.Collections.Generic;

namespace EntidadesTp3
{
    public class Jugador : Usuario, IPagoMensual
    {
        private int idEquipo;
        
        DateTime FechaDePgo;
        double montoPagado;

        public Jugador()
        {

        }
        public Jugador(string apellido, string nombre, int dni, int edad, int idEquipo) : base(apellido, nombre, dni, edad)
        {
            this.idEquipo = idEquipo;
        }

        public override int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public double MontoPagado { get => montoPagado; set => montoPagado = value; }
        public DateTime FechaDePgo1 { get => FechaDePgo; set => FechaDePgo = value; }

      

        public void PagoMensual(string monto)
        {
            this.montoPagado = double.Parse(monto);
            this.FechaDePgo = DateTime.Now;           
        }


    }
}
