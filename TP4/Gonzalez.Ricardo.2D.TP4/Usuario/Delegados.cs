using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTp3
{
  
    public delegate void DelegadoPrint(string msj);
    public delegate void DelegadoPagoMensual(string pago); 
    public delegate void EventoDelegadoNotificarError();
    public delegate void DelegadoEnventoDePago();
}
