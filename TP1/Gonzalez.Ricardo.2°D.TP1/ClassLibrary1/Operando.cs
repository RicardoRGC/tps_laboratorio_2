using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Operando
    {
        private double numero;


        private Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero) : this()
        {
            this.Numero = strNumero;
        }

        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
            //get
            //{
            //    return this.numero.ToString();
            //}
        }
        /// <summary>
        /// remplaza los puntos por comas , valida que se un numero double y lo retorna
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {

            double numero;


            strNumero = strNumero.Replace('.', ',');

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }

            return numero;


        }





        /// <summary>
        /// valida q solo sea 0 e 1.
        /// </summary>
        private static bool EsBinario(string binario)
        {
            if (Regex.IsMatch(binario, "[^01]"))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// convierte de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        public static string BinarioDecimal(string binario)

        {


            int longitud = binario.Length - 1;
            double numeroDecimal = 0;
            int contador = 0;

            if (EsBinario(binario))
            {
                for (int i = longitud; i >= 0; i--)
                {
                    if (binario[i] == '1')
                    {
                        numeroDecimal += Math.Pow(2, contador);
                    }

                    contador++;
                }

                return numeroDecimal.ToString();
            }

            return "Valor inválido";



        }
        /// <summary>
        /// convierte de decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            string binarioADevolver = "";
            int numeroAbsoluto = (int)Math.Abs(numero);
            int resto;

            if (numeroAbsoluto == 0)
            {
                binarioADevolver = "0";
            }

            while (numeroAbsoluto > 0)
            {
                resto = numeroAbsoluto % 2;
                numeroAbsoluto = numeroAbsoluto / 2;

                binarioADevolver = resto + binarioADevolver;
            }


            return binarioADevolver;




        }
        /// <summary>
        ///  convertirán el resultado, trabajarán con enteros positivos, 
        ///  quedándose para esto con el valor absoluto y entero del double recibido:
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double num;

            if (double.TryParse(numero, out num))
            {
                string resultado = DecimalBinario(Math.Abs(num));

                return resultado;
            }



            return "0";
        }


        /// <summary>
        /// sobrecarga el + para sumar los atributos de Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// sobrecarga el - para restar los atributos de Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        /// <summary>
        /// sobrecarga  / para dividir los atributos de Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }
        /// <summary>
        /// sobrecarga el * para multiplicar los atributos de Operando
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
