using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    public class ExcepcionRegistroDePagos : Exception
    {
        public ExcepcionRegistroDePagos()
        {
        }

        public ExcepcionRegistroDePagos(string message) : base(message)
        {
        }

        public ExcepcionRegistroDePagos(string message, Exception innerException) : base(message, innerException)
        {
        }
               
    }
}
