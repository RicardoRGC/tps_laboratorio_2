using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '/' || operador == '*' || operador == '+')
            {
                return operador;
            }
            operador = '+';

            return operador;
        }
        public static class Operar(Operando num1, Operando num2)
            {




            }
}
}
