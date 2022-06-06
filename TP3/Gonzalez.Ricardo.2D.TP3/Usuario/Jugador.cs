using System;

namespace EntidadesTp3
{
    public class Jugador : Usuario, IPagoMensual
    {
        private int idEquipo;
        DateTime fechaDePgo;
        double montoPagado;

        public Jugador()
        {
            fechaDePgo = new DateTime();
        }
        public Jugador(string apellido, string nombre, int dni, int edad, int idEquipo) : base(apellido, nombre, dni, edad)
        {
            this.idEquipo = idEquipo;
        }

        public override int IdEquipo { get => idEquipo; set => idEquipo = value; }
        public double MontoPagado { get => montoPagado; set => montoPagado = value; }
        public DateTime FechaDePago1 {
            get => fechaDePgo;
            set {
                fechaDePgo = value;
            }
        }


        public void PagoMensual(string monto)
        {
            this.montoPagado = double.Parse(monto);
            this.fechaDePgo = DateTime.Now;
        }


    }
}
