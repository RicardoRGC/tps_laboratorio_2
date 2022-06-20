using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    public class DatoInvalidoExeptionEquipo : Exception
    {
        public DatoInvalidoExeptionEquipo()
        {
        }

        public DatoInvalidoExeptionEquipo(string message) : base(message)
        {
        }

        public DatoInvalidoExeptionEquipo(string message, Exception innerException) : base(message, innerException)
        {
        }

 
    }
}
