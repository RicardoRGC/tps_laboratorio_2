using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string message) : base(message)
        {
        }

        public NombreInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
