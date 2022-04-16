using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }

            return numero;


        }

   

       

        /// <summary>
        /// valida q solo sea 0 e 1.
        /// </summary>
        private bool EsBinario(string binario)
        {
            if(binario=="1"||binario=="0")
            {
                return true;
            }
            return false;
        }
        public string BinarioDecimal(string binario)

        {
            if (EsBinario(binario))
            {



                int binarioInt = Convert.ToInt32(binario);
                int numero = 0;
                int digito = 0;
                const int DIVISOR = 10;

                for (long i = binarioInt, j = 0; i > 0; i /= DIVISOR, j++)
                {
                    digito = (int)i % DIVISOR;
                    if (digito != 1 && digito != 0)
                    {
                        return "Valor inválido";
                    }
                    numero += digito * (int)Math.Pow(2, j);
                }


                return numero.ToString();
            }
            return "Valor inválido";

        }
        public string DecimalBinario(double numero)
        {
            numero = Math.Abs(numero);
            double binario = 0;

            const double DIVISOR = 2;
            double digito = 0;

            for (double i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                for (int k = 0; k < DIVISOR; k++)
                {
                    digito = i % DIVISOR;
                    binario += digito * (double)Math.Pow(10, j);

                }

            }
            string numString = binario.ToString();

            return numString;
        }
        /// <summary>
        ///  convertirán el resultado, trabajarán con enteros positivos, 
        ///  quedándose para esto con el valor absoluto y entero del double recibido:
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double num;
            num = double.Parse(numero);

            string resultado = DecimalBinario(num);


            return resultado;
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
