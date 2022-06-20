using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesExcepciones
{
    public class DatoInvalidoexceptionModificarUsuario : Exception
    {
        public DatoInvalidoexceptionModificarUsuario()
        {
        }

        public DatoInvalidoexceptionModificarUsuario(string message) : base(message)
        {
        }

        public DatoInvalidoexceptionModificarUsuario(string message, Exception innerException) : base(message, innerException)
        {
        }


    }
}
