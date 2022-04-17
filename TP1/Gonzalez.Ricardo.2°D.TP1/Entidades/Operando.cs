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
        public Operando(double numero):this()
        {
            this.numero = numero;
        }

        public Operando(string strNumero):this()
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
        private double ValidarOperando(string strNumero)
        {

            double numero;
            

            strNumero= strNumero.Replace('.', ',');
    
            if(!double.TryParse(strNumero, out numero))
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
        public static string BinarioDecimal(string binario)

        {

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
            //    if (EsBinario(binario))
            //    {

            //        int binarioInt = Convert.ToInt32(binario);

            //        if (binarioInt < int.MaxValue)
            //        {



            //            int numero = 0;
            //        int digito = 0;
            //        const int DIVISOR = 10;

            //        for (long i = binarioInt, j = 0; i > 0; i /= DIVISOR, j++)
            //        {
            //            digito = (int)i % DIVISOR;
            //            if (digito != 1 && digito != 0)
            //            {
            //                return "Valor inválido";
            //            }
            //            numero += digito * (int)Math.Pow(2, j);
            //        }


            //        return numero.ToString();
            //    }
            //}
            //    return "Valor inválido";

        }
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

           if(double.TryParse(numero, out num))
            {
            string resultado = DecimalBinario(Math.Abs(num));

            return resultado;
            }



            return "0";
        }


        ///Sobrecargas
        ///
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        } public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        } public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        } public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
