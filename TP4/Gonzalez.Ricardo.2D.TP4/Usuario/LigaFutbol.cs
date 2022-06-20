using System.Collections.Generic;

namespace EntidadesTp3
{
    public class LigaFutbol<T>
    {
       
        public static List<T> listaLigaStatica;

      
        static LigaFutbol()
        {

            listaLigaStatica = new List<T>();
        }

       


    }
}
