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
        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }

        private double ValidarOperando(string strNumero)
        {

            double numero;

            if(!double.TryParse(Console.ReadLine(), out numero))
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

        }
        public string DecimalBinario(double numero)
        {

        }

        public string DecimalBinario(string numero)
        {

        }
    }
}
