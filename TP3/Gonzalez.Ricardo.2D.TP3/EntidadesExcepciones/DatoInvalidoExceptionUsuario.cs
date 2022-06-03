using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    
    public class DatoInvalidoExceptionUsuario : Exception
    {
        public DatoInvalidoExceptionUsuario()
        {
        }

        public DatoInvalidoExceptionUsuario(string message) : base(message)
        {
        }

        public DatoInvalidoExceptionUsuario(string message, Exception innerException) : base(message, innerException)
        {
        }


    }
}
