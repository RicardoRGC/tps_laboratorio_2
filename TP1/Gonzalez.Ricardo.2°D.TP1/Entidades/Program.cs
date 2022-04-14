using System;

namespace Entidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operando num = new Operando(10);
            Console.WriteLine(num.Numero);

            num.Numero = "20";

            Console.WriteLine(num.Numero);
        }
    }
}
