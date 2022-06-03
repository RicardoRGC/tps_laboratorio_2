using System;
using System.Runtime.Serialization;

namespace EntidadesExcepciones
{
    public class ArchivoInvalidoException : Exception
    {
        public ArchivoInvalidoException()
        {
        }

        public ArchivoInvalidoException(string message) : base(message)
        {
        }

        public ArchivoInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }

      
    }
}
