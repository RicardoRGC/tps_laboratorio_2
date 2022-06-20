using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    public class ArchivoInvalidoIdException : Exception
    {
        public ArchivoInvalidoIdException()
        {
        }

        public ArchivoInvalidoIdException(string message) : base(message)
        {
        }

        public ArchivoInvalidoIdException(string message, Exception innerException) : base(message, innerException)
        {
        }

       
    }
}
