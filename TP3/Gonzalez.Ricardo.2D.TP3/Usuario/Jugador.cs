using System;
using System.Text;

namespace EntidadesTp3
{
    public class Jugador : Usuario, IPagoMensual
    {
        private int idEquipo;
        DateTime fechaDePgo;
        double montoPagado;
        string historialDePago;

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

        public string HistorialDePago { get => historialDePago; set => historialDePago = value; }

        public void PagoMensual(string monto)
        {
            this.montoPagado = double.Parse(monto);
            this.fechaDePgo = DateTime.Now;

            this.historialDePago += this.Mostrar();
        }
        public virtual string Mostrar()
        {
            return (string)this;
        }
        public static explicit operator string(Jugador usuario)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {usuario.Nombre}");

            stringBuilder.AppendLine($"Apellido: {usuario.MontoPagado}");
            stringBuilder.AppendLine($"Apellido: {usuario.FechaDePago1}");

            stringBuilder.AppendLine($"-----------");

            return stringBuilder.ToString();
        }

    }
}
