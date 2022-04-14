using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// El método ValidarOperador será privado y estático.
        /// Deberá validar que el operador recibido sea +, -, / o *. Caso contrario retornará +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns> retornará +.
        private static char ValidarOperador(char operador)
        {
            if (operador == '-' || operador == '/' || operador == '*' || operador == '+')
            {
                return operador;
            }
           

            return '+';
        }
        /// <summary>
        /// El método Operar será de clase: validará y realizará la operación pedida entre ambos números.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            char operadorValidado;

            operadorValidado = ValidarOperador(operador);
            switch (operadorValidado.ToString())
            {
                case "+":
                    resultado = num1 + num2; 
                    break;

                case "-":
                   resultado = num1 - num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    if (double.IsInfinity(resultado))
                    {
                        resultado = double.MinValue;
                    }
                    break;

                case "*":
                   resultado = num1 * num2;
                    break;
            }
            return resultado;
        }

    }
}
